using SGPPC.Repository;
using System;

namespace SGPPC.Controllerss
{
    public class Controle
    {
        public bool tem;
        public string mensagem = "";

        public bool VerificarLogin(string login, string senha)
        {
            LoginDalComands loginDal = new LoginDalComands();
            string senhaCriptografada = CriptografarSenha(senha); // Criptografa a senha fornecida pelo usuário
            tem = loginDal.VerificarLogin(login, senhaCriptografada);

            if (!loginDal.mensagem.Equals(""))
            {
                this.mensagem = loginDal.mensagem;
            }

            return tem;
        }

        public string Cadastrar(string nome, string email, string funcao, string cpf, string senha, string dataAd)
        {
            LoginDalComands loginDal = new LoginDalComands();
            this.mensagem = loginDal.Cadastrar(nome, email, funcao, cpf, CriptografarSenha(senha), dataAd); // Criptografa a senha antes de armazená-la no banco

            if (loginDal.tem)
            {
                this.tem = true;
            }

            return mensagem;
        }

        // Função para aplicar o algoritmo de hash (SHA-256) na senha
        private string CriptografarSenha(string senha)
        {
            using (System.Security.Cryptography.SHA256 sha256 = System.Security.Cryptography.SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(System.Text.Encoding.UTF8.GetBytes(senha));
                return BitConverter.ToString(bytes).Replace("-", "").ToLower();
            }
        }
    }
}
