using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Fpagamento
    {
        public long Id { get; set; }
        public string Codigo { get; set; }
        public string DescrAbreviada { get; set; }
        public long EmpresaId { get; set; }
        public Empresa Empresa { get; set; }
    }
}
