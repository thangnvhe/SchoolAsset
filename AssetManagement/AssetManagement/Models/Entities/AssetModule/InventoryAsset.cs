using AssetManagement.Models.Entities.DepreciationModule;
using AssetManagement.Models.Entities.MaintainModule;
using AssetManagement.Models.Entities.SupplierModule;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AssetManagement.Models.Entities.AssetModule
{
    public class InventoryAsset
    {
        [Key]
        public int InventoryID { get; set; }
        public string AssetID { get; set; }
        public int? SupplierID { get; set; }
        [Required]
        public DateTime PurchaseDate { get; set; }
        [Required]
        public decimal PurchasePrice { get; set; }
        [Required]
        public int Quantity { get; set; }
        public string InvoiceNumber { get; set; }
        public string Notes { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        [ForeignKey("AssetID")]
        public virtual Asset? Asset { get; set; }
        [ForeignKey("SupplierID")]
        public virtual Supplier? Supplier { get; set; }
        public virtual ICollection<AssetItem>? AssetItems { get; set; } = new List<AssetItem>();
        public virtual ICollection<AssetIssue>? Issues { get; set; } = new List<AssetIssue>();
        public virtual ICollection<MaintenanceRecord>? MaintenanceRecords { get; set; } = new List<MaintenanceRecord>();
        public virtual ICollection<DepreciationRecord>? DepreciationRecords { get; set; } = new List<DepreciationRecord>();
    }
}
