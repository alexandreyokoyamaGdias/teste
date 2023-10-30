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

        public String CadastrarProd(string nome, string descricao, string valor, string data, string idFornecedor, string idSabor)
        {
            ProdutoComands loginDal = new ProdutoComands();
            this.mensagem = loginDal.CadastrarProd(nome, descricao, valor, data, idFornecedor, idSabor);

            if (loginDal.tem)
            {
                this.tem = true;
            }
            return mensagem;
        }
    }
}
