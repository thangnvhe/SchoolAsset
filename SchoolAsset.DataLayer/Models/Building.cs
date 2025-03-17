using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

    }
}
