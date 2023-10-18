using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGPPC.Data
{
    public class SaborComands
    {
        public bool tem = false;

        public String mensagem = "";

        SqlCommand cmd = new SqlCommand();

        Conexao con = new Conexao();

        SqlDataReader dr;

        public String CadastrarSabor(String descricao)
        {
            tem = false;

            // Primeiro, verifique se o sabor já existe
            string consultaSaborExistente = "SELECT COUNT(*) FROM Sabor WHERE Descricao = @Descricao";

            try
            {
                cmd.Connection = con.conectar();
                cmd.CommandText = consultaSaborExistente;
                cmd.Parameters.AddWithValue("@Descricao", descricao);

                int count = (int)cmd.ExecuteScalar();

                if (count > 0)
                {
                    // Sabor já existe, você pode exibir uma mensagem de erro aqui
                    this.mensagem = "Sabor já cadastrado!";
                }
                else
                {
                    // Sabor não existe, proceda com a inserção
                    cmd.Parameters.Clear();
                    cmd.CommandText = "INSERT INTO Sabor (Descricao) VALUES (@Descricao)";
                    cmd.Parameters.AddWithValue("@Descricao", descricao);
                    cmd.ExecuteNonQuery();
                    this.mensagem = "Cadastrado com sucesso!";
                    tem = true;
                }

                con.desconectar();
            }
            catch (SqlException ex)
            {
                this.mensagem = "Erro com Banco de Dados!" + ex.Message;
            }

            return mensagem;
        }
    }
}
