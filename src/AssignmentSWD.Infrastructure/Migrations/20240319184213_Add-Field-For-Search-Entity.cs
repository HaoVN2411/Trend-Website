using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AssignmentSWD.Infrastructure.Migrations
{
    public partial class AddFieldForSearchEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Count",
                table: "Search",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "month",
                table: "Search",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "year",
                table: "Search",
                type: "int",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "month",
                table: "Search");

            migrationBuilder.DropColumn(
                name: "year",
                table: "Search");

            migrationBuilder.AlterColumn<int>(
                name: "Count",
                table: "Search",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);
        }
    }
}
