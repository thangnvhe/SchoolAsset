using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SchoolAsset.BusinessLayer.Services;
using SchoolAsset.BusinessLayer.ViewModels;
using SchoolAsset.DataLayer;

namespace SchoolAsset.PresentLayer.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = SD.Role_Admin)]
    public class BuildingController : Controller
    {
        private readonly BuildingService _buildingService;

        public BuildingController(BuildingService buildingService)
        {
            _buildingService = buildingService;
        }
        public async Task<IActionResult> Index()
        {
            var buildings = await _buildingService.GetBuildingAll();
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
                await _buildingService.AddBuilding(buildingDTO);
                return RedirectToAction(nameof(Index));
            }
            return View(buildingDTO);
        }

        public IActionResult Edit(int id)
        {
            var building = _buildingService.GetBuildingById(id).Result;
            if (building == null)
            {
                TempData["Message"] = "Building not found!";
                return RedirectToAction(nameof(Index));
            }
            return View(building);
        }
    }
}
