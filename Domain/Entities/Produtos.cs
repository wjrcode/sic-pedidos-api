namespace Domain.Entities
{
    public class Produtos
    {
        public long Pro_id { get; private set; }
        public string Pro_nome { get; private set; }
        public string Pro_marca { get; private set; }
        public string Pro_grupo { get; private set; }
        public decimal Pro_saldo { get; private set; }
        public decimal Desconto_maximo { get; private set; }
        public string Pro_imagem { get; private set; }
        public long Sic_seqintermabd { get; private set; }
        public long Emp_id { get; private set; }
        public DateTime Created_at { get; private set; }
        public DateTime Updated_at { get; private set; }

        public Empresas Empresa { get; private set; }

        protected Produtos() { }

        public Produtos(string nome, string marca, string grupo, decimal saldo, decimal descontoMaximo,
                        string imagem, long seqIntermabd, long empresaId)
        {
            Pro_nome = nome;
            Pro_marca = marca;
            Pro_grupo = grupo;
            Pro_saldo = saldo;
            Desconto_maximo = descontoMaximo;
            Pro_imagem = imagem;
            Sic_seqintermabd = seqIntermabd;
            Emp_id = empresaId;
            Created_at = DateTime.UtcNow;
            Updated_at = DateTime.UtcNow;
        }
    }
}