using Domain.Entities;
using Domain.Interfaces.Repositories;
using MediatR;

namespace Application.Empresa.Commands.Create
{
    public class CreateEmpresasCommandHandler : IRequestHandler<CreateEmpresasCommand, long>
    {
        private readonly IEmpresasRepository _repository;

        public CreateEmpresasCommandHandler(IEmpresasRepository repository)
        {
            _repository = repository;
        }

        public async Task<long> Handle(CreateEmpresasCommand request, CancellationToken cancellationToken)
        {
            var empresa = new Empresas(
                request.Emp_nome,
                request.Emp_nfantasia,
                request.Emp_cpfcgc,
                request.Emp_chavecentralizador,
                request.Emp_chavedispositivo,
                request.Emp_ativ
            );

            await _repository.AddAsync(empresa);
            return empresa.Emp_id;
        }
    }
}