using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EasyCarpet.Domain.Migrations
{
    public partial class AddedCustomersReal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Carpet",
                keyColumn: "Id",
                keyValue: new Guid("9cf37a50-a08f-4ed6-9505-2cb18af43605"),
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 5, 18, 16, 19, 3, 909, DateTimeKind.Local).AddTicks(1065), new DateTime(2021, 5, 18, 16, 19, 3, 911, DateTimeKind.Local).AddTicks(4999) });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Address", "City", "CreatedDate", "FirstName", "LastName", "ModifiedDate", "PhoneNumber", "State" },
                values: new object[] { new Guid("14999486-bc73-4651-be18-fa308608831d"), "123 Grennada St", "Livonia", new DateTime(2021, 5, 18, 16, 19, 3, 914, DateTimeKind.Local).AddTicks(2550), "Kyle", "Warchuck", new DateTime(2021, 5, 18, 16, 19, 3, 914, DateTimeKind.Local).AddTicks(2566), "734-111-6548", "Michigan" });

            migrationBuilder.UpdateData(
                table: "Installers",
                keyColumn: "Id",
                keyValue: new Guid("ebb89a92-dd6a-43ef-9301-3a58c479120a"),
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 5, 18, 16, 19, 3, 913, DateTimeKind.Local).AddTicks(8804), new DateTime(2021, 5, 18, 16, 19, 3, 913, DateTimeKind.Local).AddTicks(8824) });

            migrationBuilder.UpdateData(
                table: "Retailers",
                keyColumn: "Id",
                keyValue: new Guid("943ba50f-41c5-4881-9a97-7e4de399836d"),
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 5, 18, 16, 19, 3, 913, DateTimeKind.Local).AddTicks(2758), new DateTime(2021, 5, 18, 16, 19, 3, 913, DateTimeKind.Local).AddTicks(2802) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.UpdateData(
                table: "Carpet",
                keyColumn: "Id",
                keyValue: new Guid("9cf37a50-a08f-4ed6-9505-2cb18af43605"),
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 5, 18, 16, 6, 4, 316, DateTimeKind.Local).AddTicks(2114), new DateTime(2021, 5, 18, 16, 6, 4, 318, DateTimeKind.Local).AddTicks(7320) });

            migrationBuilder.UpdateData(
                table: "Installers",
                keyColumn: "Id",
                keyValue: new Guid("ebb89a92-dd6a-43ef-9301-3a58c479120a"),
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 5, 18, 16, 6, 4, 320, DateTimeKind.Local).AddTicks(9173), new DateTime(2021, 5, 18, 16, 6, 4, 320, DateTimeKind.Local).AddTicks(9190) });

            migrationBuilder.UpdateData(
                table: "Retailers",
                keyColumn: "Id",
                keyValue: new Guid("943ba50f-41c5-4881-9a97-7e4de399836d"),
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 5, 18, 16, 6, 4, 320, DateTimeKind.Local).AddTicks(4671), new DateTime(2021, 5, 18, 16, 6, 4, 320, DateTimeKind.Local).AddTicks(4700) });
        }
    }
}
