using Proyecto.Modelos;

namespace Proyecto.Interfaces
{
    public interface ILibroRepository
    {
        Task<IEnumerable<Libro>> GetAllLibrosAsync();
        Task<Libro> GetLibroByIdAsync(int id);
        Task AddLibroAsync(Libro libro);
        Task UpdateLibroAsync(Libro libro);
        Task DeleteLibroAsync(int id);
    }
}
