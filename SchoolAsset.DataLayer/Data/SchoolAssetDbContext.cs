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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Building>().HasData(
                new Building
                {
                    BuildingId = 1,
                    BuildingName = "Tòa Nhà Alpha",
                    Location = "Vị trí số 1, ngang mặt đường quốc lộ nhìn vào",
                    Status = "Active",
                    Building_Date = new DateTime(2025, 3, 17)
                },
                new Building
                {
                    BuildingId = 2,
                    BuildingName = "Tòa Nhà Belta",
                    Location = "Vị trí số 2, trên bản đồ",
                    Status = "Active",
                    Building_Date = new DateTime(2025, 3, 17)
                },
                new Building
                {
                    BuildingId = 3,
                    BuildingName = "Tòa Nhà Delta",
                    Location = "Vị trí số 3, trên bản đồ",
                    Status = "Active",
                    Building_Date = new DateTime(2025, 3, 17)
                },
                new Building
                {
                    BuildingId = 4,
                    BuildingName = "Tòa Nhà Emanal",
                    Location = "Vị trí số 4, trên bản đồ",
                    Status = "Active",
                    Building_Date = new DateTime(2025, 3, 17)
                },
                new Building
                {
                    BuildingId = 5,
                    BuildingName = "Tòa nhà Grammar",
                    Location = "Vị trí số 5, trên bản đồ",
                    Status = "Active",
                    Building_Date = new DateTime(2025, 3, 17)
                }
                );
        }
    }
}
