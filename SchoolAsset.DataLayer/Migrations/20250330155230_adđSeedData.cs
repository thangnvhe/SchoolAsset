using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SchoolAsset.DataLayer.Migrations
{
    /// <inheritdoc />
    public partial class adđSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "RoomTypes",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[,]
                {
                    { 1, "Cơ Sở Vật Chất" },
                    { 2, "Thiết Bị Dạng Dạy" },
                    { 3, "Dụng Cụ Văn Phòng" },
                    { 4, "Thiết Bị Y Tế" },
                    { 5, "Thiết Bị Thể Dục" }
                });

            migrationBuilder.InsertData(
                table: "Assets",
                columns: new[] { "AssetId", "AssetName", "CategoryId", "Description", "ImgUrl", "Price", "PurchaseDate", "RoomId", "Status" },
                values: new object[,]
                {
                    { 1, "Bàn Học", 1, "Bàn học cho học sinh", "https://www.google.com", 1000000m, new DateTime(2025, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Active" },
                    { 2, "Bàn Học", 1, "Bàn học cho học sinh", "https://www.google.com", 1000000m, new DateTime(2025, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Active" },
                    { 3, "Bàn Học", 1, "Bàn học cho học sinh", "https://www.google.com", 1000000m, new DateTime(2025, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Active" },
                    { 4, "Bàn Học", 1, "Bàn học cho học sinh", "https://www.google.com", 1000000m, new DateTime(2025, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Active" },
                    { 5, "Bàn Học", 1, "Bàn học cho học sinh", "https://www.google.com", 1000000m, new DateTime(2025, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Active" },
                    { 6, "Bàn Học", 1, "Bàn học cho học sinh", "https://www.google.com", 1000000m, new DateTime(2025, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Active" },
                    { 7, "Bàn Học", 1, "Bàn học cho học sinh", "https://www.google.com", 1000000m, new DateTime(2025, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "Active" },
                    { 8, "Bàn Học", 1, "Bàn học cho học sinh", "https://www.google.com", 1000000m, new DateTime(2025, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Active" },
                    { 9, "Bàn Học", 1, "Bàn học cho học sinh", "https://www.google.com", 1000000m, new DateTime(2025, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, "Active" },
                    { 10, "Bàn Học", 1, "Bàn học cho học sinh", "https://www.google.com", 1000000m, new DateTime(2025, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, "Active" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "RoomTypes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);
        }
    }
}
