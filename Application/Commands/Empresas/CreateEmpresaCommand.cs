using MediatR;

namespace Application.Commands.Empresas
{
    public class CreateEmpresaCommand : IRequest<long>
    {
        public string Nome { get; set; }
        public string NomeFantasia { get; set; } 
        public string CpfCnpj { get; set; } 
    }
}
