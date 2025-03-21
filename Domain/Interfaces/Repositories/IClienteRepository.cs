using Domain.Entities;

namespace Domain.Interfaces.Repositories
{
    public interface IClienteRepository
    {
        Task<Clientes> GetByIdAsync(long id);
        Task<IEnumerable<Clientes>> GetAllAsync();
        Task AddAsync(Clientes cliente);
        Task UpdateAsync(Clientes cliente);
        Task DeleteAsync(Clientes cliente);
    }
}
