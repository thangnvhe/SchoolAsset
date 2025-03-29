using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAsset.DataLayer.Models
{
    public class Room
    {
        public int RoomId { get; set; }
        public string? RoomName { get; set; }
        public string? Status { get; set; }
        public DateTime? RoomDate { get; set; }
        public int RoomTypeId { get; set; }
        [ForeignKey("RoomTypeId")]
        public RoomType? RoomType { get; set; }
        public int BuildingId { get; set; }
        [ForeignKey("BuildingId")]
        public Building? Building { get; set; }
    }
}
