using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SGPPC.Repository
{
    public class LoginDalComands
    {
        public bool tem = false;

        public String mensagem = "";

        SqlCommand cmd = new SqlCommand();

        Conexao con = new Conexao();

        SqlDataReader dr;

        private string RemoverCaracteresNaoNumericos(string input)
        {
            return new string(input.Where(char.IsDigit).ToArray());
        }

        public bool VerificarLogin(String login, String senha)
        {
            cmd.CommandText = "select * from Usuario where Email = @login and Senha = @senha";
            cmd.Parameters.AddWithValue("@login", login);
            cmd.Parameters.AddWithValue("@senha", senha);

            try
            {
                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    tem = true;
                }
                con.desconectar();
                dr.Close();
            }
            catch (SqlException)
            {

                this.mensagem = "Erro com o Banco de Dados!";
            }
            return tem;
        }

        public String Cadastrar(String nome, String email, String funcao, String cpf, String senha, String dataAd)
        {
            tem = false;

            cpf = RemoverCaracteresNaoNumericos(cpf);

            cmd.CommandText = "INSERT INTO Usuario (Nome, Email, Funcao, CPF, Senha, Data_Admissao) VALUES (@Nome, @Email, @Funcao, @CPF, @Senha, @Data_Admissao);";

            cmd.Parameters.AddWithValue("@Nome", nome);
            cmd.Parameters.AddWithValue("@Email", email);
            cmd.Parameters.AddWithValue("@Funcao", funcao);
            cmd.Parameters.AddWithValue("@CPF", cpf);
            cmd.Parameters.AddWithValue("@Senha", senha);
            cmd.Parameters.AddWithValue("@Data_Admissao", dataAd);

            try
            {
                cmd.Connection = con.conectar();
                cmd.ExecuteNonQuery();
                con.desconectar();
                this.mensagem = "Cadastrado com sucesso!";
                tem = true;
            }
            catch (SqlException ex)
            {
                this.mensagem = "Erro com Banco de Dados!" + ex.Message;
            }

            return mensagem;
        }
    }
}
