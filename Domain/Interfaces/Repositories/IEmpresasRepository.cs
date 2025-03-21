using Domain.Entities;

namespace Domain.Interfaces.Repositories
{
    public interface IEmpresasRepository
    {
        Task<Empresas> GetByIdAsync(long id);
        Task<IEnumerable<Empresas>> GetAllAsync();
        Task AddAsync(Empresas empresa);
        Task UpdateAsync(Empresas empresa);
        Task DeleteAsync(Empresas empresa);
        Task<bool> ExisteCpfCnpjAsync(string cpfCnpj);
    }
}
