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
    [Migration("20250329200045_addNewTables")]
    partial class addNewTables
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasMaxLength(21)
                        .HasColumnType("nvarchar(21)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasDiscriminator().HasValue("IdentityUser");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

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

            modelBuilder.Entity("SchoolAsset.DataLayer.Models.Room", b =>
                {
                    b.Property<int>("RoomId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RoomId"));

                    b.Property<int>("BuildingId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("RoomDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("RoomName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoomTypeId")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RoomId");

                    b.HasIndex("BuildingId");

                    b.HasIndex("RoomTypeId");

                    b.ToTable("Rooms");

                    b.HasData(
                        new
                        {
                            RoomId = 1,
                            BuildingId = 1,
                            RoomDate = new DateTime(2025, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            RoomName = "Phòng 101",
                            RoomTypeId = 1,
                            Status = "Active"
                        },
                        new
                        {
                            RoomId = 2,
                            BuildingId = 2,
                            RoomDate = new DateTime(2025, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            RoomName = "Phòng 102",
                            RoomTypeId = 1,
                            Status = "Active"
                        },
                        new
                        {
                            RoomId = 3,
                            BuildingId = 1,
                            RoomDate = new DateTime(2025, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            RoomName = "Phòng 103",
                            RoomTypeId = 2,
                            Status = "Active"
                        },
                        new
                        {
                            RoomId = 4,
                            BuildingId = 2,
                            RoomDate = new DateTime(2025, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            RoomName = "Phòng 104",
                            RoomTypeId = 2,
                            Status = "Active"
                        },
                        new
                        {
                            RoomId = 5,
                            BuildingId = 2,
                            RoomDate = new DateTime(2025, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            RoomName = "Phòng 105",
                            RoomTypeId = 1,
                            Status = "Active"
                        },
                        new
                        {
                            RoomId = 6,
                            BuildingId = 3,
                            RoomDate = new DateTime(2025, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            RoomName = "Phòng 106",
                            RoomTypeId = 1,
                            Status = "Active"
                        },
                        new
                        {
                            RoomId = 7,
                            BuildingId = 3,
                            RoomDate = new DateTime(2025, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            RoomName = "Phòng 107",
                            RoomTypeId = 3,
                            Status = "Active"
                        },
                        new
                        {
                            RoomId = 8,
                            BuildingId = 3,
                            RoomDate = new DateTime(2025, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            RoomName = "Phòng 108",
                            RoomTypeId = 2,
                            Status = "Active"
                        },
                        new
                        {
                            RoomId = 9,
                            BuildingId = 3,
                            RoomDate = new DateTime(2025, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            RoomName = "Phòng 109",
                            RoomTypeId = 3,
                            Status = "Active"
                        },
                        new
                        {
                            RoomId = 10,
                            BuildingId = 2,
                            RoomDate = new DateTime(2025, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            RoomName = "Phòng 110",
                            RoomTypeId = 6,
                            Status = "Active"
                        });
                });

            modelBuilder.Entity("SchoolAsset.DataLayer.Models.RoomType", b =>
                {
                    b.Property<int>("RoomTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RoomTypeId"));

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RoomTypeId");

                    b.ToTable("RoomTypes");

                    b.HasData(
                        new
                        {
                            RoomTypeId = 1,
                            Name = "Phòng Học"
                        },
                        new
                        {
                            RoomTypeId = 2,
                            Name = "Phòng Văn Phòng"
                        },
                        new
                        {
                            RoomTypeId = 3,
                            Name = "Phòng Thí Nghiệm"
                        },
                        new
                        {
                            RoomTypeId = 4,
                            Name = "Phòng Máy"
                        },
                        new
                        {
                            RoomTypeId = 5,
                            Name = "Phòng Thể Dục"
                        },
                        new
                        {
                            RoomTypeId = 6,
                            Name = "Phòng Thư Viện"
                        },
                        new
                        {
                            RoomTypeId = 7,
                            Name = "Phòng Y Tế"
                        });
                });

            modelBuilder.Entity("SchoolAsset.DataLayer.Models.ApplicationUser", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostalCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StreetAddress")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("ApplicationUser");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SchoolAsset.DataLayer.Models.Room", b =>
                {
                    b.HasOne("SchoolAsset.DataLayer.Models.Building", "Building")
                        .WithMany("Rooms")
                        .HasForeignKey("BuildingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SchoolAsset.DataLayer.Models.RoomType", "RoomType")
                        .WithMany()
                        .HasForeignKey("RoomTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Building");

                    b.Navigation("RoomType");
                });

            modelBuilder.Entity("SchoolAsset.DataLayer.Models.Building", b =>
                {
                    b.Navigation("Rooms");
                });
#pragma warning restore 612, 618
        }
    }
}
