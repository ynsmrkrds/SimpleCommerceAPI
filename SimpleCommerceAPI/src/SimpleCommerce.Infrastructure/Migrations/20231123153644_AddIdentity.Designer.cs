﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TransportGlobal.Infrastructure.Context;

#nullable disable

namespace SimpleCommerce.Infrastructure.Migrations
{
    [DbContext(typeof(SimpleCommerceDBContext))]
    [Migration("20231123153644_AddIdentity")]
    partial class AddIdentity
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
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

                    b.HasData(
                        new
                        {
                            Id = "fab4fac1-c546-41de-aebc-a14da6895711",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "c7b013f0-5201-4317-abd8-c211f91b7330",
                            Name = "User",
                            NormalizedName = "USER"
                        });
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

                    b.HasData(
                        new
                        {
                            UserId = "b74ddd14-6340-4840-95c2-db12554843e5",
                            RoleId = "fab4fac1-c546-41de-aebc-a14da6895711"
                        });
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

            modelBuilder.Entity("SimpleCommerce.Domain.Entities.Address.AddressEntity", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("District")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("UserID")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("ID");

                    b.HasIndex("UserID");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("SimpleCommerce.Domain.Entities.Order.OrderEntity", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("AddressID")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("UserID")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("ID");

                    b.HasIndex("AddressID");

                    b.HasIndex("UserID");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("SimpleCommerce.Domain.Entities.Order.OrderItemEntity", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("OrderID")
                        .HasColumnType("int");

                    b.Property<int>("ProductID")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("OrderID");

                    b.HasIndex("ProductID");

                    b.ToTable("OrderItems");
                });

            modelBuilder.Entity("SimpleCommerce.Domain.Entities.Product.ProductCategoryEntity", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("ProductCategories");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            CreatedDate = new DateTime(2023, 11, 23, 18, 36, 44, 361, DateTimeKind.Local).AddTicks(5017),
                            Description = "Electronics product category",
                            IsDeleted = false,
                            Name = "Electronics"
                        },
                        new
                        {
                            ID = 2,
                            CreatedDate = new DateTime(2023, 11, 23, 18, 36, 44, 361, DateTimeKind.Local).AddTicks(5033),
                            Description = "Clothing product category",
                            IsDeleted = false,
                            Name = "Clothing"
                        },
                        new
                        {
                            ID = 3,
                            CreatedDate = new DateTime(2023, 11, 23, 18, 36, 44, 361, DateTimeKind.Local).AddTicks(5034),
                            Description = "Home appliances category",
                            IsDeleted = false,
                            Name = "Home Appliances"
                        },
                        new
                        {
                            ID = 4,
                            CreatedDate = new DateTime(2023, 11, 23, 18, 36, 44, 361, DateTimeKind.Local).AddTicks(5036),
                            Description = "Sports equipment category",
                            IsDeleted = false,
                            Name = "Sports Equipment"
                        },
                        new
                        {
                            ID = 5,
                            CreatedDate = new DateTime(2023, 11, 23, 18, 36, 44, 361, DateTimeKind.Local).AddTicks(5037),
                            Description = "Jewelry category",
                            IsDeleted = false,
                            Name = "Jewelry"
                        });
                });

            modelBuilder.Entity("SimpleCommerce.Domain.Entities.Product.ProductEntity", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("CategoryID")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<int>("StockQuantity")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("CategoryID");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            CategoryID = 1,
                            CreatedDate = new DateTime(2023, 11, 23, 18, 36, 44, 361, DateTimeKind.Local).AddTicks(5202),
                            Description = "High-end smartphone with advanced features",
                            ImageUrl = "https://images.pexels.com/photos/63690/pexels-photo-63690.jpeg",
                            IsDeleted = false,
                            Name = "Smartphone",
                            Price = 599.99m,
                            StockQuantity = 100
                        },
                        new
                        {
                            ID = 2,
                            CategoryID = 1,
                            CreatedDate = new DateTime(2023, 11, 23, 18, 36, 44, 361, DateTimeKind.Local).AddTicks(5211),
                            Description = "Powerful laptop for work and gaming",
                            ImageUrl = "https://images.pexels.com/photos/6446709/pexels-photo-6446709.jpeg",
                            IsDeleted = false,
                            Name = "Laptop",
                            Price = 1299.99m,
                            StockQuantity = 50
                        },
                        new
                        {
                            ID = 3,
                            CategoryID = 1,
                            CreatedDate = new DateTime(2023, 11, 23, 18, 36, 44, 361, DateTimeKind.Local).AddTicks(5212),
                            Description = "Noise-canceling headphones for an immersive audio experience",
                            ImageUrl = "https://images.pexels.com/photos/3394654/pexels-photo-3394654.jpeg",
                            IsDeleted = false,
                            Name = "Headphones",
                            Price = 149.99m,
                            StockQuantity = 200
                        },
                        new
                        {
                            ID = 4,
                            CategoryID = 2,
                            CreatedDate = new DateTime(2023, 11, 23, 18, 36, 44, 361, DateTimeKind.Local).AddTicks(5214),
                            Description = "Comfortable and stylish cotton t-shirt",
                            ImageUrl = "https://images.pexels.com/photos/8532616/pexels-photo-8532616.jpeg",
                            IsDeleted = false,
                            Name = "T-Shirt",
                            Price = 19.99m,
                            StockQuantity = 300
                        },
                        new
                        {
                            ID = 5,
                            CategoryID = 2,
                            CreatedDate = new DateTime(2023, 11, 23, 18, 36, 44, 361, DateTimeKind.Local).AddTicks(5215),
                            Description = "Classic denim jeans for a timeless look",
                            ImageUrl = "https://images.pexels.com/photos/4210864/pexels-photo-4210864.jpeg",
                            IsDeleted = false,
                            Name = "Jeans",
                            Price = 49.99m,
                            StockQuantity = 150
                        },
                        new
                        {
                            ID = 6,
                            CategoryID = 2,
                            CreatedDate = new DateTime(2023, 11, 23, 18, 36, 44, 361, DateTimeKind.Local).AddTicks(5218),
                            Description = "Elegant evening dress for special occasions",
                            ImageUrl = "https://images.pexels.com/photos/1566435/pexels-photo-1566435.jpeg",
                            IsDeleted = false,
                            Name = "Dress",
                            Price = 79.99m,
                            StockQuantity = 100
                        },
                        new
                        {
                            ID = 7,
                            CategoryID = 3,
                            CreatedDate = new DateTime(2023, 11, 23, 18, 36, 44, 361, DateTimeKind.Local).AddTicks(5220),
                            Description = "Energy-efficient refrigerator with spacious storage",
                            ImageUrl = "https://images.pexels.com/photos/6996088/pexels-photo-6996088.jpeg",
                            IsDeleted = false,
                            Name = "Refrigerator",
                            Price = 699.99m,
                            StockQuantity = 50
                        },
                        new
                        {
                            ID = 8,
                            CategoryID = 3,
                            CreatedDate = new DateTime(2023, 11, 23, 18, 36, 44, 361, DateTimeKind.Local).AddTicks(5221),
                            Description = "Front-loading washing machine for clean laundry",
                            ImageUrl = "https://images.pexels.com/photos/5591460/pexels-photo-5591460.jpeg",
                            IsDeleted = false,
                            Name = "Washing Machine",
                            Price = 499.99m,
                            StockQuantity = 75
                        },
                        new
                        {
                            ID = 9,
                            CategoryID = 3,
                            CreatedDate = new DateTime(2023, 11, 23, 18, 36, 44, 361, DateTimeKind.Local).AddTicks(5222),
                            Description = "Compact microwave oven for quick heating",
                            ImageUrl = "https://images.pexels.com/photos/211761/pexels-photo-211761.jpeg",
                            IsDeleted = false,
                            Name = "Microwave Oven",
                            Price = 89.99m,
                            StockQuantity = 100
                        },
                        new
                        {
                            ID = 10,
                            CategoryID = 4,
                            CreatedDate = new DateTime(2023, 11, 23, 18, 36, 44, 361, DateTimeKind.Local).AddTicks(5225),
                            Description = "High-performance running shoes for athletes",
                            ImageUrl = "https://images.pexels.com/photos/2529148/pexels-photo-2529148.jpeg",
                            IsDeleted = false,
                            Name = "Running Shoes",
                            Price = 79.99m,
                            StockQuantity = 200
                        },
                        new
                        {
                            ID = 11,
                            CategoryID = 4,
                            CreatedDate = new DateTime(2023, 11, 23, 18, 36, 44, 361, DateTimeKind.Local).AddTicks(5226),
                            Description = "Non-slip yoga mat for yoga and exercise routines",
                            ImageUrl = "https://images.pexels.com/photos/4498606/pexels-photo-4498606.jpeg",
                            IsDeleted = false,
                            Name = "Yoga Mat",
                            Price = 29.99m,
                            StockQuantity = 150
                        },
                        new
                        {
                            ID = 12,
                            CategoryID = 4,
                            CreatedDate = new DateTime(2023, 11, 23, 18, 36, 44, 361, DateTimeKind.Local).AddTicks(5227),
                            Description = "Adjustable dumbbells for strength training",
                            ImageUrl = "https://images.pexels.com/photos/39671/physiotherapy-weight-training-dumbbell-exercise-balls-39671.jpeg",
                            IsDeleted = false,
                            Name = "Dumbbells",
                            Price = 99.99m,
                            StockQuantity = 100
                        },
                        new
                        {
                            ID = 13,
                            CategoryID = 5,
                            CreatedDate = new DateTime(2023, 11, 23, 18, 36, 44, 361, DateTimeKind.Local).AddTicks(5229),
                            Description = "Exquisite diamond ring for special occasions",
                            ImageUrl = "https://images.pexels.com/photos/1457801/pexels-photo-1457801.jpeg",
                            IsDeleted = false,
                            Name = "Diamond Ring",
                            Price = 1499.99m,
                            StockQuantity = 50
                        },
                        new
                        {
                            ID = 14,
                            CategoryID = 5,
                            CreatedDate = new DateTime(2023, 11, 23, 18, 36, 44, 361, DateTimeKind.Local).AddTicks(5230),
                            Description = "Elegant gold necklace with a timeless design",
                            ImageUrl = "https://images.pexels.com/photos/248077/pexels-photo-248077.jpeg",
                            IsDeleted = false,
                            Name = "Gold Necklace",
                            Price = 799.99m,
                            StockQuantity = 75
                        },
                        new
                        {
                            ID = 15,
                            CategoryID = 5,
                            CreatedDate = new DateTime(2023, 11, 23, 18, 36, 44, 361, DateTimeKind.Local).AddTicks(5231),
                            Description = "Stylish silver bracelet for everyday wear",
                            ImageUrl = "https://images.pexels.com/photos/12026055/pexels-photo-12026055.jpeg",
                            IsDeleted = false,
                            Name = "Silver Bracelet",
                            Price = 149.99m,
                            StockQuantity = 100
                        });
                });

            modelBuilder.Entity("SimpleCommerce.Domain.Entities.User.UserEntity", b =>
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

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

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

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

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

                    b.HasData(
                        new
                        {
                            Id = "b74ddd14-6340-4840-95c2-db12554843e5",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "95209ca3-7e3f-44fe-a6cd-eacf7d1957ae",
                            Email = "admin@xyz.com",
                            EmailConfirmed = false,
                            IsActive = true,
                            LockoutEnabled = false,
                            Name = "Admin",
                            NormalizedEmail = "ADMIN@XYZ.COM",
                            NormalizedUserName = "ADMIN@XYZ.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEIyhLkWyttvWhFDk3Ef6Dxazo+NYihhZJRj126Fj15PJ6GBR3Bw+sck0JRo9qIr9PA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "51997e85-741d-4a4f-ab0c-d088fb70209b",
                            Surname = "ADMIN",
                            TwoFactorEnabled = false,
                            UserName = "admin@xyz.com"
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
                    b.HasOne("SimpleCommerce.Domain.Entities.User.UserEntity", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("SimpleCommerce.Domain.Entities.User.UserEntity", null)
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

                    b.HasOne("SimpleCommerce.Domain.Entities.User.UserEntity", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("SimpleCommerce.Domain.Entities.User.UserEntity", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SimpleCommerce.Domain.Entities.Address.AddressEntity", b =>
                {
                    b.HasOne("SimpleCommerce.Domain.Entities.User.UserEntity", "User")
                        .WithMany("Addresses")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("SimpleCommerce.Domain.Entities.Order.OrderEntity", b =>
                {
                    b.HasOne("SimpleCommerce.Domain.Entities.Address.AddressEntity", "Address")
                        .WithMany("Orders")
                        .HasForeignKey("AddressID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("SimpleCommerce.Domain.Entities.User.UserEntity", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Address");

                    b.Navigation("User");
                });

            modelBuilder.Entity("SimpleCommerce.Domain.Entities.Order.OrderItemEntity", b =>
                {
                    b.HasOne("SimpleCommerce.Domain.Entities.Order.OrderEntity", "Order")
                        .WithMany("Items")
                        .HasForeignKey("OrderID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("SimpleCommerce.Domain.Entities.Product.ProductEntity", "Product")
                        .WithMany("OrderItems")
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("SimpleCommerce.Domain.Entities.Product.ProductEntity", b =>
                {
                    b.HasOne("SimpleCommerce.Domain.Entities.Product.ProductCategoryEntity", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("SimpleCommerce.Domain.Entities.Address.AddressEntity", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("SimpleCommerce.Domain.Entities.Order.OrderEntity", b =>
                {
                    b.Navigation("Items");
                });

            modelBuilder.Entity("SimpleCommerce.Domain.Entities.Product.ProductCategoryEntity", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("SimpleCommerce.Domain.Entities.Product.ProductEntity", b =>
                {
                    b.Navigation("OrderItems");
                });

            modelBuilder.Entity("SimpleCommerce.Domain.Entities.User.UserEntity", b =>
                {
                    b.Navigation("Addresses");

                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}
