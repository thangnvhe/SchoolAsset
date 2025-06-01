using AssetManagement.Models.Entities.UserModule;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AssetManagement.Data.SeedData
{
    public class UserSeed : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            var hasher = new PasswordHasher<ApplicationUser>();

            var users = new List<ApplicationUser>();

            for (int i = 1; i <= 20; i++)
            {
                var user = new ApplicationUser
                {
                    Id = $"user{i}", // string ID do Identity yêu cầu
                    UserName = $"user{i}",
                    NormalizedUserName = $"USER{i}",
                    Email = $"user{i}@example.com",
                    NormalizedEmail = $"USER{i}@EXAMPLE.COM",
                    EmailConfirmed = true,
                    PhoneNumber = $"09876543{i:D2}",
                    PhoneNumberConfirmed = true,
                    FirstName = $"First{i}",
                    LastName = $"Last{i}",
                    Age = 20 + (i % 10),
                    IsMale = i % 2 == 0,
                    Province = "Hanoi",
                    District = "Cau Giay",
                    Ward = "Dich Vong Hau",
                    Street = $"Street {i}",
                    CreateAt = DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss"),
                    UpdateAt = DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss"),
                    IsActive = true,
                    SecurityStamp = Guid.NewGuid().ToString()
                };

                user.PasswordHash = hasher.HashPassword(user, "Password@123");
                users.Add(user);
            }

            builder.HasData(users);
        }
    }
}
