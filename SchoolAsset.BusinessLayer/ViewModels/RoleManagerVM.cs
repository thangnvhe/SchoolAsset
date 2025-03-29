using Microsoft.AspNetCore.Mvc.Rendering;
using SchoolAsset.DataLayer.Models;

namespace SchoolAsset.BusinessLayer.ViewModels
{
    public class RoleManagmentVM
    {
        public ApplicationUser ApplicationUser { get; set; }
        public IEnumerable<SelectListItem> RoleList { get; set; }
    }
}
