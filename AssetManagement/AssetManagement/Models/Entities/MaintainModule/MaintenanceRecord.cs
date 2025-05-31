using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using AssetManagement.Models.Entities.UserModule;
using AssetManagement.Models.Entities.AssetModule;

namespace AssetManagement.Models.Entities.MaintainModule
{
    public class MaintenanceRecord
    {
        [Key]
        public int MaintenanceID { get; set; }
        public int? InventoryID { get; set; }
        public string? AssetItemID { get; set; }
        public int? IssueID { get; set; }
        [Required]
        public DateTime MaintenanceDate { get; set; }
        [Required]
        public int MaintenanceQuantity { get; set; }
        public string? Description { get; set; }
        public decimal? Cost { get; set; }
        public int PerformedBy { get; set; }
        public string? CompletionPhoto { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        [ForeignKey("InventoryID")]
        public virtual InventoryAsset? InventoryAsset { get; set; }
        [ForeignKey("AssetItemID")]
        public virtual AssetItem? AssetItem { get; set; }
        [ForeignKey("IssueID")]
        public virtual AssetIssue? Issue { get; set; }
        [ForeignKey("PerformedBy")]
        public virtual ApplicationUser? Maintainer { get; set; }
    }
}
