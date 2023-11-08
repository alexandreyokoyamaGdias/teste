using SGPPC.Repository;
using BCrypt.Net;

public class Controle
{
    public bool tem;
    public string mensagem = "";

    //public bool VerificarLogin(string login, string senha, int userID, string userName)
    //{
    //    LoginDalComands loginDal = new LoginDalComands();
    //    tem = loginDal.VerificarLogin(login, senha, userID, userName);

    //    if (!loginDal.mensagem.Equals(""))
    //    {
    //        this.mensagem = loginDal.mensagem;
    //    }

    //    return tem;
    //}

    public bool VerificarLogin(string login, string senha, out int userID, out string userName)
    {
        LoginDalComands loginDal = new LoginDalComands();
        tem = loginDal.VerificarLogin(login, senha, out userID, out userName);

        if (!loginDal.mensagem.Equals(""))
        {
            this.mensagem = loginDal.mensagem;
        }

        return tem;
    }


    public string Cadastrar(string nome, string email, string funcao, string cpf, string senha, string dataAd)
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
