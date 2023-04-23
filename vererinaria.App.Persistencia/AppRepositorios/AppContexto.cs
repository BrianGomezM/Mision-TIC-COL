using System;
using Microsoft.EntityFrameworkCore;
using veterinaria.App.Dominio;
namespace veterinaria.App.Persistencia {
    public class AppContexto : DbContext  {
        public DbSet<Persona> Personas {get;set;}
        public DbSet<Gato> Gatos { get; set; }
        public DbSet<Propietario> Propietarios { get; set; }
        public DbSet<Veterinario> Veterinarios { get; set; }
        public DbSet<Visita> Visitas { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
            if(!optionsBuilder.IsConfigured){
                optionsBuilder.UseSqlServer("Data source = (localdb)\\MSSQLLocalDB; Initial Catalog = veterinariaData");
            }
        }
    }
}