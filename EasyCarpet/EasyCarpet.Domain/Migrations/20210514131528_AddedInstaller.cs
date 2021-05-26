using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EasyCarpet.Domain.Migrations
{
    public partial class AddedInstaller : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Installers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RetailerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SquareYardPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Area = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Installers", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Carpet",
                keyColumn: "Id",
                keyValue: new Guid("9cf37a50-a08f-4ed6-9505-2cb18af43605"),
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 5, 14, 9, 15, 28, 445, DateTimeKind.Local).AddTicks(3708), new DateTime(2021, 5, 14, 9, 15, 28, 447, DateTimeKind.Local).AddTicks(9696) });

            migrationBuilder.InsertData(
                table: "Installers",
                columns: new[] { "Id", "Area", "CreatedDate", "FirstName", "LastName", "ModifiedDate", "PhoneNumber", "RetailerId", "SquareYardPrice" },
                values: new object[] { new Guid("ebb89a92-dd6a-43ef-9301-3a58c479120a"), 0m, new DateTime(2021, 5, 14, 9, 15, 28, 449, DateTimeKind.Local).AddTicks(8997), "Sean", "Warchuck", new DateTime(2021, 5, 14, 9, 15, 28, 449, DateTimeKind.Local).AddTicks(9012), "734-788-6458", new Guid("943ba50f-41c5-4881-9a97-7e4de399836d"), 4.99m });

            migrationBuilder.UpdateData(
                table: "Retailers",
                keyColumn: "Id",
                keyValue: new Guid("943ba50f-41c5-4881-9a97-7e4de399836d"),
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 5, 14, 9, 15, 28, 449, DateTimeKind.Local).AddTicks(4954), new DateTime(2021, 5, 14, 9, 15, 28, 449, DateTimeKind.Local).AddTicks(4971) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Installers");

            migrationBuilder.UpdateData(
                table: "Carpet",
                keyColumn: "Id",
                keyValue: new Guid("9cf37a50-a08f-4ed6-9505-2cb18af43605"),
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 5, 13, 14, 42, 4, 3, DateTimeKind.Local).AddTicks(9940), new DateTime(2021, 5, 13, 14, 42, 4, 6, DateTimeKind.Local).AddTicks(6523) });

            migrationBuilder.UpdateData(
                table: "Retailers",
                keyColumn: "Id",
                keyValue: new Guid("943ba50f-41c5-4881-9a97-7e4de399836d"),
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 5, 13, 14, 42, 4, 8, DateTimeKind.Local).AddTicks(2270), new DateTime(2021, 5, 13, 14, 42, 4, 8, DateTimeKind.Local).AddTicks(2298) });
        }
    }
}
