using MediatR;

namespace Application.Empresa.Commands.Create
{
    public class CreateEmpresasCommand : IRequest<long>
    {
        public string Emp_nome { get; set; }
        public string Emp_nfantasia { get; set; }
        public string Emp_cpfcgc { get; set; }
        public Guid Emp_chavecentralizador { get; set; }
        public Guid Emp_chavedispositivo { get; set; }
        public bool Emp_ativ { get; set; }
    }
}
