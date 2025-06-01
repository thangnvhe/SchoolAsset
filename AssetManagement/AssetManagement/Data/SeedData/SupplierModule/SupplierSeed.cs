using AssetManagement.Models.Entities.SupplierModule;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace AssetManagement.Data.SeedData.SupplierModule
{
    public class SupplierSeed : IEntityTypeConfiguration<Supplier>
    {
        public void Configure(EntityTypeBuilder<Supplier> builder)
        {
            builder.HasData(GetSuppliers());
        }

        private static List<Supplier> GetSuppliers()
        {
            return new List<Supplier>
            {
                new Supplier
                {
                    SupplierID = 1,
                    SupplierName = "Công ty TNHH Thiết Bị Giáo Dục A",
                    ContactInfo = "0123 456 789",
                    Address = "123 Đường Lê Lợi, Quận 1, TP.HCM",
                    Notes = "Nhà cung cấp chính cho phòng lab"
                },
                new Supplier
                {
                    SupplierID = 2,
                    SupplierName = "Công ty CP Thiết Bị Học Đường B",
                    ContactInfo = "0987 654 321",
                    Address = "456 Đường Trần Hưng Đạo, Quận 5, TP.HCM",
                    Notes = "Chuyên cung cấp thiết bị phòng học"
                },
                new Supplier
                {
                    SupplierID = 3,
                    SupplierName = "Công ty TNHH Máy Chiếu C",
                    ContactInfo = "0932 111 222",
                    Address = "789 Đường Nguyễn Trãi, Quận 3, TP.HCM",
                    Notes = "Cung cấp máy chiếu và thiết bị trình chiếu"
                },
                new Supplier
                {
                    SupplierID = 4,
                    SupplierName = "Công ty CP Nội Thất D",
                    ContactInfo = "0909 888 777",
                    Address = "321 Đường Cách Mạng Tháng 8, Quận 10, TP.HCM",
                    Notes = "Chuyên về nội thất phòng học và văn phòng"
                },
                new Supplier
                {
                    SupplierID = 5,
                    SupplierName = "Công ty TNHH Văn Phòng Phẩm E",
                    ContactInfo = "0977 123 456",
                    Address = "654 Đường Lý Thường Kiệt, Quận Tân Bình, TP.HCM",
                    Notes = "Cung cấp văn phòng phẩm định kỳ"
                },
                new Supplier
                {
                    SupplierID = 6,
                    SupplierName = "Công ty CP Thiết Bị Văn Phòng F",
                    ContactInfo = "0912 345 678",
                    Address = "987 Đường Hai Bà Trưng, Quận 1, TP.HCM",
                    Notes = "Cung cấp thiết bị văn phòng cao cấp"
                }
            };
        }
    }
}