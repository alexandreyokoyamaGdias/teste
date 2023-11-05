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

        public String CadastrarEntProd(string precoUnitario, string quantidade, string data, string id)
        {
            EntradaProdutoComands loginDal = new EntradaProdutoComands();
            this.mensagem = loginDal.CadastrarEntProd(precoUnitario, quantidade, data, id);

            if (loginDal.tem)
            {
                this.tem = true;
            }
            return mensagem;
        }
    }
}
