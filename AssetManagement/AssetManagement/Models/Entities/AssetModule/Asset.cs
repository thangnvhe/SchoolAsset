using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AssetManagement.Models.Entities.AssetModule
{
    public class Asset
    {
        [Key]
        public string AssetID { get; set; }
        [Required]
        public string AssetName { get; set; }
        public int AssetTypeID { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        [ForeignKey("AssetTypeID")]
        public virtual AssetType? AssetType { get; set; }
        public virtual ICollection<InventoryAsset>? InventoryAssets { get; set; } = new List<InventoryAsset>();
    }
}
