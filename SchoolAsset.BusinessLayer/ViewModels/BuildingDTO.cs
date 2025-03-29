using System.ComponentModel.DataAnnotations;

namespace SchoolAsset.BusinessLayer.ViewModels
{
    public class BuildingDTO
    {
        [Required, MaxLength(100)]
        public string? BuildingName { get; set; }
        [Required, MaxLength(100)]
        public string? Location { get; set; }
        [Required, MaxLength(100)]
        public string? Status { get; set; }

        public DateTime BuildingDate { get; set; } = DateTime.Now;
    }
}
