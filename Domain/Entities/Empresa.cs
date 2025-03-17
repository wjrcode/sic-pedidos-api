using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Empresa
    {
        public long Id { get; set; }
        public string Nome { get; set; }
        public string NomeFantasia { get; set; }
        public string CpfCnpj { get; set; }

    }
}
