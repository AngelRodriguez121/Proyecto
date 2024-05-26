using Proyecto.Modelos;

namespace Proyecto.Interfaces
{
    public interface ISinDevolverRepository
    {
        Task<IEnumerable<SinDevolver>> GetAllSinDevolversAsync();
        Task<SinDevolver> GetSinDevolverByIdAsync(int id);
        Task AddSinDevolverAsync(SinDevolver sinDevolver);
        Task UpdateSinDevolverAsync(SinDevolver sinDevolver);
        Task DeleteSinDevolverAsync(int id);
    }
}
