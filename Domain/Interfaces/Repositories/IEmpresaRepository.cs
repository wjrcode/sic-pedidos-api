using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Repositories
{
    public interface IEmpresaRepository
    {
        Task<Empresa> GetByIdAsync(long id);
        Task<IEnumerable<Empresa>> GetAllAsync();
        Task AddAsync(Empresa empresa);
        Task UpdateAsync(Empresa empresa);
        Task DeleteAsync(Empresa empresa);
        Task<bool> ExisteCpfCnpjAsync(string cpfCnpj);
    }
}
