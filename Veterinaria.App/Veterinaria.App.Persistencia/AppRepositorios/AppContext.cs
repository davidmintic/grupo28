using Microsoft.EntityFrameworkCore;
using Veterinaria.App.Dominio;
namespace Veterinaria.App.Persistencia
{

    public class AppContext: DbContext{

        public DbSet<Persona> Personas {get; set;}
        public DbSet<Veterinario> Veterinarios {get; set;}
        public DbSet<Cuidador> Cuidadores {get; set;}
        public DbSet<Mascota> Mascotas {get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {

                if(!optionsBuilder.IsConfigured) {
                    optionsBuilder.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog =VeterinariaGrupoG28");
                }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<Mascota>().HasOne(c => c.Cuidador).WithMany(m => m.Mascotas).IsRequired();
        }

        

    }
    
}