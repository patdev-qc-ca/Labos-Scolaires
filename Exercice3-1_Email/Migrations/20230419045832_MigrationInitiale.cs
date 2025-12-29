using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Exercice31_Email.Migrations
{
    /// <inheritdoc />
    public partial class MigrationInitiale : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            _ = migrationBuilder.CreateTable(
         name: "ServeurMail",
         columns: table => new
         {
             ServeurID = table.Column<int>(type: "int", nullable: false).Annotation("SqlServer:Identity", "1, 1"),
             MailID = table.Column<int>(type: "int", nullable: false),
             RecuDe = table.Column<int>(type: "int", nullable: false),
             EnvoyeA = table.Column<int>(type: "int", nullable: false)
         },
         constraints: table =>
         {
             _ = table.PrimaryKey("ServeurMail", x => x.ServeurID);
         });


        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(  name: "Ordinateur");

        }
    }
}
