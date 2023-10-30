using SGPPC.Data;
using SGPPC.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGPPC.Modelo
{
    public class CaixaControle
    {
        public bool tem;

        public String mensagem = "";

        public String CadastrarCaixa(string motivo, string tipo, string valor, string data)
        {
            CaixaComands loginDal = new CaixaComands();
            this.mensagem = loginDal.CadastrarCaixa(motivo, tipo, valor, data);

            if (loginDal.tem)
            {
                this.tem = true;
            }
            return mensagem;
        }

        public String EditarCaixa(string motivo, string tipo, string valor, Int32 id)
        {
            CaixaComands loginDal = new CaixaComands();
            this.mensagem = loginDal.EditarCaixa(motivo, tipo, valor, id);

            if (loginDal.tem)
            {
                this.tem = true;
            }
            return mensagem;
        }
    }
}
