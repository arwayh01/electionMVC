using Microsoft.EntityFrameworkCore.Migrations;

namespace ELECTION.Migrations
{
    public partial class ELECTIONDBnew : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Administrateurs",
                columns: table => new
                {
                    AdministrateurId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nom_admin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    prenom_admin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cin_admin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    mot_de_passe = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Administrateurs", x => x.AdministrateurId);
                });

            migrationBuilder.CreateTable(
                name: "Candidats",
                columns: table => new
                {
                    candidatId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nom_candidat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    prenom_candidat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cin_candidat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image_candidat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdministrateurId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Candidats", x => x.candidatId);
                    table.ForeignKey(
                        name: "FK_Candidats_Administrateurs_AdministrateurId",
                        column: x => x.AdministrateurId,
                        principalTable: "Administrateurs",
                        principalColumn: "AdministrateurId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CentreElections",
                columns: table => new
                {
                    centreElectionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    libelle_centre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    adresse_centre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdministrateurId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CentreElections", x => x.centreElectionId);
                    table.ForeignKey(
                        name: "FK_CentreElections_Administrateurs_AdministrateurId",
                        column: x => x.AdministrateurId,
                        principalTable: "Administrateurs",
                        principalColumn: "AdministrateurId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Electeurs",
                columns: table => new
                {
                    electeurId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nom_electeur = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    prenom_electeur = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cin_electeur = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    genre_electeur = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    centreElectionId = table.Column<int>(type: "int", nullable: true),
                    CondidatcandidatId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Electeurs", x => x.electeurId);
                    table.ForeignKey(
                        name: "FK_Electeurs_Candidats_CondidatcandidatId",
                        column: x => x.CondidatcandidatId,
                        principalTable: "Candidats",
                        principalColumn: "candidatId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Electeurs_CentreElections_centreElectionId",
                        column: x => x.centreElectionId,
                        principalTable: "CentreElections",
                        principalColumn: "centreElectionId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Candidats_AdministrateurId",
                table: "Candidats",
                column: "AdministrateurId");

            migrationBuilder.CreateIndex(
                name: "IX_CentreElections_AdministrateurId",
                table: "CentreElections",
                column: "AdministrateurId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Electeurs_centreElectionId",
                table: "Electeurs",
                column: "centreElectionId");

            migrationBuilder.CreateIndex(
                name: "IX_Electeurs_CondidatcandidatId",
                table: "Electeurs",
                column: "CondidatcandidatId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Electeurs");

            migrationBuilder.DropTable(
                name: "Candidats");

            migrationBuilder.DropTable(
                name: "CentreElections");

            migrationBuilder.DropTable(
                name: "Administrateurs");
        }
    }
}
