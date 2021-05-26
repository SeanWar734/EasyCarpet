using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EasyCarpet.Domain.Migrations
{
    public partial class AddedCustomers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Carpet",
                keyColumn: "Id",
                keyValue: new Guid("9cf37a50-a08f-4ed6-9505-2cb18af43605"),
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 5, 14, 9, 15, 28, 445, DateTimeKind.Local).AddTicks(3708), new DateTime(2021, 5, 14, 9, 15, 28, 447, DateTimeKind.Local).AddTicks(9696) });

            migrationBuilder.UpdateData(
                table: "Installers",
                keyColumn: "Id",
                keyValue: new Guid("ebb89a92-dd6a-43ef-9301-3a58c479120a"),
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 5, 14, 9, 15, 28, 449, DateTimeKind.Local).AddTicks(8997), new DateTime(2021, 5, 14, 9, 15, 28, 449, DateTimeKind.Local).AddTicks(9012) });

            migrationBuilder.UpdateData(
                table: "Retailers",
                keyColumn: "Id",
                keyValue: new Guid("943ba50f-41c5-4881-9a97-7e4de399836d"),
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 5, 14, 9, 15, 28, 449, DateTimeKind.Local).AddTicks(4954), new DateTime(2021, 5, 14, 9, 15, 28, 449, DateTimeKind.Local).AddTicks(4971) });
        }
    }
}
