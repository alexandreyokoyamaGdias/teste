using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGPPC.Model
{
    public class ProdutoEntradaClass
    {
        public string NotaFiscal { get; set; }

        public DateTime DataHoraEntrada { get; set;}

        public int IdFornecedor { get; set;}

        public decimal PrecoUnitario { get; set;}

        public int Quantidade { get; set;}

        public int IdProduto { get; set;}

        public int idEntrada { get; set;}
    }
}
