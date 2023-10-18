using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGPPC.Data
{
    public class FornecedorAlterarComands
    {
        public bool tem = false;

        public String mensagem = "";

        SqlCommand cmd = new SqlCommand();

        Conexao con = new Conexao();

        SqlDataReader dr;

        public String AlterarForn(Int32 id, string cnpj, string nome, string pais, string cidade, string estado, string status)
        {
            tem = false;

            cmd.CommandText = "UPDATE Fornecedor SET Nome = @Nome, CNPJ = @CNPJ, Pais = @Pais, Cidade = @Cidade, Estado = @Estado, Status = @Status WHERE Id = @Id";

            cmd.Parameters.AddWithValue("@Id", id);
            cmd.Parameters.AddWithValue("@CNPJ", cnpj);
            cmd.Parameters.AddWithValue("@Nome", nome);
            cmd.Parameters.AddWithValue("@Pais", pais);
            cmd.Parameters.AddWithValue("@Cidade", cidade);
            cmd.Parameters.AddWithValue("@Cidade", estado);
            cmd.Parameters.AddWithValue("@Cidade", status);

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

            return mensagem;
        }
    }
}