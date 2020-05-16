﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;
using WebShopDB.Models;

namespace WebShopDB.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20191001005822_WebShopDB")]
    partial class WebShopDB
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("WebShopDB.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CategoryName");

                    b.Property<string>("Description");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("WebShopDB.Models.Fan", b =>
                {
                    b.Property<int>("FanID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CategoryID");

                    b.Property<string>("FanImageThubnailUrl");

                    b.Property<string>("FanImageUrl");

                    b.Property<bool>("FanInStock");

                    b.Property<string>("FanLongDescription");

                    b.Property<string>("FanName");

                    b.Property<decimal>("FanPrice");

                    b.Property<string>("FanShortDescription");

                    b.Property<bool>("IsPreferredFan");

                    b.HasKey("FanID");

                    b.HasIndex("CategoryID");

                    b.ToTable("Fan");
                });

            modelBuilder.Entity("WebShopDB.Models.Gpu", b =>
                {
                    b.Property<int>("GpuID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CategoryID");

                    b.Property<string>("GpuImageThubnailUrl");

                    b.Property<string>("GpuImageUrl");

                    b.Property<bool>("GpuInStock");

                    b.Property<string>("GpuLongDescription");

                    b.Property<string>("GpuName");

                    b.Property<decimal>("GpuPrice");

                    b.Property<string>("GpuShortDescription");

                    b.Property<bool>("IsPreferredGpu");

                    b.HasKey("GpuID");

                    b.HasIndex("CategoryID");

                    b.ToTable("Gpu");
                });

            modelBuilder.Entity("WebShopDB.Models.Harddisk", b =>
                {
                    b.Property<int>("HarddiskID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CategoryID");

                    b.Property<string>("HarddiskImageThubnailUrl");

                    b.Property<string>("HarddiskImageUrl");

                    b.Property<bool>("HarddiskInStock");

                    b.Property<string>("HarddiskLongDescription");

                    b.Property<string>("HarddiskName");

                    b.Property<decimal>("HarddiskPrice");

                    b.Property<string>("HarddiskShortDescription");

                    b.Property<bool>("IsPreferredHarddisk");

                    b.HasKey("HarddiskID");

                    b.HasIndex("CategoryID");

                    b.ToTable("Harddisks");
                });

            modelBuilder.Entity("WebShopDB.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CategoryId");

                    b.Property<string>("ImageThumbnailUrl");

                    b.Property<string>("ImageUrl");

                    b.Property<bool>("InStock");

                    b.Property<bool>("IsPreferredProduct");

                    b.Property<string>("LongDescription");

                    b.Property<string>("Name");

                    b.Property<decimal>("Price");

                    b.Property<string>("ShortDescription");

                    b.HasKey("ProductId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("WebShopDB.Models.Motherboard", b =>
                {
                    b.Property<int>("BoardkID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("BoardImageUrl");

                    b.Property<bool>("BoardInStock");

                    b.Property<string>("BoardLongDescription");

                    b.Property<string>("BoardName");

                    b.Property<decimal>("BoardPrice");

                    b.Property<string>("BoardShortDescription");

                    b.Property<int>("CategoryID");

                    b.Property<string>("HarddiskImageThubnailUrl");

                    b.Property<bool>("IsPreferredBoard");

                    b.HasKey("BoardkID");

                    b.HasIndex("CategoryID");

                    b.ToTable("Motherboard");
                });

            modelBuilder.Entity("WebShopDB.Models.Order", b =>
                {
                    b.Property<Guid>("OrderId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AddressLine1");

                    b.Property<string>("AddressLine2");

                    b.Property<string>("City");

                    b.Property<string>("Country");

                    b.Property<string>("Email");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<DateTime>("OrderPlaced");

                    b.Property<decimal>("OrderTotal");

                    b.Property<string>("PhoneNumber");

                    b.Property<string>("State");

                    b.Property<string>("ZipCode");

                    b.HasKey("OrderId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("WebShopDB.Models.OrderDetail", b =>
                {
                    b.Property<Guid>("OrderDetailId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Amount");

                    b.Property<int>("ProductId");

                    b.Property<Guid>("OrderId");

                    b.Property<decimal>("Price");

                    b.HasKey("OrderDetailId");

                    b.HasIndex("ProductId");

                    b.HasIndex("OrderId");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("WebShopDB.Models.PCcase", b =>
                {
                    b.Property<int>("CaseId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CaseImageThumbnailUrl");

                    b.Property<string>("CaseImageUrl");

                    b.Property<bool>("CaseInStock");

                    b.Property<string>("CaseLongDescription");

                    b.Property<string>("CaseName");

                    b.Property<decimal>("CasePrice");

                    b.Property<string>("CaseShortDescription");

                    b.Property<int>("CategoryId");

                    b.Property<bool>("IsPreferredCase");

                    b.HasKey("CaseId");

                    b.HasIndex("CategoryId");

                    b.ToTable("PCcase");
                });

            modelBuilder.Entity("WebShopDB.Models.Powersupply", b =>
                {
                    b.Property<int>("PowerID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CategoryID");

                    b.Property<bool>("IsPreferredPower");

                    b.Property<string>("PowerImageThubnailUrl");

                    b.Property<string>("PowerImageUrl");

                    b.Property<bool>("PowerInStock");

                    b.Property<string>("PowerLongDescription");

                    b.Property<string>("PowerName");

                    b.Property<string>("PowerShortDescription");

                    b.Property<decimal>("PowerdPrice");

                    b.HasKey("PowerID");

                    b.HasIndex("CategoryID");

                    b.ToTable("Powersupply");
                });

            modelBuilder.Entity("WebShopDB.Models.Processor", b =>
                {
                    b.Property<int>("ProID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CategoryID");

                    b.Property<bool>("IsPreferredPro");

                    b.Property<string>("ProImageThubnailUrl");

                    b.Property<string>("ProImageUrl");

                    b.Property<bool>("ProInStock");

                    b.Property<string>("ProLongDescription");

                    b.Property<string>("ProName");

                    b.Property<decimal>("ProPrice");

                    b.Property<string>("ProShortDescription");

                    b.HasKey("ProID");

                    b.HasIndex("CategoryID");

                    b.ToTable("Processor");
                });

            modelBuilder.Entity("WebShopDB.Models.Ram", b =>
                {
                    b.Property<int>("RamID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CategoryID");

                    b.Property<bool>("IsPreferredRam");

                    b.Property<string>("RamImageThubnailUrl");

                    b.Property<string>("RamImageUrl");

                    b.Property<bool>("RamInStock");

                    b.Property<string>("RamLongDescription");

                    b.Property<string>("RamName");

                    b.Property<decimal>("RamPrice");

                    b.Property<string>("RamShortDescription");

                    b.HasKey("RamID");

                    b.HasIndex("CategoryID");

                    b.ToTable("Ram");
                });

            modelBuilder.Entity("WebShopDB.Models.ShoppingCartItem", b =>
                {
                    b.Property<int>("ShoppingCartItemId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Amount");

                    b.Property<int?>("ProductId");

                    b.Property<string>("ShoppingCartId");

                    b.HasKey("ShoppingCartItemId");

                    b.HasIndex("ProductId");

                    b.ToTable("ShoppingCartItems");
                });

            modelBuilder.Entity("WebShopDB.Models.Ssd", b =>
                {
                    b.Property<int>("SsdID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CategoryID");

                    b.Property<bool>("IsPreferredSsd");

                    b.Property<string>("SsdImageThubnailUrl");

                    b.Property<string>("SsdImageUrl");

                    b.Property<bool>("SsdInStock");

                    b.Property<string>("SsdLongDescription");

                    b.Property<string>("SsdName");

                    b.Property<decimal>("SsdPrice");

                    b.Property<string>("SsdShortDescription");

                    b.HasKey("SsdID");

                    b.HasIndex("CategoryID");

                    b.ToTable("Ssd");
                });

            modelBuilder.Entity("WebShopDB.Models.test", b =>
                {
                    b.Property<int>("TestId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("TestName");

                    b.HasKey("TestId");

                    b.ToTable("Tests");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WebShopDB.Models.Fan", b =>
                {
                    b.HasOne("WebShopDB.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WebShopDB.Models.Gpu", b =>
                {
                    b.HasOne("WebShopDB.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WebShopDB.Models.Harddisk", b =>
                {
                    b.HasOne("WebShopDB.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WebShopDB.Models.Product", b =>
                {
                    b.HasOne("WebShopDB.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WebShopDB.Models.Motherboard", b =>
                {
                    b.HasOne("WebShopDB.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WebShopDB.Models.OrderDetail", b =>
                {
                    b.HasOne("WebShopDB.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("WebShopDB.Models.Order", "Order")
                        .WithMany("OrderLines")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WebShopDB.Models.PCcase", b =>
                {
                    b.HasOne("WebShopDB.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WebShopDB.Models.Powersupply", b =>
                {
                    b.HasOne("WebShopDB.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WebShopDB.Models.Processor", b =>
                {
                    b.HasOne("WebShopDB.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WebShopDB.Models.Ram", b =>
                {
                    b.HasOne("WebShopDB.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WebShopDB.Models.ShoppingCartItem", b =>
                {
                    b.HasOne("WebShopDB.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId");
                });

            modelBuilder.Entity("WebShopDB.Models.Ssd", b =>
                {
                    b.HasOne("WebShopDB.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}