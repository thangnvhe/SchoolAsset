using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using AssetManagement.Models.Entities.AssetModule;

namespace AssetManagement.Models.Entities.DepreciationModule
{
    public class DepreciationRecord
    {
        [Key]
        public int DepreciationID { get; set; }
        public int? InventoryID { get; set; }
        public string? AssetItemID { get; set; }
        [Required]
        public DateTime DepreciationDate { get; set; }
        public decimal DepreciationAmount { get; set; }
        public decimal NewValue { get; set; }
        public string? Notes { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        [ForeignKey("InventoryID")]
        public virtual InventoryAsset? InventoryAsset { get; set; }
        [ForeignKey("AssetItemID")]
        public virtual AssetItem? AssetItem { get; set; }
    }
}
