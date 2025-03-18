using MediatR;

namespace Application.Queries.Clientes
{
    public class GetClienteByIdQuery : IRequest<ClienteDto>
    {
        public long Id { get; set; }
    }
    public class ClienteDto
    {
        public long Id { get; set; }
        public string Nome { get; set; }
        public string Fantasia { get; set; }
    }
}
