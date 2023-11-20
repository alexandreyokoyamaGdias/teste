using SGPPC.Repository;
using BCrypt.Net;
using System.Data.SqlClient;
using System;

public class Controle
{
    public bool tem;

    public string mensagem = "";

    //public bool VerificarLogin(string login, string senha, out int userID, out string userName)
    //{
    //    LoginDalComands loginDal = new LoginDalComands();
    //    tem = loginDal.VerificarLogin(login, senha, out userID, out userName);

    //    if (!loginDal.mensagem.Equals(""))
    //    {
    //        this.mensagem = loginDal.mensagem;
    //    }

    //    return tem;
    //}

    public bool VerificarLogin(string login, string senha, out int userID, out string userName, out string userFunction)
    {
        LoginDalComands loginDal = new LoginDalComands();
        bool tem = loginDal.VerificarLogin(login, senha, out userID, out userName, out userFunction);

        if (!loginDal.mensagem.Equals(""))
        {
            this.mensagem = loginDal.mensagem;
        }

        return tem;
    }


    public string Cadastrar(string nome, string email, string funcao, string cpf, string senha, string dataAd, string id_perfil)
    {
        LoginDalComands loginDal = new LoginDalComands();
        this.mensagem = loginDal.Cadastrar(nome, email, funcao, cpf, senha, dataAd, id_perfil);

        if (loginDal.tem)
        {
            this.tem = true;
        }

        return mensagem;
    }
}
