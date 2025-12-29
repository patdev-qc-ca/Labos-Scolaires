using DemoOrdinateur.Models;
using Microsoft.EntityFrameworkCore;

namespace DemoOrdinateur
{
    public class ApplicationContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //methode qui marche en utilisant le nom de l'ordi pour se connecter au ServeurSQL
            _ = optionsBuilder.UseSqlServer("Data Source=" + Environment.MachineName + "\\SQLEXPRESS;Initial Catalog="
                + "BaseDonneeOrdi" //nom de la base de donner a creer
                + ";Integrated Security=True;TrustServerCertificate=Yes");
        }

        DbSet<Ordinateur> Ordinateur { get; set; }
    }
}
