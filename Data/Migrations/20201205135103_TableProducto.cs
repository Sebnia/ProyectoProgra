using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace ProyectoProgra.Data.Migrations
{
    public partial class TableProducto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Password",
                table: "t_contacto");

            migrationBuilder.DropColumn(
                name: "VerifiedPassword",
                table: "t_contacto");

            migrationBuilder.DropColumn(
                name: "spam",
                table: "t_contacto");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "t_contacto",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Lastname",
                table: "t_contacto",
                newName: "lastname");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "t_contacto",
                newName: "email");

            migrationBuilder.RenameColumn(
                name: "District",
                table: "t_contacto",
                newName: "district");

            migrationBuilder.AddColumn<string>(
                name: "message",
                table: "t_contacto",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "phone",
                table: "t_contacto",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "subject",
                table: "t_contacto",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "t_producto",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    idProduct = table.Column<string>(nullable: true),
                    nameProduct = table.Column<string>(nullable: true),
                    priceProduct = table.Column<double>(nullable: false),
                    describeProduct = table.Column<string>(nullable: true),
                    specifyProduct = table.Column<string>(nullable: true),
                    category = table.Column<string>(nullable: true),
                    Response = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t_producto", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "t_producto");

            migrationBuilder.DropColumn(
                name: "message",
                table: "t_contacto");

            migrationBuilder.DropColumn(
                name: "phone",
                table: "t_contacto");

            migrationBuilder.DropColumn(
                name: "subject",
                table: "t_contacto");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "t_contacto",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "lastname",
                table: "t_contacto",
                newName: "Lastname");

            migrationBuilder.RenameColumn(
                name: "email",
                table: "t_contacto",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "district",
                table: "t_contacto",
                newName: "District");

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "t_contacto",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "VerifiedPassword",
                table: "t_contacto",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "spam",
                table: "t_contacto",
                type: "boolean",
                nullable: false,
                defaultValue: false);
        }
    }
}
