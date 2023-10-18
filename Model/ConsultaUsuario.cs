using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGPPC.Model
{
    public class ConsultaUsuario
    {
        private Conexao objConexao;

        public ConsultaUsuario(Conexao conexao)
        {
            objConexao = conexao;
        }

        public DataTable LocalizarUsuario(string Nome, string CPF)
        {
            DataTable dtt = new DataTable();

            dtt.Clear();
            SqlDataAdapter das = new SqlDataAdapter("SELECT * FROM Usuario WHERE Nome LIKE '%" + Nome + "%' OR CPF LIKE '%" + CPF + "%'", objConexao.conectar());
            das.Fill(dtt);
            return dtt;
        }
    }
}
