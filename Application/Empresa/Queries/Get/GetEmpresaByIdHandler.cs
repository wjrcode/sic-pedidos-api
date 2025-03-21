using MediatR;
using Domain.Entities;
using Domain.Interfaces.Repositories;

namespace Application.Empresa.Queries.Get
{
    public class GetEmpresaByIdHandler : IRequestHandler<GetEmpresaByIdQuery, Empresas>
    {
        private readonly IEmpresasRepository _empresaRepository;

        public GetEmpresaByIdHandler(IEmpresasRepository empresaRepository)
        {
            _empresaRepository = empresaRepository;
        }

        public async Task<Empresas> Handle(GetEmpresaByIdQuery request, CancellationToken cancellationToken)
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
