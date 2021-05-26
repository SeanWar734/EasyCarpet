﻿// <auto-generated />
using System;
using EasyCarpet.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EasyCarpet.Domain.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210514131528_AddedInstaller")]
    partial class AddedInstaller
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EasyCarpet.Domain.Models.Carpet", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Brand")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Length")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("SquareYardPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Style")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Width")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Carpet");

                    b.HasData(
                        new
                        {
                            Id = new Guid("9cf37a50-a08f-4ed6-9505-2cb18af43605"),
                            Brand = "Traffic Master",
                            CreatedDate = new DateTime(2021, 5, 14, 9, 15, 28, 445, DateTimeKind.Local).AddTicks(3708),
                            Description = "Medium Beige / Dark Beige flecks, indoor residential",
                            Image = "TrafficMasterBrown.jpg",
                            Length = 200m,
                            ModifiedDate = new DateTime(2021, 5, 14, 9, 15, 28, 447, DateTimeKind.Local).AddTicks(9696),
                            Name = "TrafficMaster: Brown",
                            SquareYardPrice = 5.89m,
                            Style = "Plush",
                            Width = 12m
                        });
                });

            modelBuilder.Entity("EasyCarpet.Domain.Models.Installer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Area")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RetailerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("SquareYardPrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Installers");

                    b.HasData(
                        new
                        {
                            Id = new Guid("ebb89a92-dd6a-43ef-9301-3a58c479120a"),
                            Area = 0m,
                            CreatedDate = new DateTime(2021, 5, 14, 9, 15, 28, 449, DateTimeKind.Local).AddTicks(8997),
                            FirstName = "Sean",
                            LastName = "Warchuck",
                            ModifiedDate = new DateTime(2021, 5, 14, 9, 15, 28, 449, DateTimeKind.Local).AddTicks(9012),
                            PhoneNumber = "734-788-6458",
                            RetailerId = new Guid("943ba50f-41c5-4881-9a97-7e4de399836d"),
                            SquareYardPrice = 4.99m
                        });
                });

            modelBuilder.Entity("EasyCarpet.Domain.Models.Retailer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Retailers");

                    b.HasData(
                        new
                        {
                            Id = new Guid("943ba50f-41c5-4881-9a97-7e4de399836d"),
                            Address = "321 Schoolcraft Rd",
                            City = "Livonia",
                            CompanyName = "Home Depot",
                            CreatedDate = new DateTime(2021, 5, 14, 9, 15, 28, 449, DateTimeKind.Local).AddTicks(4954),
                            Description = "A large box chain retailer with good prices",
                            ModifiedDate = new DateTime(2021, 5, 14, 9, 15, 28, 449, DateTimeKind.Local).AddTicks(4971),
                            PhoneNumber = "734-111-2222",
                            State = "Michigan"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
