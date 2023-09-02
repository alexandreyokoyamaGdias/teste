using System;
using System.Data.SqlClient;

namespace SGPPC.Model
{
    public class CadastroFornecedor
    {
        //Instanciando as classes que irei utilizar
        Conexao conexao = new Conexao();

        SqlCommand cmd = new SqlCommand();

        public String mensagem = "";

        public CadastroFornecedor(string Nome, string CNPJ, string Pais, string Cidade, string Estado)
        {
            try
            {
                //Conectar com o banco de dados -- Conexao
                cmd.Connection = conexao.conectar();

                //Comando sql -- SqlCommand
                cmd.CommandText = "INSERT INTO Fornecedor (Nome, CNPJ, Pais, Cidade, Estado) VALUES (@Nome, @CNPJ, @Pais, @Cidade, @Estado)";

                //Parametros
                cmd.Parameters.AddWithValue("@Nome", Nome);
                cmd.Parameters.AddWithValue("@CNPJ", CNPJ);
                cmd.Parameters.AddWithValue("@Pais", Pais);
                cmd.Parameters.AddWithValue("@Cidade", Cidade);
                cmd.Parameters.AddWithValue("@Estado", Estado);
                cmd.ExecuteNonQuery();

                //Executar o comando

                //Desconectar
                conexao.desconectar();

                //Mostrar a mensagem de erro ou sucesso -- variável
                this.mensagem = "Cadastrado com sucesso!";

            }
            catch (SqlException ex)
            {
                this.mensagem = "Erro ao se conectar com o Banco de Dados" + ex.Message;
            }
        }
    }
}
