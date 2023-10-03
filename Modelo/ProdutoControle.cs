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

        public String CadastrarProd(String nome, String descricao, String valor, String data)
        {
            ProdutoComands loginDal = new ProdutoComands();
            this.mensagem = loginDal.CadastrarProd(nome, descricao, valor, data);

            if (loginDal.tem)
            {
                this.tem = true;
            }
            return mensagem;
        }
    }
}
