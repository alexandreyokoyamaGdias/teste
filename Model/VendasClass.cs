using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGPPC.Model
{
    public class VendasClass
    {
        public string NomeCliente { get; set; }

        public string NomeProduto { get; set; }

        public string Quantidade { get; set; }

        public string Valor { get; set; }

        public DateTime DataHoraPedido { get; set; }

        public string IdFormasPagamento { get; set; }
    }
}
