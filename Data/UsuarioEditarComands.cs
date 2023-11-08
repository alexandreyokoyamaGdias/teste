using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace SGPPC.Data
{
    public class UsuarioEditarComands
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

        public String EditarUsuario(string nome, string email, string cpf, string funcao, string senha, Int32 id)
        {
            tem = false;

            cpf = RemoverCaracteresNaoNumericos(cpf);

            if (CPFJaExiste(cpf))
            {
                this.mensagem = "CPF já cadastrado. Não é possível cadastrar novamente.";
            }
            else if (EMAILJaExiste(email))
            {
                this.mensagem = "EMAIL já cadastrado. Não é possível cadastrar novamente.";
            }
            else
            {
                cmd.CommandText = "UPDATE Usuario SET Nome = @Nome, Email = @Email, CPF = @CPF, Funcao = @Funcao, Senha = @Senha WHERE Id = @Id";

                cmd.Parameters.AddWithValue("@Nome", nome);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@CPF", cpf);
                cmd.Parameters.AddWithValue("@Funcao", funcao);
                cmd.Parameters.AddWithValue("@Senha", senha);
                cmd.Parameters.AddWithValue("@Id", id);

                try
                {
                    cmd.Connection = con.conectar();
                    cmd.ExecuteNonQuery();
                    con.desconectar();
                    this.mensagem = "Atualizado com sucesso!";
                    tem = true;
                }
                catch (SqlException ex)
                {
                    this.mensagem = "Erro com Banco de Dados!" + ex.Message;
                }
            }
            return mensagem;
        }

        private bool CPFJaExiste(string cnpj)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=ACF014\\SQLEXPRESS;Initial Catalog=SGPPC;Integrated Security=True"))
            {
                connection.Open();
                string consulta = "SELECT COUNT(*) FROM Usuario WHERE CPF = @CPF";
                using (SqlCommand command = new SqlCommand(consulta, connection))
                {
                    command.Parameters.AddWithValue("@CPF", cnpj);
                    int count = (int)command.ExecuteScalar();
                    return count > 0;
                }
            }
        }

        private bool EMAILJaExiste(string email)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=ACF014\\SQLEXPRESS;Initial Catalog=SGPPC;Integrated Security=True"))
            {
                connection.Open();
                string consulta = "SELECT COUNT(*) FROM Usuario WHERE Email = @Email";
                using (SqlCommand command = new SqlCommand(consulta, connection))
                {
                    command.Parameters.AddWithValue("@Email", email);
                    int count = (int)command.ExecuteScalar();
                    return count > 0;
                }
            }
        }
    }
}
