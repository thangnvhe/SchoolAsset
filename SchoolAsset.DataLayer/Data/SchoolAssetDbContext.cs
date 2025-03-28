using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SchoolAsset.DataLayer.Models;

namespace SchoolAsset.DataLayer.Data
{
    public class SchoolAssetDbContext : IdentityDbContext<IdentityUser>
    {
        public SchoolAssetDbContext(DbContextOptions<SchoolAssetDbContext> options) : base(options)
        {

        }

        public DbSet<Building> Buildings { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }

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
