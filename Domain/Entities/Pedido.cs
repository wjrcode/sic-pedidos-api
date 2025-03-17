using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Pedido
    {
        public long Id { get; set; }
        public long UsuarioId { get; set; }
        public long ClienteId { get; set; }
        public DateTime Data { get; set; }
        public string Pagamento { get; set; }
        public string Observacao { get; set; }
        public long EmpresaId { get; set; }
        public Empresa Empresa { get; set; }
    }
}
