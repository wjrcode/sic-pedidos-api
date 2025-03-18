using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Repositories
{
    public interface IFpagamentoRepository
    {
        Task<Fpagamento> GetByIdAsync(long id);
        Task<IEnumerable<Fpagamento>> GetAllAsync();
        Task AddAsync(Fpagamento fpagamento);
        Task UpdateAsync(Fpagamento fpagamento);
        Task DeleteAsync(long id);
    }
}
