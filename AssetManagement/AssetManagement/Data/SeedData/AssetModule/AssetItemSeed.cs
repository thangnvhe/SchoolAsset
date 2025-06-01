using AssetManagement.Enums;
using AssetManagement.Models.Entities.AssetModule;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AssetManagement.Data.SeedData.AssetModule
{
    public class AssetItemSeed : IEntityTypeConfiguration<AssetItem>
    {
        public void Configure(EntityTypeBuilder<AssetItem> builder)
        {
            builder.HasData(GetAssetItems());
        }
        private static List<AssetItem> GetAssetItems()
        {
            var assetItems = new List<AssetItem>
            {
                new AssetItem { AssetItemID = "AI001", InventoryID = 1, LocationID = 1, Status = AssetItemStatus.Available, UpdatedBy = "user9", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                new AssetItem { AssetItemID = "AI002", InventoryID = 2, LocationID = 2, Status = AssetItemStatus.InUse, UpdatedBy = "user10", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                new AssetItem { AssetItemID = "AI003", InventoryID = 3, LocationID = 3, Status = AssetItemStatus.Maintenance, UpdatedBy = "user11", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                new AssetItem { AssetItemID = "AI004", InventoryID = 4, LocationID = 4, Status = AssetItemStatus.Available, UpdatedBy = "user12", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                new AssetItem { AssetItemID = "AI005", InventoryID = 5, LocationID = 1, Status = AssetItemStatus.InUse, UpdatedBy = "user9", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                new AssetItem { AssetItemID = "AI006", InventoryID = 6, LocationID = 2, Status = AssetItemStatus.Available, UpdatedBy = "user10", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                new AssetItem { AssetItemID = "AI007", InventoryID = 7, LocationID = 3, Status = AssetItemStatus.Retired, UpdatedBy = "user11", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                new AssetItem { AssetItemID = "AI008", InventoryID = 8, LocationID = 4, Status = AssetItemStatus.InUse, UpdatedBy = "user12", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                new AssetItem { AssetItemID = "AI009", InventoryID = 9, LocationID = 1, Status = AssetItemStatus.Available, UpdatedBy = "user9", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                new AssetItem { AssetItemID = "AI010", InventoryID = 10, LocationID = 2, Status = AssetItemStatus.Maintenance, UpdatedBy = "user10", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },

                new AssetItem { AssetItemID = "AI011", InventoryID = 11, LocationID = 3, Status = AssetItemStatus.InUse, UpdatedBy = "user11", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                new AssetItem { AssetItemID = "AI012", InventoryID = 12, LocationID = 4, Status = AssetItemStatus.Available, UpdatedBy = "user12", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                new AssetItem { AssetItemID = "AI013", InventoryID = 13, LocationID = 1, Status = AssetItemStatus.InUse, UpdatedBy = "user9", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                new AssetItem { AssetItemID = "AI014", InventoryID = 14, LocationID = 2, Status = AssetItemStatus.Retired, UpdatedBy = "user10", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                new AssetItem { AssetItemID = "AI015", InventoryID = 15, LocationID = 3, Status = AssetItemStatus.Available, UpdatedBy = "user11", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                new AssetItem { AssetItemID = "AI016", InventoryID = 16, LocationID = 4, Status = AssetItemStatus.InUse, UpdatedBy = "user12", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                new AssetItem { AssetItemID = "AI017", InventoryID = 17, LocationID = 1, Status = AssetItemStatus.Available, UpdatedBy = "user9", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                new AssetItem { AssetItemID = "AI018", InventoryID = 18, LocationID = 2, Status = AssetItemStatus.Maintenance, UpdatedBy = "user10", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                new AssetItem { AssetItemID = "AI019", InventoryID = 19, LocationID = 3, Status = AssetItemStatus.InUse, UpdatedBy = "user11", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                new AssetItem { AssetItemID = "AI020", InventoryID = 20, LocationID = 4, Status = AssetItemStatus.Available, UpdatedBy = "user12", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
            };

            return assetItems;
        }
    }
}
