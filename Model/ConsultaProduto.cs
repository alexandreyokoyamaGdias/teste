using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGPPC.Model
{
    public class ConsultaProduto
    {
        private Conexao objConexao;
        public ConsultaProduto(Conexao conexao)
        {
            objConexao = conexao;
        }

        public DataTable Localizar(string Nome)
        {
            DataTable dtt = new DataTable();

            dtt.Clear();
            SqlDataAdapter das = new SqlDataAdapter("SELECT * FROM Produto WHERE Nome_Produto like '%" + Nome + "%' ", objConexao.conectar());
            das.Fill(dtt);
            return dtt;
        }
    }
}
