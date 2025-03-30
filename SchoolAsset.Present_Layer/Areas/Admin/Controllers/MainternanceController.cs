using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SchoolAsset.DataLayer;
using SchoolAsset.DataLayer.IRepository;

namespace SchoolAsset.PresentLayer.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = SD.Role_Admin)]
    public class MainternanceController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public MainternanceController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
