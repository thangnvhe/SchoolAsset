using AssetManagement.Models.Entities.UserModule;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace AssetManagement.Data.SeedData
{
    public class RoleSeed : IEntityTypeConfiguration<UserRole>
    {
        public void Configure(EntityTypeBuilder<UserRole> builder)
        {
            var now = DateTime.UtcNow;

            var roles = new List<UserRole>
            {
                new UserRole
                {
                    Id = "role1",
                    Name = "Admin",
                    NormalizedName = "ADMIN",
                    Description = "System administrator with full access",
                    IsActive = true,
                    CreatedAt = now,
                    UpdatedAt = now
                },
                new UserRole
                {
                    Id = "role2",
                    Name = "Manager",
                    NormalizedName = "MANAGER",
                    Description = "Manager with permission to assign and review assets",
                    IsActive = true,
                    CreatedAt = now,
                    UpdatedAt = now
                },
                new UserRole
                {
                    Id = "role3",
                    Name = "Staff",
                    NormalizedName = "STAFF",
                    Description = "Regular staff managing assigned assets",
                    IsActive = true,
                    CreatedAt = now,
                    UpdatedAt = now
                },
                new UserRole
                {
                    Id = "role4",
                    Name = "Technician",
                    NormalizedName = "TECHNICIAN",
                    Description = "Handles maintenance and repairs",
                    IsActive = true,
                    CreatedAt = now,
                    UpdatedAt = now
                },
                new UserRole
                {
                    Id = "role5",
                    Name = "Viewer",
                    NormalizedName = "VIEWER",
                    Description = "Read-only access for audit or tracking",
                    IsActive = true,
                    CreatedAt = now,
                    UpdatedAt = now
                }
            };

            builder.HasData(roles);
        }
    }
}
