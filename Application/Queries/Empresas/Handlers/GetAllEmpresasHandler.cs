using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Domain.Interfaces.Repositories;
using Domain.Entities;

namespace Application.Queries.Empresas.Handlers
{
    public class GetAllEmpresasHandler : IRequestHandler<GetAllEmpresasQuery, IEnumerable<Empresa>>
    {
        private readonly IEmpresaRepository _empresaRepository;

        public GetAllEmpresasHandler(IEmpresaRepository empresaRepository)
        {
            _empresaRepository = empresaRepository;
        }

        public async Task<IEnumerable<Empresa>> Handle(GetAllEmpresasQuery request, CancellationToken cancellationToken)
        {
            var empresas = await _empresaRepository.GetAllAsync();
            return empresas;
        }
    }
}
