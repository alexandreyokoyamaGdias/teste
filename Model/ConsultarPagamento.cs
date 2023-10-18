using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGPPC.Model
{
    public class ConsultarPagamento
    {
        private Conexao objConexao;

        public ConsultarPagamento(Conexao conexao)
        {
            objConexao = conexao;
        }

        public DataTable LocalizarPagamento(string Nome, string Descricao)
        {
            DataTable dtt = new DataTable();

            dtt.Clear();
            SqlDataAdapter das = new SqlDataAdapter("SELECT * FROM FormasPagamento WHERE Nome LIKE '%" + Nome + "%' OR Descricao LIKE '%" + Descricao + "%'", objConexao.conectar());
            das.Fill(dtt);
            return dtt;
        }
    }
}
