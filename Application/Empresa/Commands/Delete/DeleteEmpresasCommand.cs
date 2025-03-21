using MediatR;

namespace Application.Empresa.Commands.Delete
{
    public class DeleteEmpresasCommand : IRequest<bool>
    {
        public long Emp_id { get; set; }
    }
}
