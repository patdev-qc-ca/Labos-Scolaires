using Exercice_ProgWeb31.Models;
using Microsoft.EntityFrameworkCore;

namespace Exercice_ProgWeb31
{
    public class ApplicationContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            _ = optionsBuilder.UseSqlServer("Data Source=" + Environment.MachineName + "\\SQLEXPRESS;Initial Catalog="
                + "3-1" //nom de la base de donner a creer
                + ";Integrated Security=True;TrustServerCertificate=Yes");
        }

        DbSet<Email> Emails { get; set; }
        DbSet<Utilisateurs> Utilisateurs { get; set; }
        DbSet<ServeurMail> serveurMail { get; set; }
    }
}
