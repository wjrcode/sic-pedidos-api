
using MediatR;
using Domain.Entities;
using Application.Queries.Empresas;
using Domain.Interfaces.Repositories;

namespace Application.Queries.Empresas.Handlers
{
    public class GetEmpresaByIdHandler : IRequestHandler<GetEmpresaByIdQuery, Empresa>
    {
        private readonly IEmpresaRepository _empresaRepository;

        public GetEmpresaByIdHandler(IEmpresaRepository empresaRepository)
        {
            _empresaRepository = empresaRepository;
        }

        public async Task<Empresa> Handle(GetEmpresaByIdQuery request, CancellationToken cancellationToken)
        {
            var empresa = await _empresaRepository.GetByIdAsync(request.Id);

            if (empresa == null)
            {
                return null;
            }

            return empresa;
        }
    }
}
