using Microsoft.EntityFrameworkCore;
using Proyecto.Data.Contexts;
using Proyecto.Interfaces;
using Proyecto.Modelos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Proyecto.Data.Repositories
{
    public class HistorialRepository : IHistorialRepository
    {
        private readonly LibraryDbContext _context;

        public HistorialRepository(LibraryDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Historial>> GetAllHistorialesAsync()
        {
            return await _context.Historiales.ToListAsync();
        }

        public async Task<Historial> GetHistorialByIdAsync(int id)
        {
            return await _context.Historiales.FindAsync(id);
        }

        public async Task AddHistorialAsync(Historial historial)
        {
            await _context.Historiales.AddAsync(historial);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateHistorialAsync(Historial historial)
        {
            _context.Historiales.Update(historial);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteHistorialAsync(int id)
        {
            var historial = await _context.Historiales.FindAsync(id);
            if (historial != null)
            {
                _context.Historiales.Remove(historial);
                await _context.SaveChangesAsync();
            }
        }
    }
}
