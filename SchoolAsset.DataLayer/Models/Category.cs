using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAsset.DataLayer.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "Category Name")]
        public string? CategoryName { get; set; }
    }
}
