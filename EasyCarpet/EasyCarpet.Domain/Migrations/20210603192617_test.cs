using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EasyCarpet.Domain.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Carpet",
                keyColumn: "Id",
                keyValue: new Guid("9cf37a50-a08f-4ed6-9505-2cb18af43605"),
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 3, 15, 26, 16, 514, DateTimeKind.Local).AddTicks(3809), new DateTime(2021, 6, 3, 15, 26, 16, 517, DateTimeKind.Local).AddTicks(1523) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("14999486-bc73-4651-be18-fa308608831d"),
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 3, 15, 26, 16, 519, DateTimeKind.Local).AddTicks(6840), new DateTime(2021, 6, 3, 15, 26, 16, 519, DateTimeKind.Local).AddTicks(6854) });

            migrationBuilder.UpdateData(
                table: "Installers",
                keyColumn: "Id",
                keyValue: new Guid("ebb89a92-dd6a-43ef-9301-3a58c479120a"),
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 3, 15, 26, 16, 519, DateTimeKind.Local).AddTicks(3035), new DateTime(2021, 6, 3, 15, 26, 16, 519, DateTimeKind.Local).AddTicks(3052) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("6ea4eafb-0b96-40e3-ab04-da5db6195a17"),
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 3, 15, 26, 16, 520, DateTimeKind.Local).AddTicks(500), new DateTime(2021, 6, 3, 15, 26, 16, 520, DateTimeKind.Local).AddTicks(514) });

            migrationBuilder.UpdateData(
                table: "Retailers",
                keyColumn: "Id",
                keyValue: new Guid("943ba50f-41c5-4881-9a97-7e4de399836d"),
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 3, 15, 26, 16, 518, DateTimeKind.Local).AddTicks(8268), new DateTime(2021, 6, 3, 15, 26, 16, 518, DateTimeKind.Local).AddTicks(8293) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Carpet",
                keyColumn: "Id",
                keyValue: new Guid("9cf37a50-a08f-4ed6-9505-2cb18af43605"),
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 3, 15, 24, 7, 221, DateTimeKind.Local).AddTicks(9925), new DateTime(2021, 6, 3, 15, 24, 7, 224, DateTimeKind.Local).AddTicks(9583) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("14999486-bc73-4651-be18-fa308608831d"),
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 3, 15, 24, 7, 227, DateTimeKind.Local).AddTicks(5848), new DateTime(2021, 6, 3, 15, 24, 7, 227, DateTimeKind.Local).AddTicks(5864) });

            migrationBuilder.UpdateData(
                table: "Installers",
                keyColumn: "Id",
                keyValue: new Guid("ebb89a92-dd6a-43ef-9301-3a58c479120a"),
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 3, 15, 24, 7, 227, DateTimeKind.Local).AddTicks(2165), new DateTime(2021, 6, 3, 15, 24, 7, 227, DateTimeKind.Local).AddTicks(2183) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("6ea4eafb-0b96-40e3-ab04-da5db6195a17"),
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 3, 15, 24, 7, 227, DateTimeKind.Local).AddTicks(9560), new DateTime(2021, 6, 3, 15, 24, 7, 227, DateTimeKind.Local).AddTicks(9575) });

            migrationBuilder.UpdateData(
                table: "Retailers",
                keyColumn: "Id",
                keyValue: new Guid("943ba50f-41c5-4881-9a97-7e4de399836d"),
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 3, 15, 24, 7, 226, DateTimeKind.Local).AddTicks(7428), new DateTime(2021, 6, 3, 15, 24, 7, 226, DateTimeKind.Local).AddTicks(7475) });
        }
    }
}
