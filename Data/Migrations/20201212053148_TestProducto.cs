using Microsoft.EntityFrameworkCore.Migrations;

namespace ProyectoProgra.Data.Migrations
{
    public partial class TestProducto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Response",
                table: "t_producto");

            migrationBuilder.AlterColumn<string>(
                name: "specifyProduct",
                table: "t_producto",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "nameProduct",
                table: "t_producto",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "describeProduct",
                table: "t_producto",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "category",
                table: "t_producto",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "rootImageProduct",
                table: "t_producto",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "rootImageProduct",
                table: "t_producto");

            migrationBuilder.AlterColumn<string>(
                name: "specifyProduct",
                table: "t_producto",
                type: "text",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "nameProduct",
                table: "t_producto",
                type: "text",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "describeProduct",
                table: "t_producto",
                type: "text",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "category",
                table: "t_producto",
                type: "text",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<string>(
                name: "Response",
                table: "t_producto",
                type: "text",
                nullable: true);
        }
    }
}
