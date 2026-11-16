using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

#nullable disable

namespace lab_01_e04_pokeapi_api.Migrations
{
    /// <inheritdoc />
    public partial class Users : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Utilisateurs",
                columns: table => new
                {
                    IdUtilisateur = table.Column<string>(type: "varchar(255)", nullable: false),
                    Email = table.Column<string>(type: "longtext", nullable: false),
                    MotDePasse = table.Column<string>(type: "longtext", nullable: false),
                    Pseudo = table.Column<string>(type: "longtext", nullable: false),
                    DateInscription = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Utilisateurs", x => x.IdUtilisateur);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Personnages",
                columns: table => new
                {
                    IdPersonnage = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Nom = table.Column<string>(type: "longtext", nullable: false),
                    Niveau = table.Column<int>(type: "int", nullable: false),
                    PointsDeVie = table.Column<int>(type: "int", nullable: false),
                    PointDeVieMax = table.Column<int>(type: "int", nullable: false),
                    Force = table.Column<int>(type: "int", nullable: false),
                    Defense = table.Column<int>(type: "int", nullable: false),
                    PositionX = table.Column<int>(type: "int", nullable: false),
                    PositionY = table.Column<int>(type: "int", nullable: false),
                    UtilisateurIdIdUtilisateur = table.Column<string>(type: "varchar(255)", nullable: false),
                    DateCreation = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personnages", x => x.IdPersonnage);
                    table.ForeignKey(
                        name: "FK_Personnages_Utilisateurs_UtilisateurIdIdUtilisateur",
                        column: x => x.UtilisateurIdIdUtilisateur,
                        principalTable: "Utilisateurs",
                        principalColumn: "IdUtilisateur",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Personnages_UtilisateurIdIdUtilisateur",
                table: "Personnages",
                column: "UtilisateurIdIdUtilisateur");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Personnages");

            migrationBuilder.DropTable(
                name: "Utilisateurs");
        }
    }
}
