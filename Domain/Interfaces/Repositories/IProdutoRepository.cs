using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Repositories
{
    public interface IProdutoRepository
    {
        Task<Produto> GetByIdAsync(long id);
        Task<IEnumerable<Produto>> GetAllAsync();
        Task AddAsync(Produto produto);
        Task UpdateAsync(Produto produto);
        Task DeleteAsync(long id);
    }
}
