using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SimpleCommerce.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddUserAndProductSeedDatas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ProductCategories",
                columns: new[] { "ID", "CreatedDate", "Description", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 11, 1, 20, 48, 36, 312, DateTimeKind.Local).AddTicks(3209), "Electronics product category", false, "Electronics" },
                    { 2, new DateTime(2023, 11, 1, 20, 48, 36, 312, DateTimeKind.Local).AddTicks(3230), "Clothing product category", false, "Clothing" },
                    { 3, new DateTime(2023, 11, 1, 20, 48, 36, 312, DateTimeKind.Local).AddTicks(3231), "Home appliances category", false, "Home Appliances" },
                    { 4, new DateTime(2023, 11, 1, 20, 48, 36, 312, DateTimeKind.Local).AddTicks(3233), "Sports equipment category", false, "Sports Equipment" },
                    { 5, new DateTime(2023, 11, 1, 20, 48, 36, 312, DateTimeKind.Local).AddTicks(3234), "Jewelry category", false, "Jewelry" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "ID", "CreatedDate", "Email", "IsDeleted", "Name", "PasswordHash", "Surname" },
                values: new object[] { 1, new DateTime(2023, 11, 1, 20, 48, 36, 312, DateTimeKind.Local).AddTicks(3591), "john.doe@gmail.com", false, "John", "wEXC+zsV9xjSjrlsyqK58SjE3IasyI327aF25jotP7/98elqf/+cd+KzKDv2PSPBaeSE0/8cPOnOJYtkZ3y1Eg==", "Doe" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ID", "CategoryID", "CreatedDate", "Description", "ImageUrl", "IsDeleted", "Name", "Price", "StockQuantity" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 11, 1, 20, 48, 36, 312, DateTimeKind.Local).AddTicks(3431), "High-end smartphone with advanced features", "https://images.pexels.com/photos/63690/pexels-photo-63690.jpeg", false, "Smartphone", 599.99m, 100 },
                    { 2, 1, new DateTime(2023, 11, 1, 20, 48, 36, 312, DateTimeKind.Local).AddTicks(3438), "Powerful laptop for work and gaming", "https://images.pexels.com/photos/6446709/pexels-photo-6446709.jpeg", false, "Laptop", 1299.99m, 50 },
                    { 3, 1, new DateTime(2023, 11, 1, 20, 48, 36, 312, DateTimeKind.Local).AddTicks(3440), "Noise-canceling headphones for an immersive audio experience", "https://images.pexels.com/photos/3394654/pexels-photo-3394654.jpeg", false, "Headphones", 149.99m, 200 },
                    { 4, 2, new DateTime(2023, 11, 1, 20, 48, 36, 312, DateTimeKind.Local).AddTicks(3441), "Comfortable and stylish cotton t-shirt", "https://images.pexels.com/photos/8532616/pexels-photo-8532616.jpeg", false, "T-Shirt", 19.99m, 300 },
                    { 5, 2, new DateTime(2023, 11, 1, 20, 48, 36, 312, DateTimeKind.Local).AddTicks(3443), "Classic denim jeans for a timeless look", "https://images.pexels.com/photos/4210864/pexels-photo-4210864.jpeg", false, "Jeans", 49.99m, 150 },
                    { 6, 2, new DateTime(2023, 11, 1, 20, 48, 36, 312, DateTimeKind.Local).AddTicks(3446), "Elegant evening dress for special occasions", "https://images.pexels.com/photos/1566435/pexels-photo-1566435.jpeg", false, "Dress", 79.99m, 100 },
                    { 7, 3, new DateTime(2023, 11, 1, 20, 48, 36, 312, DateTimeKind.Local).AddTicks(3448), "Energy-efficient refrigerator with spacious storage", "https://images.pexels.com/photos/6996088/pexels-photo-6996088.jpeg", false, "Refrigerator", 699.99m, 50 },
                    { 8, 3, new DateTime(2023, 11, 1, 20, 48, 36, 312, DateTimeKind.Local).AddTicks(3449), "Front-loading washing machine for clean laundry", "https://images.pexels.com/photos/5591460/pexels-photo-5591460.jpeg", false, "Washing Machine", 499.99m, 75 },
                    { 9, 3, new DateTime(2023, 11, 1, 20, 48, 36, 312, DateTimeKind.Local).AddTicks(3451), "Compact microwave oven for quick heating", "https://images.pexels.com/photos/211761/pexels-photo-211761.jpeg", false, "Microwave Oven", 89.99m, 100 },
                    { 10, 4, new DateTime(2023, 11, 1, 20, 48, 36, 312, DateTimeKind.Local).AddTicks(3454), "High-performance running shoes for athletes", "https://images.pexels.com/photos/2529148/pexels-photo-2529148.jpeg", false, "Running Shoes", 79.99m, 200 },
                    { 11, 4, new DateTime(2023, 11, 1, 20, 48, 36, 312, DateTimeKind.Local).AddTicks(3455), "Non-slip yoga mat for yoga and exercise routines", "https://images.pexels.com/photos/4498606/pexels-photo-4498606.jpeg", false, "Yoga Mat", 29.99m, 150 },
                    { 12, 4, new DateTime(2023, 11, 1, 20, 48, 36, 312, DateTimeKind.Local).AddTicks(3458), "Adjustable dumbbells for strength training", "https://images.pexels.com/photos/39671/physiotherapy-weight-training-dumbbell-exercise-balls-39671.jpeg", false, "Dumbbells", 99.99m, 100 },
                    { 13, 5, new DateTime(2023, 11, 1, 20, 48, 36, 312, DateTimeKind.Local).AddTicks(3459), "Exquisite diamond ring for special occasions", "https://images.pexels.com/photos/1457801/pexels-photo-1457801.jpeg", false, "Diamond Ring", 1499.99m, 50 },
                    { 14, 5, new DateTime(2023, 11, 1, 20, 48, 36, 312, DateTimeKind.Local).AddTicks(3460), "Elegant gold necklace with a timeless design", "https://images.pexels.com/photos/248077/pexels-photo-248077.jpeg", false, "Gold Necklace", 799.99m, 75 },
                    { 15, 5, new DateTime(2023, 11, 1, 20, 48, 36, 312, DateTimeKind.Local).AddTicks(3462), "Stylish silver bracelet for everyday wear", "https://images.pexels.com/photos/12026055/pexels-photo-12026055.jpeg", false, "Silver Bracelet", 149.99m, 100 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "ID",
                keyValue: 5);
        }
    }
}
