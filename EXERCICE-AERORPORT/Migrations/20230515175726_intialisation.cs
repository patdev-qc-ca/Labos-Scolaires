using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Exercice1_Aerorport.Migrations
{
    /// <inheritdoc />
    public partial class intialisation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "aeroports",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    IdPays = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_aeroports", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "mPays",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    Nom = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mPays", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "passagers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Prenom = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    CodePostal = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Numero = table.Column<int>(type: "int", nullable: false),
                    Rue = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Localitee = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    numPassport = table.Column<string>(type: "nvarchar(14)", maxLength: 14, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_passagers", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "aeroports");

            migrationBuilder.DropTable(
                name: "mPays");

            migrationBuilder.DropTable(
                name: "passagers");
        }
    }
}
