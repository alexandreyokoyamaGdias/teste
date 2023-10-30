using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGPPC.Data
{
    public class InserirLogsComands
    {
        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();

        public InserirLogsComands(string tabelaAfetada, DateTime dataHora, string acao, string descricao)
        {
            cmd.Connection = conexao.conectar();
            cmd.CommandText = "INSERT INTO Logs (TabelaAfetada, Data_Hora, Acao, Descricao) VALUES (@tabelaAfetada, @datahora, @acao, @descricao)";

            cmd.Parameters.AddWithValue("@tabelaAfetada", tabelaAfetada);
            cmd.Parameters.AddWithValue("@datahora", dataHora);
            cmd.Parameters.AddWithValue("@acao", acao);
            cmd.Parameters.AddWithValue("@descricao", descricao);

            cmd.ExecuteNonQuery();
            conexao.desconectar();
        }
    }
}
