using Domain.Interfaces.Repositories;
using MediatR;

namespace Application.Commands.Empresas.Handlers
{
    public class UpdateEmpresaCommandHandler : IRequestHandler<UpdateEmpresaCommand, bool>
    {
        private readonly IEmpresaRepository _empresaRepository;

        public UpdateEmpresaCommandHandler(IEmpresaRepository empresaRepository)
        {
            _empresaRepository = empresaRepository;
        }

        public async Task<bool> Handle(UpdateEmpresaCommand command, CancellationToken cancellationToken)
        {
            var empresa = await _empresaRepository.GetByIdAsync(command.Id);

            if (empresa == null)
            {
                return false;
            }

            empresa.Nome = command.Nome;
            empresa.NomeFantasia = command.NomeFantasia;
            empresa.CpfCnpj = command.CpfCnpj;

            await _empresaRepository.UpdateAsync(empresa);
            return true;
        }
    }
}