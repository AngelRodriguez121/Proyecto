using Microsoft.EntityFrameworkCore;
using Proyecto.Data.Contexts;
using Proyecto.Interfaces;
using Proyecto.Modelos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Proyecto.Data.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly LibraryDbContext _context;

        public ClienteRepository(LibraryDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Cliente>> GetAll()
        {
            return await _context.Clientes.ToListAsync();
        }

        public async Task<Cliente> Get(int id)
        {
            return await _context.Clientes.FindAsync(id);
        }

        public async Task Add(Cliente cliente)
        {
            await _context.Clientes.AddAsync(cliente);
            await _context.SaveChangesAsync();
        }

        public async Task Update(Cliente cliente)
        {
            _context.Clientes.Update(cliente);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var cliente = await _context.Clientes.FindAsync(id);
            if (cliente != null)
            {
                _context.Clientes.Remove(cliente);
                await _context.SaveChangesAsync();
            }
        }
    }
}
