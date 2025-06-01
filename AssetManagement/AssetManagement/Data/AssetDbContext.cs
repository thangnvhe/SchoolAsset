using AssetManagement.Data.SeedData;
using AssetManagement.Data.SeedData.AssetModule;
using AssetManagement.Data.SeedData.SupplierModule;
using AssetManagement.Data.SeedData.UserModule;
using AssetManagement.Enums;
using AssetManagement.Models.Entities.AssetModule;
using AssetManagement.Models.Entities.DepreciationModule;
using AssetManagement.Models.Entities.MaintainModule;
using AssetManagement.Models.Entities.SupplierModule;
using AssetManagement.Models.Entities.UserModule;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AssetManagement.Data
{
    public class AssetDbContext : IdentityDbContext<ApplicationUser, UserRole, string>
    {
        public AssetDbContext(DbContextOptions<AssetDbContext> options) : base(options)
        {
        }

        // Asset Module
        public DbSet<AssetType> AssetTypes { get; set; }
        public DbSet<Asset> Assets { get; set; }
        public DbSet<InventoryAsset> InventoryAssets { get; set; }
        public DbSet<AssetItem> AssetItems { get; set; }
        public DbSet<Location> Locations { get; set; }

        // Supplier Module
        public DbSet<Supplier> Suppliers { get; set; }

        // Maintain Module
        public DbSet<AssetIssue> AssetIssues { get; set; }
        public DbSet<MaintenanceRecord> MaintenanceRecords { get; set; }

        // Depreciation Module
        public DbSet<DepreciationRecord> DepreciationRecords { get; set; }

        // User Module
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<RolePermission> RolePermissions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // AssetManagement: AssetType
            modelBuilder.Entity<AssetType>(entity =>
            {
                entity.HasKey(e => e.AssetTypeID);
                entity.Property(e => e.TypeName).IsRequired().HasMaxLength(100);
                entity.Property(e => e.Description).HasMaxLength(500);
            });

            // AssetManagement: Asset
            modelBuilder.Entity<Asset>(entity =>
            {
                entity.HasKey(e => e.AssetID);
                entity.Property(e => e.AssetID).HasMaxLength(50);
                entity.Property(e => e.AssetName).IsRequired().HasMaxLength(100);
                entity.HasOne(e => e.AssetType)
                      .WithMany(at => at.Assets)
                      .HasForeignKey(e => e.AssetTypeID)
                      .OnDelete(DeleteBehavior.Restrict);
            });

            // AssetManagement: InventoryAsset
            modelBuilder.Entity<InventoryAsset>(entity =>
            {
                entity.HasKey(e => e.InventoryID);
                entity.Property(e => e.PurchaseDate).IsRequired();
                entity.Property(e => e.PurchasePrice).IsRequired().HasColumnType("decimal(18,2)");
                entity.Property(e => e.Quantity).IsRequired();
                entity.Property(e => e.InvoiceNumber).HasMaxLength(50);
                entity.Property(e => e.Notes).HasMaxLength(500);
                entity.HasOne(e => e.Asset)
                      .WithMany(a => a.InventoryAssets)
                      .HasForeignKey(e => e.AssetID)
                      .OnDelete(DeleteBehavior.Restrict);
                entity.HasOne(e => e.Supplier)
                      .WithMany(s => s.InventoryAssets)
                      .HasForeignKey(e => e.SupplierID)
                      .OnDelete(DeleteBehavior.SetNull);
            });

            // AssetManagement: AssetItem
            modelBuilder.Entity<AssetItem>(entity =>
            {
                entity.HasKey(e => e.AssetItemID);
                entity.Property(e => e.AssetItemID).HasMaxLength(50);
                entity.Property(e => e.Status)
                      .HasConversion(
                          v => v.ToString(),
                          v => (AssetItemStatus)Enum.Parse(typeof(AssetItemStatus), v))
                      .HasMaxLength(50);
                entity.HasOne(e => e.InventoryAsset)
                      .WithMany(ia => ia.AssetItems)
                      .HasForeignKey(e => e.InventoryID)
                      .OnDelete(DeleteBehavior.Cascade);
                entity.HasOne(e => e.Location)
                      .WithMany(l => l.AssetItems)
                      .HasForeignKey(e => e.LocationID)
                      .OnDelete(DeleteBehavior.Restrict);
                entity.HasOne(e => e.UpdatedByUser)
                      .WithMany(u => u.UpdatedAssetItems)
                      .HasForeignKey(e => e.UpdatedBy)
                      .OnDelete(DeleteBehavior.SetNull);
                entity.HasIndex(e => new { e.InventoryID, e.AssetItemID }).IsUnique();
            });

            // AssetManagement: Location
            modelBuilder.Entity<Location>(entity =>
            {
                entity.HasKey(e => e.LocationID);
                entity.Property(e => e.LocationName).IsRequired().HasMaxLength(100);
                entity.Property(e => e.Address).HasMaxLength(200);
                entity.Property(e => e.Description).HasMaxLength(500);
            });

            // SupplierManagement: Supplier
            modelBuilder.Entity<Supplier>(entity =>
            {
                entity.HasKey(e => e.SupplierID);
                entity.Property(e => e.SupplierName).IsRequired().HasMaxLength(100);
                entity.Property(e => e.ContactInfo).HasMaxLength(200);
                entity.Property(e => e.Address).HasMaxLength(200);
                entity.Property(e => e.Notes).HasMaxLength(500);
            });

            // MaintenanceManagement: AssetIssue
            modelBuilder.Entity<AssetIssue>(entity =>
            {
                entity.HasKey(e => e.IssueID);
                entity.Property(e => e.IssueDescription).IsRequired().HasMaxLength(1000);
                entity.Property(e => e.Status)
                      .HasConversion(
                          v => v.ToString(),
                          v => (AssetIssueStatus)Enum.Parse(typeof(AssetIssueStatus), v))
                      .HasMaxLength(50);
                entity.HasOne(e => e.InventoryAsset)
                      .WithMany(ia => ia.Issues)
                      .HasForeignKey(e => e.InventoryID)
                      .OnDelete(DeleteBehavior.Restrict);
                entity.HasOne(e => e.AssetItem)
                      .WithMany(ai => ai.Issues)
                      .HasForeignKey(e => e.AssetItemID)
                      .OnDelete(DeleteBehavior.Restrict);
                entity.HasOne(e => e.Reporter)
                      .WithMany(u => u.ReportedIssues)
                      .HasForeignKey(e => e.ReportedBy)
                      .OnDelete(DeleteBehavior.Restrict);
                entity.HasIndex(e => new { e.InventoryID, e.AssetItemID });
            });

            // MaintenanceManagement: MaintenanceRecord
            modelBuilder.Entity<MaintenanceRecord>(entity =>
            {
                entity.HasKey(e => e.MaintenanceID);
                entity.Property(e => e.MaintenanceDate).IsRequired();
                entity.Property(e => e.MaintenanceQuantity).IsRequired();
                entity.Property(e => e.Description).HasMaxLength(1000);
                entity.Property(e => e.Cost).HasColumnType("decimal(18,2)");
                entity.Property(e => e.CompletionPhoto).HasMaxLength(500);
                entity.HasOne(e => e.InventoryAsset)
                      .WithMany(ia => ia.MaintenanceRecords)
                      .HasForeignKey(e => e.InventoryID)
                      .OnDelete(DeleteBehavior.Restrict);
                entity.HasOne(e => e.AssetItem)
                      .WithMany(ai => ai.MaintenanceRecords)
                      .HasForeignKey(e => e.AssetItemID)
                      .OnDelete(DeleteBehavior.Restrict);
                entity.HasOne(e => e.Issue)
                      .WithOne(i => i.MaintenanceRecord)
                      .HasForeignKey<MaintenanceRecord>(e => e.IssueID)
                      .OnDelete(DeleteBehavior.Restrict);
                entity.HasOne(e => e.Maintainer)
                      .WithMany(u => u.MaintenanceRecords)
                      .HasForeignKey(e => e.PerformedBy)
                      .OnDelete(DeleteBehavior.Restrict);
                entity.HasIndex(e => new { e.InventoryID, e.AssetItemID });
            });

            // DepreciationManagement: DepreciationRecord
            modelBuilder.Entity<DepreciationRecord>(entity =>
            {
                entity.HasKey(e => e.DepreciationID);
                entity.Property(e => e.DepreciationDate).IsRequired();
                entity.Property(e => e.DepreciationAmount).HasColumnType("decimal(18,2)");
                entity.Property(e => e.NewValue).HasColumnType("decimal(18,2)");
                entity.Property(e => e.Notes).HasMaxLength(500);
                entity.HasOne(e => e.InventoryAsset)
                      .WithMany(ia => ia.DepreciationRecords)
                      .HasForeignKey(e => e.InventoryID)
                      .OnDelete(DeleteBehavior.Restrict);
                entity.HasOne(e => e.AssetItem)
                      .WithMany(ai => ai.DepreciationRecords)
                      .HasForeignKey(e => e.AssetItemID)
                      .OnDelete(DeleteBehavior.Restrict);
                entity.HasIndex(e => new { e.InventoryID, e.AssetItemID });
            });

            // UserModule: Permission
            modelBuilder.Entity<Permission>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Name).IsRequired().HasMaxLength(50);
                entity.Property(e => e.Description).HasMaxLength(200);
                entity.HasIndex(e => e.Name).IsUnique();
            });

            // UserModule: RolePermission
            modelBuilder.Entity<RolePermission>(entity =>
            {
                entity.HasKey(rp => new { rp.RoleId, rp.PermissionId });
                entity.HasOne(rp => rp.Role)
                      .WithMany()
                      .HasForeignKey(rp => rp.RoleId)
                      .OnDelete(DeleteBehavior.Cascade);
                entity.HasOne(rp => rp.Permission)
                      .WithMany(p => p.RolePermissions)
                      .HasForeignKey(rp => rp.PermissionId)
                      .OnDelete(DeleteBehavior.Cascade);
            });

            // Seed data
            modelBuilder.ApplyConfiguration(new LocationSeed());
            modelBuilder.ApplyConfiguration(new AssetTypeSeed());
            modelBuilder.ApplyConfiguration(new AssetSeed());
            modelBuilder.ApplyConfiguration(new SupplierSeed());
            modelBuilder.ApplyConfiguration(new InventoryAssetSeed());
            modelBuilder.ApplyConfiguration(new AssetItemSeed());
            modelBuilder.ApplyConfiguration(new UserSeed());
            modelBuilder.ApplyConfiguration(new RoleSeed());
            modelBuilder.ApplyConfiguration(new UserRoleSeed());
            modelBuilder.ApplyConfiguration(new PermissionSeed());
            modelBuilder.ApplyConfiguration(new RolePermissionSeed());
        }
    }
}