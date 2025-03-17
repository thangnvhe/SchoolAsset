﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SchoolAsset.DataLayer.Data;

#nullable disable

namespace SchoolAsset.DataLayer.Migrations
{
    [DbContext(typeof(SchoolAssetDbContext))]
    [Migration("20250317163048_Initial-Database")]
    partial class InitialDatabase
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SchoolAsset.DataLayer.Models.Building", b =>
                {
                    b.Property<int>("BuildingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BuildingId"));

                    b.Property<string>("BuildingName")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime?>("Building_Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Location")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Status")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("BuildingId");

                    b.ToTable("Buildings");

                    b.HasData(
                        new
                        {
                            BuildingId = 1,
                            BuildingName = "Tòa Nhà Alpha",
                            Building_Date = new DateTime(2025, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Location = "Vị trí số 1, ngang mặt đường quốc lộ nhìn vào",
                            Status = "Active"
                        },
                        new
                        {
                            BuildingId = 2,
                            BuildingName = "Tòa Nhà Belta",
                            Building_Date = new DateTime(2025, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Location = "Vị trí số 2, trên bản đồ",
                            Status = "Active"
                        },
                        new
                        {
                            BuildingId = 3,
                            BuildingName = "Tòa Nhà Delta",
                            Building_Date = new DateTime(2025, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Location = "Vị trí số 3, trên bản đồ",
                            Status = "Active"
                        },
                        new
                        {
                            BuildingId = 4,
                            BuildingName = "Tòa Nhà Emanal",
                            Building_Date = new DateTime(2025, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Location = "Vị trí số 4, trên bản đồ",
                            Status = "Active"
                        },
                        new
                        {
                            BuildingId = 5,
                            BuildingName = "Tòa nhà Grammar",
                            Building_Date = new DateTime(2025, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Location = "Vị trí số 5, trên bản đồ",
                            Status = "Active"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
