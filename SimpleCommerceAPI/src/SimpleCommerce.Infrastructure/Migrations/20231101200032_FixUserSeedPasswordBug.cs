using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SimpleCommerce.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class FixUserSeedPasswordBug : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 1, 23, 0, 32, 244, DateTimeKind.Local).AddTicks(397));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 1, 23, 0, 32, 244, DateTimeKind.Local).AddTicks(414));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 1, 23, 0, 32, 244, DateTimeKind.Local).AddTicks(415));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 1, 23, 0, 32, 244, DateTimeKind.Local).AddTicks(417));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 1, 23, 0, 32, 244, DateTimeKind.Local).AddTicks(418));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 1, 23, 0, 32, 244, DateTimeKind.Local).AddTicks(552));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 1, 23, 0, 32, 244, DateTimeKind.Local).AddTicks(559));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 1, 23, 0, 32, 244, DateTimeKind.Local).AddTicks(561));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 1, 23, 0, 32, 244, DateTimeKind.Local).AddTicks(562));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 1, 23, 0, 32, 244, DateTimeKind.Local).AddTicks(563));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 1, 23, 0, 32, 244, DateTimeKind.Local).AddTicks(567));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 1, 23, 0, 32, 244, DateTimeKind.Local).AddTicks(568));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 1, 23, 0, 32, 244, DateTimeKind.Local).AddTicks(570));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 1, 23, 0, 32, 244, DateTimeKind.Local).AddTicks(571));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 1, 23, 0, 32, 244, DateTimeKind.Local).AddTicks(573));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 1, 23, 0, 32, 244, DateTimeKind.Local).AddTicks(575));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 1, 23, 0, 32, 244, DateTimeKind.Local).AddTicks(576));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 1, 23, 0, 32, 244, DateTimeKind.Local).AddTicks(577));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 1, 23, 0, 32, 244, DateTimeKind.Local).AddTicks(579));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 1, 23, 0, 32, 244, DateTimeKind.Local).AddTicks(581));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash" },
                values: new object[] { new DateTime(2023, 11, 1, 23, 0, 32, 244, DateTimeKind.Local).AddTicks(718), "f88kKg9BTfLRX79/OCyi3SkMT+9tp6HUkpNDKb0B1i3wicsu7ibl3Gx1WTiGqQMI9f5IkY4nABU+L/XVNWKg5A==" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "CreatedDate", "PasswordHash" },
                values: new object[] { new DateTime(2023, 11, 1, 22, 36, 41, 654, DateTimeKind.Local).AddTicks(114), "wEXC+zsV9xjSjrlsyqK58SjE3IasyI327aF25jotP7/98elqf/+cd+KzKDv2PSPBaeSE0/8cPOnOJYtkZ3y1Eg==" });
        }
    }
}
