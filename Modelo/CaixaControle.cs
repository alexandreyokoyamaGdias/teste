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

        public String CadastrarCaixa(String motivo, String tipo, String valor, String data)
        {

            CaixaComands loginDal = new CaixaComands();
            this.mensagem = loginDal.CadastrarCaixa(motivo, tipo, valor, data);

            if (loginDal.tem)
            {
                this.tem = true;
            }
            return mensagem;
        }
    }
}
