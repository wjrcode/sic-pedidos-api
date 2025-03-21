using Domain.Entities;

namespace Application.Interfaces.Repositories
{
    public interface IProdutoRepository
    {
        Task<Produtos> GetByIdAsync(long id);
        Task<IEnumerable<Produtos>> GetAllAsync();
        Task AddAsync(Produtos produto);
        Task UpdateAsync(Produtos produto);
        Task DeleteAsync(long id);
    }
}
