using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAsset.DataLayer.Models
{
    public class AssetDetail
    {
        public int AssetDetailId { get; set; }
        public int AssetId { get; set; }
        [ForeignKey("AssetId")]
        public Asset? Asset { get; set; }
        public string? SerialNumber { get; set; }
        public string? Status { get; set; }
    }
}
