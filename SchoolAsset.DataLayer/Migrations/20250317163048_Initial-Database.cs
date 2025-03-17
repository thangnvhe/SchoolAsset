using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SchoolAsset.DataLayer.Migrations
{
    /// <inheritdoc />
    public partial class InitialDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Buildings",
                columns: table => new
                {
                    BuildingId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BuildingName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Location = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Status = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Building_Date = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Buildings", x => x.BuildingId);
                });

            migrationBuilder.InsertData(
                table: "Buildings",
                columns: new[] { "BuildingId", "BuildingName", "Building_Date", "Location", "Status" },
                values: new object[,]
                {
                    { 1, "Tòa Nhà Alpha", new DateTime(2025, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vị trí số 1, ngang mặt đường quốc lộ nhìn vào", "Active" },
                    { 2, "Tòa Nhà Belta", new DateTime(2025, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vị trí số 2, trên bản đồ", "Active" },
                    { 3, "Tòa Nhà Delta", new DateTime(2025, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vị trí số 3, trên bản đồ", "Active" },
                    { 4, "Tòa Nhà Emanal", new DateTime(2025, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vị trí số 4, trên bản đồ", "Active" },
                    { 5, "Tòa nhà Grammar", new DateTime(2025, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vị trí số 5, trên bản đồ", "Active" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Buildings");
        }
    }
}
