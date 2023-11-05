using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGPPC.Model
{
    public class ConsultarVendas
    {
        private Conexao objConexao;

        public ConsultarVendas(Conexao conexao)
        {
            objConexao = conexao;
        }

        public DataTable LocalizarVendas(string NomeProduto)
        {
            DataTable dt = new DataTable();

            string query = "SELECT P.Nome_Produto, PE.Nome_Cliente, PE.Data_Hora_Pedido, PE.Id_FormasPagamento, PI.Quantidade, PI.Valor " +
                           "FROM Produto P " +
                           "INNER JOIN Pedido_Item PI ON P.Id = PI.Id_Produto " +
                           "INNER JOIN Pedido PE ON PI.Id_Pedido = PE.Id " +
                           "WHERE P.Nome_Produto LIKE '%" + NomeProduto + "%' " +
                           "ORDER BY PE.Data_Hora_Pedido DESC";

            dt.Clear();
            SqlDataAdapter da = new SqlDataAdapter(query, objConexao.conectar());
            da.Fill(dt);
            return dt;
        }
    }
}
