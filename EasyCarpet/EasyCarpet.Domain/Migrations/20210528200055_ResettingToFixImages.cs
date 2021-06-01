using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EasyCarpet.Domain.Migrations
{
    public partial class ResettingToFixImages : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Image",
                table: "Carpet",
                newName: "ImageUrl");

            migrationBuilder.UpdateData(
                table: "Carpet",
                keyColumn: "Id",
                keyValue: new Guid("9cf37a50-a08f-4ed6-9505-2cb18af43605"),
                columns: new[] { "CreatedDate", "ImageUrl", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 5, 28, 16, 0, 54, 445, DateTimeKind.Local).AddTicks(1957), null, new DateTime(2021, 5, 28, 16, 0, 54, 447, DateTimeKind.Local).AddTicks(9083) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("14999486-bc73-4651-be18-fa308608831d"),
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 5, 28, 16, 0, 54, 450, DateTimeKind.Local).AddTicks(3757), new DateTime(2021, 5, 28, 16, 0, 54, 450, DateTimeKind.Local).AddTicks(3771) });

            migrationBuilder.UpdateData(
                table: "Installers",
                keyColumn: "Id",
                keyValue: new Guid("ebb89a92-dd6a-43ef-9301-3a58c479120a"),
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 5, 28, 16, 0, 54, 450, DateTimeKind.Local).AddTicks(162), new DateTime(2021, 5, 28, 16, 0, 54, 450, DateTimeKind.Local).AddTicks(179) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("6ea4eafb-0b96-40e3-ab04-da5db6195a17"),
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 5, 28, 16, 0, 54, 450, DateTimeKind.Local).AddTicks(7354), new DateTime(2021, 5, 28, 16, 0, 54, 450, DateTimeKind.Local).AddTicks(7368) });

            migrationBuilder.UpdateData(
                table: "Retailers",
                keyColumn: "Id",
                keyValue: new Guid("943ba50f-41c5-4881-9a97-7e4de399836d"),
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 5, 28, 16, 0, 54, 449, DateTimeKind.Local).AddTicks(5710), new DateTime(2021, 5, 28, 16, 0, 54, 449, DateTimeKind.Local).AddTicks(5732) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ImageUrl",
                table: "Carpet",
                newName: "Image");

            migrationBuilder.UpdateData(
                table: "Carpet",
                keyColumn: "Id",
                keyValue: new Guid("9cf37a50-a08f-4ed6-9505-2cb18af43605"),
                columns: new[] { "CreatedDate", "Image", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 5, 19, 10, 25, 24, 351, DateTimeKind.Local).AddTicks(2561), "TrafficMasterBrown.jpg", new DateTime(2021, 5, 19, 10, 25, 24, 354, DateTimeKind.Local).AddTicks(184) });

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

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("6ea4eafb-0b96-40e3-ab04-da5db6195a17"),
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 5, 19, 10, 25, 24, 356, DateTimeKind.Local).AddTicks(8079), new DateTime(2021, 5, 19, 10, 25, 24, 356, DateTimeKind.Local).AddTicks(8093) });

            migrationBuilder.UpdateData(
                table: "Retailers",
                keyColumn: "Id",
                keyValue: new Guid("943ba50f-41c5-4881-9a97-7e4de399836d"),
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 5, 19, 10, 25, 24, 355, DateTimeKind.Local).AddTicks(6584), new DateTime(2021, 5, 19, 10, 25, 24, 355, DateTimeKind.Local).AddTicks(6604) });
        }
    }
}
