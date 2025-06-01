using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AssetManagement.Data.SeedData.UserModule
{
    public class UserRoleSeed : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            var userRoleMappings = new List<IdentityUserRole<string>>();

            // Giả sử có 5 role: role1 - Admin, role2 - Manager, role3 - Staff, role4 - Technician, role5 - Viewer

            for (int i = 1; i <= 20; i++)
            {
                var roleId = "";

                if (i <= 4) roleId = "role1";             // user 1 - 4 là Admin
                else if (i <= 8) roleId = "role2";        // user 5 - 8 là Manager
                else if (i <= 12) roleId = "role3";       // user 9 - 12 là Staff
                else if (i <= 16) roleId = "role4";       // user 13 - 16 là Technician
                else roleId = "role5";                     // user 17 - 20 là Viewer

                userRoleMappings.Add(new IdentityUserRole<string>
                {
                    UserId = $"user{i}",
                    RoleId = roleId
                });
            }

            builder.HasData(userRoleMappings);
        }
    }
}
