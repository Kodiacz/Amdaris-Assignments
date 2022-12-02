﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PetClinic.Infrastructure;

#nullable disable

namespace PetClinic.Infrastructure.Migrations
{
    [DbContext(typeof(PetClinicDbContext))]
    [Migration("20221202134553_SeedingData")]
    partial class SeedingData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("PetClinic.Domain.Entities.Doctor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(35)
                        .HasColumnType("nvarchar(35)");

                    b.Property<bool>("IsAvailable")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("JobDescription")
                        .IsRequired()
                        .HasMaxLength(400)
                        .HasColumnType("nvarchar(400)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(35)
                        .HasColumnType("nvarchar(35)");

                    b.Property<string>("Phonenumber")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<DateTime>("StartedJobDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Doctors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Age = 33,
                            FirstName = "Gergana",
                            IsAvailable = true,
                            IsDeleted = false,
                            JobDescription = "Emergency medical care, internal medicine",
                            LastName = "Nikolova",
                            Phonenumber = "0215688",
                            StartedJobDate = new DateTime(2018, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            Age = 26,
                            FirstName = "Valentina",
                            IsAvailable = true,
                            IsDeleted = false,
                            JobDescription = "Parasitology and infectious diseases",
                            LastName = "Naidenova",
                            Phonenumber = "0233727",
                            StartedJobDate = new DateTime(2018, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            Age = 46,
                            FirstName = "Borisalv",
                            IsAvailable = true,
                            IsDeleted = false,
                            JobDescription = "orthopedics and traumatology, abdominal and thoracic surgery, panelist",
                            LastName = "Georgiev",
                            Phonenumber = "0251473",
                            StartedJobDate = new DateTime(2011, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 4,
                            Age = 35,
                            FirstName = "Veseling",
                            IsAvailable = true,
                            IsDeleted = false,
                            JobDescription = "exotic animals, internal diseases",
                            LastName = "Milushev",
                            Phonenumber = "0275727",
                            StartedJobDate = new DateTime(2010, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("PetClinic.Domain.Entities.Owner", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<int?>("DoctorId")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(35)
                        .HasColumnType("nvarchar(35)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(35)
                        .HasColumnType("nvarchar(35)");

                    b.Property<string>("Phonenumber")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int?>("ReceptionistId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DoctorId");

                    b.HasIndex("ReceptionistId");

                    b.ToTable("Owners");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Age = 23,
                            FirstName = "Stanimir",
                            IsDeleted = false,
                            LastName = "Petkov",
                            Phonenumber = "0894556801"
                        },
                        new
                        {
                            Id = 2,
                            Age = 30,
                            FirstName = "Desislava",
                            IsDeleted = false,
                            LastName = "Koleva",
                            Phonenumber = "0876378080"
                        },
                        new
                        {
                            Id = 3,
                            Age = 43,
                            FirstName = "Vencislav",
                            IsDeleted = false,
                            LastName = "Kolev",
                            Phonenumber = "0897484868"
                        },
                        new
                        {
                            Id = 4,
                            Age = 26,
                            FirstName = "Simeon",
                            IsDeleted = false,
                            LastName = "Kostadinov",
                            Phonenumber = "0873441234"
                        });
                });

            modelBuilder.Entity("PetClinic.Domain.Entities.Pet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Breed")
                        .IsRequired()
                        .HasMaxLength(35)
                        .HasColumnType("nvarchar(35)");

                    b.Property<int?>("DoctorId")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(35)
                        .HasColumnType("nvarchar(35)");

                    b.Property<int>("OwnerId")
                        .HasColumnType("int");

                    b.Property<int?>("ReceptionistId")
                        .HasColumnType("int");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(35)
                        .HasColumnType("nvarchar(35)");

                    b.HasKey("Id");

                    b.HasIndex("DoctorId");

                    b.HasIndex("OwnerId");

                    b.HasIndex("ReceptionistId");

                    b.ToTable("Pets");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Age = 2,
                            Breed = "Akita",
                            IsDeleted = false,
                            Name = "Bella",
                            OwnerId = 4,
                            Type = "Dog"
                        },
                        new
                        {
                            Id = 2,
                            Age = 4,
                            Breed = "Street",
                            IsDeleted = false,
                            Name = "Milo",
                            OwnerId = 4,
                            Type = "Cat"
                        },
                        new
                        {
                            Id = 3,
                            Age = 1,
                            Breed = "Syrian",
                            IsDeleted = false,
                            Name = "Loki",
                            OwnerId = 1,
                            Type = "Hamster"
                        },
                        new
                        {
                            Id = 4,
                            Age = 1,
                            Breed = "Bichon Frise",
                            IsDeleted = false,
                            Name = "Simba",
                            OwnerId = 2,
                            Type = "Dog"
                        },
                        new
                        {
                            Id = 5,
                            Age = 1,
                            Breed = "Street",
                            IsDeleted = false,
                            Name = "Nala",
                            OwnerId = 3,
                            Type = "Cat"
                        });
                });

            modelBuilder.Entity("PetClinic.Domain.Entities.Receptionist", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(35)
                        .HasColumnType("nvarchar(35)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("JobDescription")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(35)
                        .HasColumnType("nvarchar(35)");

                    b.Property<string>("Phonenumber")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<DateTime>("StartedJobDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Receptionists");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Age = 24,
                            FirstName = "Katya",
                            IsDeleted = false,
                            JobDescription = "Receptionist",
                            LastName = "Manolova",
                            Phonenumber = "0239949",
                            StartedJobDate = new DateTime(2018, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            Age = 35,
                            FirstName = "Tanyq",
                            IsDeleted = false,
                            JobDescription = "Receptionist",
                            LastName = "Gramatikova",
                            Phonenumber = "0239949",
                            StartedJobDate = new DateTime(2018, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            Age = 24,
                            FirstName = "Vesela",
                            IsDeleted = false,
                            JobDescription = "Receptionist",
                            LastName = "Cvetkova",
                            Phonenumber = "0239949",
                            StartedJobDate = new DateTime(2018, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("PetClinic.Domain.Entities.Owner", b =>
                {
                    b.HasOne("PetClinic.Domain.Entities.Doctor", "Doctor")
                        .WithMany("OwnersOfPatients")
                        .HasForeignKey("DoctorId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("PetClinic.Domain.Entities.Receptionist", "Receptionist")
                        .WithMany("OwnersOfPatients")
                        .HasForeignKey("ReceptionistId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.Navigation("Doctor");

                    b.Navigation("Receptionist");
                });

            modelBuilder.Entity("PetClinic.Domain.Entities.Pet", b =>
                {
                    b.HasOne("PetClinic.Domain.Entities.Doctor", "Doctor")
                        .WithMany("Patients")
                        .HasForeignKey("DoctorId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("PetClinic.Domain.Entities.Owner", "Owner")
                        .WithMany("Pets")
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PetClinic.Domain.Entities.Receptionist", "Receptionist")
                        .WithMany("Patients")
                        .HasForeignKey("ReceptionistId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.Navigation("Doctor");

                    b.Navigation("Owner");

                    b.Navigation("Receptionist");
                });

            modelBuilder.Entity("PetClinic.Domain.Entities.Doctor", b =>
                {
                    b.Navigation("OwnersOfPatients");

                    b.Navigation("Patients");
                });

            modelBuilder.Entity("PetClinic.Domain.Entities.Owner", b =>
                {
                    b.Navigation("Pets");
                });

            modelBuilder.Entity("PetClinic.Domain.Entities.Receptionist", b =>
                {
                    b.Navigation("OwnersOfPatients");

                    b.Navigation("Patients");
                });
#pragma warning restore 612, 618
        }
    }
}
