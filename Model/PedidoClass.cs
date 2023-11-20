using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGPPC.Model
{
    public class PedidoClass
    {
        public string NomeCliente { get; set; }//

        public int IdProduto { get; set; }//

        public int Quantidade { get; set; }//

        public int IdFormasPagamento { get; set; }//

        public decimal Valor { get; set; }//

        public DateTime DataHoraPedido { get; set; }//

        public int IdUsuario { get; set; }//

        public int IdPedido { get; set; }//
    }
}
