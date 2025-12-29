using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DemoOrdinateur.Migrations
{
    /// <inheritdoc />
    public partial class MigrationInitiale : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
    name: "Ordinateur",
    columns: table => new
    {
        Id = table.Column<int>(type: "int", nullable: false)
        .Annotation("SqlServer:Identity", "1, 1"),
        Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
        Processeur  = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
        Marque  = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
        Generation = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
        CarteMere = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
        Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
  },
    constraints: table =>
    {
        table.PrimaryKey("PK_Ordinateur", x => x.Id);
    });

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(  name: "Ordinateur");

        }
    }
}
