using SGPPC.Controllerss;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace SGPPC.Data
{
    public class FornecedorComands
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

        public string CadastrarFor(string nome, string cnpj, string pais, string cidade, string estado, string status)
        {
            tem = false;

            cnpj = RemoverCaracteresNaoNumericos(cnpj);

            if (CNPJJaExiste(cnpj))
            {
                this.mensagem = "CNPJ já cadastrado. Não é possível cadastrar novamente.";
            }
            else
            {
                cmd.CommandText = "INSERT INTO Fornecedor (Nome, CNPJ, Pais, Cidade, Estado, Status) VALUES (@Nome, @CNPJ, @Pais, @Cidade, @Estado, @Status);";

                cmd.Parameters.AddWithValue("@Nome", nome);
                cmd.Parameters.AddWithValue("@CNPJ", cnpj);
                cmd.Parameters.AddWithValue("@Pais", pais);
                cmd.Parameters.AddWithValue("@Cidade", cidade);
                cmd.Parameters.AddWithValue("@Estado", estado);
                cmd.Parameters.AddWithValue("@Status", status);

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
                    this.mensagem = "Erro com Banco de Dados! " + ex.Message;
                }
            }

            return mensagem;
        }

        private bool CNPJJaExiste(string cnpj)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=ACF014\\SQLEXPRESS;Initial Catalog=SGPPC;Integrated Security=True"))
            {
                connection.Open();
                string consulta = "SELECT COUNT(*) FROM Fornecedor WHERE CNPJ = @CNPJ";
                using (SqlCommand command = new SqlCommand(consulta, connection))
                {
                    command.Parameters.AddWithValue("@CNPJ", cnpj);
                    int count = (int)command.ExecuteScalar();
                    return count > 0;
                }
            }
        }
    }
}
