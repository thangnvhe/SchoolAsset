using AssetManagement.Models.Entities.AssetModule;
using AssetManagement.Models.Entities.MaintainModule;
using Microsoft.AspNetCore.Identity;

namespace AssetManagement.Models.Entities.UserModule
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public bool IsMale { get; set; }
        public string Email { get; set; }
        public string Province  { get; set; }
        public string District  { get; set; }
        public string Ward  { get; set; }
        public string? Street  { get; set; }
        public string? CreateAt  { get; set; }
        public string? UpdateAt  { get; set; }
        public bool IsActive { get; set; } = false;
        public virtual ICollection<AssetIssue>? ReportedIssues { get; set; }
        public virtual ICollection<MaintenanceRecord>? MaintenanceRecords { get; set; }
        public virtual ICollection<AssetItem>? UpdatedAssetItems { get; set; }
    }
}
