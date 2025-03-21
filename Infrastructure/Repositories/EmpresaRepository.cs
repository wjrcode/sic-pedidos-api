using Domain.Interfaces.Repositories;
using Domain.Entities;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
namespace Infrastructure.Repositories
{
    public class EmpresaRepository : IEmpresasRepository
    {
        private readonly AppDbContext _context;

        public EmpresaRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Empresas> GetByIdAsync(long id)
        {
            return await _context.Empresas.FindAsync(id);
        }

        public async Task<IEnumerable<Empresas>> GetAllAsync()
        {
            return await _context.Empresas.ToListAsync();
        }

        public async Task AddAsync(Empresas empresa)
        {
            await _context.Empresas.AddAsync(empresa);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Empresas empresa)
        {
            _context.Empresas.Update(empresa);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Empresas empresa)
        {
            _context.Empresas.Remove(empresa);
            await _context.SaveChangesAsync();
        }

        public async Task<bool> ExisteCpfCnpjAsync(string cpfCnpj)
        {
            return await _context.Empresas.AnyAsync(e => e.Emp_cpfcgc == cpfCnpj);
        }
    }
}