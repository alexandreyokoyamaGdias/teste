using SGPPC.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGPPC.Modelo
{
    public class FormaPagamentoControle
    {
        public bool tem;

        public String mensagem = "";

        public String CadastrarPagamento(string nome, string descricao, string status)
        {
            PagamentoComands loginDal = new PagamentoComands();
            this.mensagem = loginDal.CadastrarPagamento(nome, descricao, status);

            if (loginDal.tem)
            {
                this.tem = true;
            }
            return mensagem;
        }
    }
}
