using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UserRolePermissionService.Migrations
{
    public partial class _022 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 7, 14, 6, 26, 451, DateTimeKind.Local).AddTicks(3034), new DateTime(2022, 11, 7, 14, 6, 26, 452, DateTimeKind.Local).AddTicks(541) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 7, 14, 6, 26, 452, DateTimeKind.Local).AddTicks(953), new DateTime(2022, 11, 7, 14, 6, 26, 452, DateTimeKind.Local).AddTicks(957) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 7, 14, 6, 26, 452, DateTimeKind.Local).AddTicks(959), new DateTime(2022, 11, 7, 14, 6, 26, 452, DateTimeKind.Local).AddTicks(960) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 5, 23, 6, 43, 129, DateTimeKind.Local).AddTicks(6253), new DateTime(2022, 11, 5, 23, 6, 43, 130, DateTimeKind.Local).AddTicks(4950) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 5, 23, 6, 43, 130, DateTimeKind.Local).AddTicks(5192), new DateTime(2022, 11, 5, 23, 6, 43, 130, DateTimeKind.Local).AddTicks(5195) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 5, 23, 6, 43, 130, DateTimeKind.Local).AddTicks(5196), new DateTime(2022, 11, 5, 23, 6, 43, 130, DateTimeKind.Local).AddTicks(5197) });
        }
    }
}
