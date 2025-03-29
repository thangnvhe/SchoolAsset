using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SchoolAsset.BusinessLayer.ViewModels;
using SchoolAsset.DataLayer;
using SchoolAsset.DataLayer.IRepository;
using SchoolAsset.DataLayer.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolAsset.PresentLayer.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = SD.Role_Admin)]
    public class UserController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IUnitOfWork _unitOfWork;

        public UserController(UserManager<IdentityUser> userManager, IUnitOfWork unitOfWork, RoleManager<IdentityRole> roleManager)
        {
            _unitOfWork = unitOfWork;
            _roleManager = roleManager;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> RoleManagment(string userId)
        {
            RoleManagmentVM RoleVM = new RoleManagmentVM()
            {
                ApplicationUser = await _unitOfWork.ApplicationUsers.GetByIdAsync(u => u.Id == userId),
                RoleList = _roleManager.Roles.Select(i => new SelectListItem
                {
                    Text = i.Name,
                    Value = i.Name
                })
            };

            RoleVM.ApplicationUser.Role = _userManager.GetRolesAsync(RoleVM.ApplicationUser)
                .GetAwaiter().GetResult().FirstOrDefault();

            return View(RoleVM);
        }

        [HttpPost]
        public async Task<IActionResult> RoleManagment(RoleManagmentVM roleManagmentVM)
        {
            // Lấy ApplicationUser với AsNoTracking để tránh bị theo dõi nhiều lần
            var applicationUser = await _unitOfWork.ApplicationUsers.GetByIdAsync(
                u => u.Id == roleManagmentVM.ApplicationUser.Id,
                tracked: false // Không theo dõi thực thể
            );

            if (applicationUser == null)
            {
                return NotFound();
            }

            // Lấy vai trò cũ
            var oldRole = (await _userManager.GetRolesAsync(applicationUser)).FirstOrDefault();

            if (roleManagmentVM.ApplicationUser.Role != oldRole)
            {
                // Lấy thực thể ApplicationUser có trạng thái tracked để cập nhật vai trò
                var trackedUser = await _userManager.FindByIdAsync(applicationUser.Id);
                if (trackedUser == null)
                {
                    return NotFound();
                }

                // Xóa vai trò cũ và thêm vai trò mới
                await _userManager.RemoveFromRoleAsync(trackedUser, oldRole);
                await _userManager.AddToRoleAsync(trackedUser, roleManagmentVM.ApplicationUser.Role);
            }

            return RedirectToAction("Index");
        }



        #region API CALLS

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            List<ApplicationUser> objUserList = (await _unitOfWork.ApplicationUsers.GetAllAsync()).ToList();

            foreach (var user in objUserList)
            {
                user.Role = (await _userManager.GetRolesAsync(user)).FirstOrDefault();
            }

            return Json(new { data = objUserList });
        }

        [HttpPost]
        public async Task<IActionResult> LockUnlock([FromBody] string id)
        {
            var objFromDb = await _unitOfWork.ApplicationUsers.GetByIdAsync(u => u.Id == id);
            if (objFromDb == null)
            {
                return Json(new { success = false, message = "Error while Locking/Unlocking" });
            }

            objFromDb.LockoutEnd = (objFromDb.LockoutEnd.HasValue && objFromDb.LockoutEnd > DateTime.UtcNow)
                ? DateTime.UtcNow
                : DateTime.UtcNow.AddYears(1000);

            _unitOfWork.ApplicationUsers.Update(objFromDb);
            await _unitOfWork.CompleteAsync();

            return Json(new { success = true, message = "Operation Successful" });
        }

        #endregion
    }
}
