﻿// <auto-generated />
using System;
using DiseaseService.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DiseaseService.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20221108101634_cause1")]
    partial class cause1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DiseaseService.Models.Cause", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(2000)
                        .HasColumnType("nvarchar(2000)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Causes");
                });

            modelBuilder.Entity("DiseaseService.Models.Disease", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasMaxLength(2000)
                        .HasColumnType("nvarchar(2000)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(191)
                        .HasColumnType("nvarchar(191)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Diseases");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            CreatedAt = new DateTime(2022, 11, 8, 10, 16, 34, 289, DateTimeKind.Utc).AddTicks(3391),
                            Description = "Powdery mildew is one of the major strawberry diseases that attacks all parts of the plant, but is usually first seen on the older leaves. As this fungal disease can overwinter on dead tissue from previous seasons, sanitation is an important part of pre-season management. The common name \"powdery mildew\" is also found in other crop groups, but those are different fungi that cannot infect strawberries (e.g. powdery mildew in strawberries is different from the powdery mildew in raspberries). Day neutral strawberry varieties can be harder hit than June bearing varieties, as they have a longer season.",
                            Image = "",
                            Name = "Powdery Mildew",
                            Status = true,
                            UpdatedAt = new DateTime(2022, 11, 8, 10, 16, 34, 289, DateTimeKind.Utc).AddTicks(3599)
                        },
                        new
                        {
                            Id = 2L,
                            CreatedAt = new DateTime(2022, 11, 8, 10, 16, 34, 289, DateTimeKind.Utc).AddTicks(3770),
                            Description = "Common leaf spot of strawberry (also known as Mycosphaerella leaf spot, Ramularia leaf spot, strawberry leaf spot, bird’s-eye spot, gray spotness, and white spot) is a common fungal leaf disease that affects both wild and cultivated strawberries throughout the world.  Common leaf spot was once the most economically important strawberry disease, but the use of resistant strawberry varieties/cultivars and improvements in methods for growing strawberries have been effective in managing the disease and reducing its impact.  Today, the disease is often a cosmetic problem and typically has little impact on yield or fruit quality.",
                            Image = "",
                            Name = "Leaf Spot",
                            Status = true,
                            UpdatedAt = new DateTime(2022, 11, 8, 10, 16, 34, 289, DateTimeKind.Utc).AddTicks(3771)
                        });
                });

            modelBuilder.Entity("DiseaseService.Models.DiseasesHasCauses", b =>
                {
                    b.Property<long>("DiseaseId")
                        .HasColumnType("bigint");

                    b.Property<long>("CauseId")
                        .HasColumnType("bigint");

                    b.HasKey("DiseaseId", "CauseId");

                    b.HasIndex("CauseId");

                    b.ToTable("DiseasesHasCauses");
                });

            modelBuilder.Entity("DiseaseService.Models.DiseasesHasSymptoms", b =>
                {
                    b.Property<long>("DiseaseId")
                        .HasColumnType("bigint");

                    b.Property<long>("SymptomId")
                        .HasColumnType("bigint");

                    b.HasKey("DiseaseId", "SymptomId");

                    b.HasIndex("SymptomId");

                    b.ToTable("DiseasesHasSymptoms");

                    b.HasData(
                        new
                        {
                            DiseaseId = 1L,
                            SymptomId = 1L
                        },
                        new
                        {
                            DiseaseId = 1L,
                            SymptomId = 2L
                        },
                        new
                        {
                            DiseaseId = 1L,
                            SymptomId = 3L
                        },
                        new
                        {
                            DiseaseId = 1L,
                            SymptomId = 4L
                        },
                        new
                        {
                            DiseaseId = 1L,
                            SymptomId = 5L
                        },
                        new
                        {
                            DiseaseId = 2L,
                            SymptomId = 6L
                        },
                        new
                        {
                            DiseaseId = 2L,
                            SymptomId = 7L
                        });
                });

            modelBuilder.Entity("DiseaseService.Models.DiseasesNeedsMeasures", b =>
                {
                    b.Property<long>("DiseaseId")
                        .HasColumnType("bigint");

                    b.Property<long>("PreventativeMeasureId")
                        .HasColumnType("bigint");

                    b.HasKey("DiseaseId", "PreventativeMeasureId");

                    b.HasIndex("PreventativeMeasureId");

                    b.ToTable("DiseasesNeedsMeasures");
                });

            modelBuilder.Entity("DiseaseService.Models.DiseasesNeedsPesticides", b =>
                {
                    b.Property<long>("DiseaseId")
                        .HasColumnType("bigint");

                    b.Property<long>("PesticideId")
                        .HasColumnType("bigint");

                    b.HasKey("DiseaseId", "PesticideId");

                    b.HasIndex("PesticideId");

                    b.ToTable("DiseasesNeedsPesticides");
                });

            modelBuilder.Entity("DiseaseService.Models.Pesticide", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasMaxLength(2000)
                        .HasColumnType("nvarchar(2000)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Pesticides");
                });

            modelBuilder.Entity("DiseaseService.Models.PreventativeMeasure", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasMaxLength(2000)
                        .HasColumnType("nvarchar(2000)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("PreventativeMeasures");
                });

            modelBuilder.Entity("DiseaseService.Models.Symptom", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasMaxLength(2000)
                        .HasColumnType("nvarchar(2000)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Symptoms");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            CreatedAt = new DateTime(2022, 11, 8, 10, 16, 34, 290, DateTimeKind.Utc).AddTicks(3582),
                            Description = "Leaves infected with powdery mildew initially have small, white powdery colonies on the undersides of leaves. These colonies enlarge to cover the entire lower leaf surface, causing the edges of the leaves to roll up",
                            Status = true,
                            Title = "White powdery colonies",
                            UpdatedAt = new DateTime(2022, 11, 8, 10, 16, 34, 290, DateTimeKind.Utc).AddTicks(3588)
                        },
                        new
                        {
                            Id = 2L,
                            CreatedAt = new DateTime(2022, 11, 8, 10, 16, 34, 290, DateTimeKind.Utc).AddTicks(3590),
                            Description = "Purple reddish blotches appear on the upper and lower surface of leaves.",
                            Status = true,
                            Title = "Purple reddish blotches",
                            UpdatedAt = new DateTime(2022, 11, 8, 10, 16, 34, 290, DateTimeKind.Utc).AddTicks(3591)
                        },
                        new
                        {
                            Id = 3L,
                            CreatedAt = new DateTime(2022, 11, 8, 10, 16, 34, 290, DateTimeKind.Utc).AddTicks(3593),
                            Description = "Infected flowers produce deformed fruit or no fruit at all. Severely infected flowers may be completely covered by mycelium and killed.",
                            Status = true,
                            Title = "Infected flowers",
                            UpdatedAt = new DateTime(2022, 11, 8, 10, 16, 34, 290, DateTimeKind.Utc).AddTicks(3593)
                        },
                        new
                        {
                            Id = 4L,
                            CreatedAt = new DateTime(2022, 11, 8, 10, 16, 34, 290, DateTimeKind.Utc).AddTicks(3595),
                            Description = "Infected immature fruits become hardened and desiccated",
                            Status = true,
                            Title = "Infected immature fruits",
                            UpdatedAt = new DateTime(2022, 11, 8, 10, 16, 34, 290, DateTimeKind.Utc).AddTicks(3596)
                        },
                        new
                        {
                            Id = 5L,
                            CreatedAt = new DateTime(2022, 11, 8, 10, 16, 34, 290, DateTimeKind.Utc).AddTicks(3597),
                            Description = "Infected mature fruits become seedy in appearance and support spore-producing colonies that look powdery and white.",
                            Status = true,
                            Title = "Infected mature fruits",
                            UpdatedAt = new DateTime(2022, 11, 8, 10, 16, 34, 290, DateTimeKind.Utc).AddTicks(3598)
                        },
                        new
                        {
                            Id = 6L,
                            CreatedAt = new DateTime(2022, 11, 8, 10, 16, 34, 290, DateTimeKind.Utc).AddTicks(3599),
                            Description = "Small and circular leaf spots with light to tan centers and purplish borders.Lesions usually start on the upper leaf surface as small, deep purple, round to irregularly shaped necrotic spots, which can grow to 1–2 mm in diameter",
                            Status = true,
                            Title = "Leaves",
                            UpdatedAt = new DateTime(2022, 11, 8, 10, 16, 34, 290, DateTimeKind.Utc).AddTicks(3600)
                        },
                        new
                        {
                            Id = 7L,
                            CreatedAt = new DateTime(2022, 11, 8, 10, 16, 34, 290, DateTimeKind.Utc).AddTicks(3601),
                            Description = "Spots remain light brown, whereas on older leaves the center changes from tan or brown to gray or white, and the necrotic center is surrounded by reddish-purple to rusty-brown borders. Lesions occur less frequently on the underside of the leaves, and the color is not as vivid. Intense spotting may lead to death of the infected leaves.",
                            Status = true,
                            Title = "Young leaves",
                            UpdatedAt = new DateTime(2022, 11, 8, 10, 16, 34, 290, DateTimeKind.Utc).AddTicks(3602)
                        });
                });

            modelBuilder.Entity("DiseaseService.Models.DiseasesHasCauses", b =>
                {
                    b.HasOne("DiseaseService.Models.Cause", "Cause")
                        .WithMany("DiseasesHasCauses")
                        .HasForeignKey("CauseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DiseaseService.Models.Disease", "Disease")
                        .WithMany("DiseasesHasCauses")
                        .HasForeignKey("DiseaseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cause");

                    b.Navigation("Disease");
                });

            modelBuilder.Entity("DiseaseService.Models.DiseasesHasSymptoms", b =>
                {
                    b.HasOne("DiseaseService.Models.Disease", "Disease")
                        .WithMany("DiseasesHasSymptoms")
                        .HasForeignKey("DiseaseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DiseaseService.Models.Symptom", "Symptom")
                        .WithMany("DiseasesHasSymptoms")
                        .HasForeignKey("SymptomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Disease");

                    b.Navigation("Symptom");
                });

            modelBuilder.Entity("DiseaseService.Models.DiseasesNeedsMeasures", b =>
                {
                    b.HasOne("DiseaseService.Models.Disease", "Disease")
                        .WithMany("DiseasesNeedsMeasures")
                        .HasForeignKey("DiseaseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DiseaseService.Models.PreventativeMeasure", "PreventativeMeasure")
                        .WithMany("DiseasesNeedsMeasures")
                        .HasForeignKey("PreventativeMeasureId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Disease");

                    b.Navigation("PreventativeMeasure");
                });

            modelBuilder.Entity("DiseaseService.Models.DiseasesNeedsPesticides", b =>
                {
                    b.HasOne("DiseaseService.Models.Disease", "Disease")
                        .WithMany("DiseasesNeedsPesticides")
                        .HasForeignKey("DiseaseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DiseaseService.Models.Pesticide", "Pesticide")
                        .WithMany("DiseasesNeedsPesticides")
                        .HasForeignKey("PesticideId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Disease");

                    b.Navigation("Pesticide");
                });

            modelBuilder.Entity("DiseaseService.Models.Cause", b =>
                {
                    b.Navigation("DiseasesHasCauses");
                });

            modelBuilder.Entity("DiseaseService.Models.Disease", b =>
                {
                    b.Navigation("DiseasesHasCauses");

                    b.Navigation("DiseasesHasSymptoms");

                    b.Navigation("DiseasesNeedsMeasures");

                    b.Navigation("DiseasesNeedsPesticides");
                });

            modelBuilder.Entity("DiseaseService.Models.Pesticide", b =>
                {
                    b.Navigation("DiseasesNeedsPesticides");
                });

            modelBuilder.Entity("DiseaseService.Models.PreventativeMeasure", b =>
                {
                    b.Navigation("DiseasesNeedsMeasures");
                });

            modelBuilder.Entity("DiseaseService.Models.Symptom", b =>
                {
                    b.Navigation("DiseasesHasSymptoms");
                });
#pragma warning restore 612, 618
        }
    }
}
