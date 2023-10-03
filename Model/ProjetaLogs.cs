using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGPPC.Model
{
    public class ProjetaLogs
    {
        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();
        
        public ProjetaLogs(DateTime dataHora, string tabelaAfetada, string acao, string descricao)
        {
            cmd.Connection = conexao.conectar();
            cmd.CommandText = "INSERT INTO Logs (TabelaAfetada, Data_Hora, Acao, Descricao) VALUES (@tabelaAfetada, @dataHora, @acao, @descricao)";
            cmd.Parameters.AddWithValue("@TabelaAfetada", tabelaAfetada);
            cmd.Parameters.AddWithValue("@Data_Hora", dataHora);
            cmd.Parameters.AddWithValue("@Acao", acao);
            cmd.Parameters.AddWithValue("@Descricao", descricao);
            cmd.ExecuteNonQuery();
            conexao.desconectar();
        }
    }
}
