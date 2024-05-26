using Microsoft.EntityFrameworkCore;
using Proyecto.Data.Contexts;
using Proyecto.Interfaces;
using Proyecto.Modelos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Proyecto.Data.Repositories
{
    public class LibroRepository : ILibroRepository
    {
        private readonly LibraryDbContext _context;

        public LibroRepository(LibraryDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Libro>> GetAllLibrosAsync()
        {
            return await _context.Libros.ToListAsync();
        }

        public async Task<Libro> GetLibroByIdAsync(int id)
        {
            return await _context.Libros.FindAsync(id);
        }

        public async Task AddLibroAsync(Libro libro)
        {
            await _context.Libros.AddAsync(libro);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateLibroAsync(Libro libro)
        {
            _context.Libros.Update(libro);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteLibroAsync(int id)
        {
            var libro = await _context.Libros.FindAsync(id);
            if (libro != null)
            {
                _context.Libros.Remove(libro);
                await _context.SaveChangesAsync();
            }
        }
    }
}
