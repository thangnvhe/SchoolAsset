using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AssetManagement.Migrations
{
    /// <inheritdoc />
    public partial class InitialDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    IsMale = table.Column<bool>(type: "bit", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    Province = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    District = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ward = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Street = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateAt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateAt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AssetTypes",
                columns: table => new
                {
                    AssetTypeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssetTypes", x => x.AssetTypeID);
                });

            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    LocationID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LocationName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.LocationID);
                });

            migrationBuilder.CreateTable(
                name: "Permissions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permissions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Suppliers",
                columns: table => new
                {
                    SupplierID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SupplierName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ContactInfo = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suppliers", x => x.SupplierID);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Assets",
                columns: table => new
                {
                    AssetID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    AssetName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    AssetTypeID = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assets", x => x.AssetID);
                    table.ForeignKey(
                        name: "FK_Assets_AssetTypes_AssetTypeID",
                        column: x => x.AssetTypeID,
                        principalTable: "AssetTypes",
                        principalColumn: "AssetTypeID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RolePermissions",
                columns: table => new
                {
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PermissionId = table.Column<int>(type: "int", nullable: false),
                    UserRoleId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RolePermissions", x => new { x.RoleId, x.PermissionId });
                    table.ForeignKey(
                        name: "FK_RolePermissions_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RolePermissions_AspNetRoles_UserRoleId",
                        column: x => x.UserRoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RolePermissions_Permissions_PermissionId",
                        column: x => x.PermissionId,
                        principalTable: "Permissions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InventoryAssets",
                columns: table => new
                {
                    InventoryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AssetID = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    SupplierID = table.Column<int>(type: "int", nullable: true),
                    PurchaseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PurchasePrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    InvoiceNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InventoryAssets", x => x.InventoryID);
                    table.ForeignKey(
                        name: "FK_InventoryAssets_Assets_AssetID",
                        column: x => x.AssetID,
                        principalTable: "Assets",
                        principalColumn: "AssetID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_InventoryAssets_Suppliers_SupplierID",
                        column: x => x.SupplierID,
                        principalTable: "Suppliers",
                        principalColumn: "SupplierID",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "AssetItems",
                columns: table => new
                {
                    AssetItemID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    InventoryID = table.Column<int>(type: "int", nullable: false),
                    LocationID = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssetItems", x => x.AssetItemID);
                    table.ForeignKey(
                        name: "FK_AssetItems_AspNetUsers_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_AssetItems_InventoryAssets_InventoryID",
                        column: x => x.InventoryID,
                        principalTable: "InventoryAssets",
                        principalColumn: "InventoryID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AssetItems_Locations_LocationID",
                        column: x => x.LocationID,
                        principalTable: "Locations",
                        principalColumn: "LocationID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AssetIssues",
                columns: table => new
                {
                    IssueID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InventoryID = table.Column<int>(type: "int", nullable: true),
                    AssetItemID = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    ReportedBy = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IssueDescription = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    ReportDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssetIssues", x => x.IssueID);
                    table.ForeignKey(
                        name: "FK_AssetIssues_AspNetUsers_ReportedBy",
                        column: x => x.ReportedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AssetIssues_AssetItems_AssetItemID",
                        column: x => x.AssetItemID,
                        principalTable: "AssetItems",
                        principalColumn: "AssetItemID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AssetIssues_InventoryAssets_InventoryID",
                        column: x => x.InventoryID,
                        principalTable: "InventoryAssets",
                        principalColumn: "InventoryID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DepreciationRecords",
                columns: table => new
                {
                    DepreciationID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InventoryID = table.Column<int>(type: "int", nullable: true),
                    AssetItemID = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    DepreciationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DepreciationAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NewValue = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DepreciationRecords", x => x.DepreciationID);
                    table.ForeignKey(
                        name: "FK_DepreciationRecords_AssetItems_AssetItemID",
                        column: x => x.AssetItemID,
                        principalTable: "AssetItems",
                        principalColumn: "AssetItemID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DepreciationRecords_InventoryAssets_InventoryID",
                        column: x => x.InventoryID,
                        principalTable: "InventoryAssets",
                        principalColumn: "InventoryID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MaintenanceRecords",
                columns: table => new
                {
                    MaintenanceID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InventoryID = table.Column<int>(type: "int", nullable: true),
                    AssetItemID = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    IssueID = table.Column<int>(type: "int", nullable: true),
                    MaintenanceDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MaintenanceQuantity = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    Cost = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PerformedBy = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CompletionPhoto = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaintenanceRecords", x => x.MaintenanceID);
                    table.ForeignKey(
                        name: "FK_MaintenanceRecords_AspNetUsers_PerformedBy",
                        column: x => x.PerformedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MaintenanceRecords_AssetIssues_IssueID",
                        column: x => x.IssueID,
                        principalTable: "AssetIssues",
                        principalColumn: "IssueID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MaintenanceRecords_AssetItems_AssetItemID",
                        column: x => x.AssetItemID,
                        principalTable: "AssetItems",
                        principalColumn: "AssetItemID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MaintenanceRecords_InventoryAssets_InventoryID",
                        column: x => x.InventoryID,
                        principalTable: "InventoryAssets",
                        principalColumn: "InventoryID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "CreatedAt", "Description", "IsActive", "Name", "NormalizedName", "UpdatedAt" },
                values: new object[,]
                {
                    { "role1", null, new DateTime(2025, 6, 1, 14, 1, 10, 615, DateTimeKind.Utc).AddTicks(5184), "System administrator with full access", true, "Admin", "ADMIN", new DateTime(2025, 6, 1, 14, 1, 10, 615, DateTimeKind.Utc).AddTicks(5184) },
                    { "role2", null, new DateTime(2025, 6, 1, 14, 1, 10, 615, DateTimeKind.Utc).AddTicks(5184), "Manager with permission to assign and review assets", true, "Manager", "MANAGER", new DateTime(2025, 6, 1, 14, 1, 10, 615, DateTimeKind.Utc).AddTicks(5184) },
                    { "role3", null, new DateTime(2025, 6, 1, 14, 1, 10, 615, DateTimeKind.Utc).AddTicks(5184), "Regular staff managing assigned assets", true, "Staff", "STAFF", new DateTime(2025, 6, 1, 14, 1, 10, 615, DateTimeKind.Utc).AddTicks(5184) },
                    { "role4", null, new DateTime(2025, 6, 1, 14, 1, 10, 615, DateTimeKind.Utc).AddTicks(5184), "Handles maintenance and repairs", true, "Technician", "TECHNICIAN", new DateTime(2025, 6, 1, 14, 1, 10, 615, DateTimeKind.Utc).AddTicks(5184) },
                    { "role5", null, new DateTime(2025, 6, 1, 14, 1, 10, 615, DateTimeKind.Utc).AddTicks(5184), "Read-only access for audit or tracking", true, "Viewer", "VIEWER", new DateTime(2025, 6, 1, 14, 1, 10, 615, DateTimeKind.Utc).AddTicks(5184) }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Age", "ConcurrencyStamp", "CreateAt", "District", "Email", "EmailConfirmed", "FirstName", "IsActive", "IsMale", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Province", "SecurityStamp", "Street", "TwoFactorEnabled", "UpdateAt", "UserName", "Ward" },
                values: new object[,]
                {
                    { "user1", 0, 21, "19b46261-dba6-4b61-9730-437c9363a829", "2025-06-01 14:01:09", "Cau Giay", "user1@example.com", true, "First1", true, false, "Last1", false, null, "USER1@EXAMPLE.COM", "USER1", "AQAAAAIAAYagAAAAEEUMTeuXWxCSqcrN6N6YbWQkZInK6Yq9D4Uc4WMaPt84dauKwxZmSPzR6GkODi75xw==", "0987654301", true, "Hanoi", "19f0b6c9-3902-4a35-8f5d-b947411e4f8f", "Street 1", false, "2025-06-01 14:01:09", "user1", "Dich Vong Hau" },
                    { "user10", 0, 20, "e22ac14f-a1a0-4cfc-9e16-52fc96713625", "2025-06-01 14:01:10", "Cau Giay", "user10@example.com", true, "First10", true, true, "Last10", false, null, "USER10@EXAMPLE.COM", "USER10", "AQAAAAIAAYagAAAAEI7PDZihky9DdvhIMU5LINpjfCiGVqS4QFCpw3mXEis99J+xcE5HW9EgJ/AI+necsw==", "0987654310", true, "Hanoi", "8579663e-d173-435d-946e-fc38753ae80c", "Street 10", false, "2025-06-01 14:01:10", "user10", "Dich Vong Hau" },
                    { "user11", 0, 21, "57f8fdbf-a6a2-4df3-8e71-ca878f61103b", "2025-06-01 14:01:10", "Cau Giay", "user11@example.com", true, "First11", true, false, "Last11", false, null, "USER11@EXAMPLE.COM", "USER11", "AQAAAAIAAYagAAAAEEtZsOy7a6i3wi1DcNtzrXgBEXYO4IY2+wU7hrHlCadCb1q3eGWCB2xrsVL9ZVirCg==", "0987654311", true, "Hanoi", "81778c8a-e31e-494c-a243-58a573096bfc", "Street 11", false, "2025-06-01 14:01:10", "user11", "Dich Vong Hau" },
                    { "user12", 0, 22, "b81bce75-7ec7-4bfc-a83c-35a05f87f665", "2025-06-01 14:01:10", "Cau Giay", "user12@example.com", true, "First12", true, true, "Last12", false, null, "USER12@EXAMPLE.COM", "USER12", "AQAAAAIAAYagAAAAEPyDE7/EMmUKtM+5X1OSjCQQbrV0KQTaMRpUdJKNtVyz8EEL8svRpH5h7ex410zOow==", "0987654312", true, "Hanoi", "9c11ea67-2272-488d-9d47-da7449d2d695", "Street 12", false, "2025-06-01 14:01:10", "user12", "Dich Vong Hau" },
                    { "user13", 0, 23, "2b30d55f-ca70-44e2-a1dd-c3a3e2bdd92d", "2025-06-01 14:01:10", "Cau Giay", "user13@example.com", true, "First13", true, false, "Last13", false, null, "USER13@EXAMPLE.COM", "USER13", "AQAAAAIAAYagAAAAEA80xOPgAZJqAfmHUqLZujKxL0ztY+naX/5iTxLPEZyNnjYJQ0p6MWwQTRCIpf93fQ==", "0987654313", true, "Hanoi", "392f01fa-5c77-44e4-9bca-f1940cee3580", "Street 13", false, "2025-06-01 14:01:10", "user13", "Dich Vong Hau" },
                    { "user14", 0, 24, "9eeda37a-6bd4-4d4a-8c54-71867e55feee", "2025-06-01 14:01:10", "Cau Giay", "user14@example.com", true, "First14", true, true, "Last14", false, null, "USER14@EXAMPLE.COM", "USER14", "AQAAAAIAAYagAAAAENqM2iFzMV0ZOwrxbioipOEqx66DEhx2o5Cbfsd0E6IJyHbyzJXUNvl6I5zIjnxjIA==", "0987654314", true, "Hanoi", "abbbc5b5-9386-42c3-9c7a-578ef423507a", "Street 14", false, "2025-06-01 14:01:10", "user14", "Dich Vong Hau" },
                    { "user15", 0, 25, "95fd1d60-36d5-4177-ba97-590a72b8815c", "2025-06-01 14:01:10", "Cau Giay", "user15@example.com", true, "First15", true, false, "Last15", false, null, "USER15@EXAMPLE.COM", "USER15", "AQAAAAIAAYagAAAAEBmISZ4H+VSinWuY2xa7uQAiGOcRf+O7XNCuWBwdLl37tmzZ1W4nzqRRq02puCZruw==", "0987654315", true, "Hanoi", "4b3babf3-7946-4d92-8fca-08e8953aecc9", "Street 15", false, "2025-06-01 14:01:10", "user15", "Dich Vong Hau" },
                    { "user16", 0, 26, "51a16562-72aa-4589-af55-cf88f8359b0d", "2025-06-01 14:01:10", "Cau Giay", "user16@example.com", true, "First16", true, true, "Last16", false, null, "USER16@EXAMPLE.COM", "USER16", "AQAAAAIAAYagAAAAEGdwUZpu+ZkgYpT9vFnhpKSOHiRW/EtdGHxOm/2PhYq5DTDOTKOdZAT0sci6BKVBTg==", "0987654316", true, "Hanoi", "b6b7e5ee-94cf-4323-a183-2a6ab6601dfc", "Street 16", false, "2025-06-01 14:01:10", "user16", "Dich Vong Hau" },
                    { "user17", 0, 27, "6335c5bb-b2aa-4124-b538-9b8d5ed2d89d", "2025-06-01 14:01:10", "Cau Giay", "user17@example.com", true, "First17", true, false, "Last17", false, null, "USER17@EXAMPLE.COM", "USER17", "AQAAAAIAAYagAAAAEOGbYi4kGgJytzZOCqoASt/23Wzk1f9JZoniLr6sWElQXe4q6ebfOESmAm9xzUpOIw==", "0987654317", true, "Hanoi", "6499864b-3ce5-440e-a257-1f760f84b287", "Street 17", false, "2025-06-01 14:01:10", "user17", "Dich Vong Hau" },
                    { "user18", 0, 28, "4dee82b9-0f58-43b5-981b-b7ad3595e092", "2025-06-01 14:01:10", "Cau Giay", "user18@example.com", true, "First18", true, true, "Last18", false, null, "USER18@EXAMPLE.COM", "USER18", "AQAAAAIAAYagAAAAEOH+OeCjGcQ6l35nrdRkr4tHCCT5N6eao94Nq2ddhIpeFNP+9LuEqeKOvCVSIDn9gg==", "0987654318", true, "Hanoi", "20f7d017-707e-487a-a709-4b2b961c0dba", "Street 18", false, "2025-06-01 14:01:10", "user18", "Dich Vong Hau" },
                    { "user19", 0, 29, "f2c971ec-7bd1-432b-baa9-4b8176f4ab5e", "2025-06-01 14:01:10", "Cau Giay", "user19@example.com", true, "First19", true, false, "Last19", false, null, "USER19@EXAMPLE.COM", "USER19", "AQAAAAIAAYagAAAAEJgZ0aERnm+h77LiUwcLq2RXfMSbfx9WbBpoTqg7z039hwB/94sgMKOc4sdFhIjoEw==", "0987654319", true, "Hanoi", "1144c4ee-f122-437c-b283-533f32008481", "Street 19", false, "2025-06-01 14:01:10", "user19", "Dich Vong Hau" },
                    { "user2", 0, 22, "42027e43-b5bd-4f96-8a8b-7d90e80b8a83", "2025-06-01 14:01:09", "Cau Giay", "user2@example.com", true, "First2", true, true, "Last2", false, null, "USER2@EXAMPLE.COM", "USER2", "AQAAAAIAAYagAAAAEN7t+9wVcLyHXMonJHFaK3f+Bs42Th4ob8StsysGVuDEwo/oURLnwMe5Q442u5J2iA==", "0987654302", true, "Hanoi", "71500a8e-8a3a-4842-b819-81d82ead4bea", "Street 2", false, "2025-06-01 14:01:09", "user2", "Dich Vong Hau" },
                    { "user20", 0, 20, "5c24f190-57f5-4541-9509-46f89f806db5", "2025-06-01 14:01:10", "Cau Giay", "user20@example.com", true, "First20", true, true, "Last20", false, null, "USER20@EXAMPLE.COM", "USER20", "AQAAAAIAAYagAAAAEN/T6H+tJua6jK58Bz0b1iWhzelXPxSVy4GKjY5BhLhWMSjgNgsVLB0J8kULrpSLJw==", "0987654320", true, "Hanoi", "4a0f2bc8-b8de-4e94-a5d9-7035d1aa4211", "Street 20", false, "2025-06-01 14:01:10", "user20", "Dich Vong Hau" },
                    { "user3", 0, 23, "92956fa8-67ef-4cd7-96de-3324479ee2bd", "2025-06-01 14:01:09", "Cau Giay", "user3@example.com", true, "First3", true, false, "Last3", false, null, "USER3@EXAMPLE.COM", "USER3", "AQAAAAIAAYagAAAAEDrRyceQ0ONpiitoko2hw/yI0reEIeNpbxWepEf/82lX4BUnCewd5HIrw9yOjz4/hQ==", "0987654303", true, "Hanoi", "47ee739c-70a5-470b-9d9f-522a8d1f26cd", "Street 3", false, "2025-06-01 14:01:09", "user3", "Dich Vong Hau" },
                    { "user4", 0, 24, "69003afb-6865-4246-b997-4a19a0d66c3e", "2025-06-01 14:01:09", "Cau Giay", "user4@example.com", true, "First4", true, true, "Last4", false, null, "USER4@EXAMPLE.COM", "USER4", "AQAAAAIAAYagAAAAELf79WdtgI1jwl/+ZUHHxdinaVvDEm/fRSg4hQlAXbqymK/YmQreVjilYboXNX/fRA==", "0987654304", true, "Hanoi", "cf78ff1d-e486-4ba1-aa40-80de0697541b", "Street 4", false, "2025-06-01 14:01:09", "user4", "Dich Vong Hau" },
                    { "user5", 0, 25, "95f2b291-0d5e-4fca-8fe5-5dd8260dbf76", "2025-06-01 14:01:09", "Cau Giay", "user5@example.com", true, "First5", true, false, "Last5", false, null, "USER5@EXAMPLE.COM", "USER5", "AQAAAAIAAYagAAAAEP9fdxUftNMz3Ne+6KeU/P+9E+HnFlfV3shDzdumtI0Q/RhwSHWCkYt2IEkJrOMtow==", "0987654305", true, "Hanoi", "17aae616-f926-4a0f-acbc-d85dd7bb5e50", "Street 5", false, "2025-06-01 14:01:09", "user5", "Dich Vong Hau" },
                    { "user6", 0, 26, "a5153d24-a4b9-4a9d-995e-9e86df404669", "2025-06-01 14:01:09", "Cau Giay", "user6@example.com", true, "First6", true, true, "Last6", false, null, "USER6@EXAMPLE.COM", "USER6", "AQAAAAIAAYagAAAAEJ4cVDAMiVuLMrCoQ/H7zzRfRDIHptkggKcREZko9UYT8yj970q6ivPr3T3qq44YhQ==", "0987654306", true, "Hanoi", "8103490a-bfca-44fb-89ba-c96566569c1a", "Street 6", false, "2025-06-01 14:01:09", "user6", "Dich Vong Hau" },
                    { "user7", 0, 27, "8a800d8b-accf-4742-9eb9-0b9b31716b29", "2025-06-01 14:01:09", "Cau Giay", "user7@example.com", true, "First7", true, false, "Last7", false, null, "USER7@EXAMPLE.COM", "USER7", "AQAAAAIAAYagAAAAEPVUG8O9q544zU0aoS+xfzzKIUGE4YbQInMAO+r/7lJz/SKy1vmNirBSHyqj4Tpqqg==", "0987654307", true, "Hanoi", "424b0155-3618-407e-9299-1074c9af9ed8", "Street 7", false, "2025-06-01 14:01:09", "user7", "Dich Vong Hau" },
                    { "user8", 0, 28, "d57ad967-6d38-40e3-8d2d-cd24ca820f7a", "2025-06-01 14:01:09", "Cau Giay", "user8@example.com", true, "First8", true, true, "Last8", false, null, "USER8@EXAMPLE.COM", "USER8", "AQAAAAIAAYagAAAAEDFRTT9wfJmJSUasuy+jHMTSHJqSa8aFYA/pmKrDVCEjUiHZACNrozR9zuy1r5datw==", "0987654308", true, "Hanoi", "16c3d4ac-b4f7-4b9b-97ee-5da2a80c8188", "Street 8", false, "2025-06-01 14:01:09", "user8", "Dich Vong Hau" },
                    { "user9", 0, 29, "2664f510-df14-4606-a348-a23b4d40d34e", "2025-06-01 14:01:09", "Cau Giay", "user9@example.com", true, "First9", true, false, "Last9", false, null, "USER9@EXAMPLE.COM", "USER9", "AQAAAAIAAYagAAAAEOGq9i0LUvJpRWufUHOuHG+aruuYULF2H1oQDiXzGhx0UZbqOsqEUARBY0xLgNGCBA==", "0987654309", true, "Hanoi", "707318d1-a4c2-498d-853c-90f100aac6c5", "Street 9", false, "2025-06-01 14:01:09", "user9", "Dich Vong Hau" }
                });

            migrationBuilder.InsertData(
                table: "AssetTypes",
                columns: new[] { "AssetTypeID", "Description", "TypeName" },
                values: new object[,]
                {
                    { 1, "Thiết bị văn phòng cho nhân viên.", "Máy tính để bàn" },
                    { 2, "Thiết bị di động cho quản lý và nhân sự.", "Laptop" },
                    { 3, "Dùng để in tài liệu trong văn phòng.", "Máy in" },
                    { 4, "Dùng trong phòng học hoặc họp nhóm.", "Máy chiếu" },
                    { 5, "Bàn dùng trong phòng học cho học sinh/sinh viên.", "Bàn học" },
                    { 6, "Ghế văn phòng hoặc phòng học.", "Ghế ngồi" },
                    { 7, "Đèn chiếu sáng cho bàn làm việc hoặc học tập.", "Đèn bàn" },
                    { 8, "Dùng làm mát trong phòng học hoặc làm việc.", "Quạt điện" },
                    { 9, "Tủ đựng hồ sơ và tài liệu.", "Tủ tài liệu" },
                    { 10, "Thiết bị an ninh gắn tại các khu vực quan trọng.", "Camera giám sát" }
                });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "LocationID", "Address", "Description", "LocationName" },
                values: new object[,]
                {
                    { 1, "120 đường 420, xã, Kim Quan, Thạch Thất, Hà Nội", "Khu hành chính", "Tòa nhà Alpha" },
                    { 2, "120 đường 420, xã, Kim Quan, Thạch Thất, Hà Nội", "Phòng học lý thuyết", "Tòa nhà Belta" },
                    { 3, "120 đường 420, xã, Kim Quan, Thạch Thất, Hà Nội", "Thư viện trung tâm", "Tòa nhà Cilta" },
                    { 4, "120 đường 420, xã, Kim Quan, Thạch Thất, Hà Nội", "Phòng thí nghiệm và lab máy tính", "Tòa nhà Delta" },
                    { 5, "120 đường 420, xã, Kim Quan, Thạch Thất, Hà Nội", "Ký túc xá sinh viên", "Tòa nhà Emma" }
                });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Permission to view assets", "ViewAssets" },
                    { 2, "Permission to create new assets", "CreateAssets" },
                    { 3, "Permission to edit existing assets", "EditAssets" },
                    { 4, "Permission to delete assets", "DeleteAssets" },
                    { 5, "Permission to manage user accounts", "ManageUsers" }
                });

            migrationBuilder.InsertData(
                table: "Suppliers",
                columns: new[] { "SupplierID", "Address", "ContactInfo", "Notes", "SupplierName" },
                values: new object[,]
                {
                    { 1, "123 Đường Lê Lợi, Quận 1, TP.HCM", "0123 456 789", "Nhà cung cấp chính cho phòng lab", "Công ty TNHH Thiết Bị Giáo Dục A" },
                    { 2, "456 Đường Trần Hưng Đạo, Quận 5, TP.HCM", "0987 654 321", "Chuyên cung cấp thiết bị phòng học", "Công ty CP Thiết Bị Học Đường B" },
                    { 3, "789 Đường Nguyễn Trãi, Quận 3, TP.HCM", "0932 111 222", "Cung cấp máy chiếu và thiết bị trình chiếu", "Công ty TNHH Máy Chiếu C" },
                    { 4, "321 Đường Cách Mạng Tháng 8, Quận 10, TP.HCM", "0909 888 777", "Chuyên về nội thất phòng học và văn phòng", "Công ty CP Nội Thất D" },
                    { 5, "654 Đường Lý Thường Kiệt, Quận Tân Bình, TP.HCM", "0977 123 456", "Cung cấp văn phòng phẩm định kỳ", "Công ty TNHH Văn Phòng Phẩm E" },
                    { 6, "987 Đường Hai Bà Trưng, Quận 1, TP.HCM", "0912 345 678", "Cung cấp thiết bị văn phòng cao cấp", "Công ty CP Thiết Bị Văn Phòng F" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "role1", "user1" },
                    { "role3", "user10" },
                    { "role3", "user11" },
                    { "role3", "user12" },
                    { "role4", "user13" },
                    { "role4", "user14" },
                    { "role4", "user15" },
                    { "role4", "user16" },
                    { "role5", "user17" },
                    { "role5", "user18" },
                    { "role5", "user19" },
                    { "role1", "user2" },
                    { "role5", "user20" },
                    { "role1", "user3" },
                    { "role1", "user4" },
                    { "role2", "user5" },
                    { "role2", "user6" },
                    { "role2", "user7" },
                    { "role2", "user8" },
                    { "role3", "user9" }
                });

            migrationBuilder.InsertData(
                table: "Assets",
                columns: new[] { "AssetID", "AssetName", "AssetTypeID", "CreatedAt", "UpdatedAt" },
                values: new object[,]
                {
                    { "AST001", "Bàn học A1", 5, new DateTime(2025, 6, 1, 21, 1, 9, 597, DateTimeKind.Local).AddTicks(3015), new DateTime(2025, 6, 1, 21, 1, 9, 597, DateTimeKind.Local).AddTicks(3028) },
                    { "AST002", "Ghế học A1", 6, new DateTime(2025, 6, 1, 21, 1, 9, 597, DateTimeKind.Local).AddTicks(3031), new DateTime(2025, 6, 1, 21, 1, 9, 597, DateTimeKind.Local).AddTicks(3032) },
                    { "AST003", "Đèn bàn A1", 7, new DateTime(2025, 6, 1, 21, 1, 9, 597, DateTimeKind.Local).AddTicks(3033), new DateTime(2025, 6, 1, 21, 1, 9, 597, DateTimeKind.Local).AddTicks(3034) },
                    { "AST004", "Quạt điện A1", 8, new DateTime(2025, 6, 1, 21, 1, 9, 597, DateTimeKind.Local).AddTicks(3034), new DateTime(2025, 6, 1, 21, 1, 9, 597, DateTimeKind.Local).AddTicks(3035) },
                    { "AST005", "Laptop Dell Vostro", 2, new DateTime(2025, 6, 1, 21, 1, 9, 597, DateTimeKind.Local).AddTicks(3036), new DateTime(2025, 6, 1, 21, 1, 9, 597, DateTimeKind.Local).AddTicks(3036) },
                    { "AST006", "Máy tính HP Compaq", 1, new DateTime(2025, 6, 1, 21, 1, 9, 597, DateTimeKind.Local).AddTicks(3038), new DateTime(2025, 6, 1, 21, 1, 9, 597, DateTimeKind.Local).AddTicks(3038) },
                    { "AST007", "Máy in Canon LBP", 3, new DateTime(2025, 6, 1, 21, 1, 9, 597, DateTimeKind.Local).AddTicks(3039), new DateTime(2025, 6, 1, 21, 1, 9, 597, DateTimeKind.Local).AddTicks(3039) },
                    { "AST008", "Máy chiếu Epson", 4, new DateTime(2025, 6, 1, 21, 1, 9, 597, DateTimeKind.Local).AddTicks(3040), new DateTime(2025, 6, 1, 21, 1, 9, 597, DateTimeKind.Local).AddTicks(3040) },
                    { "AST009", "Tủ tài liệu gỗ", 9, new DateTime(2025, 6, 1, 21, 1, 9, 597, DateTimeKind.Local).AddTicks(3041), new DateTime(2025, 6, 1, 21, 1, 9, 597, DateTimeKind.Local).AddTicks(3042) },
                    { "AST010", "Camera Hikvision", 10, new DateTime(2025, 6, 1, 21, 1, 9, 597, DateTimeKind.Local).AddTicks(3043), new DateTime(2025, 6, 1, 21, 1, 9, 597, DateTimeKind.Local).AddTicks(3043) },
                    { "AST011", "Bàn học A2", 5, new DateTime(2025, 6, 1, 21, 1, 9, 597, DateTimeKind.Local).AddTicks(3044), new DateTime(2025, 6, 1, 21, 1, 9, 597, DateTimeKind.Local).AddTicks(3045) },
                    { "AST012", "Ghế học A2", 6, new DateTime(2025, 6, 1, 21, 1, 9, 597, DateTimeKind.Local).AddTicks(3046), new DateTime(2025, 6, 1, 21, 1, 9, 597, DateTimeKind.Local).AddTicks(3046) },
                    { "AST013", "Đèn bàn A2", 7, new DateTime(2025, 6, 1, 21, 1, 9, 597, DateTimeKind.Local).AddTicks(3047), new DateTime(2025, 6, 1, 21, 1, 9, 597, DateTimeKind.Local).AddTicks(3053) },
                    { "AST014", "Quạt điện A2", 8, new DateTime(2025, 6, 1, 21, 1, 9, 597, DateTimeKind.Local).AddTicks(3055), new DateTime(2025, 6, 1, 21, 1, 9, 597, DateTimeKind.Local).AddTicks(3055) },
                    { "AST015", "Laptop Lenovo ThinkPad", 2, new DateTime(2025, 6, 1, 21, 1, 9, 597, DateTimeKind.Local).AddTicks(3056), new DateTime(2025, 6, 1, 21, 1, 9, 597, DateTimeKind.Local).AddTicks(3058) },
                    { "AST016", "Máy tính Dell Optiplex", 1, new DateTime(2025, 6, 1, 21, 1, 9, 597, DateTimeKind.Local).AddTicks(3077), new DateTime(2025, 6, 1, 21, 1, 9, 597, DateTimeKind.Local).AddTicks(3078) },
                    { "AST017", "Máy in HP LaserJet", 3, new DateTime(2025, 6, 1, 21, 1, 9, 597, DateTimeKind.Local).AddTicks(3079), new DateTime(2025, 6, 1, 21, 1, 9, 597, DateTimeKind.Local).AddTicks(3079) },
                    { "AST018", "Máy chiếu Sony", 4, new DateTime(2025, 6, 1, 21, 1, 9, 597, DateTimeKind.Local).AddTicks(3081), new DateTime(2025, 6, 1, 21, 1, 9, 597, DateTimeKind.Local).AddTicks(3081) },
                    { "AST019", "Tủ sắt 3 ngăn", 9, new DateTime(2025, 6, 1, 21, 1, 9, 597, DateTimeKind.Local).AddTicks(3082), new DateTime(2025, 6, 1, 21, 1, 9, 597, DateTimeKind.Local).AddTicks(3082) },
                    { "AST020", "Camera Dahua", 10, new DateTime(2025, 6, 1, 21, 1, 9, 597, DateTimeKind.Local).AddTicks(3083), new DateTime(2025, 6, 1, 21, 1, 9, 597, DateTimeKind.Local).AddTicks(3083) }
                });

            migrationBuilder.InsertData(
                table: "RolePermissions",
                columns: new[] { "PermissionId", "RoleId", "UserRoleId" },
                values: new object[,]
                {
                    { 1, "role1", null },
                    { 2, "role1", null },
                    { 3, "role1", null },
                    { 4, "role1", null },
                    { 5, "role1", null },
                    { 2, "role2", null },
                    { 3, "role2", null },
                    { 4, "role2", null },
                    { 3, "role3", null },
                    { 4, "role4", null },
                    { 5, "role4", null },
                    { 1, "role5", null }
                });

            migrationBuilder.InsertData(
                table: "InventoryAssets",
                columns: new[] { "InventoryID", "AssetID", "CreatedAt", "InvoiceNumber", "Notes", "PurchaseDate", "PurchasePrice", "Quantity", "SupplierID" },
                values: new object[,]
                {
                    { 1, "AST001", new DateTime(2025, 6, 1, 21, 1, 9, 597, DateTimeKind.Local).AddTicks(3382), "INV-20240101", "Dành cho phòng lab A1", new DateTime(2024, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 12000000m, 10, 1 },
                    { 2, "AST002", new DateTime(2025, 6, 1, 21, 1, 9, 597, DateTimeKind.Local).AddTicks(3386), "INV-20240210", "Dành cho lớp học thực hành", new DateTime(2024, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 500000m, 50, 2 },
                    { 3, "AST003", new DateTime(2025, 6, 1, 21, 1, 9, 597, DateTimeKind.Local).AddTicks(3389), "INV-20240305", "Bổ sung máy chiếu lớp học", new DateTime(2024, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 15000000m, 15, 3 },
                    { 4, "AST004", new DateTime(2025, 6, 1, 21, 1, 9, 597, DateTimeKind.Local).AddTicks(3391), "INV-20240408", "Thay mới bàn học khối 10", new DateTime(2024, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 4000000m, 8, 1 },
                    { 5, "AST005", new DateTime(2025, 6, 1, 21, 1, 9, 597, DateTimeKind.Local).AddTicks(3394), "INV-20240520", "Ghế cho phòng họp", new DateTime(2024, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 7000000m, 6, 4 },
                    { 6, "AST006", new DateTime(2025, 6, 1, 21, 1, 9, 597, DateTimeKind.Local).AddTicks(3397), "INV-20240601", "Bút viết bảng dùng hàng tháng", new DateTime(2024, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 300000m, 100, 5 },
                    { 7, "AST007", new DateTime(2025, 6, 1, 21, 1, 9, 597, DateTimeKind.Local).AddTicks(3400), "INV-20240710", "Máy scan dùng chung phòng hành chính", new DateTime(2024, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 20000000m, 3, 6 },
                    { 8, "AST008", new DateTime(2025, 6, 1, 21, 1, 9, 597, DateTimeKind.Local).AddTicks(3403), "INV-20240815", "Mua máy in phòng giáo vụ", new DateTime(2024, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 8000000m, 5, 2 },
                    { 9, "AST009", new DateTime(2025, 6, 1, 21, 1, 9, 597, DateTimeKind.Local).AddTicks(3405), "INV-20240920", "Hóa chất dùng cho thí nghiệm", new DateTime(2024, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 450000m, 20, 1 },
                    { 10, "AST010", new DateTime(2025, 6, 1, 21, 1, 9, 597, DateTimeKind.Local).AddTicks(3409), "INV-20241005", "Máy hút bụi sử dụng cho toàn trường", new DateTime(2024, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 9500000m, 4, 4 },
                    { 11, "AST011", new DateTime(2025, 6, 1, 21, 1, 9, 597, DateTimeKind.Local).AddTicks(3449), "INV-20241110", "Trang bị micro phòng học ngoại ngữ", new DateTime(2024, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 2500000m, 10, 3 },
                    { 12, "AST012", new DateTime(2025, 6, 1, 21, 1, 9, 597, DateTimeKind.Local).AddTicks(3451), "INV-20241201", "Màn hình LED phòng hội trường", new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 12500000m, 6, 5 },
                    { 13, "AST013", new DateTime(2025, 6, 1, 21, 1, 9, 597, DateTimeKind.Local).AddTicks(3459), "INV-20250108", "Bàn giáo viên thay thế định kỳ", new DateTime(2025, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 950000m, 25, 1 },
                    { 14, "AST014", new DateTime(2025, 6, 1, 21, 1, 9, 597, DateTimeKind.Local).AddTicks(3462), "INV-20250205", "Tập vở phát cho học sinh", new DateTime(2025, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 370000m, 40, 2 },
                    { 15, "AST015", new DateTime(2025, 6, 1, 21, 1, 9, 597, DateTimeKind.Local).AddTicks(3483), "INV-20250301", "Máy tính dựng video", new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 30000000m, 2, 6 },
                    { 16, "AST016", new DateTime(2025, 6, 1, 21, 1, 9, 597, DateTimeKind.Local).AddTicks(3485), "INV-20250320", "Ghế học sinh mẫu mới", new DateTime(2025, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1200000m, 30, 3 },
                    { 17, "AST017", new DateTime(2025, 6, 1, 21, 1, 9, 597, DateTimeKind.Local).AddTicks(3488), "INV-20250401", "Loa di động dùng cho sự kiện", new DateTime(2025, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 650000m, 25, 4 },
                    { 18, "AST018", new DateTime(2025, 6, 1, 21, 1, 9, 597, DateTimeKind.Local).AddTicks(3491), "INV-20250415", "Tivi treo tường các phòng học", new DateTime(2025, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 9000000m, 5, 5 },
                    { 19, "AST019", new DateTime(2025, 6, 1, 21, 1, 9, 597, DateTimeKind.Local).AddTicks(3494), "INV-20250501", "Thiết bị học trực tuyến", new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 18000000m, 3, 6 },
                    { 20, "AST020", new DateTime(2025, 6, 1, 21, 1, 9, 597, DateTimeKind.Local).AddTicks(3496), "INV-20250520", "Đồng phục nhân viên mới", new DateTime(2025, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1500000m, 12, 2 }
                });

            migrationBuilder.InsertData(
                table: "AssetItems",
                columns: new[] { "AssetItemID", "CreatedAt", "InventoryID", "LocationID", "Status", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { "AI001", new DateTime(2025, 6, 1, 21, 1, 9, 597, DateTimeKind.Local).AddTicks(3623), 1, 1, "Available", new DateTime(2025, 6, 1, 21, 1, 9, 597, DateTimeKind.Local).AddTicks(3624), "user9" },
                    { "AI002", new DateTime(2025, 6, 1, 21, 1, 9, 597, DateTimeKind.Local).AddTicks(3629), 2, 2, "InUse", new DateTime(2025, 6, 1, 21, 1, 9, 597, DateTimeKind.Local).AddTicks(3629), "user10" },
                    { "AI003", new DateTime(2025, 6, 1, 21, 1, 9, 597, DateTimeKind.Local).AddTicks(3631), 3, 3, "Maintenance", new DateTime(2025, 6, 1, 21, 1, 9, 597, DateTimeKind.Local).AddTicks(3632), "user11" },
                    { "AI004", new DateTime(2025, 6, 1, 21, 1, 9, 597, DateTimeKind.Local).AddTicks(3634), 4, 4, "Available", new DateTime(2025, 6, 1, 21, 1, 9, 597, DateTimeKind.Local).AddTicks(3634), "user12" },
                    { "AI005", new DateTime(2025, 6, 1, 21, 1, 9, 597, DateTimeKind.Local).AddTicks(3636), 5, 1, "InUse", new DateTime(2025, 6, 1, 21, 1, 9, 597, DateTimeKind.Local).AddTicks(3637), "user9" },
                    { "AI006", new DateTime(2025, 6, 1, 21, 1, 9, 597, DateTimeKind.Local).AddTicks(3639), 6, 2, "Available", new DateTime(2025, 6, 1, 21, 1, 9, 597, DateTimeKind.Local).AddTicks(3640), "user10" },
                    { "AI007", new DateTime(2025, 6, 1, 21, 1, 9, 597, DateTimeKind.Local).AddTicks(3642), 7, 3, "Retired", new DateTime(2025, 6, 1, 21, 1, 9, 597, DateTimeKind.Local).AddTicks(3642), "user11" },
                    { "AI008", new DateTime(2025, 6, 1, 21, 1, 9, 597, DateTimeKind.Local).AddTicks(3644), 8, 4, "InUse", new DateTime(2025, 6, 1, 21, 1, 9, 597, DateTimeKind.Local).AddTicks(3644), "user12" },
                    { "AI009", new DateTime(2025, 6, 1, 21, 1, 9, 597, DateTimeKind.Local).AddTicks(3646), 9, 1, "Available", new DateTime(2025, 6, 1, 21, 1, 9, 597, DateTimeKind.Local).AddTicks(3647), "user9" },
                    { "AI010", new DateTime(2025, 6, 1, 21, 1, 9, 597, DateTimeKind.Local).AddTicks(3649), 10, 2, "Maintenance", new DateTime(2025, 6, 1, 21, 1, 9, 597, DateTimeKind.Local).AddTicks(3649), "user10" },
                    { "AI011", new DateTime(2025, 6, 1, 21, 1, 9, 597, DateTimeKind.Local).AddTicks(3651), 11, 3, "InUse", new DateTime(2025, 6, 1, 21, 1, 9, 597, DateTimeKind.Local).AddTicks(3652), "user11" },
                    { "AI012", new DateTime(2025, 6, 1, 21, 1, 9, 597, DateTimeKind.Local).AddTicks(3654), 12, 4, "Available", new DateTime(2025, 6, 1, 21, 1, 9, 597, DateTimeKind.Local).AddTicks(3654), "user12" },
                    { "AI013", new DateTime(2025, 6, 1, 21, 1, 9, 597, DateTimeKind.Local).AddTicks(3656), 13, 1, "InUse", new DateTime(2025, 6, 1, 21, 1, 9, 597, DateTimeKind.Local).AddTicks(3656), "user9" },
                    { "AI014", new DateTime(2025, 6, 1, 21, 1, 9, 597, DateTimeKind.Local).AddTicks(3658), 14, 2, "Retired", new DateTime(2025, 6, 1, 21, 1, 9, 597, DateTimeKind.Local).AddTicks(3659), "user10" },
                    { "AI015", new DateTime(2025, 6, 1, 21, 1, 9, 597, DateTimeKind.Local).AddTicks(3661), 15, 3, "Available", new DateTime(2025, 6, 1, 21, 1, 9, 597, DateTimeKind.Local).AddTicks(3661), "user11" },
                    { "AI016", new DateTime(2025, 6, 1, 21, 1, 9, 597, DateTimeKind.Local).AddTicks(3663), 16, 4, "InUse", new DateTime(2025, 6, 1, 21, 1, 9, 597, DateTimeKind.Local).AddTicks(3663), "user12" },
                    { "AI017", new DateTime(2025, 6, 1, 21, 1, 9, 597, DateTimeKind.Local).AddTicks(3665), 17, 1, "Available", new DateTime(2025, 6, 1, 21, 1, 9, 597, DateTimeKind.Local).AddTicks(3665), "user9" },
                    { "AI018", new DateTime(2025, 6, 1, 21, 1, 9, 597, DateTimeKind.Local).AddTicks(3668), 18, 2, "Maintenance", new DateTime(2025, 6, 1, 21, 1, 9, 597, DateTimeKind.Local).AddTicks(3668), "user10" },
                    { "AI019", new DateTime(2025, 6, 1, 21, 1, 9, 597, DateTimeKind.Local).AddTicks(3710), 19, 3, "InUse", new DateTime(2025, 6, 1, 21, 1, 9, 597, DateTimeKind.Local).AddTicks(3711), "user11" },
                    { "AI020", new DateTime(2025, 6, 1, 21, 1, 9, 597, DateTimeKind.Local).AddTicks(3713), 20, 4, "Available", new DateTime(2025, 6, 1, 21, 1, 9, 597, DateTimeKind.Local).AddTicks(3713), "user12" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AssetIssues_AssetItemID",
                table: "AssetIssues",
                column: "AssetItemID");

            migrationBuilder.CreateIndex(
                name: "IX_AssetIssues_InventoryID_AssetItemID",
                table: "AssetIssues",
                columns: new[] { "InventoryID", "AssetItemID" });

            migrationBuilder.CreateIndex(
                name: "IX_AssetIssues_ReportedBy",
                table: "AssetIssues",
                column: "ReportedBy");

            migrationBuilder.CreateIndex(
                name: "IX_AssetItems_InventoryID_AssetItemID",
                table: "AssetItems",
                columns: new[] { "InventoryID", "AssetItemID" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AssetItems_LocationID",
                table: "AssetItems",
                column: "LocationID");

            migrationBuilder.CreateIndex(
                name: "IX_AssetItems_UpdatedBy",
                table: "AssetItems",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Assets_AssetTypeID",
                table: "Assets",
                column: "AssetTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_DepreciationRecords_AssetItemID",
                table: "DepreciationRecords",
                column: "AssetItemID");

            migrationBuilder.CreateIndex(
                name: "IX_DepreciationRecords_InventoryID_AssetItemID",
                table: "DepreciationRecords",
                columns: new[] { "InventoryID", "AssetItemID" });

            migrationBuilder.CreateIndex(
                name: "IX_InventoryAssets_AssetID",
                table: "InventoryAssets",
                column: "AssetID");

            migrationBuilder.CreateIndex(
                name: "IX_InventoryAssets_SupplierID",
                table: "InventoryAssets",
                column: "SupplierID");

            migrationBuilder.CreateIndex(
                name: "IX_MaintenanceRecords_AssetItemID",
                table: "MaintenanceRecords",
                column: "AssetItemID");

            migrationBuilder.CreateIndex(
                name: "IX_MaintenanceRecords_InventoryID_AssetItemID",
                table: "MaintenanceRecords",
                columns: new[] { "InventoryID", "AssetItemID" });

            migrationBuilder.CreateIndex(
                name: "IX_MaintenanceRecords_IssueID",
                table: "MaintenanceRecords",
                column: "IssueID",
                unique: true,
                filter: "[IssueID] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_MaintenanceRecords_PerformedBy",
                table: "MaintenanceRecords",
                column: "PerformedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Permissions_Name",
                table: "Permissions",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_RolePermissions_PermissionId",
                table: "RolePermissions",
                column: "PermissionId");

            migrationBuilder.CreateIndex(
                name: "IX_RolePermissions_UserRoleId",
                table: "RolePermissions",
                column: "UserRoleId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "DepreciationRecords");

            migrationBuilder.DropTable(
                name: "MaintenanceRecords");

            migrationBuilder.DropTable(
                name: "RolePermissions");

            migrationBuilder.DropTable(
                name: "AssetIssues");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Permissions");

            migrationBuilder.DropTable(
                name: "AssetItems");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "InventoryAssets");

            migrationBuilder.DropTable(
                name: "Locations");

            migrationBuilder.DropTable(
                name: "Assets");

            migrationBuilder.DropTable(
                name: "Suppliers");

            migrationBuilder.DropTable(
                name: "AssetTypes");
        }
    }
}
