using SGPPC.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGPPC.Controllerss
{
    public class Controle
    {
        public bool tem;

        public String mensagem = "";

        public bool Acessar(String login, String senha)
        {
            LoginDalComands loginDal = new LoginDalComands();
            tem = loginDal.VerificarLogin(login, senha);
            if (!loginDal.mensagem.Equals(""))
            {
                this.mensagem = loginDal.mensagem;
            }
            return tem;
        }

        public String Cadastrar(String email, String senha, String confSenha)
        {
            LoginDalComands loginDal = new LoginDalComands();
            this.mensagem = loginDal.Cadastrar(email, senha, confSenha);

            if (loginDal.tem)
            {
                this.tem = true;
            }
            return mensagem;
        }
    }
}
