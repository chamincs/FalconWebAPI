using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Falcon.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Initial2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_weatherType",
                table: "weatherType");

            migrationBuilder.RenameTable(
                name: "weatherType",
                newName: "WeatherType");

            migrationBuilder.AddPrimaryKey(
                name: "PK_WeatherType",
                table: "WeatherType",
                column: "WeatherTypeId");

            migrationBuilder.CreateTable(
                name: "WeatherEvents",
                columns: table => new
                {
                    WeatherEventId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WeatherEventName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CountryId = table.Column<int>(type: "int", nullable: true),
                    WeatherTypeId = table.Column<int>(type: "int", nullable: true),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeatherEvents", x => x.WeatherEventId);
                    table.ForeignKey(
                        name: "FK_WeatherEvents_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "CountryId");
                    table.ForeignKey(
                        name: "FK_WeatherEvents_WeatherType_WeatherTypeId",
                        column: x => x.WeatherTypeId,
                        principalTable: "WeatherType",
                        principalColumn: "WeatherTypeId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_WeatherEvents_CountryId",
                table: "WeatherEvents",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_WeatherEvents_WeatherTypeId",
                table: "WeatherEvents",
                column: "WeatherTypeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WeatherEvents");

            migrationBuilder.DropPrimaryKey(
                name: "PK_WeatherType",
                table: "WeatherType");

            migrationBuilder.RenameTable(
                name: "WeatherType",
                newName: "weatherType");

            migrationBuilder.AddPrimaryKey(
                name: "PK_weatherType",
                table: "weatherType",
                column: "WeatherTypeId");
        }
    }
}
