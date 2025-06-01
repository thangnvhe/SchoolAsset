using AssetManagement.Models.Entities.UserModule;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace AssetManagement.Data.SeedData
{
    public class RolePermissionSeed : IEntityTypeConfiguration<RolePermission>
    {
        public void Configure(EntityTypeBuilder<RolePermission> builder)
        {
            var rolePermissions = new List<RolePermission>
            {
                // Admin có tất cả quyền (ví dụ permissionId từ 1 đến 5)
                new RolePermission { RoleId = "role1", PermissionId = 1 },
                new RolePermission { RoleId = "role1", PermissionId = 2 },
                new RolePermission { RoleId = "role1", PermissionId = 3 },
                new RolePermission { RoleId = "role1", PermissionId = 4 },
                new RolePermission { RoleId = "role1", PermissionId = 5 },

                // Manager có quyền 2, 3, 4
                new RolePermission { RoleId = "role2", PermissionId = 2 },
                new RolePermission { RoleId = "role2", PermissionId = 3 },
                new RolePermission { RoleId = "role2", PermissionId = 4 },

                // Staff có quyền 3
                new RolePermission { RoleId = "role3", PermissionId = 3 },

                // Technician có quyền 4, 5
                new RolePermission { RoleId = "role4", PermissionId = 4 },
                new RolePermission { RoleId = "role4", PermissionId = 5 },

                // Viewer chỉ có quyền 1 (Xem)
                new RolePermission { RoleId = "role5", PermissionId = 1 },
            };

            builder.HasData(rolePermissions);
        }
    }
}
