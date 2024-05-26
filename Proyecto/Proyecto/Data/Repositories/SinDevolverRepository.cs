using Microsoft.EntityFrameworkCore;
using Proyecto.Data.Contexts;
using Proyecto.Interfaces;
using Proyecto.Modelos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Proyecto.Data.Repositories
{
    public class SinDevolverRepository : ISinDevolverRepository
    {
        private readonly LibraryDbContext _context;

        public SinDevolverRepository(LibraryDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<SinDevolver>> GetAllSinDevolversAsync()
        {
            return await _context.SinDevolvers.ToListAsync();
        }

        public async Task<SinDevolver> GetSinDevolverByIdAsync(int id)
        {
            return await _context.SinDevolvers.FindAsync(id);
        }

        public async Task AddSinDevolverAsync(SinDevolver sinDevolver)
        {
            await _context.SinDevolvers.AddAsync(sinDevolver);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateSinDevolverAsync(SinDevolver sinDevolver)
        {
            _context.SinDevolvers.Update(sinDevolver);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteSinDevolverAsync(int id)
        {
            var sinDevolver = await _context.SinDevolvers.FindAsync(id);
            if (sinDevolver != null)
            {
                _context.SinDevolvers.Remove(sinDevolver);
                await _context.SaveChangesAsync();
            }
        }
    }
}
