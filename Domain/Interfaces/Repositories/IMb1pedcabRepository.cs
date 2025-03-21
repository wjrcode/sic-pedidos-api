using Domain.Entities;

namespace Domain.Interfaces.Repositories
{
    public interface IMb1pedcabRepository
    {
        Task<Mb1pedcab> GetByIdAsync(long id);
        Task<IEnumerable<Mb1pedcab>> GetAllAsync();
        Task AddAsync(Mb1pedcab mb1pedcab);
        Task UpdateAsync(Mb1pedcab mb1pedcab);
        Task DeleteAsync(long id);
    }
}
