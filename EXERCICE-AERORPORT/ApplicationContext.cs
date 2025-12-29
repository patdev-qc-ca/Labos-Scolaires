using Exercice1_Aerorport.Models;
using Microsoft.EntityFrameworkCore;
public  class ApplicationContext:DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=PETU-STI-35\\SQLEXPRESS;Initial Catalog=EXercice1Aeroroport;Integrated Security=True;TrustServerCertificate=Yes");
    }

    public DbSet<Aeroport> aeroports { get; set; }
    public DbSet<Pays> mPays  {get; set; }
    public DbSet<Passager> passagers { get; set; }
}