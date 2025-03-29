using System.ComponentModel.DataAnnotations;

namespace SchoolAsset.DataLayer.Models
{
    public class Building
    {
        [Key]
        public int BuildingId { get; set; }
        [MaxLength(100)]
        public string? BuildingName { get; set; }
        [MaxLength(100)]
        public string? Location { get; set; }
        [MaxLength(100)]
        public string? Status { get; set; }
        public DateTime? Building_Date { get; set; }
        public IEnumerable<Room>? Rooms { get; set; }

    }
}
