using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGPPC.Model
{
    public class PedidoClass
    {
        public string NomeCliente { get; set; }
        public string Produto { get; set; }
        public string Descricao { get; set; }
        public int Quantidade { get; set; }
        public decimal Valor { get; set; }
        public DateTime Data { get; set; }
    }
}
