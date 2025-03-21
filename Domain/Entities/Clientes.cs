namespace Domain.Entities
{
    public class Clientes
    {
        public long Cli_id { get; set; }
        public string Cli_nome { get; set; }
        public string Cli_nfantasia { get; set; }
        public string Cli_cpfcgc { get; set; }
        public string Cli_endereco { get; set; }
        public string Cli_fone { get; set; }
        public string Cli_email { get; set; }
        public string Cli_cidade { get; set; }
        public string Cli_uf { get; set; }
        public string Cli_bloquear { get; set; }
        public long Cli_idinterno { get; set; }
        public long Emp_id { get; set; }
        public DateTime Created_at { get; set; }
        public DateTime Updated_at { get; set; }

        public Empresas Empresa { get; set; }

        protected Clientes() { }

        public Clientes(string nome, string nfantasia, string cpfcgc, string endereco, string fone,
                        string email, string cidade, string uf, string bloquear, long idinterno, long empresaId)
        {
            Cli_nome = nome;
            Cli_nfantasia = nfantasia;
            Cli_cpfcgc = cpfcgc;
            Cli_endereco = endereco;
            Cli_fone = fone;
            Cli_email = email;
            Cli_cidade = cidade;
            Cli_uf = uf;
            Cli_bloquear = bloquear;
            Cli_idinterno = idinterno;
            Emp_id = empresaId;
            Created_at = DateTime.UtcNow;
            Updated_at = DateTime.UtcNow;
        }
    }
}
