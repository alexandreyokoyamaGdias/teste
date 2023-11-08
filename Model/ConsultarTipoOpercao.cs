using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGPPC.Model
{
    public class ConsultarTipoOpercao
    {
        private Conexao objConexao;

        public ConsultarTipoOpercao(Conexao conexao)
        {
            objConexao = conexao;
        }

        public DataTable LocalizarTipoOperacao(string Descricao)
        {
            DataTable dtt = new DataTable();

            dtt.Clear();
            SqlDataAdapter das = new SqlDataAdapter("SELECT * FROM TipoOperacao WHERE Descricao like '%" + Descricao + "%' ", objConexao.conectar());
            das.Fill(dtt);
            return dtt;
        }
    }
}
