using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGPPC.Data
{
    public class ProdutoAlterarComands
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

        public String AlterarProd(Int32 id,String nome, String descricao, decimal valor, String data)
        {
            tem = false;

            data = RemoverCaracteresNaoNumericos(data);

            cmd.CommandText = "UPDATE Produto SET Nome_Produto = @Nome, Descricao = @Descricao, Valor = @Valor, Data_Validade = @Data WHERE Id = @Id";

            cmd.Parameters.AddWithValue("@Id", id);
            cmd.Parameters.AddWithValue("@Nome", nome);
            cmd.Parameters.AddWithValue("@Descricao", descricao);
            cmd.Parameters.AddWithValue("@Valor", valor);
            cmd.Parameters.AddWithValue("@Data", data);
            

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
