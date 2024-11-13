using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class BoleteriaContext : DbContext
    {
        public DbSet<Pasajero> Pasajeros { get; set; }
      //  public DbSet<PasajeroEstudiante> PasajeroEstudiantes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer($"Data Source=(localdb)\\MSSQLLocalDB; Initial Catalog=EjercicioBoleto");
        }
        protected override void OnModelCreating(ModelBuilder model)
        {
           // model.Entity<Colectivo>().HasKey(z => z.Id);
            model.Entity<Pasajero>().HasKey(x => x.Id);
            model.Entity<PasajeroEstudiante>().ToTable(nameof(PasajeroEstudiante));
            model.Entity<Colectivo>().HasKey (x => x.Id);
            model.Entity<Colectivo>().HasIndex(x => x.Patente).IsUnique();
            model.Entity<Colectivo>().HasMany(x => x.Pasajeros);
            base.OnModelCreating(model);
        }
    }
}
