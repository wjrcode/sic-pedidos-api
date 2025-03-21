namespace Domain.Entities
{
    public class Fpagamentos
    {
        public long Fpa_id { get; private set; }
        public string Fpa_codigo { get; private set; }
        public string Fpa_descrabreviada { get; private set; }
        public long Emp_id { get; private set; }
        public DateTime Created_at { get; private set; }
        public DateTime Updated_at { get; private set; }

        public Empresas Empresa { get; private set; }

        protected Fpagamentos() { }

        public Fpagamentos(string codigo, string descrabreviada, long empresaId)
        {
            Fpa_codigo = codigo;
            Fpa_descrabreviada = descrabreviada;
            Emp_id = empresaId;
            Created_at = DateTime.UtcNow;
            Updated_at = DateTime.UtcNow;
        }
    }
}
