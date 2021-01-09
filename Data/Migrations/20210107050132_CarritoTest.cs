using Microsoft.EntityFrameworkCore.Migrations;

namespace ProyectoProgra.Data.Migrations
{
    public partial class CarritoTest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "t_OrdenDetail",
                columns: table => new
                {
                    Email = table.Column<string>(nullable: false),
                    producto = table.Column<int>(nullable: false),
                    quantity = table.Column<int>(nullable: false),
                    price = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t_OrdenDetail", x => x.Email);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "t_OrdenDetail");
        }
    }
}
