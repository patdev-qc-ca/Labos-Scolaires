using Microsoft.EntityFrameworkCore;
using Laboratoire2.Models;
using Laboratoire2;
using Laboratoire2.Controllers;
using System;

namespace Laboratoire2
{
    public class ContexteApplication:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source="+Environment.MachineName+"\\SQLEXPRESS;Initial Catalog=Laboratoire2;Integrated Security=True;TrustServerCertificate=Yes;");
        }
        public DbSet<Clients> Clients { get; set; }
        public DbSet<Commande> Commandes { get; set; }
        public DbSet<Inventaire> Inventaires { get; set; }
        public DbSet<Paniers> Paniers { get; set; }
        public DbSet<Vetement> Vetements { get; set; }
        public DbSet<LigneCommande> LigneCommande { get; set; }
        public DbSet<LigneInventaire> LigneInventaire { get; set; }
    }
}
