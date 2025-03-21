using Domain.Interfaces.Repositories;
using MediatR;

namespace Application.Empresa.Commands.Update
{
    public class UpdateEmpresasCommandHandler : IRequestHandler<UpdateEmpresasCommand, bool>
    {
        private readonly IEmpresasRepository _repository;

        public UpdateEmpresasCommandHandler(IEmpresasRepository repository)
        {
            _repository = repository;
        }

        public async Task<bool> Handle(UpdateEmpresasCommand request, CancellationToken cancellationToken)
        {
            var empresa = await _repository.GetByIdAsync(request.Emp_id);

            if (empresa == null)
            {
                return false;
            }

            empresa.Emp_nome = request.Emp_nome;
            empresa.Emp_nfantasia = request.Emp_nfantasia;
            empresa.Emp_cpfcgc = request.Emp_cpfcgc;
            empresa.Emp_chavecentralizador = request.Emp_chavecentralizador;
            empresa.Emp_chavedispositivo = request.Emp_chavedispositivo;
            empresa.Emp_ativ = request.Emp_ativ;

            await _repository.UpdateAsync(empresa);

            return true;
        }
    }
}