using Proyecto.Modelos;

namespace Proyecto.Interfaces
{
    public interface IHistorialRepository
    {
        Task<IEnumerable<Historial>> GetAllHistorialesAsync();
        Task<Historial> GetHistorialByIdAsync(int id);
        Task AddHistorialAsync(Historial historial);
        Task UpdateHistorialAsync(Historial historial);
        Task DeleteHistorialAsync(int id);
    }
}
