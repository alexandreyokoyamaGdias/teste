using System;
using System.Data.SqlClient;

namespace SGPPC.Model
{
    public class CadastroProduto
    {
        //Instanciando as classes que irei utilizar
        Conexao conexao = new Conexao();

        SqlCommand cmd = new SqlCommand();

        public String mensagem = "";

        public CadastroProduto(string Nome, string Descricao, Decimal Valor, DateTime DataValidade)
        {
            try
            {
                //Conectar com o banco de dados -- Conexao
                cmd.Connection = conexao.conectar();

                //Comando sql -- SqlCommand
                cmd.CommandText = "INSERT INTO Fornecedor (Nome, Descricao, Valor, DataValidade) VALUES (@Nome, @Descricao, @Valor, @DataValidade)";

                //Parametros
                cmd.Parameters.AddWithValue("@Nome", Nome);
                cmd.Parameters.AddWithValue("@Descricao", Descricao);
                cmd.Parameters.AddWithValue("@Valor", Valor);
                cmd.Parameters.AddWithValue("@DataValidade", DataValidade);
                cmd.ExecuteNonQuery();

                //Desconectar
                conexao.desconectar();

                //Mostrar a mensagem de erro ou sucesso
                this.mensagem = "Cadastrado com sucesso!";
            }
            catch (SqlException ex)
            {
                this.mensagem = "Erro ao se conectar com o Banco de Dados" + ex.Message;
            }
        }
    }
}
