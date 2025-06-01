using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using AssetManagement.Models.Entities.UserModule;

namespace AssetManagement.Data.SeedData
{
    public class PermissionSeed : IEntityTypeConfiguration<Permission>
    {
        public void Configure(EntityTypeBuilder<Permission> builder)
        {
            builder.HasData(
                new Permission
                {
                    Id = 1,
                    Name = "ViewAssets",
                    Description = "Permission to view assets"
                },
                new Permission
                {
                    Id = 2,
                    Name = "CreateAssets",
                    Description = "Permission to create new assets"
                },
                new Permission
                {
                    Id = 3,
                    Name = "EditAssets",
                    Description = "Permission to edit existing assets"
                },
                new Permission
                {
                    Id = 4,
                    Name = "DeleteAssets",
                    Description = "Permission to delete assets"
                },
                new Permission
                {
                    Id = 5,
                    Name = "ManageUsers",
                    Description = "Permission to manage user accounts"
                }
            );
        }
    }
}
