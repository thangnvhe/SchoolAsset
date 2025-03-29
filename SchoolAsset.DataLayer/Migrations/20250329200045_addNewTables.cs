using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SchoolAsset.DataLayer.Migrations
{
    /// <inheritdoc />
    public partial class addNewTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RoomTypes",
                columns: table => new
                {
                    RoomTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomTypes", x => x.RoomTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Rooms",
                columns: table => new
                {
                    RoomId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoomName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RoomDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RoomTypeId = table.Column<int>(type: "int", nullable: false),
                    BuildingId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rooms", x => x.RoomId);
                    table.ForeignKey(
                        name: "FK_Rooms_Buildings_BuildingId",
                        column: x => x.BuildingId,
                        principalTable: "Buildings",
                        principalColumn: "BuildingId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Rooms_RoomTypes_RoomTypeId",
                        column: x => x.RoomTypeId,
                        principalTable: "RoomTypes",
                        principalColumn: "RoomTypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "RoomTypes",
                columns: new[] { "RoomTypeId", "Name" },
                values: new object[,]
                {
                    { 1, "Phòng Học" },
                    { 2, "Phòng Văn Phòng" },
                    { 3, "Phòng Thí Nghiệm" },
                    { 4, "Phòng Máy" },
                    { 5, "Phòng Thể Dục" },
                    { 6, "Phòng Thư Viện" },
                    { 7, "Phòng Y Tế" }
                });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "RoomId", "BuildingId", "RoomDate", "RoomName", "RoomTypeId", "Status" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2025, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Phòng 101", 1, "Active" },
                    { 2, 2, new DateTime(2025, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Phòng 102", 1, "Active" },
                    { 3, 1, new DateTime(2025, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Phòng 103", 2, "Active" },
                    { 4, 2, new DateTime(2025, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Phòng 104", 2, "Active" },
                    { 5, 2, new DateTime(2025, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Phòng 105", 1, "Active" },
                    { 6, 3, new DateTime(2025, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Phòng 106", 1, "Active" },
                    { 7, 3, new DateTime(2025, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Phòng 107", 3, "Active" },
                    { 8, 3, new DateTime(2025, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Phòng 108", 2, "Active" },
                    { 9, 3, new DateTime(2025, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Phòng 109", 3, "Active" },
                    { 10, 2, new DateTime(2025, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Phòng 110", 6, "Active" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_BuildingId",
                table: "Rooms",
                column: "BuildingId");

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_RoomTypeId",
                table: "Rooms",
                column: "RoomTypeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Rooms");

            migrationBuilder.DropTable(
                name: "RoomTypes");
        }
    }
}
