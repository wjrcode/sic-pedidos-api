using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Cliente
    {
        public long Id { get; set; }
        public string Nome { get; set; }
        public string NomeFantasia { get; set; }
        public string CpfCnpj { get; set; }
        public string Endereco { get; set; }
        public string Fone { get; set; }
        public string Email { get; set; }
        public string Cidade { get; set; }
        public string Uf { get; set; }
        public string Bloquear { get; set; }
        public long? IdInterno { get; set; }
        public long EmpresaId { get; set; }
        public Empresa Empresa { get; set; }
    }
}
