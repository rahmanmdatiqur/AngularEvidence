﻿// <auto-generated />
using System;
using Angular_MasterDetails.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Angular_MasterDetails.Migrations
{
    [DbContext(typeof(TestDbContext))]
    [Migration("20230218031205_A")]
    partial class A
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Angular_MasterDetails.Models.Disese", b =>
                {
                    b.Property<int>("DiseseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DiseseId"), 1L, 1);

                    b.Property<string>("DiseseName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DiseseId");

                    b.ToTable("Diseses");

                    b.HasData(
                        new
                        {
                            DiseseId = 1,
                            DiseseName = "Fever"
                        },
                        new
                        {
                            DiseseId = 2,
                            DiseseName = "Covid-19"
                        },
                        new
                        {
                            DiseseId = 3,
                            DiseseName = "Cold"
                        },
                        new
                        {
                            DiseseId = 4,
                            DiseseName = "Maleria"
                        });
                });

            modelBuilder.Entity("Angular_MasterDetails.Models.Patient", b =>
                {
                    b.Property<int>("PatientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PatientId"), 1L, 1);

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("date");

                    b.Property<bool>("MaritalStatus")
                        .HasColumnType("bit");

                    b.Property<string>("PatientName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PhoneNo")
                        .HasColumnType("int");

                    b.Property<string>("Picture")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PatientId");

                    b.ToTable("Patients");
                });

            modelBuilder.Entity("Angular_MasterDetails.Models.TestEntry", b =>
                {
                    b.Property<int>("TestEntryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TestEntryId"), 1L, 1);

                    b.Property<int>("DiseseId")
                        .HasColumnType("int");

                    b.Property<int>("PatientId")
                        .HasColumnType("int");

                    b.HasKey("TestEntryId");

                    b.HasIndex("DiseseId");

                    b.HasIndex("PatientId");

                    b.ToTable("TestEntries");
                });

            modelBuilder.Entity("Angular_MasterDetails.Models.TestEntry", b =>
                {
                    b.HasOne("Angular_MasterDetails.Models.Disese", "Disese")
                        .WithMany("testEntries")
                        .HasForeignKey("DiseseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Angular_MasterDetails.Models.Patient", "Patient")
                        .WithMany("testEntries")
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Disese");

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("Angular_MasterDetails.Models.Disese", b =>
                {
                    b.Navigation("testEntries");
                });

            modelBuilder.Entity("Angular_MasterDetails.Models.Patient", b =>
                {
                    b.Navigation("testEntries");
                });
#pragma warning restore 612, 618
        }
    }
}
