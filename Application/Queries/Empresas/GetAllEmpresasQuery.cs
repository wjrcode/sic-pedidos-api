using Domain.Entities;
using MediatR;

namespace Application.Queries.Empresas
{
    public class GetAllEmpresasQuery : IRequest<IEnumerable<Empresa>>
    {
    }
}
