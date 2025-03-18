using MediatR;

namespace Application.Commands.Empresas
{
    public class DeleteEmpresaCommand : IRequest<bool>
    {
        public long Id { get; set; }
    }
}
