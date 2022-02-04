using Microsoft.EntityFrameworkCore.Migrations;

namespace CityBusManagement.DAL.Migrations
{
    public partial class RouteDetailsModelCreation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "routedetails",
                columns: table => new
                {
                    routeNo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    source = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    destination = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_routedetails", x => x.routeNo);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "routedetails");
        }
    }
}
