using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DiseaseService.Migrations
{
    public partial class cause : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Diseases",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 8, 9, 13, 27, 723, DateTimeKind.Utc).AddTicks(7302), new DateTime(2022, 11, 8, 9, 13, 27, 723, DateTimeKind.Utc).AddTicks(7508) });

            migrationBuilder.UpdateData(
                table: "Diseases",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 8, 9, 13, 27, 723, DateTimeKind.Utc).AddTicks(7669), new DateTime(2022, 11, 8, 9, 13, 27, 723, DateTimeKind.Utc).AddTicks(7670) });

            migrationBuilder.UpdateData(
                table: "Symptoms",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 8, 9, 13, 27, 724, DateTimeKind.Utc).AddTicks(7276), new DateTime(2022, 11, 8, 9, 13, 27, 724, DateTimeKind.Utc).AddTicks(7281) });

            migrationBuilder.UpdateData(
                table: "Symptoms",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 8, 9, 13, 27, 724, DateTimeKind.Utc).AddTicks(7283), new DateTime(2022, 11, 8, 9, 13, 27, 724, DateTimeKind.Utc).AddTicks(7284) });

            migrationBuilder.UpdateData(
                table: "Symptoms",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 8, 9, 13, 27, 724, DateTimeKind.Utc).AddTicks(7285), new DateTime(2022, 11, 8, 9, 13, 27, 724, DateTimeKind.Utc).AddTicks(7286) });

            migrationBuilder.UpdateData(
                table: "Symptoms",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 8, 9, 13, 27, 724, DateTimeKind.Utc).AddTicks(7287), new DateTime(2022, 11, 8, 9, 13, 27, 724, DateTimeKind.Utc).AddTicks(7288) });

            migrationBuilder.UpdateData(
                table: "Symptoms",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 8, 9, 13, 27, 724, DateTimeKind.Utc).AddTicks(7289), new DateTime(2022, 11, 8, 9, 13, 27, 724, DateTimeKind.Utc).AddTicks(7290) });

            migrationBuilder.UpdateData(
                table: "Symptoms",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 8, 9, 13, 27, 724, DateTimeKind.Utc).AddTicks(7291), new DateTime(2022, 11, 8, 9, 13, 27, 724, DateTimeKind.Utc).AddTicks(7292) });

            migrationBuilder.UpdateData(
                table: "Symptoms",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 8, 9, 13, 27, 724, DateTimeKind.Utc).AddTicks(7293), new DateTime(2022, 11, 8, 9, 13, 27, 724, DateTimeKind.Utc).AddTicks(7294) });
        }
    }
}
