using SGPPC.Class;
using SGPPC.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGPPC.Modelo
{
    public class ProdutoAlterarControle
    {
        public bool tem;

        public String mensagem = "";

        public String AlterarProd(Int32 id, string nome, string descricao, decimal valor, string idFornecedor, string idSabor, string data)
        {
            ProdutoAlterarComands loginDal = new ProdutoAlterarComands();
            this.mensagem = loginDal.AlterarProd(id, nome, descricao, valor, idFornecedor, idSabor, data);

            if (loginDal.tem)
            {
                this.tem = true;
            }
            return mensagem;
        }
    }
}
