using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DiseaseService.Migrations
{
    public partial class cause1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Causes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Diseases",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 8, 10, 16, 34, 289, DateTimeKind.Utc).AddTicks(3391), new DateTime(2022, 11, 8, 10, 16, 34, 289, DateTimeKind.Utc).AddTicks(3599) });

            migrationBuilder.UpdateData(
                table: "Diseases",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 8, 10, 16, 34, 289, DateTimeKind.Utc).AddTicks(3770), new DateTime(2022, 11, 8, 10, 16, 34, 289, DateTimeKind.Utc).AddTicks(3771) });

            migrationBuilder.UpdateData(
                table: "Symptoms",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 8, 10, 16, 34, 290, DateTimeKind.Utc).AddTicks(3582), new DateTime(2022, 11, 8, 10, 16, 34, 290, DateTimeKind.Utc).AddTicks(3588) });

            migrationBuilder.UpdateData(
                table: "Symptoms",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 8, 10, 16, 34, 290, DateTimeKind.Utc).AddTicks(3590), new DateTime(2022, 11, 8, 10, 16, 34, 290, DateTimeKind.Utc).AddTicks(3591) });

            migrationBuilder.UpdateData(
                table: "Symptoms",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 8, 10, 16, 34, 290, DateTimeKind.Utc).AddTicks(3593), new DateTime(2022, 11, 8, 10, 16, 34, 290, DateTimeKind.Utc).AddTicks(3593) });

            migrationBuilder.UpdateData(
                table: "Symptoms",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 8, 10, 16, 34, 290, DateTimeKind.Utc).AddTicks(3595), new DateTime(2022, 11, 8, 10, 16, 34, 290, DateTimeKind.Utc).AddTicks(3596) });

            migrationBuilder.UpdateData(
                table: "Symptoms",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 8, 10, 16, 34, 290, DateTimeKind.Utc).AddTicks(3597), new DateTime(2022, 11, 8, 10, 16, 34, 290, DateTimeKind.Utc).AddTicks(3598) });

            migrationBuilder.UpdateData(
                table: "Symptoms",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 8, 10, 16, 34, 290, DateTimeKind.Utc).AddTicks(3599), new DateTime(2022, 11, 8, 10, 16, 34, 290, DateTimeKind.Utc).AddTicks(3600) });

            migrationBuilder.UpdateData(
                table: "Symptoms",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 8, 10, 16, 34, 290, DateTimeKind.Utc).AddTicks(3601), new DateTime(2022, 11, 8, 10, 16, 34, 290, DateTimeKind.Utc).AddTicks(3602) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "Causes");

            migrationBuilder.UpdateData(
                table: "Diseases",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 8, 10, 14, 26, 867, DateTimeKind.Utc).AddTicks(9737), new DateTime(2022, 11, 8, 10, 14, 26, 867, DateTimeKind.Utc).AddTicks(9950) });

            migrationBuilder.UpdateData(
                table: "Diseases",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 8, 10, 14, 26, 868, DateTimeKind.Utc).AddTicks(111), new DateTime(2022, 11, 8, 10, 14, 26, 868, DateTimeKind.Utc).AddTicks(112) });

            migrationBuilder.UpdateData(
                table: "Symptoms",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 8, 10, 14, 26, 869, DateTimeKind.Utc).AddTicks(725), new DateTime(2022, 11, 8, 10, 14, 26, 869, DateTimeKind.Utc).AddTicks(743) });

            migrationBuilder.UpdateData(
                table: "Symptoms",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 8, 10, 14, 26, 869, DateTimeKind.Utc).AddTicks(745), new DateTime(2022, 11, 8, 10, 14, 26, 869, DateTimeKind.Utc).AddTicks(746) });

            migrationBuilder.UpdateData(
                table: "Symptoms",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 8, 10, 14, 26, 869, DateTimeKind.Utc).AddTicks(747), new DateTime(2022, 11, 8, 10, 14, 26, 869, DateTimeKind.Utc).AddTicks(748) });

            migrationBuilder.UpdateData(
                table: "Symptoms",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 8, 10, 14, 26, 869, DateTimeKind.Utc).AddTicks(750), new DateTime(2022, 11, 8, 10, 14, 26, 869, DateTimeKind.Utc).AddTicks(750) });

            migrationBuilder.UpdateData(
                table: "Symptoms",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 8, 10, 14, 26, 869, DateTimeKind.Utc).AddTicks(752), new DateTime(2022, 11, 8, 10, 14, 26, 869, DateTimeKind.Utc).AddTicks(753) });

            migrationBuilder.UpdateData(
                table: "Symptoms",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 8, 10, 14, 26, 869, DateTimeKind.Utc).AddTicks(754), new DateTime(2022, 11, 8, 10, 14, 26, 869, DateTimeKind.Utc).AddTicks(755) });

            migrationBuilder.UpdateData(
                table: "Symptoms",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 8, 10, 14, 26, 869, DateTimeKind.Utc).AddTicks(756), new DateTime(2022, 11, 8, 10, 14, 26, 869, DateTimeKind.Utc).AddTicks(757) });
        }
    }
}
