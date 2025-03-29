using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAsset.DataLayer.Models
{
    public class Maintenance
    {
        public int MaintenanceId { get; set; }
        public DateTime? MaintenanceDate { get; set; }
        public string? MaintenanceType { get; set; }
        public string? Description { get; set; }
        [Precision(18, 2)]
        public decimal? Cost { get; set; }
        public int AssetId { get; set; }
        public Asset? Asset { get; set; }
    }
}
