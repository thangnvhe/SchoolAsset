using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SchoolAsset.DataLayer;
using SchoolAsset.DataLayer.IRepository;
using SchoolAsset.DataLayer.Models;
using System.Threading.Tasks;
using X.PagedList.Extensions;

namespace SchoolAsset.PresentLayer.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = SD.Role_Admin)]
    public class RoomTypeController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public RoomTypeController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IActionResult> Index(int? pageNumber)
        {
            int pageSize = 10;
            int page = pageNumber ?? 1;

            var query = await _unitOfWork.RoomTypes.GetAllAsync(includeProperties:"Rooms");
            return View(query.ToPagedList(page, pageSize));
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(RoomType roomType)
        {
            if (ModelState.IsValid)
            {
                await _unitOfWork.RoomTypes.AddAsync(roomType);
                await _unitOfWork.CompleteAsync();
                TempData["Message"] = "Room Type Created Successfully";
                return RedirectToAction(nameof(Index));
            }
            return View(roomType);
        }

        public async Task<IActionResult> Edit(int id)
        {
            var roomType = await _unitOfWork.RoomTypes.GetByIdAsync(x => x.RoomTypeId == id);
            if (roomType == null)
            {
                return NotFound();
            }
            return View(roomType);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(RoomType roomType)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.RoomTypes.Update(roomType);
                await _unitOfWork.CompleteAsync();
                TempData["Message"] = "Room Type Updated Successfully";
                return RedirectToAction(nameof(Index));
            }
            return View(roomType);
        }

        public async Task<IActionResult> Delete(int id)
        {
            var roomType = await _unitOfWork.RoomTypes.GetByIdAsync(x=>x.RoomTypeId == id);
            if (roomType == null)
            {
                return NotFound();
            }
            return View(roomType);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(RoomType roomType)
        {
            _unitOfWork.RoomTypes.Remove(roomType);
            await _unitOfWork.CompleteAsync();
            TempData["Message"] = "Room Type Deleted Successfully";
            return RedirectToAction(nameof(Index));
        }
    }
}
