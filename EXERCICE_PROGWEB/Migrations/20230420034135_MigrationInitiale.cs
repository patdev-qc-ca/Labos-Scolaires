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
       name: "ServeurMail",
       columns: table => new
       {
            ServeurID= table.Column<int>(type: "int", nullable: false).Annotation("SqlServer:Identity", "1, 1"),
            MailID = table.Column<int>(type: "int", nullable: false),
            RecuDe = table.Column<int>(type: "int", nullable: false),
            EnvoyeA = table.Column<int>(type: "int", nullable: false)
       },
       constraints: table =>
       {
           table.PrimaryKey("ServeurID", x => x.ServeurID);
       }); 

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(name: "ServeurMail");

        }
    }
}

/*using Exercice_ProgWeb31
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Exercice_ProgWeb31.Migrations
{
    /// <inheritdoc />
    public partial class MigrationInitiale : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
       
 
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
        }
    }
}
*/