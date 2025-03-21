using Domain.Entities;

namespace Application.Interfaces.Repositories
{
    interface ILjusuariosRepository
    {
        Task<Ljusuarios> GetByIdAsync(long id);
        Task<IEnumerable<Ljusuarios>> GetAllAsync();
        Task AddAsync(Ljusuarios usuario);
        Task UpdateAsync(Ljusuarios usuario);
        Task DeleteAsync(long id);
    }
}
