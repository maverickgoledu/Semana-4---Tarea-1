using Microsoft.EntityFrameworkCore;
using Preguntas.Models;

namespace Preguntas.Data
{
    // Clase que representa el contexto de la base de datos para la aplicación.
    // Hereda de DbContext, que es parte de Entity Framework Core.
    public class ApplicationDbContext : DbContext
    {
        // Constructor que recibe opciones de configuración para el contexto.
        // Estas opciones son pasadas a la clase base DbContext.
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // DbSet que representa la colección de preguntas en la base de datos.
        // Esto permite realizar operaciones CRUD (Crear, Leer, Actualizar, Eliminar) sobre las preguntas.
        public DbSet<Pregunta> Preguntas { get; set; }
    }
}
