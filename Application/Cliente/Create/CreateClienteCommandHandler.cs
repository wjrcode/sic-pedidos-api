using MediatR;
using Domain.Interfaces.Repositories;
using Domain.Entities;

namespace Application.Cliente.Create
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
            var cliente = new Clientes(
                command.Nome,
                command.NomeFantasia,
                command.CpfCnpj,
                command.Endereco,
                command.Cidade,
                command.Uf,
                command.Fone,
                command.Email,
                command.Bloquear,
                command.IdInterno,
                command.EmpresaId
            );

            await _clienteRepository.AddAsync(cliente);
            return 1;
        }
    }
}