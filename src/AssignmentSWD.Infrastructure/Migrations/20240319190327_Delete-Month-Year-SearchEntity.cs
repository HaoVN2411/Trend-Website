using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AssignmentSWD.Infrastructure.Migrations
{
    public partial class DeleteMonthYearSearchEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "month",
                table: "Search");

            migrationBuilder.DropColumn(
                name: "year",
                table: "Search");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
