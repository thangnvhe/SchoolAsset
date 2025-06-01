using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace AssetManagement.Models.Entities.UserModule
{
    public class UserRole : IdentityRole
    {
        [StringLength(200)]
        public string? Description { get; set; }

        public bool IsActive { get; set; } = true; // Default to active

        public DateTime? CreatedAt { get; set; }

        public DateTime? UpdatedAt { get; set; }
        public ICollection<RolePermission>? RolePermissions { get; set; }
    }
}
