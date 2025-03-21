namespace Domain.Entities
{
    public class Ljusuarios
    {
        public long Lju_id { get; private set; }
        public string Lju_pwusuario { get; private set; }
        public string Lju_psdsh { get; private set; }
        public decimal Ven_desconto { get; private set; }
        public long Sic_seqinternabd { get; private set; }
        public long Emp_id { get; private set; }
        public DateTime Created_at { get; private set; }
        public DateTime Updated_at { get; private set; }

        public Empresas Empresa { get; private set; }

        protected Ljusuarios() { }

        public Ljusuarios(string pwusuario, string psdsh, decimal desconto, long seqInternabd, long empresaId)
        {
            Lju_pwusuario = pwusuario;
            Lju_psdsh = psdsh;
            Ven_desconto = desconto;
            Sic_seqinternabd = seqInternabd;
            Emp_id = empresaId;
            Created_at = DateTime.UtcNow;
            Updated_at = DateTime.UtcNow;
        }
    }
}