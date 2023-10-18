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

        public String CadastrarPagamento(String nome, String descricao)
        {
            PagamentoComands loginDal = new PagamentoComands();
            this.mensagem = loginDal.CadastrarPagamento(nome, descricao);

            if (loginDal.tem)
            {
                this.tem = true;
            }
            return mensagem;
        }
    }
}
