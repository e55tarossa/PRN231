using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DiseaseService.Migrations
{
    public partial class pes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Causes",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Causes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Diseases",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(191)", maxLength: 191, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Diseases", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pesticides",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pesticides", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PreventativeMeasures",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PreventativeMeasures", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Symptoms",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Symptoms", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DiseasesHasCauses",
                columns: table => new
                {
                    DiseaseId = table.Column<long>(type: "bigint", nullable: false),
                    CauseId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiseasesHasCauses", x => new { x.DiseaseId, x.CauseId });
                    table.ForeignKey(
                        name: "FK_DiseasesHasCauses_Causes_CauseId",
                        column: x => x.CauseId,
                        principalTable: "Causes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DiseasesHasCauses_Diseases_DiseaseId",
                        column: x => x.DiseaseId,
                        principalTable: "Diseases",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DiseasesNeedsPesticides",
                columns: table => new
                {
                    DiseaseId = table.Column<long>(type: "bigint", nullable: false),
                    PesticideId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiseasesNeedsPesticides", x => new { x.DiseaseId, x.PesticideId });
                    table.ForeignKey(
                        name: "FK_DiseasesNeedsPesticides_Diseases_DiseaseId",
                        column: x => x.DiseaseId,
                        principalTable: "Diseases",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DiseasesNeedsPesticides_Pesticides_PesticideId",
                        column: x => x.PesticideId,
                        principalTable: "Pesticides",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DiseasesNeedsMeasures",
                columns: table => new
                {
                    DiseaseId = table.Column<long>(type: "bigint", nullable: false),
                    PreventativeMeasureId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiseasesNeedsMeasures", x => new { x.DiseaseId, x.PreventativeMeasureId });
                    table.ForeignKey(
                        name: "FK_DiseasesNeedsMeasures_Diseases_DiseaseId",
                        column: x => x.DiseaseId,
                        principalTable: "Diseases",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DiseasesNeedsMeasures_PreventativeMeasures_PreventativeMeasureId",
                        column: x => x.PreventativeMeasureId,
                        principalTable: "PreventativeMeasures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DiseasesHasSymptoms",
                columns: table => new
                {
                    DiseaseId = table.Column<long>(type: "bigint", nullable: false),
                    SymptomId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiseasesHasSymptoms", x => new { x.DiseaseId, x.SymptomId });
                    table.ForeignKey(
                        name: "FK_DiseasesHasSymptoms_Diseases_DiseaseId",
                        column: x => x.DiseaseId,
                        principalTable: "Diseases",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DiseasesHasSymptoms_Symptoms_SymptomId",
                        column: x => x.SymptomId,
                        principalTable: "Symptoms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Diseases",
                columns: new[] { "Id", "CreatedAt", "Description", "Image", "Name", "Status", "UpdatedAt" },
                values: new object[,]
                {
                    { 1L, new DateTime(2022, 11, 8, 9, 13, 27, 723, DateTimeKind.Utc).AddTicks(7302), "Powdery mildew is one of the major strawberry diseases that attacks all parts of the plant, but is usually first seen on the older leaves. As this fungal disease can overwinter on dead tissue from previous seasons, sanitation is an important part of pre-season management. The common name \"powdery mildew\" is also found in other crop groups, but those are different fungi that cannot infect strawberries (e.g. powdery mildew in strawberries is different from the powdery mildew in raspberries). Day neutral strawberry varieties can be harder hit than June bearing varieties, as they have a longer season.", "", "Powdery Mildew", true, new DateTime(2022, 11, 8, 9, 13, 27, 723, DateTimeKind.Utc).AddTicks(7508) },
                    { 2L, new DateTime(2022, 11, 8, 9, 13, 27, 723, DateTimeKind.Utc).AddTicks(7669), "Common leaf spot of strawberry (also known as Mycosphaerella leaf spot, Ramularia leaf spot, strawberry leaf spot, bird’s-eye spot, gray spotness, and white spot) is a common fungal leaf disease that affects both wild and cultivated strawberries throughout the world.  Common leaf spot was once the most economically important strawberry disease, but the use of resistant strawberry varieties/cultivars and improvements in methods for growing strawberries have been effective in managing the disease and reducing its impact.  Today, the disease is often a cosmetic problem and typically has little impact on yield or fruit quality.", "", "Leaf Spot", true, new DateTime(2022, 11, 8, 9, 13, 27, 723, DateTimeKind.Utc).AddTicks(7670) }
                });

            migrationBuilder.InsertData(
                table: "Symptoms",
                columns: new[] { "Id", "CreatedAt", "Description", "Image", "Status", "Title", "UpdatedAt" },
                values: new object[,]
                {
                    { 1L, new DateTime(2022, 11, 8, 9, 13, 27, 724, DateTimeKind.Utc).AddTicks(7276), "Leaves infected with powdery mildew initially have small, white powdery colonies on the undersides of leaves. These colonies enlarge to cover the entire lower leaf surface, causing the edges of the leaves to roll up", null, true, "White powdery colonies", new DateTime(2022, 11, 8, 9, 13, 27, 724, DateTimeKind.Utc).AddTicks(7281) },
                    { 2L, new DateTime(2022, 11, 8, 9, 13, 27, 724, DateTimeKind.Utc).AddTicks(7283), "Purple reddish blotches appear on the upper and lower surface of leaves.", null, true, "Purple reddish blotches", new DateTime(2022, 11, 8, 9, 13, 27, 724, DateTimeKind.Utc).AddTicks(7284) },
                    { 3L, new DateTime(2022, 11, 8, 9, 13, 27, 724, DateTimeKind.Utc).AddTicks(7285), "Infected flowers produce deformed fruit or no fruit at all. Severely infected flowers may be completely covered by mycelium and killed.", null, true, "Infected flowers", new DateTime(2022, 11, 8, 9, 13, 27, 724, DateTimeKind.Utc).AddTicks(7286) },
                    { 4L, new DateTime(2022, 11, 8, 9, 13, 27, 724, DateTimeKind.Utc).AddTicks(7287), "Infected immature fruits become hardened and desiccated", null, true, "Infected immature fruits", new DateTime(2022, 11, 8, 9, 13, 27, 724, DateTimeKind.Utc).AddTicks(7288) },
                    { 5L, new DateTime(2022, 11, 8, 9, 13, 27, 724, DateTimeKind.Utc).AddTicks(7289), "Infected mature fruits become seedy in appearance and support spore-producing colonies that look powdery and white.", null, true, "Infected mature fruits", new DateTime(2022, 11, 8, 9, 13, 27, 724, DateTimeKind.Utc).AddTicks(7290) },
                    { 6L, new DateTime(2022, 11, 8, 9, 13, 27, 724, DateTimeKind.Utc).AddTicks(7291), "Small and circular leaf spots with light to tan centers and purplish borders.Lesions usually start on the upper leaf surface as small, deep purple, round to irregularly shaped necrotic spots, which can grow to 1–2 mm in diameter", null, true, "Leaves", new DateTime(2022, 11, 8, 9, 13, 27, 724, DateTimeKind.Utc).AddTicks(7292) },
                    { 7L, new DateTime(2022, 11, 8, 9, 13, 27, 724, DateTimeKind.Utc).AddTicks(7293), "Spots remain light brown, whereas on older leaves the center changes from tan or brown to gray or white, and the necrotic center is surrounded by reddish-purple to rusty-brown borders. Lesions occur less frequently on the underside of the leaves, and the color is not as vivid. Intense spotting may lead to death of the infected leaves.", null, true, "Young leaves", new DateTime(2022, 11, 8, 9, 13, 27, 724, DateTimeKind.Utc).AddTicks(7294) }
                });

            migrationBuilder.InsertData(
                table: "DiseasesHasSymptoms",
                columns: new[] { "DiseaseId", "SymptomId" },
                values: new object[,]
                {
                    { 1L, 1L },
                    { 1L, 2L },
                    { 1L, 3L },
                    { 1L, 4L },
                    { 1L, 5L },
                    { 2L, 6L },
                    { 2L, 7L }
                });

            migrationBuilder.CreateIndex(
                name: "IX_DiseasesHasCauses_CauseId",
                table: "DiseasesHasCauses",
                column: "CauseId");

            migrationBuilder.CreateIndex(
                name: "IX_DiseasesHasSymptoms_SymptomId",
                table: "DiseasesHasSymptoms",
                column: "SymptomId");

            migrationBuilder.CreateIndex(
                name: "IX_DiseasesNeedsMeasures_PreventativeMeasureId",
                table: "DiseasesNeedsMeasures",
                column: "PreventativeMeasureId");

            migrationBuilder.CreateIndex(
                name: "IX_DiseasesNeedsPesticides_PesticideId",
                table: "DiseasesNeedsPesticides",
                column: "PesticideId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DiseasesHasCauses");

            migrationBuilder.DropTable(
                name: "DiseasesHasSymptoms");

            migrationBuilder.DropTable(
                name: "DiseasesNeedsMeasures");

            migrationBuilder.DropTable(
                name: "DiseasesNeedsPesticides");

            migrationBuilder.DropTable(
                name: "Causes");

            migrationBuilder.DropTable(
                name: "Symptoms");

            migrationBuilder.DropTable(
                name: "PreventativeMeasures");

            migrationBuilder.DropTable(
                name: "Diseases");

            migrationBuilder.DropTable(
                name: "Pesticides");
        }
    }
}
