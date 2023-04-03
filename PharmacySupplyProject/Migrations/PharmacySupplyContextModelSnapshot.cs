﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PharmacySupplyProject.Models;

#nullable disable

namespace PharmacySupplyProject.Migrations
{
    [DbContext(typeof(PharmacySupplyContext))]
    partial class PharmacySupplyContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("PharmacySupplyProject.Models.MedicalRepresentative", b =>
                {
                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ContactNumber")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.HasKey("Name");

                    b.HasIndex("ContactNumber")
                        .IsUnique();

                    b.HasIndex("Id")
                        .IsUnique();

                    b.ToTable("MedicalRepresentatives");
                });

            modelBuilder.Entity("PharmacySupplyProject.Models.MedicineStock", b =>
                {
                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ChemicalComposition")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("DateOfExpiry")
                        .HasColumnType("datetime2");

                    b.Property<int>("NumberOfTabletsInStock")
                        .HasColumnType("int");

                    b.Property<string>("TargetAilment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Name");

                    b.HasIndex("ChemicalComposition")
                        .IsUnique();

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("MedicineStocks");
                });

            modelBuilder.Entity("PharmacySupplyProject.Models.RepresentativeSchedule", b =>
                {
                    b.Property<string>("RepresentativeName")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("DoctorName")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("DoctorContactNumber")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Medicine")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Slot")
                        .HasColumnType("datetime2");

                    b.Property<string>("TreatingAilment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RepresentativeName", "DoctorName");

                    b.ToTable("RepresentativeSchedules");
                });
#pragma warning restore 612, 618
        }
    }
}
