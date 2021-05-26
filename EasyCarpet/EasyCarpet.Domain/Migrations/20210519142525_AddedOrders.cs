using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EasyCarpet.Domain.Migrations
{
    public partial class AddedOrders : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CustomerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RetailerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    InstallerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CarpetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Total = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Carpet",
                keyColumn: "Id",
                keyValue: new Guid("9cf37a50-a08f-4ed6-9505-2cb18af43605"),
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 5, 19, 10, 25, 24, 351, DateTimeKind.Local).AddTicks(2561), new DateTime(2021, 5, 19, 10, 25, 24, 354, DateTimeKind.Local).AddTicks(184) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("14999486-bc73-4651-be18-fa308608831d"),
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 5, 19, 10, 25, 24, 356, DateTimeKind.Local).AddTicks(4485), new DateTime(2021, 5, 19, 10, 25, 24, 356, DateTimeKind.Local).AddTicks(4500) });

            migrationBuilder.UpdateData(
                table: "Installers",
                keyColumn: "Id",
                keyValue: new Guid("ebb89a92-dd6a-43ef-9301-3a58c479120a"),
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 5, 19, 10, 25, 24, 356, DateTimeKind.Local).AddTicks(841), new DateTime(2021, 5, 19, 10, 25, 24, 356, DateTimeKind.Local).AddTicks(857) });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CarpetId", "CreatedDate", "CustomerId", "InstallerId", "ModifiedDate", "RetailerId", "Total" },
                values: new object[] { new Guid("6ea4eafb-0b96-40e3-ab04-da5db6195a17"), new Guid("9cf37a50-a08f-4ed6-9505-2cb18af43605"), new DateTime(2021, 5, 19, 10, 25, 24, 356, DateTimeKind.Local).AddTicks(8079), new Guid("14999486-bc73-4651-be18-fa308608831d"), new Guid("ebb89a92-dd6a-43ef-9301-3a58c479120a"), new DateTime(2021, 5, 19, 10, 25, 24, 356, DateTimeKind.Local).AddTicks(8093), new Guid("943ba50f-41c5-4881-9a97-7e4de399836d"), 100m });

            migrationBuilder.UpdateData(
                table: "Retailers",
                keyColumn: "Id",
                keyValue: new Guid("943ba50f-41c5-4881-9a97-7e4de399836d"),
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 5, 19, 10, 25, 24, 355, DateTimeKind.Local).AddTicks(6584), new DateTime(2021, 5, 19, 10, 25, 24, 355, DateTimeKind.Local).AddTicks(6604) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.UpdateData(
                table: "Carpet",
                keyColumn: "Id",
                keyValue: new Guid("9cf37a50-a08f-4ed6-9505-2cb18af43605"),
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 5, 18, 16, 19, 3, 909, DateTimeKind.Local).AddTicks(1065), new DateTime(2021, 5, 18, 16, 19, 3, 911, DateTimeKind.Local).AddTicks(4999) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("14999486-bc73-4651-be18-fa308608831d"),
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 5, 18, 16, 19, 3, 914, DateTimeKind.Local).AddTicks(2550), new DateTime(2021, 5, 18, 16, 19, 3, 914, DateTimeKind.Local).AddTicks(2566) });

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
    }
}
