using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SchoolAsset.BusinessLayer.ViewModels;
using SchoolAsset.DataLayer;
using SchoolAsset.DataLayer.IRepository;
using SchoolAsset.DataLayer.Models;

namespace SchoolAsset.PresentLayer.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = SD.Role_Admin)]
    public class BuildingController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public BuildingController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<IActionResult> Index()
        {
            var buildings = await _unitOfWork.Buildings.GetAllAsync();
            return View(buildings);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(BuildingDTO buildingDTO)
        {
            if (ModelState.IsValid)
            {
                var Building = new Building
                {
                    BuildingName = buildingDTO.BuildingName,
                    Location = buildingDTO.Location,
                    Status = buildingDTO.Status,
                    Building_Date = buildingDTO.BuildingDate
                };
                await _unitOfWork.Buildings.AddAsync(Building);
                await _unitOfWork.CompleteAsync();
                TempData["Message"] = "Create Building Successful.";
                return RedirectToAction(nameof(Index));
            }
            return View(buildingDTO);
        }

        public IActionResult Edit(int id)
        {
            var building = _unitOfWork.Buildings.GetByIdAsync(x=>x.BuildingId == id).Result;
            if (building == null)
            {
                TempData["Message"] = "Building not found!";
                return RedirectToAction(nameof(Index));
            }
            return View(building);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Building building)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.Buildings.Update(building);
                await _unitOfWork.CompleteAsync();
                TempData["Message"] = "Update Building Successful.";
                return RedirectToAction(nameof(Index));
            }
            return View(building);
        }

        public IActionResult Delete(int? id)
        {
            var building = _unitOfWork.Buildings.GetByIdAsync(x => x.BuildingId == id).Result;
            if (building == null)
            {
                TempData["Message"] = "Building not found!";
                return RedirectToAction(nameof(Index));
            }
            return View(building);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(Building building)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.Buildings.Remove(building);
                await _unitOfWork.CompleteAsync();
                TempData["Message"] = "Delete Building Successful.";
                return RedirectToAction(nameof(Index));
            }
            return View(building);
        }
    }
}
