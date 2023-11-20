using SGPPC.Data;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGPPC.Modelo
{
    public class EntadaProdutoControle
    {
        public bool tem;

        public String mensagem = "";

        public String CadastrarEntProd(string notaFiscal, Decimal preco, Int32 quantidade, Int32 fornecedor, string produto,  DateTime data)
        {
            EntradaProdutoComands loginDal = new EntradaProdutoComands();
            this.mensagem = loginDal.CadastrarEntProd(notaFiscal, preco, quantidade, fornecedor, produto, data);

            if (loginDal.tem)
            {
                this.tem = true;
            }
            return mensagem;
        }
    }
}
