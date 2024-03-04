﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StockMarketApi.Configuration;

#nullable disable

namespace StockMarketApi.Migrations
{
    [DbContext(typeof(StockMarketDbContext))]
    [Migration("20240215121103_SeedData")]
    partial class SeedData
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "6dcf18bb-00bc-4c69-a752-9a28b7636cfe",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "9ab8cfa4-8782-40b2-bfab-323b77306fda",
                            Name = "User",
                            NormalizedName = "USER"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("longtext");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("RoleId")
                        .HasColumnType("varchar(255)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Value")
                        .HasColumnType("longtext");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("StockMarketApi.Models.AppUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("longtext");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("longtext");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("longtext");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("StockMarketApi.Models.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("AppUserId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime(6)");

                    b.Property<int?>("StockId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("AppUserId");

                    b.HasIndex("StockId");

                    b.ToTable("Comments");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Content = "Netflix announces the release of its highly anticipated original series.",
                            CreatedOn = new DateTime(2024, 2, 8, 14, 11, 3, 209, DateTimeKind.Local).AddTicks(7719),
                            StockId = 1,
                            Title = "Netflix's New Original Series 1"
                        },
                        new
                        {
                            Id = 2,
                            Content = "Excited to watch this series!",
                            CreatedOn = new DateTime(2024, 2, 9, 14, 11, 3, 209, DateTimeKind.Local).AddTicks(7726),
                            StockId = 1,
                            Title = "Netflix's New Original Series 2"
                        },
                        new
                        {
                            Id = 3,
                            Content = "I've been waiting for this. Can't wait!",
                            CreatedOn = new DateTime(2024, 2, 10, 14, 11, 3, 209, DateTimeKind.Local).AddTicks(7731),
                            StockId = 1,
                            Title = "Netflix's New Original Series 3"
                        },
                        new
                        {
                            Id = 4,
                            Content = "Netflix always delivers quality content.",
                            CreatedOn = new DateTime(2024, 2, 11, 14, 11, 3, 209, DateTimeKind.Local).AddTicks(7734),
                            StockId = 1,
                            Title = "Netflix's New Original Series 4"
                        },
                        new
                        {
                            Id = 5,
                            Content = "Johnson & Johnson unveils a breakthrough drug for treating a rare disease.",
                            CreatedOn = new DateTime(2024, 2, 5, 14, 11, 3, 209, DateTimeKind.Local).AddTicks(7738),
                            StockId = 2,
                            Title = "Johnson & Johnson's Breakthrough Drug"
                        },
                        new
                        {
                            Id = 6,
                            Content = "Procter & Gamble launches a new sustainability initiative to reduce its environmental footprint.",
                            CreatedOn = new DateTime(2024, 2, 10, 14, 11, 3, 209, DateTimeKind.Local).AddTicks(7743),
                            StockId = 3,
                            Title = "Procter & Gamble's Sustainability Initiative"
                        },
                        new
                        {
                            Id = 7,
                            Content = "Great initiative by Procter & Gamble!",
                            CreatedOn = new DateTime(2024, 2, 12, 14, 11, 3, 209, DateTimeKind.Local).AddTicks(7746),
                            StockId = 3,
                            Title = "Procter & Gamble's Sustainability Initiative 2"
                        },
                        new
                        {
                            Id = 8,
                            Content = "It's about time companies focus on sustainability.",
                            CreatedOn = new DateTime(2024, 2, 13, 14, 11, 3, 209, DateTimeKind.Local).AddTicks(7750),
                            StockId = 3,
                            Title = "Procter & Gamble's Sustainability Initiative 3"
                        },
                        new
                        {
                            Id = 9,
                            Content = "Berkshire Hathaway acquires a major stake in a leading technology company.",
                            CreatedOn = new DateTime(2024, 2, 3, 14, 11, 3, 209, DateTimeKind.Local).AddTicks(7753),
                            StockId = 4,
                            Title = "Berkshire Hathaway's Latest Acquisition"
                        },
                        new
                        {
                            Id = 10,
                            Content = "NVIDIA unveils its latest graphics card with groundbreaking performance.",
                            CreatedOn = new DateTime(2024, 2, 12, 14, 11, 3, 209, DateTimeKind.Local).AddTicks(7757),
                            StockId = 5,
                            Title = "NVIDIA's New Graphics Card"
                        },
                        new
                        {
                            Id = 11,
                            Content = "Bank of America releases its quarterly earnings report, exceeding market expectations.",
                            CreatedOn = new DateTime(2024, 2, 7, 14, 11, 3, 209, DateTimeKind.Local).AddTicks(7761),
                            StockId = 6,
                            Title = "Bank of America's Quarterly Earnings Report"
                        });
                });

            modelBuilder.Entity("StockMarketApi.Models.PortofolioUserStock", b =>
                {
                    b.Property<string>("AppUserId")
                        .HasColumnType("varchar(255)");

                    b.Property<int>("StockId")
                        .HasColumnType("int");

                    b.HasKey("AppUserId", "StockId");

                    b.HasIndex("StockId");

                    b.ToTable("Portofolios");
                });

            modelBuilder.Entity("StockMarketApi.Models.Stock", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Industry")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<decimal>("LastDiv")
                        .HasColumnType("decimal(18,2");

                    b.Property<long>("MarketCap")
                        .HasColumnType("bigint");

                    b.Property<decimal>("Purchase")
                        .HasColumnType("decimal(18,2");

                    b.Property<string>("Symbol")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Stocks");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CompanyName = "Netflix Inc.",
                            Industry = "Entertainment",
                            LastDiv = 0.00m,
                            MarketCap = 250000000000L,
                            Purchase = 600.00m,
                            Symbol = "NFLX"
                        },
                        new
                        {
                            Id = 2,
                            CompanyName = "Johnson & Johnson",
                            Industry = "Pharmaceutical",
                            LastDiv = 4.04m,
                            MarketCap = 430000000000L,
                            Purchase = 150.00m,
                            Symbol = "JNJ"
                        },
                        new
                        {
                            Id = 3,
                            CompanyName = "Procter & Gamble Co.",
                            Industry = "Consumer Goods",
                            LastDiv = 3.20m,
                            MarketCap = 340000000000L,
                            Purchase = 140.00m,
                            Symbol = "PG"
                        },
                        new
                        {
                            Id = 4,
                            CompanyName = "Berkshire Hathaway Inc.",
                            Industry = "Conglomerate",
                            LastDiv = 0.00m,
                            MarketCap = 660000000000L,
                            Purchase = 420000.00m,
                            Symbol = "BRK-A"
                        },
                        new
                        {
                            Id = 5,
                            CompanyName = "NVIDIA Corporation",
                            Industry = "Technology",
                            LastDiv = 0.64m,
                            MarketCap = 900000000000L,
                            Purchase = 700.00m,
                            Symbol = "NVDA"
                        },
                        new
                        {
                            Id = 6,
                            CompanyName = "Bank of America Corp.",
                            Industry = "Finance",
                            LastDiv = 2.24m,
                            MarketCap = 380000000000L,
                            Purchase = 40.00m,
                            Symbol = "BAC"
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
                    b.HasOne("StockMarketApi.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("StockMarketApi.Models.AppUser", null)
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

                    b.HasOne("StockMarketApi.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("StockMarketApi.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("StockMarketApi.Models.Comment", b =>
                {
                    b.HasOne("StockMarketApi.Models.AppUser", "AppUser")
                        .WithMany()
                        .HasForeignKey("AppUserId");

                    b.HasOne("StockMarketApi.Models.Stock", "Stock")
                        .WithMany("Comments")
                        .HasForeignKey("StockId");

                    b.Navigation("AppUser");

                    b.Navigation("Stock");
                });

            modelBuilder.Entity("StockMarketApi.Models.PortofolioUserStock", b =>
                {
                    b.HasOne("StockMarketApi.Models.AppUser", "AppUser")
                        .WithMany("Portofolios")
                        .HasForeignKey("AppUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StockMarketApi.Models.Stock", "Stock")
                        .WithMany("Portofolios")
                        .HasForeignKey("StockId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AppUser");

                    b.Navigation("Stock");
                });

            modelBuilder.Entity("StockMarketApi.Models.AppUser", b =>
                {
                    b.Navigation("Portofolios");
                });

            modelBuilder.Entity("StockMarketApi.Models.Stock", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("Portofolios");
                });
#pragma warning restore 612, 618
        }
    }
}
