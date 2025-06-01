using AssetManagement.Models.Entities.AssetModule;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AssetManagement.Data.SeedData.AssetModule
{
    public class AssetSeed : IEntityTypeConfiguration<Asset>
    {
        public void Configure(EntityTypeBuilder<Asset> builder)
        {
            builder.HasData(GetAssets());
        }

        private static List<Asset> GetAssets()
        {
            return new List<Asset>
            {
                new Asset { AssetID = "AST001", AssetName = "Bàn học A1", AssetTypeID = 5 },
                new Asset { AssetID = "AST002", AssetName = "Ghế học A1", AssetTypeID = 6 },
                new Asset { AssetID = "AST003", AssetName = "Đèn bàn A1", AssetTypeID = 7 },
                new Asset { AssetID = "AST004", AssetName = "Quạt điện A1", AssetTypeID = 8 },
                new Asset { AssetID = "AST005", AssetName = "Laptop Dell Vostro", AssetTypeID = 2 },
                new Asset { AssetID = "AST006", AssetName = "Máy tính HP Compaq", AssetTypeID = 1 },
                new Asset { AssetID = "AST007", AssetName = "Máy in Canon LBP", AssetTypeID = 3 },
                new Asset { AssetID = "AST008", AssetName = "Máy chiếu Epson", AssetTypeID = 4 },
                new Asset { AssetID = "AST009", AssetName = "Tủ tài liệu gỗ", AssetTypeID = 9 },
                new Asset { AssetID = "AST010", AssetName = "Camera Hikvision", AssetTypeID = 10 },
                new Asset { AssetID = "AST011", AssetName = "Bàn học A2", AssetTypeID = 5 },
                new Asset { AssetID = "AST012", AssetName = "Ghế học A2", AssetTypeID = 6 },
                new Asset { AssetID = "AST013", AssetName = "Đèn bàn A2", AssetTypeID = 7 },
                new Asset { AssetID = "AST014", AssetName = "Quạt điện A2", AssetTypeID = 8 },
                new Asset { AssetID = "AST015", AssetName = "Laptop Lenovo ThinkPad", AssetTypeID = 2 },
                new Asset { AssetID = "AST016", AssetName = "Máy tính Dell Optiplex", AssetTypeID = 1 },
                new Asset { AssetID = "AST017", AssetName = "Máy in HP LaserJet", AssetTypeID = 3 },
                new Asset { AssetID = "AST018", AssetName = "Máy chiếu Sony", AssetTypeID = 4 },
                new Asset { AssetID = "AST019", AssetName = "Tủ sắt 3 ngăn", AssetTypeID = 9 },
                new Asset { AssetID = "AST020", AssetName = "Camera Dahua", AssetTypeID = 10 }
            };
        }
    }
}
