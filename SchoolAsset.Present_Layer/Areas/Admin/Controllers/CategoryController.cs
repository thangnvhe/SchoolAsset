using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SchoolAsset.DataLayer;
using SchoolAsset.DataLayer.IRepository;
using SchoolAsset.DataLayer.Models;
using X.PagedList.Extensions;

namespace SchoolAsset.PresentLayer.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = SD.Role_Admin)]
    public class CategoryController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public CategoryController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<IActionResult> Index(int? pageNumber)
        {
            int pageSize = 10;
            int page = pageNumber ?? 1;

            var query = await _unitOfWork.Categories.GetAllAsync();
            return View(query.ToPagedList(page, pageSize));
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Category category)
        {
            if (ModelState.IsValid)
            {
                await _unitOfWork.Categories.AddAsync(category);
                await _unitOfWork.CompleteAsync();
                TempData["Message"] = "Category Created Successfully";
                return RedirectToAction(nameof(Index));
            }
            return View(category);
        }

        public async Task<IActionResult> Edit(int id)
        {
            var category = await _unitOfWork.Categories.GetByIdAsync(x => x.CategoryId == id);
            if (category == null)
            {
                return NotFound();
            }
            return View(category);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Category category)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.Categories.Update(category);
                await _unitOfWork.CompleteAsync();
                TempData["Message"] = "Category Updated Successfully";
                return RedirectToAction(nameof(Index));
            }
            return View(category);
        }

        public async Task<IActionResult> Delete(int id)
        {
            var category = await _unitOfWork.Categories.GetByIdAsync(x => x.CategoryId == id);
            if (category == null)
            {
                return NotFound();
            }
            return View(category);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(Category category)
        {
            _unitOfWork.Categories.Remove(category);
            await _unitOfWork.CompleteAsync();
            TempData["Message"] = "Category Deleted Successfully";
            return RedirectToAction(nameof(Index));
        }
    }
}
