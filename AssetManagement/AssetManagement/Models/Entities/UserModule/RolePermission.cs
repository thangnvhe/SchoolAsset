namespace AssetManagement.Models.Entities.UserModule
{
    public class RolePermission
    {
        public string RoleId { get; set; }
        public int PermissionId { get; set; }
        public UserRole? Role { get; set; }
        public Permission? Permission { get; set; }
    }
}
