namespace Domain.Entities
{
    public class Mb1pedcab
    {
        public long Mb1_id { get; private set; }
        public long Mb1_usuario { get; private set; }
        public long Mb1_cliente { get; private set; }
        public DateTime Mb1_data { get; private set; }
        public string Mb1_pagamento { get; private set; }
        public string Mb1_observacao { get; private set; }
        public long Emp_id { get; private set; }
        public DateTime Created_at { get; private set; }
        public DateTime Updated_at { get; private set; }

        public Empresas Empresa { get; private set; }
        public Clientes Cliente { get; private set; }

        protected Mb1pedcab() { }

        public Mb1pedcab(long usuario, long cliente, DateTime data, string pagamento, string observacao, long empresaId)
        {
            Mb1_usuario = usuario;
            Mb1_cliente = cliente;
            Mb1_data = data;
            Mb1_pagamento = pagamento;
            Mb1_observacao = observacao;
            Emp_id = empresaId;
            Created_at = DateTime.UtcNow;
            Updated_at = DateTime.UtcNow;
        }
    }
}