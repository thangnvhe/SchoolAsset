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
        public DbSet<RoomType> RoomTypes { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Asset> Assets { get; set; }
        public DbSet<Maintenance> Maintenances { get; set; }
        public DbSet<AssetDetail> AssetDetails { get; set; }

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

            modelBuilder.Entity<RoomType>().HasData(
                new RoomType
                {
                    RoomTypeId = 1,
                    Name = "Phòng Học"
                },
                new RoomType
                {
                    RoomTypeId = 2,
                    Name = "Phòng Văn Phòng"
                },
                new RoomType
                {
                    RoomTypeId = 3,
                    Name = "Phòng Thí Nghiệm"
                },
                new RoomType
                {
                    RoomTypeId = 4,
                    Name = "Phòng Máy"
                },
                new RoomType
                {
                    RoomTypeId = 5,
                    Name = "Phòng Thể Dục"
                },
                new RoomType
                {
                    RoomTypeId = 6,
                    Name = "Phòng Thư Viện"
                },
                new RoomType
                {
                    RoomTypeId = 7,
                    Name = "Phòng Y Tế"
                }
                );
            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = 1,
                    RoomName = "Phòng 101",
                    Status = "Active",
                    RoomDate = new DateTime(2025, 3, 17),
                    RoomTypeId = 1,
                    BuildingId = 1
                },
                new Room
                {
                    RoomId = 2,
                    RoomName = "Phòng 102",
                    Status = "Active",
                    RoomDate = new DateTime(2025, 3, 17),
                    RoomTypeId = 1,
                    BuildingId = 2
                },
                new Room
                {
                    RoomId = 3,
                    RoomName = "Phòng 103",
                    Status = "Active",
                    RoomDate = new DateTime(2025, 3, 17),
                    RoomTypeId = 2,
                    BuildingId = 1
                },
                new Room
                {
                    RoomId = 4,
                    RoomName = "Phòng 104",
                    Status = "Active",
                    RoomDate = new DateTime(2025, 3, 17),
                    RoomTypeId = 2,
                    BuildingId = 2
                },
                new Room
                {
                    RoomId = 5,
                    RoomName = "Phòng 105",
                    Status = "Active",
                    RoomDate = new DateTime(2025, 3, 17),
                    RoomTypeId = 1,
                    BuildingId = 2
                },
                new Room
                {
                    RoomId = 6,
                    RoomName = "Phòng 106",
                    Status = "Active",
                    RoomDate = new DateTime(2025, 3, 17),
                    RoomTypeId = 1,
                    BuildingId = 3
                },
                new Room
                {
                    RoomId = 7,
                    RoomName = "Phòng 107",
                    Status = "Active",
                    RoomDate = new DateTime(2025, 3, 17),
                    RoomTypeId = 3,
                    BuildingId = 3
                },
                new Room
                {
                    RoomId = 8,
                    RoomName = "Phòng 108",
                    Status = "Active",
                    RoomDate = new DateTime(2025, 3, 17),
                    RoomTypeId = 2,
                    BuildingId = 3
                },
                new Room
                {
                    RoomId = 9,
                    RoomName = "Phòng 109",
                    Status = "Active",
                    RoomDate = new DateTime(2025, 3, 17),
                    RoomTypeId = 3,
                    BuildingId = 3
                },
                new Room
                {
                    RoomId = 10,
                    RoomName = "Phòng 110",
                    Status = "Active",
                    RoomDate = new DateTime(2025, 3, 17),
                    RoomTypeId = 6,
                    BuildingId = 2
                }
                );
            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    CategoryId = 1,
                    CategoryName = "Cơ Sở Vật Chất"
                },
                new Category
                {
                    CategoryId = 2,
                    CategoryName = "Thiết Bị Dạng Dạy"
                },
                new Category
                {
                    CategoryId = 3,
                    CategoryName = "Dụng Cụ Văn Phòng"
                },
                new Category
                {
                    CategoryId = 4,
                    CategoryName = "Thiết Bị Y Tế"
                },
                new Category
                {
                    CategoryId = 5,
                    CategoryName = "Thiết Bị Thể Dục"
                }
                );
        }
    }
}
