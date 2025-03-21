namespace Domain.Entities
{
    public class Empresas
    {
        public long Emp_id { get; set; }
        public string Emp_nome { get; set; }
        public string Emp_nfantasia { get; set; }
        public string Emp_cpfcgc { get; set; }
        public Guid Emp_chavecentralizador { get; set; }
        public Guid Emp_chavedispositivo { get; set; }
        public bool Emp_ativ { get; set; }
        public DateTime Created_at { get; set; }
        public DateTime Updated_at { get; set; }

        protected Empresas() { }

        public Empresas(string nome, string nfantasia, string cpfcgc, Guid chavecentralizador, Guid chavedispositivo, bool ativ)
        {
            if (string.IsNullOrWhiteSpace(nome))
            {
                throw new ArgumentException("Name cannot be empty.");
            }

            if (string.IsNullOrWhiteSpace(cpfcgc))
            {
                throw new ArgumentException("Document cannot be empty.");
            }

            Emp_nome = nome;
            Emp_nfantasia = nfantasia;
            Emp_cpfcgc = cpfcgc;
            Emp_chavecentralizador = chavecentralizador;
            Emp_chavedispositivo = chavedispositivo;
            Emp_ativ = ativ;
            Created_at = DateTime.UtcNow;
            Updated_at = DateTime.UtcNow;
        }
    }
}
