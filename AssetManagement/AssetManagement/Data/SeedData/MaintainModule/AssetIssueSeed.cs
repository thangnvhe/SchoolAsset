using AssetManagement.Models.Entities.MaintainModule;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AssetManagement.Data.SeedData.MaintainModule
{
    public class AssetIssueSeed : IEntityTypeConfiguration<AssetIssue>
    {
        public void Configure(EntityTypeBuilder<AssetIssue> builder)
        {
            builder.HasData();
        }
    }
}
