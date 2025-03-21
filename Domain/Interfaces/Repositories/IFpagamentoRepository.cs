using Domain.Entities;

namespace Domain.Interfaces.Repositories
{
    public interface IFpagamentoRepository
    {
        Task<Fpagamentos> GetByIdAsync(long id);
        Task<IEnumerable<Fpagamentos>> GetAllAsync();
        Task AddAsync(Fpagamentos fpagamento);
        Task UpdateAsync(Fpagamentos fpagamento);
        Task DeleteAsync(long id);
    }
}
