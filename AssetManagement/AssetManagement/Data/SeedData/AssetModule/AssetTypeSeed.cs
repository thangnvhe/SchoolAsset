using AssetManagement.Models.Entities.AssetModule;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AssetManagement.Data.SeedData.AssetModule
{
    public class AssetTypeSeed : IEntityTypeConfiguration<AssetType>
    {
        public void Configure(EntityTypeBuilder<AssetType> builder)
        {
            builder.HasData(GetAssetTypes());
        }

        private static List<AssetType> GetAssetTypes()
        {
            return new List<AssetType>
            {
                new AssetType { AssetTypeID = 1, TypeName = "Máy tính để bàn", Description = "Thiết bị văn phòng cho nhân viên." },
                new AssetType { AssetTypeID = 2, TypeName = "Laptop", Description = "Thiết bị di động cho quản lý và nhân sự." },
                new AssetType { AssetTypeID = 3, TypeName = "Máy in", Description = "Dùng để in tài liệu trong văn phòng." },
                new AssetType { AssetTypeID = 4, TypeName = "Máy chiếu", Description = "Dùng trong phòng học hoặc họp nhóm." },
                new AssetType { AssetTypeID = 5, TypeName = "Bàn học", Description = "Bàn dùng trong phòng học cho học sinh/sinh viên." },
                new AssetType { AssetTypeID = 6, TypeName = "Ghế ngồi", Description = "Ghế văn phòng hoặc phòng học." },
                new AssetType { AssetTypeID = 7, TypeName = "Đèn bàn", Description = "Đèn chiếu sáng cho bàn làm việc hoặc học tập." },
                new AssetType { AssetTypeID = 8, TypeName = "Quạt điện", Description = "Dùng làm mát trong phòng học hoặc làm việc." },
                new AssetType { AssetTypeID = 9, TypeName = "Tủ tài liệu", Description = "Tủ đựng hồ sơ và tài liệu." },
                new AssetType { AssetTypeID = 10, TypeName = "Camera giám sát", Description = "Thiết bị an ninh gắn tại các khu vực quan trọng." }
            };
        }
    }
}
