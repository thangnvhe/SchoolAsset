using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
