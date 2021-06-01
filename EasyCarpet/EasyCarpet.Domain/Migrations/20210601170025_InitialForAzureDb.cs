﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EasyCarpet.Domain.Migrations
{
    public partial class InitialForAzureDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Carpet",
                keyColumn: "Id",
                keyValue: new Guid("9cf37a50-a08f-4ed6-9505-2cb18af43605"),
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 1, 13, 0, 24, 529, DateTimeKind.Local).AddTicks(7410), new DateTime(2021, 6, 1, 13, 0, 24, 533, DateTimeKind.Local).AddTicks(2349) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("14999486-bc73-4651-be18-fa308608831d"),
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 1, 13, 0, 24, 536, DateTimeKind.Local).AddTicks(8100), new DateTime(2021, 6, 1, 13, 0, 24, 536, DateTimeKind.Local).AddTicks(8113) });

            migrationBuilder.UpdateData(
                table: "Installers",
                keyColumn: "Id",
                keyValue: new Guid("ebb89a92-dd6a-43ef-9301-3a58c479120a"),
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 1, 13, 0, 24, 536, DateTimeKind.Local).AddTicks(4799), new DateTime(2021, 6, 1, 13, 0, 24, 536, DateTimeKind.Local).AddTicks(4817) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("6ea4eafb-0b96-40e3-ab04-da5db6195a17"),
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 1, 13, 0, 24, 537, DateTimeKind.Local).AddTicks(1391), new DateTime(2021, 6, 1, 13, 0, 24, 537, DateTimeKind.Local).AddTicks(1404) });

            migrationBuilder.UpdateData(
                table: "Retailers",
                keyColumn: "Id",
                keyValue: new Guid("943ba50f-41c5-4881-9a97-7e4de399836d"),
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 1, 13, 0, 24, 535, DateTimeKind.Local).AddTicks(8598), new DateTime(2021, 6, 1, 13, 0, 24, 535, DateTimeKind.Local).AddTicks(8658) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Carpet",
                keyColumn: "Id",
                keyValue: new Guid("9cf37a50-a08f-4ed6-9505-2cb18af43605"),
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 5, 28, 16, 0, 54, 445, DateTimeKind.Local).AddTicks(1957), new DateTime(2021, 5, 28, 16, 0, 54, 447, DateTimeKind.Local).AddTicks(9083) });

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
    }
}
