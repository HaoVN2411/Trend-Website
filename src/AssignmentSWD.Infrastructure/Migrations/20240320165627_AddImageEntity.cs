using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AssignmentSWD.Infrastructure.Migrations
{
    public partial class AddImageEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AuthorId",
                table: "Trend",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "TrendImage",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TrendId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageNote = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LastUpdatedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeletedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrendImage", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TrendImage_Trend_TrendId",
                        column: x => x.TrendId,
                        principalTable: "Trend",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Trend_AuthorId",
                table: "Trend",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_TrendImage_TrendId",
                table: "TrendImage",
                column: "TrendId");

            migrationBuilder.AddForeignKey(
                name: "FK_Trend_User_AuthorId",
                table: "Trend",
                column: "AuthorId",
                principalTable: "User",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Trend_User_AuthorId",
                table: "Trend");

            migrationBuilder.DropTable(
                name: "TrendImage");

            migrationBuilder.DropIndex(
                name: "IX_Trend_AuthorId",
                table: "Trend");

            migrationBuilder.DropColumn(
                name: "AuthorId",
                table: "Trend");
        }
    }
}
