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

        //public bool VerificarLogin(string login, string senha, out int userID, out string userName)
        //{
        //    userID = -1;  // Valor padrão para indicar falha no login
        //    userName = string.Empty;

        //    using (SqlConnection connection = new SqlConnection("Data Source=ACF014\\SQLEXPRESS;Initial Catalog=SGPPC;Integrated Security=True"))
        //    {
        //        using (SqlCommand cmd = new SqlCommand("SELECT Id, Nome, Senha FROM Usuario WHERE Email = @login", connection))
        //        {
        //            cmd.Parameters.AddWithValue("@login", login);

        //            try
        //            {
        //                connection.Open();
        //                using (SqlDataReader dr = cmd.ExecuteReader())
        //                {
        //                    if (dr.HasRows)
        //                    {
        //                        string senhaArmazenada = "";

        //                        while (dr.Read())
        //                        {
        //                            userID = Convert.ToInt32(dr["ID"]);
        //                            userName = dr["Nome"].ToString();
        //                            senhaArmazenada = dr["Senha"].ToString();
        //                        }

        //                        if (BCrypt.Net.BCrypt.Verify(senha, senhaArmazenada))
        //                        {
        //                            return true;
        //                        }
        //                        else
        //                        {
        //                            return false;
        //                        }
        //                    }
        //                }
        //            }
        //            catch (SqlException ex)
        //            {
        //                this.mensagem = "Erro com o Banco de Dados: " + ex.Message;
        //            }
        //        }
        //    }
        //    return false;
        //}

        //public bool VerificarLogin(string login, string senha, out int userID, out string userName)
        //{
        //    userID = -1; // Valor padrão para indicar falha no login
        //    userName = string.Empty;

        //    using (SqlConnection connection = new SqlConnection("Data Source=ACF014\\SQLEXPRESS;Initial Catalog=SGPPC;Integrated Security=True"))
        //    {
        //        using (SqlCommand cmd = new SqlCommand("SELECT Id, Nome, Senha FROM Usuario WHERE Email = @login", connection))
        //        {
        //            cmd.Parameters.AddWithValue("@login", login);

        //            try
        //            {
        //                connection.Open();
        //                using (SqlDataReader dr = cmd.ExecuteReader())
        //                {
        //                    if (dr.HasRows)
        //                    {
        //                        string senhaArmazenada = "";

        //                        while (dr.Read())
        //                        {
        //                            userID = Convert.ToInt32(dr["ID"]);
        //                            userName = dr["Nome"].ToString();
        //                            senhaArmazenada = dr["Senha"].ToString();
        //                        }

        //                        if (BCrypt.Net.BCrypt.Verify(senha, senhaArmazenada))
        //                        {
        //                            return true;
        //                        }
        //                        else
        //                        {
        //                            return false;
        //                        }
        //                    }
        //                }
        //            }
        //            catch (SqlException ex)
        //            {
        //                this.mensagem = "Erro com o Banco de Dados: " + ex.Message;
        //            }
        //        }
        //    }
        //    return false;
        //}

        //public bool VerificarLogin(string login, string senha, out int userID, out string userName, out string userFunction)
        //{
        //    userID = -1;
        //    userName = string.Empty;
        //    userFunction = string.Empty;

        //    using (SqlConnection connection = new SqlConnection("Data Source=ACF014\\SQLEXPRESS;Initial Catalog=SGPPC;Integrated Security=True"))
        //    {
        //        using (SqlCommand cmd = new SqlCommand("SELECT Id, Nome, Senha, Funcao FROM Usuario WHERE Email = @login", connection))
        //        {
        //            cmd.Parameters.AddWithValue("@login", login);

        //            try
        //            {
        //                connection.Open();
        //                using (SqlDataReader dr = cmd.ExecuteReader())
        //                {
        //                    if (dr.HasRows)
        //                    {
        //                        string senhaArmazenada = "";

        //                        while (dr.Read())
        //                        {
        //                            userID = Convert.ToInt32(dr["ID"]);
        //                            userName = dr["Nome"].ToString();
        //                            senhaArmazenada = dr["Senha"].ToString();
        //                            userFunction = dr["Funcao"].ToString(); // Adiciona a busca pela função
        //                        }

        //                        if (BCrypt.Net.BCrypt.Verify(senha, senhaArmazenada))
        //                        {
        //                            return true;
        //                        }
        //                        else
        //                        {
        //                            return false;
        //                        }
        //                    }
        //                }
        //            }
        //            catch (SqlException ex)
        //            {
        //                this.mensagem = "Erro com o Banco de Dados: " + ex.Message;
        //            }
        //        }
        //    }
        //    return false;
        //}

        public bool VerificarLogin(string login, string senha, out int userID, out string userName, out string userFunction)
        {
            userID = -1;
            userName = string.Empty;
            userFunction = string.Empty;

            using (SqlConnection connection = new SqlConnection("Data Source=ACF014\\SQLEXPRESS;Initial Catalog=SGPPC;Integrated Security=True"))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT Id, Nome, Senha, Funcao FROM Usuario WHERE Email = @login", connection))
                {
                    cmd.Parameters.AddWithValue("@login", login);

                    try
                    {
                        connection.Open();
                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                string senhaArmazenada = "";

                                while (dr.Read())
                                {
                                    userID = Convert.ToInt32(dr["ID"]);
                                    userName = dr["Nome"].ToString();
                                    senhaArmazenada = dr["Senha"].ToString();
                                    userFunction = dr["Funcao"].ToString();
                                }

                                if (BCrypt.Net.BCrypt.Verify(senha, senhaArmazenada))
                                {
                                    return true;
                                }
                                else
                                {
                                    return false;
                                }
                            }
                        }
                    }
                    catch (SqlException ex)
                    {
                        this.mensagem = "Erro com o Banco de Dados: " + ex.Message;
                    }
                }
            }
            return false;
        }


        public String Cadastrar(String nome, String email, String funcao, String cpf, String senha, String dataAd, string id_perfil)
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
                cmd.CommandText = "INSERT INTO Usuario (Nome, Email, Funcao, CPF, Senha, Data_Admissao, Id_Perfil) VALUES (@Nome, @Email, @Funcao, @CPF, @Senha, @Data_Admissao, @Id_Perfil);";

                cmd.Parameters.AddWithValue("@Nome", nome);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Funcao", funcao);
                cmd.Parameters.AddWithValue("@CPF", cpf);
                cmd.Parameters.AddWithValue("@Senha", senha);
                cmd.Parameters.AddWithValue("@Data_Admissao", dataAd);
                cmd.Parameters.AddWithValue("@Id_Perfil", id_perfil);

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

        public bool ObterInformacoesUsuarioPorID(int userID, out string nome, out string email, out string cpf, out string funcao, out DateTime dataAdmissao)
        {
            nome = "";
            email = "";
            cpf = "";
            funcao = "";
            dataAdmissao = DateTime.MinValue;

            using (SqlConnection connection = new SqlConnection("Data Source=ACF014\\SQLEXPRESS;Initial Catalog=SGPPC;Integrated Security=True"))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT Nome, Email, CPF, Funcao, Data_Admissao FROM Usuario WHERE Id = @userID", connection))
                {
                    cmd.Parameters.AddWithValue("@userID", userID);

                    try
                    {
                        connection.Open();
                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                nome = dr["Nome"].ToString();
                                email = dr["Email"].ToString();
                                cpf = dr["CPF"].ToString();
                                funcao = dr["Funcao"].ToString();
                                dataAdmissao = Convert.ToDateTime(dr["Data_Admissao"]);

                                return true;
                            }
                        }
                    }
                    catch (SqlException ex)
                    {
                        // Lide com exceções específicas do SQL, mostrando uma mensagem de erro
                        throw new Exception($"Erro ao obter informações do usuário: {ex.Message}");
                    }             
                }
            }
            return false;
        }
    }
}
