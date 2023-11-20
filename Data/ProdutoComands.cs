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

        public String CadastrarProd(string notaFiscal, string preco, string quantidade, string fornecedor, string produto, string data)
        {
            tem = false;

            data = RemoverCaracteresNaoNumericos(data);

            cmd.CommandText = "INSERT INTO Produto (Nome_Produto, Descricao, Valor, Data_Validade, Id_Fornecedor, Id_Sabor) " +
                              "VALUES (@Nome, @Descricao, @Valor, @Data, @IdFornecedor, @IdSabor);";
            
            cmd.Parameters.AddWithValue("@Nome", notaFiscal);
            cmd.Parameters.AddWithValue("@Descricao", preco);
            cmd.Parameters.AddWithValue("@Valor", quantidade);
            cmd.Parameters.AddWithValue("@Data", data);
            cmd.Parameters.AddWithValue("@IdFornecedor", fornecedor);
            cmd.Parameters.AddWithValue("@IdSabor", produto);
            cmd.Parameters.AddWithValue("@IdSabor", data);

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
