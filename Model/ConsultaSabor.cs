using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGPPC.Model
{
    public class ConsultaSabor
    {
        private Conexao objConexao;
        public ConsultaSabor(Conexao conexao)
        {
            objConexao = conexao;
        }

        public DataTable LocalizarSabor(string Descricao)
        {
            DataTable ddt = new DataTable();

            ddt.Clear();
            SqlDataAdapter dda = new SqlDataAdapter("SELECT * FROM Sabor WHERE Descricao like '%" + Descricao + "%' ", objConexao.conectar());
            dda.Fill(ddt);
            return ddt;
        }
    }
}
