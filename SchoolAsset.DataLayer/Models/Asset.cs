using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAsset.DataLayer.Models
{
    public class Asset
    {
        public int AssetId { get; set; }
        public string? AssetName { get; set; }
        public string? Description { get; set; }
        public string? Status { get; set; }
        public DateTime? PurchaseDate { get; set; }
        [Precision(18, 2)]
        public decimal? Price { get; set; }
        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public Category? Category { get; set; }
        public int RoomId { get; set; }
        [ForeignKey("RoomId")]
        public Room? Room { get; set; }
        public string? ImgUrl { get; set; }
        IEnumerable<Maintenance>? Maintenances { get; set; }
    }
}
