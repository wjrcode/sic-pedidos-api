using MediatR;

namespace Application.Commands.Empresas
{
    public class UpdateEmpresaCommand : IRequest<bool>
    {
        public long Id { get; set; }
        public string Nome { get; set; }
        public string NomeFantasia { get; set; }
        public string CpfCnpj { get; set; }
    }
}
