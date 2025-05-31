using AssetManagement.Models.Entities.AssetModule;
using System.ComponentModel.DataAnnotations;

namespace AssetManagement.Models.Entities.SupplierModule
{
    public class Supplier
    {
            [Key]
            public int SupplierID { get; set; }
            [Required]
            public string SupplierName { get; set; }
            public string ContactInfo { get; set; }
            public string Address { get; set; }
            public string? Notes { get; set; }
            public virtual ICollection<InventoryAsset>? InventoryAssets { get; set; } = new List<InventoryAsset>();
    }
}
