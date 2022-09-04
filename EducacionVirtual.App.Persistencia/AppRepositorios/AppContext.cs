using Microsoft.EntityFrameworkCore;
using EducacionVirtual.App.Dominio;

namespace EducacionVirtual.App.Persistencia
{
    public class AppContext : DbContext
    {
        public DbSet<Persona> Personas {get; set;}
        public DbSet<Estudiante> Estudiantes{get; set;}
        public DbSet<Profesor> Profesores {get;set;}
        public DbSet<Materia> Materias {get;set;}
        public DbSet<Grado> Grado {get;set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
            if(!optionsBuilder.IsConfigured){
                optionsBuilder.UseSqlServer("Data Source =(localdb)\\MSSQLLocalDB; Initial Catalog = EducacionVirtual");
            }
        }
     }

}