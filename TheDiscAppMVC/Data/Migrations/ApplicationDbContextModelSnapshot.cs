﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TheDiscAppMVC.Data;

#nullable disable

namespace TheDiscAppMVC.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

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

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

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
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

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
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

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
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("TheDiscAppMVC.Data.Collection", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("DiscId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PlayerId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Collections");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DiscId = 2,
                            Name = "Paul's Bag",
                            PlayerId = 1
                        },
                        new
                        {
                            Id = 2,
                            DiscId = 1,
                            Name = "Calvin's Bag",
                            PlayerId = 3
                        },
                        new
                        {
                            Id = 3,
                            DiscId = 3,
                            Name = "Eagle's Bag",
                            PlayerId = 4
                        },
                        new
                        {
                            Id = 4,
                            DiscId = 4,
                            Name = "Ricky's Bag",
                            PlayerId = 2
                        },
                        new
                        {
                            Id = 5,
                            DiscId = 5,
                            Name = "James' Bag",
                            PlayerId = 5
                        });
                });

            modelBuilder.Entity("TheDiscAppMVC.Data.Disc", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Brand")
                        .HasColumnType("int");

                    b.Property<int?>("CollectionId")
                        .HasColumnType("int");

                    b.Property<int>("DiscType")
                        .HasColumnType("int");

                    b.Property<int>("Fade")
                        .HasColumnType("int");

                    b.Property<int>("Glide")
                        .HasColumnType("int");

                    b.Property<double?>("Height")
                        .HasColumnType("float");

                    b.Property<double?>("InnerDiameter")
                        .HasColumnType("float");

                    b.Property<double?>("MaxWeight")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("OuterDiameter")
                        .HasColumnType("float");

                    b.Property<string>("Plastic")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("RimConfiguration")
                        .HasColumnType("float");

                    b.Property<double?>("RimDepth")
                        .HasColumnType("float");

                    b.Property<double?>("RimWidth")
                        .HasColumnType("float");

                    b.Property<int>("Speed")
                        .HasColumnType("int");

                    b.Property<int>("Stability")
                        .HasColumnType("int");

                    b.Property<int>("Turn")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CollectionId");

                    b.ToTable("Discs");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Brand = 47,
                            DiscType = 0,
                            Fade = 6,
                            Glide = 9,
                            Height = 1.3999999999999999,
                            InnerDiameter = 16.699999999999999,
                            MaxWeight = 176.0,
                            Name = "Destroyer",
                            OuterDiameter = 21.100000000000001,
                            Plastic = "Champion",
                            RimConfiguration = 30.5,
                            RimDepth = 5.6900000000000004,
                            RimWidth = 2.2000000000000002,
                            Speed = 23,
                            Stability = 1,
                            Turn = 4
                        },
                        new
                        {
                            Id = 2,
                            Brand = 21,
                            DiscType = 2,
                            Fade = 2,
                            Glide = 7,
                            Height = 1.8999999999999999,
                            InnerDiameter = 19.300000000000001,
                            MaxWeight = 180.0,
                            Name = "Buzzz",
                            OuterDiameter = 21.699999999999999,
                            Plastic = "Big Z",
                            RimConfiguration = 44.0,
                            RimDepth = 5.9900000000000002,
                            RimWidth = 1.2,
                            Speed = 9,
                            Stability = 2,
                            Turn = 4
                        },
                        new
                        {
                            Id = 3,
                            Brand = 20,
                            DiscType = 2,
                            Fade = 4,
                            Glide = 9,
                            Height = 1.8999999999999999,
                            InnerDiameter = 19.0,
                            MaxWeight = 180.0,
                            Name = "MD3",
                            OuterDiameter = 21.800000000000001,
                            Plastic = "C-Line",
                            RimConfiguration = 44.5,
                            RimDepth = 5.96,
                            RimWidth = 1.3999999999999999,
                            Speed = 9,
                            Stability = 1,
                            Turn = 2
                        },
                        new
                        {
                            Id = 4,
                            Brand = 25,
                            DiscType = 2,
                            Fade = 2,
                            Glide = 9,
                            Height = 1.7,
                            InnerDiameter = 18.699999999999999,
                            MaxWeight = 180.0,
                            Name = "Truth",
                            OuterDiameter = 21.699999999999999,
                            Plastic = "Lucid",
                            RimConfiguration = 41.5,
                            RimDepth = 5.5300000000000002,
                            RimWidth = 1.5,
                            Speed = 9,
                            Stability = 2,
                            Turn = 4
                        },
                        new
                        {
                            Id = 5,
                            Brand = 62,
                            DiscType = 0,
                            Fade = 4,
                            Glide = 9,
                            Height = 1.7,
                            InnerDiameter = 16.800000000000001,
                            MaxWeight = 176.0,
                            Name = "Zenith",
                            OuterDiameter = 21.199999999999999,
                            Plastic = "Neutron",
                            RimConfiguration = 27.0,
                            RimDepth = 5.1900000000000004,
                            RimWidth = 2.2000000000000002,
                            Speed = 21,
                            Stability = 1,
                            Turn = 3
                        });
                });

            modelBuilder.Entity("TheDiscAppMVC.Data.Player", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("CollectionId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PdgaNumber")
                        .HasColumnType("int");

                    b.Property<int?>("PdgaRating")
                        .HasColumnType("int");

                    b.Property<int>("TeamId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CollectionId");

                    b.HasIndex("TeamId");

                    b.ToTable("Players");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Paul McBeth",
                            PdgaNumber = 27523,
                            PdgaRating = 1055,
                            TeamId = 2
                        },
                        new
                        {
                            Id = 2,
                            Name = "Ricky Wysocki",
                            PdgaNumber = 38008,
                            PdgaRating = 1049,
                            TeamId = 4
                        },
                        new
                        {
                            Id = 3,
                            Name = "Calvin Heimburg",
                            PdgaNumber = 45971,
                            PdgaRating = 1039,
                            TeamId = 1
                        },
                        new
                        {
                            Id = 4,
                            Name = "Eagle McMahon",
                            PdgaNumber = 37817,
                            PdgaRating = 1045,
                            TeamId = 5
                        },
                        new
                        {
                            Id = 5,
                            Name = "James Conrad",
                            PdgaNumber = 17295,
                            PdgaRating = 1035,
                            TeamId = 3
                        });
                });

            modelBuilder.Entity("TheDiscAppMVC.Data.Team", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Teams");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Innova"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Discraft"
                        },
                        new
                        {
                            Id = 3,
                            Name = "MVP Disc Sports"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Dynamic Discs"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Discmania"
                        });
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

            modelBuilder.Entity("TheDiscAppMVC.Data.Disc", b =>
                {
                    b.HasOne("TheDiscAppMVC.Data.Collection", null)
                        .WithMany("Discs")
                        .HasForeignKey("CollectionId");
                });

            modelBuilder.Entity("TheDiscAppMVC.Data.Player", b =>
                {
                    b.HasOne("TheDiscAppMVC.Data.Collection", null)
                        .WithMany("Players")
                        .HasForeignKey("CollectionId");

                    b.HasOne("TheDiscAppMVC.Data.Team", "Team")
                        .WithMany("Players")
                        .HasForeignKey("TeamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Team");
                });

            modelBuilder.Entity("TheDiscAppMVC.Data.Collection", b =>
                {
                    b.Navigation("Discs");

                    b.Navigation("Players");
                });

            modelBuilder.Entity("TheDiscAppMVC.Data.Team", b =>
                {
                    b.Navigation("Players");
                });
#pragma warning restore 612, 618
        }
    }
}
