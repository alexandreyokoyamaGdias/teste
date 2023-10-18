using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SGPPC.Model
{
    public class ConsultaControleCaixa
    {
        private Conexao objConexao;
        public ConsultaControleCaixa(Conexao conexao)
        {
            objConexao = conexao;
        }

        public DataTable LocalizarControleCaixa(string Motivo, string Tipo_Opercacao, string Valor, string Data_Hora)
        {
            DataTable dt = new DataTable();

            dt.Clear();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Controle_Caixa_Pedido WHERE Motivo like '%" + Motivo + "%' OR Motivo like '%" + Tipo_Opercacao + "%' OR Motivo like '%" + Valor + "%' OR Motivo like '%" + Data_Hora + "%'", objConexao.conectar());
            da.Fill(dt);
            return dt;
        }
    }
}
