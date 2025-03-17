using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Usuario
    {
        public long Id { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }
        public decimal DescontoMaximo { get; set; }
        public long? SicSegmentoId { get; set; }
        public long EmpresaId { get; set; }
        public Empresa Empresa { get; set; }
    }
}
