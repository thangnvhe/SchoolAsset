using AssetManagement.Models.Entities.AssetModule;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AssetManagement.Data.SeedData.AssetModule
{
    public class LocationSeed : IEntityTypeConfiguration<Location>
    {
        public void Configure(EntityTypeBuilder<Location> builder)
        {
            builder.HasData(GetLocations());
        }

        private static List<Location> GetLocations()
        {
            string commonAddress = "120 đường 420, xã, Kim Quan, Thạch Thất, Hà Nội";

            var list = new List<Location>
            {
                new Location
                {
                    LocationID = 1,
                    LocationName = "Tòa nhà Alpha",
                    Address = commonAddress,
                    Description = "Khu hành chính"
                },
                new Location
                {
                    LocationID = 2,
                    LocationName = "Tòa nhà Belta",
                    Address = commonAddress,
                    Description = "Phòng học lý thuyết"
                },
                new Location
                {
                    LocationID = 3,
                    LocationName = "Tòa nhà Cilta",
                    Address = commonAddress,
                    Description = "Thư viện trung tâm"
                },
                new Location
                {
                    LocationID = 4,
                    LocationName = "Tòa nhà Delta",
                    Address = commonAddress,
                    Description = "Phòng thí nghiệm và lab máy tính"
                },
                new Location
                {
                    LocationID = 5,
                    LocationName = "Tòa nhà Emma",
                    Address = commonAddress,
                    Description = "Ký túc xá sinh viên"
                }
            };
            return list;
        }

    }
}
