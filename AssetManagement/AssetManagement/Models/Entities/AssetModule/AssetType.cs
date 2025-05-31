using System.ComponentModel.DataAnnotations;

namespace AssetManagement.Models.Entities.AssetModule
{
    public class AssetType
    {
        [Key]
        public int AssetTypeID { get; set; }
        [Required]
        public string TypeName { get; set; }
        public string? Description { get; set; }
        public virtual ICollection<Asset>? Assets { get; set; } = new List<Asset>(); 
    }
}
