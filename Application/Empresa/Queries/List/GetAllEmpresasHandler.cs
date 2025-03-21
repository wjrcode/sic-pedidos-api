using MediatR;
using Domain.Interfaces.Repositories;
using Domain.Entities;

namespace Application.Empresa.Queries.List
{
    public class GetAllEmpresasHandler : IRequestHandler<GetAllEmpresasQuery, IEnumerable<Empresas>>
    {
        private readonly IEmpresasRepository _empresaRepository;

        public GetAllEmpresasHandler(IEmpresasRepository empresaRepository)
        {
            _empresaRepository = empresaRepository;
        }

        public async Task<IEnumerable<Empresas>> Handle(GetAllEmpresasQuery request, CancellationToken cancellationToken)
        {
            var empresas = await _empresaRepository.GetAllAsync();
            return empresas;
        }
    }
}