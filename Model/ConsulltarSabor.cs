using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGPPC.Model
{
    public class ConsulltarSabor
    {
        private Conexao objConexao;
        public ConsulltarSabor(Conexao conexao)
        {
            objConexao = conexao;
        }

        public DataTable LocalizarSabor(string Descricao)
        {
            DataTable dtt = new DataTable();

            dtt.Clear();
            SqlDataAdapter das = new SqlDataAdapter("SELECT * FROM Sabor WHERE Descricao like '%" + Descricao + "%' ", objConexao.conectar());
            das.Fill(dtt);
            return dtt;
        }
    }
}
