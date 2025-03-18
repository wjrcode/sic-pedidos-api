using MediatR;

namespace Application.Commands.Clientes
{
    public class CreateClienteCommand : IRequest<long>
    {
        public string Nome { get; set; }
        public string NomeFantasia { get; set; }
        public string CpfCnpj { get; set; }
        public string Endereco { get; set; }
        public string Cidade { get; set; }
        public string Uf { get; set; }
        public string Fone { get; set; }
        public string Email { get; set; }
        public string Bloquear { get; set; }
        public long? IdInterno { get; set; }
        public long EmpresaId { get; set; }
    }
}