using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGPPC.Data
{
    public class EntradaProdutoComands
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

        //public String CadastrarEntProd(string precoUnitario, string quantidade, string data)
        //{
        //    tem = false;

        //    data = RemoverCaracteresNaoNumericos(data);

        //    cmd.CommandText = "INSERT INTO Produto_Entrada (Preco_Unitario, Quantidade, Data_Hora_Entrada) " +
        //                      "VALUES (@PrecoUnitario, @Quantidade, @Data);";

        //    cmd.Parameters.AddWithValue("@PrecoUnitario", precoUnitario);
        //    cmd.Parameters.AddWithValue("@Quantidade", quantidade);
        //    cmd.Parameters.AddWithValue("@Data", data);

        //    try
        //    {
        //        cmd.Connection = con.conectar();
        //        cmd.ExecuteNonQuery();
        //        con.desconectar();
        //        this.mensagem = "Cadastrado com sucesso!";
        //        tem = true;
        //    }
        //    catch (SqlException ex)
        //    {
        //        this.mensagem = "Erro com Banco de Dados!" + ex.Message;
        //    }

        //    return mensagem;
        //}

        public String CadastrarEntProd(string precoUnitario, string quantidade, string data, string id)
        {
            tem = false;

            data = RemoverCaracteresNaoNumericos(data);

            cmd.CommandText = "INSERT INTO Produto_Entrada (Preco_Unitario, Quantidade, Id) " +
                              "VALUES (@PrecoUnitario, @Quantidade, @Id);";

            cmd.Parameters.AddWithValue("@PrecoUnitario", precoUnitario);
            cmd.Parameters.AddWithValue("@Quantidade", quantidade);
            cmd.Parameters.AddWithValue("@Id", id);

            try
            {
                cmd.Connection = con.conectar();
                cmd.ExecuteNonQuery();

                cmd.CommandText = "INSERT INTO Entrada (Data_Hora_Entrada, Id) VALUES (@Data, @Id);";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Data", data);
                cmd.Parameters.AddWithValue("@Id", id);
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
