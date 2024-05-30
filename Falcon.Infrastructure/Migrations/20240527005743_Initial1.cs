using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Falcon.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Initial1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "weatherType",
                columns: table => new
                {
                    WeatherTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WeatherTypeCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WeatherTypeName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_weatherType", x => x.WeatherTypeId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "weatherType");
        }
    }
}
