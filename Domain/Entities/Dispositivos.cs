namespace Domain.Entities
{
    public class Dispositivos
    {
        public long Dis_id { get; private set; }
        public Guid Dis_uuid { get; private set; }
        public string Dis_plataforma { get; private set; }
        public string Dis_modelo { get; private set; }
        public string Dis_versao { get; private set; }
        public bool Dis_status { get; private set; }
        public string Dis_ultusuario { get; private set; }
        public string Dis_uuiddispositivo { get; private set; }
        public long Emp_id { get; private set; }
        public DateTime Created_at { get; private set; }
        public DateTime Updated_at { get; private set; }

        public Empresas Empresa { get; private set; }

        protected Dispositivos() { }

        public Dispositivos(Guid uuid, string plataforma, string modelo, string versao, bool status,
                            string ultusuario, string uuiddispositivo, long empresaId)
        {
            Dis_uuid = uuid;
            Dis_plataforma = plataforma;
            Dis_modelo = modelo;
            Dis_versao = versao;
            Dis_status = status;
            Dis_ultusuario = ultusuario;
            Dis_uuiddispositivo = uuiddispositivo;
            Emp_id = empresaId;
            Created_at = DateTime.UtcNow;
            Updated_at = DateTime.UtcNow;
        }
    }
}
