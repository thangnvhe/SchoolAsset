using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using AssetManagement.Models.Entities.UserModule;
using AssetManagement.Models.Entities.MaintainModule;
using AssetManagement.Models.Entities.DepreciationModule;

namespace AssetManagement.Models.Entities.AssetModule
{
    public class AssetItem
    {
        [Key]
        public string AssetItemID { get; set; }
        public int InventoryID { get; set; }
        public int LocationID { get; set; }
        public string Status { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        [ForeignKey("InventoryID")]
        public virtual InventoryAsset? InventoryAsset { get; set; }
        [ForeignKey("LocationID")]
        public virtual Location? Location { get; set; }
        [ForeignKey("UpdatedBy")]
        public virtual ApplicationUser? UpdatedByUser { get; set; }
        public virtual ICollection<AssetIssue>? Issues { get; set; } = new List<AssetIssue>();
        public virtual ICollection<MaintenanceRecord>? MaintenanceRecords { get; set; } = new List<MaintenanceRecord>();
        public virtual ICollection<DepreciationRecord>? DepreciationRecords { get; set; } = new List<DepreciationRecord>();
    }
}
