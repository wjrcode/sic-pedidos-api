using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Produto
    {
        public long Id { get; set; }
        public string Nome { get; set; }
        public string Marca { get; set; }
        public string Grupo { get; set; }
        public decimal Saldo { get; set; }
        public decimal DescontoMaximo { get; set; }
        public string Imagem { get; set; }
        public long? IdInerno { get; set; }
        public long EmpresaId { get; set; }
        public Empresa Empresa { get; set; }
    }
}
