using SGPPC.Class;
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

        //public String CadastrarEntProd(string notaFiscal, Decimal preco, Int32 quantidade, Int32 fornecedor, string produto, Int32 entrada, DateTime data)
        //{
        //    tem = false;

        //    //data = RemoverCaracteresNaoNumericos(data);

        //    cmd.CommandText = "INSERT INTO Entrada (Nota_Fiscal, Data_Hora_Entrada, Id_Fornecedor)" +
        //                      "VALUES (@NotaFiscal, @DataHoraEntrada, @IdFornecedor);";

        //    cmd.CommandText = "INSERT INTO Produto_Entrada (Preco_Unitario, Quantidade, Id_Produto, Id_Entrada) " +
        //                      "VALUES (@PrecoUnitario, @Quantidade, @IdProduto, @IdEntrada);";

        //    cmd.Parameters.AddWithValue("@NotaFiscal", notaFiscal);
        //    cmd.Parameters.AddWithValue("@PrecoUnitario", preco);
        //    cmd.Parameters.AddWithValue("@Quantidade", quantidade);
        //    cmd.Parameters.AddWithValue("@IdFornecedor", fornecedor);  
        //    cmd.Parameters.AddWithValue("@IdProduto", produto);
        //    cmd.Parameters.AddWithValue("@IdEntrada", entrada);
        //    cmd.Parameters.AddWithValue("@DataHoraEntrada", data);
        //    //cmd.Parameters.AddWithValue("@Id", id);

        //    try
        //    {
        //        cmd.Connection = con.conectar();
        //        cmd.ExecuteNonQuery();

        //        cmd.CommandText = "INSERT INTO Entrada (Data_Hora_Entrada, Id) VALUES (@Data, @Id);";
        //        cmd.Parameters.Clear();
        //        cmd.Parameters.AddWithValue("@Data", data);
        //        //cmd.Parameters.AddWithValue("@Id", id);
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

        public String CadastrarEntProd(string notaFiscal, Decimal preco, Int32 quantidade, Int32 fornecedor, string produto, DateTime data)
        {
            tem = false;

            try
            {
                cmd.Connection = con.conectar();
                cmd.CommandText = "INSERT INTO Entrada (Nota_Fiscal, Data_Hora_Entrada, Id_Fornecedor) " +
                                  "VALUES (@NotaFiscal, @DataHoraEntrada, @IdFornecedor);";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@NotaFiscal", notaFiscal);
                cmd.Parameters.AddWithValue("@DataHoraEntrada", data);
                cmd.Parameters.AddWithValue("@IdFornecedor", fornecedor);

                // Executa o primeiro insert
                cmd.ExecuteNonQuery();

                // Obtém o último ID inserido na tabela 'Entrada'
                int lastInsertedEntradaId = GetLastInsertedId();

                cmd.CommandText = "INSERT INTO Produto_Entrada (Preco_Unitario, Quantidade, Id_Produto, Id_Entrada) " +
                                  "VALUES (@PrecoUnitario, @Quantidade, @IdProduto, @IdEntrada);";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@PrecoUnitario", preco);
                cmd.Parameters.AddWithValue("@Quantidade", quantidade);
                cmd.Parameters.AddWithValue("@IdProduto", produto);
                cmd.Parameters.AddWithValue("@IdEntrada", lastInsertedEntradaId);

                // Executa o segundo insert
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

        private int GetLastInsertedId()
        {
            cmd.CommandText = "SELECT SCOPE_IDENTITY();";
            return Convert.ToInt32(cmd.ExecuteScalar());
        }



    }
}
