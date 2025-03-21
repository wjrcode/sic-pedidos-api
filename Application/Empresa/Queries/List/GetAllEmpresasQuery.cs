using Domain.Entities;
using MediatR;

namespace Application.Empresa.Queries.List
{
    public class GetAllEmpresasQuery : IRequest<IEnumerable<Empresas>>
    {
    }
}
