using Application.Commands.Empresas;
using Domain.Interfaces.Repositories;
using MediatR;

namespace Application.Commands.Empresas.Handlers
{
    public class DeleteEmpresaCommandHandler : IRequestHandler<DeleteEmpresaCommand, bool>
    {
        private readonly IEmpresaRepository _empresaRepository;

        public DeleteEmpresaCommandHandler(IEmpresaRepository empresaRepository)
        {
            _empresaRepository = empresaRepository;
        }

        public async Task<bool> Handle(DeleteEmpresaCommand command, CancellationToken cancellationToken)
        {
            var empresa = await _empresaRepository.GetByIdAsync(command.Id);

            if (empresa == null)
            {
                return false;
            }

            await _empresaRepository.DeleteAsync(empresa);
            return true;
        }
    }
}
