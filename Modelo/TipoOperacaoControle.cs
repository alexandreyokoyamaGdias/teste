using SGPPC.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGPPC.Modelo
{
    public class TipoOperacaoControle
    {
        public bool tem;

        public String mensagem = "";

        public String CadastrarTipoOperacao(string tipoOperacao, string descricao)
        {
            TipoOperacaoComands loginDal = new TipoOperacaoComands();
            this.mensagem = loginDal.CadastrarTipoOperacao(tipoOperacao, descricao);

            if (loginDal.tem)
            {
                this.tem = true;
            }
            return mensagem;
        }

        public String AlterarTipoOperacao(Int32 id, string tipoOperacao, string descricao)
        {
            TipoOperacaoComands loginDal = new TipoOperacaoComands();
            this.mensagem = loginDal.AlterarTipoOperacao(id, tipoOperacao, descricao);

            if (loginDal.tem)
            {
                this.tem = true;
            }
            return mensagem;
        }
    }
}
