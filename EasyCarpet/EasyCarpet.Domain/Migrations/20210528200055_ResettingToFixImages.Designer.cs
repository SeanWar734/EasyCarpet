// <auto-generated />
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
    [Migration("20210528200055_ResettingToFixImages")]
    partial class ResettingToFixImages
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
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

                    b.Property<string>("ImageFileName")
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
                            CreatedDate = new DateTime(2021, 5, 28, 16, 0, 54, 445, DateTimeKind.Local).AddTicks(1957),
                            Description = "Medium Beige / Dark Beige flecks, indoor residential",
                            Length = 200m,
                            ModifiedDate = new DateTime(2021, 5, 28, 16, 0, 54, 447, DateTimeKind.Local).AddTicks(9083),
                            Name = "TrafficMaster: Brown",
                            SquareYardPrice = 5.89m,
                            Style = "Plush",
                            Width = 12m
                        });
                });

            modelBuilder.Entity("EasyCarpet.Domain.Models.Customer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

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

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            Id = new Guid("14999486-bc73-4651-be18-fa308608831d"),
                            Address = "123 Grennada St",
                            City = "Livonia",
                            CreatedDate = new DateTime(2021, 5, 28, 16, 0, 54, 450, DateTimeKind.Local).AddTicks(3757),
                            FirstName = "Kyle",
                            LastName = "Warchuck",
                            ModifiedDate = new DateTime(2021, 5, 28, 16, 0, 54, 450, DateTimeKind.Local).AddTicks(3771),
                            PhoneNumber = "734-111-6548",
                            State = "Michigan"
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
                            CreatedDate = new DateTime(2021, 5, 28, 16, 0, 54, 450, DateTimeKind.Local).AddTicks(162),
                            FirstName = "Sean",
                            LastName = "Warchuck",
                            ModifiedDate = new DateTime(2021, 5, 28, 16, 0, 54, 450, DateTimeKind.Local).AddTicks(179),
                            PhoneNumber = "734-788-6458",
                            RetailerId = new Guid("943ba50f-41c5-4881-9a97-7e4de399836d"),
                            SquareYardPrice = 4.99m
                        });
                });

            modelBuilder.Entity("EasyCarpet.Domain.Models.Order", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CarpetId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("CustomerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("InstallerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("RetailerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Total")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Orders");

                    b.HasData(
                        new
                        {
                            Id = new Guid("6ea4eafb-0b96-40e3-ab04-da5db6195a17"),
                            CarpetId = new Guid("9cf37a50-a08f-4ed6-9505-2cb18af43605"),
                            CreatedDate = new DateTime(2021, 5, 28, 16, 0, 54, 450, DateTimeKind.Local).AddTicks(7354),
                            CustomerId = new Guid("14999486-bc73-4651-be18-fa308608831d"),
                            InstallerId = new Guid("ebb89a92-dd6a-43ef-9301-3a58c479120a"),
                            ModifiedDate = new DateTime(2021, 5, 28, 16, 0, 54, 450, DateTimeKind.Local).AddTicks(7368),
                            RetailerId = new Guid("943ba50f-41c5-4881-9a97-7e4de399836d"),
                            Total = 100m
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
                            CreatedDate = new DateTime(2021, 5, 28, 16, 0, 54, 449, DateTimeKind.Local).AddTicks(5710),
                            Description = "A large box chain retailer with good prices",
                            ModifiedDate = new DateTime(2021, 5, 28, 16, 0, 54, 449, DateTimeKind.Local).AddTicks(5732),
                            PhoneNumber = "734-111-2222",
                            State = "Michigan"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
