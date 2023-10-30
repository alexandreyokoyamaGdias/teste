using SGPPC.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGPPC.Modelo
{
    public class PagamentoAlterarControle
    {
        public bool tem;

        public String mensagem = "";

        public String AlterarPagamento(Int32 id, string nome, string descricao, string status)
        {
            PagamentoAlterarComands loginDal = new PagamentoAlterarComands();
            this.mensagem = loginDal.AlterarPagamento(id, nome, descricao, status);

            if (loginDal.tem)
            {
                this.tem = true;
            }
            return mensagem;
        }
    }
}
