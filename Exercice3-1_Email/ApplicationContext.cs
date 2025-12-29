using Exercice_ProgWeb31.Models;
using Exercice31_Email.Models;
using Microsoft.EntityFrameworkCore;

namespace Exercice31_Email
{
    public class ApplicationContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //methode qui marche en utilisant le nom de l'ordi pour se connecter au ServeurSQL
            _ = optionsBuilder.UseSqlServer("Data Source=" + Environment.MachineName + "\\SQLEXPRESS;Initial Catalog="
                + "3-1" //nom de la base de donner a creer
                + ";Integrated Security=True;TrustServerCertificate=Yes");
        }

        DbSet<Email> Emails { get; set; }
        DbSet<Utilisateurs> Utilisateurs { get; set; }
        DbSet<ServeurMail> serveurMail { get; set; }
    }
}
