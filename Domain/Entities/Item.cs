using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Item
    {
        public long Id { get; set; }
        public long ProdutoId  { get; set; }
        public decimal Quantidade { get; set; }
        public decimal ValorUnitario { get; set; }
        public decimal ValorDesconto { get; set; }
        public string Observacao { get; set; }
        public long PedidoId { get; set; }
        public Pedido Pedido { get; set; }
    }
}
