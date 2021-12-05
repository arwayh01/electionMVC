using Microsoft.EntityFrameworkCore.Migrations;

namespace ELECTION.Migrations
{
    public partial class m3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CinAdmin",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MotDePasse",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NomAdmin",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PrenomAdmin",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CinAdmin",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "MotDePasse",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "NomAdmin",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "PrenomAdmin",
                table: "AspNetUsers");
        }
    }
}
