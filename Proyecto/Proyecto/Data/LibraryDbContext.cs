using Microsoft.EntityFrameworkCore;
using Proyecto.Modelos;
namespace Proyecto.Data.Contexts
{
    public class LibraryDbContext : DbContext
    {
        public LibraryDbContext(DbContextOptions<LibraryDbContext> options) : base(options)
     {}

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Libro> Libros { get; set; }
        public DbSet<SinDevolver> SinDevolvers  { get; set; }
        public DbSet<Historial> Historiales { get; set; }
    }
}