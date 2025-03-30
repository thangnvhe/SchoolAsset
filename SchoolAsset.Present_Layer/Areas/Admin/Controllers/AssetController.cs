using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SchoolAsset.DataLayer;
using SchoolAsset.DataLayer.IRepository;
using X.PagedList.Extensions;

namespace SchoolAsset.PresentLayer.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = SD.Role_Admin)]
    public class AssetController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public AssetController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IActionResult> Index(int? pageNumber)
        {
            int pageSize = 10;
            int page = pageNumber ?? 1;

            var query = await _unitOfWork.Assets.GetAllAsync();
            return View(query.ToPagedList(page, pageSize));
        }
    }
}
