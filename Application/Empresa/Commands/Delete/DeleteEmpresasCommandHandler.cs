using Domain.Interfaces.Repositories;
using MediatR;

namespace Application.Empresa.Commands.Delete
{
    public class DeleteEmpresasCommandHandler : IRequestHandler<DeleteEmpresasCommand, bool>
    {
        private readonly IEmpresasRepository _empresaRepository;

        public DeleteEmpresasCommandHandler(IEmpresasRepository empresaRepository)
        {
            _empresaRepository = empresaRepository;
        }

        public async Task<bool> Handle(DeleteEmpresasCommand command, CancellationToken cancellationToken)
        {
            var empresa = await _empresaRepository.GetByIdAsync(command.Emp_id);

            if (empresa == null)
            {
                return false;
            }

            await _empresaRepository.DeleteAsync(empresa);
            return true;
        }
    }
}
