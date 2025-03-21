namespace Domain.Entities
{
    public class Mb2peditens
    {
        public long Mb2_id { get; private set; }
        public long Mb2_produto { get; private set; }
        public decimal Mb2_quantidade { get; private set; }
        public decimal Mb2_valor_unitario { get; private set; }
        public decimal Mb2_valor_desconto { get; private set; }
        public string Mb2_observacao { get; private set; }
        public long Pedido_id { get; private set; }
        public DateTime Created_at { get; private set; }
        public DateTime Updated_at { get; private set; }

        public Produtos Produto { get; private set; }
        public Mb1pedcab Pedido { get; private set; }

        protected Mb2peditens() { }

        public Mb2peditens(long produto, decimal quantidade, decimal valorUnitario, decimal valorDesconto,
                            string observacao, long pedidoId)
        {
            Mb2_produto = produto;
            Mb2_quantidade = quantidade;
            Mb2_valor_unitario = valorUnitario;
            Mb2_valor_desconto = valorDesconto;
            Mb2_observacao = observacao;
            Pedido_id = pedidoId;
            Created_at = DateTime.UtcNow;
            Updated_at = DateTime.UtcNow;
        }
    }
}