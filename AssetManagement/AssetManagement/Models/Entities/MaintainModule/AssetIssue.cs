using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using AssetManagement.Models.Entities.AssetModule;
using AssetManagement.Models.Entities.UserModule;
using AssetManagement.Enums;

namespace AssetManagement.Models.Entities.MaintainModule
{
    public class AssetIssue
    {
        [Key]
        public int IssueID { get; set; }
        public int? InventoryID { get; set; }
        public string? AssetItemID { get; set; }
        public string ReportedBy { get; set; }
        [Required]
        public string IssueDescription { get; set; }
        public DateTime ReportDate { get; set; } = DateTime.Now;
        public AssetIssueStatus Status { get; set; }

        [ForeignKey("InventoryID")]
        public virtual InventoryAsset? InventoryAsset { get; set; }
        [ForeignKey("AssetItemID")]
        public virtual AssetItem? AssetItem { get; set; }
        [ForeignKey("ReportedBy")]
        public virtual ApplicationUser? Reporter { get; set; }
        public virtual MaintenanceRecord? MaintenanceRecord { get; set; }
    }
}
