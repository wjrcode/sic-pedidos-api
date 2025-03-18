
using Domain.Entities;
using Domain.Interfaces.Repositories;
using MediatR;

namespace Application.Commands.Empresas.Handlers
{
    public class CreateEmpresaCommandHandler : IRequestHandler<CreateEmpresaCommand, long>
    {
        private readonly IEmpresaRepository _empresaRepository;

        public CreateEmpresaCommandHandler(IEmpresaRepository empresaRepository)
        {
            _empresaRepository = empresaRepository;
        }

        public async Task<long> Handle(CreateEmpresaCommand command, CancellationToken cancellationToken)
        {
            var empresa = new Empresa
            {
                Nome = command.Nome,
                NomeFantasia = command.NomeFantasia,
                CpfCnpj = command.CpfCnpj
            };

            await _empresaRepository.AddAsync(empresa);

            return empresa.Id;
        }
    }
}