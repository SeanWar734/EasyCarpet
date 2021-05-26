using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EasyCarpet.Domain.Migrations
{
    public partial class AddedRetailer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Retailers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Retailers", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Carpet",
                keyColumn: "Id",
                keyValue: new Guid("9cf37a50-a08f-4ed6-9505-2cb18af43605"),
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 5, 13, 14, 42, 4, 3, DateTimeKind.Local).AddTicks(9940), new DateTime(2021, 5, 13, 14, 42, 4, 6, DateTimeKind.Local).AddTicks(6523) });

            migrationBuilder.InsertData(
                table: "Retailers",
                columns: new[] { "Id", "Address", "City", "CompanyName", "CreatedDate", "Description", "ModifiedDate", "PhoneNumber", "State" },
                values: new object[] { new Guid("943ba50f-41c5-4881-9a97-7e4de399836d"), "321 Schoolcraft Rd", "Livonia", "Home Depot", new DateTime(2021, 5, 13, 14, 42, 4, 8, DateTimeKind.Local).AddTicks(2270), "A large box chain retailer with good prices", new DateTime(2021, 5, 13, 14, 42, 4, 8, DateTimeKind.Local).AddTicks(2298), "734-111-2222", "Michigan" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Retailers");

            migrationBuilder.UpdateData(
                table: "Carpet",
                keyColumn: "Id",
                keyValue: new Guid("9cf37a50-a08f-4ed6-9505-2cb18af43605"),
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 5, 13, 8, 14, 32, 68, DateTimeKind.Local).AddTicks(571), new DateTime(2021, 5, 13, 8, 14, 32, 70, DateTimeKind.Local).AddTicks(6417) });
        }
    }
}
