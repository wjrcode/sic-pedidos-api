
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
            if (await _empresaRepository.ExisteCpfCnpjAsync(command.CpfCnpj))
            {
                throw new ArgumentException("Já existe uma empresa com o mesmo CpfCnpj.");
            }

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