using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGPPC.Data
{
    public class ProdutoComands
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

        public String CadastrarProd(String nome, String descricao, String valor, String data)
        {
            tem = false;

            // Remove caracteres não numéricos da Data
            data = RemoverCaracteresNaoNumericos(data);

            cmd.CommandText = "INSERT INTO Produto (Nome_Produto, Descricao, Valor, Data_Validade) VALUES (@Nome, @Descricao, @Valor, @Data);";

            cmd.Parameters.AddWithValue("@Nome", nome);
            cmd.Parameters.AddWithValue("@Descricao", descricao);
            cmd.Parameters.AddWithValue("@Valor", valor);
            cmd.Parameters.AddWithValue("@Data", data);

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
