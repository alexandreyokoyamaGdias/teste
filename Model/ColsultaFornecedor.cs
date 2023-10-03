using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGPPC.Model
{
    public class ColsultaFornecedor
    {
        private Conexao objConexao;
        public ColsultaFornecedor(Conexao conexao)
        {
            objConexao= conexao;
        }

        public DataTable LocalizarAtivos(string Nome)
        {
            DataTable dt = new DataTable();

            dt.Clear();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Fornecedor WHERE Nome like '%"+Nome+"%' ", objConexao.conectar());
            da.Fill(dt);
            return dt;
        }
    }
}
