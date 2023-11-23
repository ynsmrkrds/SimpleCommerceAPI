using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SimpleCommerce.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddNormalUserSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8efeb46d-a0e8-41e2-9788-265befad08e3", "AQAAAAIAAYagAAAAEC+QWlFEuHtdAjj0kgljyNix6XJHMDsErVeyXfCtjmPq+z17LDYVPw1CHixYR+1dhg==", "5d141bcc-f563-4c27-a32b-53ec95f9d9c5" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "IsActive", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Surname", "TwoFactorEnabled", "UserName" },
                values: new object[] { "e2232222-a4ff-4ba6-bc41-327974fbdf4e", 0, "018990a5-08b2-4158-b0e1-ee7e5964d777", "john.doe@xyz.com", false, true, false, null, "John", "JOHN.DOE@XYZ.COM", "JOHN.DOE@XYZ.COM", "AQAAAAIAAYagAAAAEJZ9CEwKIQXOZ+79Dh8E4881fH6YfrhMVJUi9rhkm7til7LKEeV8TQGfZeEzineiuQ==", null, false, "78ab493c-638d-49bc-8e55-40307138887f", "DOE", false, "john.doe@xyz.com" });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 23, 22, 13, 58, 30, DateTimeKind.Local).AddTicks(2419));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 23, 22, 13, 58, 30, DateTimeKind.Local).AddTicks(2439));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 23, 22, 13, 58, 30, DateTimeKind.Local).AddTicks(2441));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 23, 22, 13, 58, 30, DateTimeKind.Local).AddTicks(2442));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 23, 22, 13, 58, 30, DateTimeKind.Local).AddTicks(2443));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 23, 22, 13, 58, 30, DateTimeKind.Local).AddTicks(2588));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 23, 22, 13, 58, 30, DateTimeKind.Local).AddTicks(2594));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 23, 22, 13, 58, 30, DateTimeKind.Local).AddTicks(2596));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 23, 22, 13, 58, 30, DateTimeKind.Local).AddTicks(2597));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 23, 22, 13, 58, 30, DateTimeKind.Local).AddTicks(2598));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 23, 22, 13, 58, 30, DateTimeKind.Local).AddTicks(2601));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 23, 22, 13, 58, 30, DateTimeKind.Local).AddTicks(2603));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 23, 22, 13, 58, 30, DateTimeKind.Local).AddTicks(2604));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 23, 22, 13, 58, 30, DateTimeKind.Local).AddTicks(2606));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 23, 22, 13, 58, 30, DateTimeKind.Local).AddTicks(2608));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 23, 22, 13, 58, 30, DateTimeKind.Local).AddTicks(2610));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 23, 22, 13, 58, 30, DateTimeKind.Local).AddTicks(2612));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 23, 22, 13, 58, 30, DateTimeKind.Local).AddTicks(2613));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 23, 22, 13, 58, 30, DateTimeKind.Local).AddTicks(2614));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 23, 22, 13, 58, 30, DateTimeKind.Local).AddTicks(2616));

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "c7b013f0-5201-4317-abd8-c211f91b7330", "e2232222-a4ff-4ba6-bc41-327974fbdf4e" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c7b013f0-5201-4317-abd8-c211f91b7330", "e2232222-a4ff-4ba6-bc41-327974fbdf4e" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e2232222-a4ff-4ba6-bc41-327974fbdf4e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "95209ca3-7e3f-44fe-a6cd-eacf7d1957ae", "AQAAAAIAAYagAAAAEIyhLkWyttvWhFDk3Ef6Dxazo+NYihhZJRj126Fj15PJ6GBR3Bw+sck0JRo9qIr9PA==", "51997e85-741d-4a4f-ab0c-d088fb70209b" });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 23, 18, 36, 44, 361, DateTimeKind.Local).AddTicks(5017));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 23, 18, 36, 44, 361, DateTimeKind.Local).AddTicks(5033));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 23, 18, 36, 44, 361, DateTimeKind.Local).AddTicks(5034));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 23, 18, 36, 44, 361, DateTimeKind.Local).AddTicks(5036));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 23, 18, 36, 44, 361, DateTimeKind.Local).AddTicks(5037));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 23, 18, 36, 44, 361, DateTimeKind.Local).AddTicks(5202));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 23, 18, 36, 44, 361, DateTimeKind.Local).AddTicks(5211));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 23, 18, 36, 44, 361, DateTimeKind.Local).AddTicks(5212));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 23, 18, 36, 44, 361, DateTimeKind.Local).AddTicks(5214));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 23, 18, 36, 44, 361, DateTimeKind.Local).AddTicks(5215));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 23, 18, 36, 44, 361, DateTimeKind.Local).AddTicks(5218));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 23, 18, 36, 44, 361, DateTimeKind.Local).AddTicks(5220));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 23, 18, 36, 44, 361, DateTimeKind.Local).AddTicks(5221));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 23, 18, 36, 44, 361, DateTimeKind.Local).AddTicks(5222));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 23, 18, 36, 44, 361, DateTimeKind.Local).AddTicks(5225));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 23, 18, 36, 44, 361, DateTimeKind.Local).AddTicks(5226));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 23, 18, 36, 44, 361, DateTimeKind.Local).AddTicks(5227));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 23, 18, 36, 44, 361, DateTimeKind.Local).AddTicks(5229));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 23, 18, 36, 44, 361, DateTimeKind.Local).AddTicks(5230));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 23, 18, 36, 44, 361, DateTimeKind.Local).AddTicks(5231));
        }
    }
}
