using AssetManagement.Models.Entities.DepreciationModule;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AssetManagement.Data.SeedData.DepreciationModule
{
    public class DepreciationRecordSeed : IEntityTypeConfiguration<DepreciationRecord>
    {
        public void Configure(EntityTypeBuilder<DepreciationRecord> builder)
        {
            builder.HasData();
        }

        private static List<DepreciationRecord> GetDepreciationRecords()
        {
            var list = new List<DepreciationRecord>();
            return list;
        }
    }
}
