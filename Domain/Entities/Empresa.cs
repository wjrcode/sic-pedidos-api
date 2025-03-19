using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Empresa
    {
        public long Id { get; set; }

        required public string Nome { get; set; }

        required public string NomeFantasia { get; set; }

        required public string CpfCnpj { get; set; }

    }
}
