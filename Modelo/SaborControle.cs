using SGPPC.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGPPC.Modelo
{
    public class SaborControle
    {
        public bool tem;

        public String mensagem = "";

        public String CadastrarProd(String descricao)
        {
            SaborComand loginDal = new SaborComand();
            this.mensagem = loginDal.CadastrarSabor(descricao);

            if (loginDal.tem)
            {
                this.tem = true;
            }
            return mensagem;
        }
    }
}
