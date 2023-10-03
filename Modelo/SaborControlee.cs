using SGPPC.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGPPC.Modelo
{
    public class SaborControlee
    {
        public bool tem;

        public String mensagem = "";

        public String CadastrarSabor(String descricao)
        {
            SaborComands loginDal = new SaborComands();
            this.mensagem = loginDal.CadastrarSabor(descricao);

            if (loginDal.tem)
            {
                this.tem = true;
            }
            return mensagem;
        }
    }
}
