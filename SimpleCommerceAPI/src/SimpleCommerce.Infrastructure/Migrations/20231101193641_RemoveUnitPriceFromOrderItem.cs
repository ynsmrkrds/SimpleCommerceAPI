using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SimpleCommerce.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class RemoveUnitPriceFromOrderItem : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UnitPrice",
                table: "OrderItems");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 1, 22, 36, 41, 653, DateTimeKind.Local).AddTicks(9781));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 1, 22, 36, 41, 653, DateTimeKind.Local).AddTicks(9803));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 1, 22, 36, 41, 653, DateTimeKind.Local).AddTicks(9804));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 1, 22, 36, 41, 653, DateTimeKind.Local).AddTicks(9806));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 1, 22, 36, 41, 653, DateTimeKind.Local).AddTicks(9807));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 1, 22, 36, 41, 653, DateTimeKind.Local).AddTicks(9939));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 1, 22, 36, 41, 653, DateTimeKind.Local).AddTicks(9949));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 1, 22, 36, 41, 653, DateTimeKind.Local).AddTicks(9950));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 1, 22, 36, 41, 653, DateTimeKind.Local).AddTicks(9952));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 1, 22, 36, 41, 653, DateTimeKind.Local).AddTicks(9953));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 1, 22, 36, 41, 653, DateTimeKind.Local).AddTicks(9956));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 1, 22, 36, 41, 653, DateTimeKind.Local).AddTicks(9957));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 1, 22, 36, 41, 653, DateTimeKind.Local).AddTicks(9959));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 1, 22, 36, 41, 653, DateTimeKind.Local).AddTicks(9960));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 1, 22, 36, 41, 653, DateTimeKind.Local).AddTicks(9963));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 1, 22, 36, 41, 653, DateTimeKind.Local).AddTicks(9964));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 1, 22, 36, 41, 653, DateTimeKind.Local).AddTicks(9965));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 1, 22, 36, 41, 653, DateTimeKind.Local).AddTicks(9967));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 1, 22, 36, 41, 653, DateTimeKind.Local).AddTicks(9968));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 1, 22, 36, 41, 653, DateTimeKind.Local).AddTicks(9970));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 1, 22, 36, 41, 654, DateTimeKind.Local).AddTicks(114));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "UnitPrice",
                table: "OrderItems",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 1, 20, 48, 36, 312, DateTimeKind.Local).AddTicks(3209));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 1, 20, 48, 36, 312, DateTimeKind.Local).AddTicks(3230));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 1, 20, 48, 36, 312, DateTimeKind.Local).AddTicks(3231));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 1, 20, 48, 36, 312, DateTimeKind.Local).AddTicks(3233));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 1, 20, 48, 36, 312, DateTimeKind.Local).AddTicks(3234));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 1, 20, 48, 36, 312, DateTimeKind.Local).AddTicks(3431));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 1, 20, 48, 36, 312, DateTimeKind.Local).AddTicks(3438));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 1, 20, 48, 36, 312, DateTimeKind.Local).AddTicks(3440));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 1, 20, 48, 36, 312, DateTimeKind.Local).AddTicks(3441));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 1, 20, 48, 36, 312, DateTimeKind.Local).AddTicks(3443));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 1, 20, 48, 36, 312, DateTimeKind.Local).AddTicks(3446));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 1, 20, 48, 36, 312, DateTimeKind.Local).AddTicks(3448));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 1, 20, 48, 36, 312, DateTimeKind.Local).AddTicks(3449));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 1, 20, 48, 36, 312, DateTimeKind.Local).AddTicks(3451));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 1, 20, 48, 36, 312, DateTimeKind.Local).AddTicks(3454));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 1, 20, 48, 36, 312, DateTimeKind.Local).AddTicks(3455));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 1, 20, 48, 36, 312, DateTimeKind.Local).AddTicks(3458));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 1, 20, 48, 36, 312, DateTimeKind.Local).AddTicks(3459));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 1, 20, 48, 36, 312, DateTimeKind.Local).AddTicks(3460));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 1, 20, 48, 36, 312, DateTimeKind.Local).AddTicks(3462));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 1, 20, 48, 36, 312, DateTimeKind.Local).AddTicks(3591));
        }
    }
}
