using Microsoft.EntityFrameworkCore;
using SchoolAsset.DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAsset.DataLayer.Data
{
    public class SchoolAssetDbContext : DbContext
    {
        public SchoolAssetDbContext()
        {
            
        }
        public SchoolAssetDbContext(DbContextOptions<SchoolAssetDbContext> options) : base(options)
        {

        }

        public DbSet<Building> Buildings { get; set; }
    }
}
