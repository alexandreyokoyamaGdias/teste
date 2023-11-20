using SGPPC.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGPPC.Modelo
{
    public class ProdutoControle
    {
        public bool tem;

        public String mensagem = "";

        public String CadastrarProd(string notaFiscal, string preco, string quantidade, string fornecedor, string produto, string data)
        {
            ProdutoComands loginDal = new ProdutoComands();
            this.mensagem = loginDal.CadastrarProd(notaFiscal, preco, quantidade, fornecedor, produto, data);

            if (loginDal.tem)
            {
                this.tem = true;
            }
            return mensagem;
        }
    }
}
