using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAsset.DataLayer.Models
{
    public class RoomType
    {
        public int RoomTypeId { get; set; }
        public string? Name { get; set; }
        IEnumerable<Room>? Rooms { get; set; }
    }
}
