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

        public String EditarUsuario(string nome, string email, string cpf, string funcao, string senha, Int32 id)
        {
            UsuarioEditarComands loginDal = new UsuarioEditarComands();
            this.mensagem = loginDal.EditarUsuario(nome, email, cpf, funcao, senha, id);

            if (loginDal.tem)
            {
                this.tem = true;
            }
            return mensagem;
        }
    }
}
