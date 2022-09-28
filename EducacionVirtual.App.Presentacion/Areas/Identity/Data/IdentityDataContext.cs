using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EducacionVirtual.App.Presentacion.Areas.Identity.Data
{
    public class IdentityDataContext : IdentityDbContext<Usuario>
    {
        public IdentityDataContext(DbContextOptions<IdentityDataContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
           
           builder.Entity<Usuario>(entityTypeBuilder =>
           {
            entityTypeBuilder.ToTable("Usuario");

            entityTypeBuilder.Property(u => u.Nombre)
                .HasMaxLength(450);

              entityTypeBuilder.Property(u => u.Apellidos)
                .HasMaxLength(450);

              entityTypeBuilder.Property(u => u.Edad)
                .HasMaxLength(450);
            
              entityTypeBuilder.Property(u => u.Telefono)
                .HasMaxLength(450);
            
              entityTypeBuilder.Property(u => u.Direccion)
                .HasMaxLength(450);

                  entityTypeBuilder.Property(u => u.Type)
                .HasMaxLength(450);


              entityTypeBuilder.Property(u => u.CodigoM)
                .HasMaxLength(450);
           });
        }
    }

    public class Usuario : IdentityUser
    {
        
        public string Nombre{get;set;}
        public string Apellidos{get;set;}
        public string Edad{get;set;}
        public string Telefono{get;set;}
        public string Direccion{get;set;}
        public string Type{get;set;}
        public string CodigoM{get;set;}
    }
}
