using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGPPC.Model
{
    public class ConsultaEntradaProduto
    {
        private Conexao objConexao;
        public ConsultaEntradaProduto(Conexao conexao)
        {
            objConexao = conexao;
        }

        public DataTable LocalizarEntradaProduto(string Preco_Unitario)
        {
            DataTable dt = new DataTable();

            dt.Clear();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Produto_Entrada WHERE Preco_Unitario like '%" + Preco_Unitario + "%' ", objConexao.conectar());
            da.Fill(dt);
            return dt;
        }
    }
}
