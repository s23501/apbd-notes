﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PrzykladoweKolokwium2_2.Data;

#nullable disable

namespace PrzykladoweKolokwium2_2.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20230601162150_SeedData")]
    partial class SeedData
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("PrzykladoweKolokwium2_2.Models.Animal", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<DateTime>("AdmissionDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("AnimalClassID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("OwnerID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("AnimalClassID");

                    b.HasIndex("OwnerID");

                    b.ToTable("Animals");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            AdmissionDate = new DateTime(2023, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            AnimalClassID = 1,
                            Name = "AnimalName",
                            OwnerID = 1
                        });
                });

            modelBuilder.Entity("PrzykladoweKolokwium2_2.Models.AnimalClass", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("ID");

                    b.ToTable("AnimalClasses");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Name = "Mammal"
                        },
                        new
                        {
                            ID = 2,
                            Name = "Bird"
                        });
                });

            modelBuilder.Entity("PrzykladoweKolokwium2_2.Models.Owner", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("ID");

                    b.ToTable("Owners");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            FirstName = "Jan",
                            LastName = "Kowalski"
                        },
                        new
                        {
                            ID = 2,
                            FirstName = "Anna",
                            LastName = "Nowak"
                        });
                });

            modelBuilder.Entity("PrzykladoweKolokwium2_2.Models.Procedure", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("ID");

                    b.ToTable("Procedures");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Description = "Lorem ipsum ...",
                            Name = "Endoscopy"
                        },
                        new
                        {
                            ID = 2,
                            Description = "Lorem ipsum ...",
                            Name = "Cholecystectomy"
                        });
                });

            modelBuilder.Entity("PrzykladoweKolokwium2_2.Models.ProcedureAnimal", b =>
                {
                    b.Property<int>("ProcedureID")
                        .HasColumnType("int");

                    b.Property<int>("AnimalID")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.HasKey("ProcedureID", "AnimalID", "Date");

                    b.HasIndex("AnimalID");

                    b.ToTable("ProcedureAnimals");

                    b.HasData(
                        new
                        {
                            ProcedureID = 1,
                            AnimalID = 1,
                            Date = new DateTime(2023, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ProcedureID = 2,
                            AnimalID = 1,
                            Date = new DateTime(2023, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("PrzykladoweKolokwium2_2.Models.Animal", b =>
                {
                    b.HasOne("PrzykladoweKolokwium2_2.Models.AnimalClass", "AnimalClass")
                        .WithMany("Animals")
                        .HasForeignKey("AnimalClassID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PrzykladoweKolokwium2_2.Models.Owner", "Owner")
                        .WithMany("Animals")
                        .HasForeignKey("OwnerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AnimalClass");

                    b.Navigation("Owner");
                });

            modelBuilder.Entity("PrzykladoweKolokwium2_2.Models.ProcedureAnimal", b =>
                {
                    b.HasOne("PrzykladoweKolokwium2_2.Models.Animal", "Animal")
                        .WithMany("ProcedureAnimals")
                        .HasForeignKey("AnimalID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PrzykladoweKolokwium2_2.Models.Procedure", "Procedure")
                        .WithMany("ProcedureAnimals")
                        .HasForeignKey("ProcedureID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Animal");

                    b.Navigation("Procedure");
                });

            modelBuilder.Entity("PrzykladoweKolokwium2_2.Models.Animal", b =>
                {
                    b.Navigation("ProcedureAnimals");
                });

            modelBuilder.Entity("PrzykladoweKolokwium2_2.Models.AnimalClass", b =>
                {
                    b.Navigation("Animals");
                });

            modelBuilder.Entity("PrzykladoweKolokwium2_2.Models.Owner", b =>
                {
                    b.Navigation("Animals");
                });

            modelBuilder.Entity("PrzykladoweKolokwium2_2.Models.Procedure", b =>
                {
                    b.Navigation("ProcedureAnimals");
                });
#pragma warning restore 612, 618
        }
    }
}
