using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SchoolAsset.DataLayer.Data;
using SchoolAsset.DataLayer.Models;
using System;
using System.Linq;

namespace SchoolAsset.DataLayer.DbIntialier
{
    public class DbInitializer : IDbInitializer
    {
        private readonly SchoolAssetDbContext _db;

        public DbInitializer(SchoolAssetDbContext db)
        {
            _db = db;
        }

        public void Initialize()
        {
            // Áp dụng Migration nếu chưa có
            try
            {
                if (_db.Database.GetPendingMigrations().Any())
                {
                    _db.Database.Migrate();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Migration Error: {ex.Message}");
            }

            // Thêm role trực tiếp nếu chưa có
            if (!_db.Roles.Any(r => r.Name == SD.Role_Admin))
            {
                _db.Roles.AddRange(
                    new IdentityRole { Name = SD.Role_Guest, NormalizedName = SD.Role_Guest.ToUpper() },
                    new IdentityRole { Name = SD.Role_Employee, NormalizedName = SD.Role_Employee.ToUpper() },
                    new IdentityRole { Name = SD.Role_Admin, NormalizedName = SD.Role_Admin.ToUpper() },
                    new IdentityRole { Name = SD.Role_Manager, NormalizedName = SD.Role_Manager.ToUpper() }
                );
                _db.SaveChanges();
            }

            // Kiểm tra xem admin đã tồn tại chưa
            if (!_db.Users.Any(u => u.Email == "admin123@gmail.com"))
            {
                var adminUser = new ApplicationUser
                {
                    UserName = "admin123@gmail.com",
                    Email = "admin123@gmail.com",
                    Name = "Nguyen Van Admin",
                    PhoneNumber = "1112223333",
                    StreetAddress = "123 Quốc Lộ 21, Láng Hòa Lạc",
                    State = "HL",
                    PostalCode = "23422",
                    City = "Việt Nam",
                    EmailConfirmed = true,
                    NormalizedEmail = "ADMIN123@GMAIL.COM",
                    NormalizedUserName = "ADMIN123@GMAIL.COM",
                    SecurityStamp = Guid.NewGuid().ToString(),
                    PasswordHash = new PasswordHasher<ApplicationUser>().HashPassword(null, "Admin123*") // Hash password
                };

                _db.Users.Add(adminUser);
                _db.SaveChanges();

                // Thêm role Admin cho user
                var adminRole = _db.Roles.FirstOrDefault(r => r.Name == SD.Role_Admin);
                if (adminRole != null)
                {
                    _db.UserRoles.Add(new IdentityUserRole<string>
                    {
                        UserId = adminUser.Id,
                        RoleId = adminRole.Id
                    });
                    _db.SaveChanges();
                }
            }
        }
    }
}
