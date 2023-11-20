using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGPPC.Controller
{
    public class EntradaController
    {
        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();

        public String mensagem;

        public EntradaController(string NotaFiscal, DateTime DataHora, Int32 Id_Fornecedor)
        {
            try
            {
                cmd.Connection = conexao.conectar();
                cmd.CommandText = "INSERT INTO Entrada (Nota_Fiscal, Data_Hora_Entrada, Id_Fornecedor) VALUES (@notaFiscal, @data, @id)";
                cmd.Parameters.AddWithValue("@notaFiscal", NotaFiscal);
                cmd.Parameters.AddWithValue("@data", DataHora);
                cmd.Parameters.AddWithValue("@id", Id_Fornecedor);
                
                cmd.ExecuteNonQuery();

                conexao.desconectar();
                this.mensagem = "Cadastrado com sucesso!";
            }
            catch (SqlException e)
            {
                this.mensagem = "Erro ao se conectar com o banco de dados";
            }

        }
    }
}
