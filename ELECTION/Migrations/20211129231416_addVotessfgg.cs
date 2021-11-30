using Microsoft.EntityFrameworkCore.Migrations;

namespace ELECTION.Migrations
{
    public partial class addVotessfgg : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameIndex(
                name: "IX_Electeur_ElecteurId",
                table: "Votes",
                newName: "IX_Electeurs_ElecteurId");

            migrationBuilder.AddColumn<int>(
                name: "VoteId",
                table: "Electeurs",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Votes_VoteId",
                table: "Electeurs",
                column: "VoteId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Votes_VoteId",
                table: "Electeurs");

            migrationBuilder.DropColumn(
                name: "VoteId",
                table: "Electeurs");

            migrationBuilder.RenameIndex(
                name: "IX_Electeurs_ElecteurId",
                table: "Votes",
                newName: "IX_Electeur_ElecteurId");
        }
    }
}
