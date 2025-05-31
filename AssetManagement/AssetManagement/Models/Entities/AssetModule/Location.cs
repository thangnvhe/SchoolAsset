using System.ComponentModel.DataAnnotations;

namespace AssetManagement.Models.Entities.AssetModule
{
    public class Location
    {
        [Key]
        public int LocationID { get; set; }
        [Required]
        public string LocationName { get; set; }
        public string Address { get; set; }
        public string? Description { get; set; }
        public virtual ICollection<AssetItem>? AssetItems { get; set; } = new List<AssetItem>();
    }
}
