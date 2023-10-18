using SGPPC.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace SGPPC.Modelo
{
    public class UsuarioEditarControle
    {
        public bool tem;

        public String mensagem = "";

        public String EditarUsuario(String nome, String email, String funcao, String cpf, String senha, String dataAd)
        {
            UsuarioEditarComands loginDal = new UsuarioEditarComands();
            this.mensagem = loginDal.EditarUsuario(nome, email, funcao, cpf, senha, dataAd);

            if (loginDal.tem)
            {
                this.tem = true;
            }
            return mensagem;
        }
    }
}
