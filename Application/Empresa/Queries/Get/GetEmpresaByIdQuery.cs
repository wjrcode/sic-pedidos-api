using Domain.Entities;
using MediatR;


namespace Application.Empresa.Queries.Get
{
    public class GetEmpresaByIdQuery : IRequest<Empresas>
    {
        public long Id { get; set; }
    }
}