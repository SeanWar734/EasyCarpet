using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EasyCarpet.Domain.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Carpet",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Width = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Length = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SquareYardPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Brand = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Style = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carpet", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Carpet",
                columns: new[] { "Id", "Brand", "CreatedDate", "Description", "Image", "Length", "ModifiedDate", "Name", "SquareYardPrice", "Style", "Width" },
                values: new object[] { new Guid("9cf37a50-a08f-4ed6-9505-2cb18af43605"), "Traffic Master", new DateTime(2021, 5, 13, 8, 14, 32, 68, DateTimeKind.Local).AddTicks(571), "Medium Beige / Dark Beige flecks, indoor residential", "TrafficMasterBrown.jpg", 200m, new DateTime(2021, 5, 13, 8, 14, 32, 70, DateTimeKind.Local).AddTicks(6417), "TrafficMaster: Brown", 5.89m, "Plush", 12m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Carpet");
        }
    }
}
