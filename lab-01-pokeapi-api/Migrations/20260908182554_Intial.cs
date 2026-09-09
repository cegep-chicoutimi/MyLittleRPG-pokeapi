using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

#nullable disable

namespace lab_01_pokeapi_api.Migrations
{
    /// <inheritdoc />
    public partial class Intial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Monstre",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Nom = table.Column<string>(type: "longtext", nullable: false),
                    PointDeVieBase = table.Column<int>(type: "int", nullable: false),
                    ForceBase = table.Column<int>(type: "int", nullable: false),
                    DefenseBase = table.Column<int>(type: "int", nullable: false),
                    ExperienceBase = table.Column<int>(type: "int", nullable: false),
                    SpriteUrl = table.Column<string>(type: "longtext", nullable: false),
                    Type1 = table.Column<string>(type: "longtext", nullable: false),
                    Type2 = table.Column<string>(type: "longtext", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Monstre", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Monstre");
        }
    }
}
