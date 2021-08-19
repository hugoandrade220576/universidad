using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using universidad.Models;

namespace universidad.Data
{
    public class ApplicationDbContext : DbContext

    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Estudiante> Estudiante { get; set; }
        public DbSet<Docente> Docente { get; set; }

        public DbSet<Carreras> Carreras { get; set; }
    }
}
