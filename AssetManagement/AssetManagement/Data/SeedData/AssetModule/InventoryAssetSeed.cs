using AssetManagement.Models.Entities.AssetModule;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AssetManagement.Data.SeedData.AssetModule
{
    public class InventoryAssetSeed : IEntityTypeConfiguration<InventoryAsset>
    {
        public void Configure(EntityTypeBuilder<InventoryAsset> builder)
        {
            builder.HasData(GetInventoryAssets());
        }

        private static List<InventoryAsset> GetInventoryAssets()
        {
            var inventoryAssets = new List<InventoryAsset>
            {
                new InventoryAsset
                {
                    InventoryID = 1,
                    AssetID = "AST001",
                    SupplierID = 1,
                    PurchaseDate = new DateTime(2024, 1, 15),
                    PurchasePrice = 12000000,
                    Quantity = 10,
                    InvoiceNumber = "INV-20240101",
                    Notes = "Dành cho phòng lab A1",
                    CreatedAt = DateTime.Now
                },
                new InventoryAsset
                {
                    InventoryID = 2,
                    AssetID = "AST002",
                    SupplierID = 2,
                    PurchaseDate = new DateTime(2024, 2, 10),
                    PurchasePrice = 500000,
                    Quantity = 50,
                    InvoiceNumber = "INV-20240210",
                    Notes = "Dành cho lớp học thực hành",
                    CreatedAt = DateTime.Now
                },
                new InventoryAsset
                {   InventoryID = 3,
                    AssetID = "AST003",
                    SupplierID = 3,
                    PurchaseDate = new DateTime(2024, 3, 5),
                    PurchasePrice = 15000000,
                    Quantity = 15,
                    InvoiceNumber = "INV-20240305",
                    Notes = "Bổ sung máy chiếu lớp học",
                    CreatedAt = DateTime.Now
                },
                new InventoryAsset
                {   InventoryID = 4,
                    AssetID = "AST004",
                    SupplierID = 1,
                    PurchaseDate = new DateTime(2024, 4, 8),
                    PurchasePrice = 4000000,
                    Quantity = 8,
                    InvoiceNumber = "INV-20240408",
                    Notes = "Thay mới bàn học khối 10",
                    CreatedAt = DateTime.Now
                },
                new InventoryAsset
                {   InventoryID = 5,
                    AssetID = "AST005",
                    SupplierID = 4,
                    PurchaseDate = new DateTime(2024, 5, 20),
                    PurchasePrice = 7000000,
                    Quantity = 6,
                    InvoiceNumber = "INV-20240520",
                    Notes = "Ghế cho phòng họp",
                    CreatedAt = DateTime.Now
                },
                new InventoryAsset
                {   InventoryID = 6,
                    AssetID = "AST006",
                    SupplierID = 5,
                    PurchaseDate = new DateTime(2024, 6, 1),
                    PurchasePrice = 300000,
                    Quantity = 100,
                    InvoiceNumber = "INV-20240601",
                    Notes = "Bút viết bảng dùng hàng tháng",
                    CreatedAt = DateTime.Now
                },
                new InventoryAsset
                {   InventoryID = 7,
                    AssetID = "AST007",
                    SupplierID = 6,
                    PurchaseDate = new DateTime(2024, 7, 10),
                    PurchasePrice = 20000000,
                    Quantity = 3,
                    InvoiceNumber = "INV-20240710",
                    Notes = "Máy scan dùng chung phòng hành chính",
                    CreatedAt = DateTime.Now
                },
                new InventoryAsset
                {   InventoryID = 8,
                    AssetID = "AST008",
                    SupplierID = 2,
                    PurchaseDate = new DateTime(2024, 8, 15),
                    PurchasePrice = 8000000,
                    Quantity = 5,
                    InvoiceNumber = "INV-20240815",
                    Notes = "Mua máy in phòng giáo vụ",
                    CreatedAt = DateTime.Now
                },
                new InventoryAsset
                {   InventoryID = 9,
                    AssetID = "AST009",
                    SupplierID = 1,
                    PurchaseDate = new DateTime(2024, 9, 20),
                    PurchasePrice = 450000,
                    Quantity = 20,
                    InvoiceNumber = "INV-20240920",
                    Notes = "Hóa chất dùng cho thí nghiệm",
                    CreatedAt = DateTime.Now
                },
                new InventoryAsset
                {   InventoryID = 10,
                    AssetID = "AST010",
                    SupplierID = 4,
                    PurchaseDate = new DateTime(2024, 10, 5),
                    PurchasePrice = 9500000,
                    Quantity = 4,
                    InvoiceNumber = "INV-20241005",
                    Notes = "Máy hút bụi sử dụng cho toàn trường",
                    CreatedAt = DateTime.Now
                },
                new InventoryAsset
                {   InventoryID = 11,
                    AssetID = "AST011",
                    SupplierID = 3,
                    PurchaseDate = new DateTime(2024, 11, 10),
                    PurchasePrice = 2500000,
                    Quantity = 10,
                    InvoiceNumber = "INV-20241110",
                    Notes = "Trang bị micro phòng học ngoại ngữ",
                    CreatedAt = DateTime.Now
                },
                new InventoryAsset
                {   InventoryID = 12,
                    AssetID = "AST012",
                    SupplierID = 5,
                    PurchaseDate = new DateTime(2024, 12, 1),
                    PurchasePrice = 12500000,
                    Quantity = 6,
                    InvoiceNumber = "INV-20241201",
                    Notes = "Màn hình LED phòng hội trường",
                    CreatedAt = DateTime.Now
                },
                new InventoryAsset
                {   InventoryID = 13,
                    AssetID = "AST013",
                    SupplierID = 1,
                    PurchaseDate = new DateTime(2025, 1, 8),
                    PurchasePrice = 950000,
                    Quantity = 25,
                    InvoiceNumber = "INV-20250108",
                    Notes = "Bàn giáo viên thay thế định kỳ",
                    CreatedAt = DateTime.Now
                },
                new InventoryAsset
                {   InventoryID = 14,
                    AssetID = "AST014",
                    SupplierID = 2,
                    PurchaseDate = new DateTime(2025, 2, 5),
                    PurchasePrice = 370000,
                    Quantity = 40,
                    InvoiceNumber = "INV-20250205",
                    Notes = "Tập vở phát cho học sinh",
                    CreatedAt = DateTime.Now
                },
                new InventoryAsset
                {   InventoryID = 15,
                    AssetID = "AST015",
                    SupplierID = 6,
                    PurchaseDate = new DateTime(2025, 3, 1),
                    PurchasePrice = 30000000,
                    Quantity = 2,
                    InvoiceNumber = "INV-20250301",
                    Notes = "Máy tính dựng video",
                    CreatedAt = DateTime.Now
                },
                new InventoryAsset
                {   InventoryID = 16,
                    AssetID = "AST016",
                    SupplierID = 3,
                    PurchaseDate = new DateTime(2025, 3, 20),
                    PurchasePrice = 1200000,
                    Quantity = 30,
                    InvoiceNumber = "INV-20250320",
                    Notes = "Ghế học sinh mẫu mới",
                    CreatedAt = DateTime.Now
                },
                new InventoryAsset
                {   InventoryID = 17,
                    AssetID = "AST017",
                    SupplierID = 4,
                    PurchaseDate = new DateTime(2025, 4, 1),
                    PurchasePrice = 650000,
                    Quantity = 25,
                    InvoiceNumber = "INV-20250401",
                    Notes = "Loa di động dùng cho sự kiện",
                    CreatedAt = DateTime.Now
                },
                new InventoryAsset
                {   InventoryID = 18,
                    AssetID = "AST018",
                    SupplierID = 5,
                    PurchaseDate = new DateTime(2025, 4, 15),
                    PurchasePrice = 9000000,
                    Quantity = 5,
                    InvoiceNumber = "INV-20250415",
                    Notes = "Tivi treo tường các phòng học",
                    CreatedAt = DateTime.Now
                },
                new InventoryAsset
                {   InventoryID = 19,
                    AssetID = "AST019",
                    SupplierID = 6,
                    PurchaseDate = new DateTime(2025, 5, 1),
                    PurchasePrice = 18000000,
                    Quantity = 3,
                    InvoiceNumber = "INV-20250501",
                    Notes = "Thiết bị học trực tuyến",
                    CreatedAt = DateTime.Now
                },
                new InventoryAsset
                {   InventoryID = 20,
                    AssetID = "AST020",
                    SupplierID = 2,
                    PurchaseDate = new DateTime(2025, 5, 20),
                    PurchasePrice = 1500000,
                    Quantity = 12,
                    InvoiceNumber = "INV-20250520",
                    Notes = "Đồng phục nhân viên mới",
                    CreatedAt = DateTime.Now
                },
            };
            return inventoryAssets;
        }
    }
}
