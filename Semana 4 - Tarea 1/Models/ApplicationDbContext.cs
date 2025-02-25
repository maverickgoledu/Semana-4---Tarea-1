using Microsoft.EntityFrameworkCore;
using Preguntas.Models;

namespace Preguntas.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Pregunta> Preguntas { get; set; }
    }
}

