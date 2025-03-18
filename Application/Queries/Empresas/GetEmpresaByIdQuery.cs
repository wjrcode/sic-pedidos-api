using Domain.Entities;
using MediatR;


namespace Application.Queries.Empresas
{
    public class GetEmpresaByIdQuery : IRequest<Empresa>
    {
        public long Id { get; set; }
    }
}