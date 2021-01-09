using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace ProyectoProgra.Data.Migrations
{
    public partial class KeyChangeOrdenDetail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_t_OrdenDetail",
                table: "t_OrdenDetail");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "t_OrdenDetail",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AddColumn<int>(
                name: "id",
                table: "t_OrdenDetail",
                nullable: false,
                defaultValue: 0)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_t_OrdenDetail",
                table: "t_OrdenDetail",
                column: "id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_t_OrdenDetail",
                table: "t_OrdenDetail");

            migrationBuilder.DropColumn(
                name: "id",
                table: "t_OrdenDetail");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "t_OrdenDetail",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_t_OrdenDetail",
                table: "t_OrdenDetail",
                column: "Email");
        }
    }
}
