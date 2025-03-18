using MediatR;
using Domain.Interfaces.Repositories;
using Domain.Entities;

namespace Application.Commands.Clientes.Handlers
{
    public class CreateClienteCommandHandler : IRequestHandler<CreateClienteCommand, long>
{
        private readonly IClienteRepository _clienteRepository;
        public CreateClienteCommandHandler(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public async Task<long> Handle(CreateClienteCommand command, CancellationToken vancellationToken)
        {
            var cliente = new Cliente
            {
                Nome = command.Nome,
                NomeFantasia = command.NomeFantasia,
                CpfCnpj = command.CpfCnpj,
                Endereco = command.Endereco,
                Cidade = command.Cidade,
                Uf = command.Uf,
                Fone = command.Fone,
                Email = command.Email,
                Bloquear = command.Bloquear,
                IdInterno = command.IdInterno,
                EmpresaId = command.EmpresaId
            };

            await _clienteRepository.AddAsync(cliente);
            return cliente.Id;
        }
    }
}