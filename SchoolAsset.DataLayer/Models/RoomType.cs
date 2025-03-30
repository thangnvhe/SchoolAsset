using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAsset.DataLayer.Models
{
    public class RoomType
    {
        public int RoomTypeId { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "Room Type")]
        public string? Name { get; set; }
        public ICollection<Room>? Rooms { get; set; }
    }
}
