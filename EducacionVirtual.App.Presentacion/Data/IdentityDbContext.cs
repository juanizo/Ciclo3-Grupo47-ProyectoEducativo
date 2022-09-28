using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EducacionVirtual.App.Presentacion.Areas.Identity.Data;

    public class IdentityDbContext : DbContext
    {
        public IdentityDbContext (DbContextOptions<IdentityDbContext> options)
            : base(options)
        {
        }

        public DbSet<EducacionVirtual.App.Presentacion.Areas.Identity.Data.Usuario> Usuario { get; set; }
    }
