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

        public String Cadastrar(String email, String senha, String confSenha)
        {
            tem = false;
            if (senha.Equals(confSenha))
            {
                //cmd.CommandText = "insert into Usuario values (@Email, @Senha);";
                cmd.CommandText = "INSERT INTO Usuario (Email, Senha) VALUES (@Email, @Senha);";

                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Senha", senha);

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
            }
            else
            {
                this.mensagem = "Senhas não correspondem!";
            }
            return mensagem;
        }
    }
}
