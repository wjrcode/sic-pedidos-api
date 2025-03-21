using Domain.Entities;

namespace Domain.Interfaces.Repositories
{
    public interface IItemRepository
    {
        Task<Mb2peditens> GetByIdAsync(long id);
        Task<IEnumerable<Mb2peditens>> GetAllAsync();
        Task AddAsync(Mb2peditens mb2peditens);
        Task UpdateAsync(Mb2peditens mb2peditens);
        Task DeleteAsync(long id);
    }
}
