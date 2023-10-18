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

        public String Cadastrar(String nome, String email, String funcao, String cpf, String senha, String dataAd )
        {
            LoginDalComands loginDal = new LoginDalComands();
            this.mensagem = loginDal.Cadastrar(nome, email, funcao, cpf, senha, dataAd);

            if (loginDal.tem)
            {
                this.tem = true;
            }
            return mensagem;
        }
    }
}
