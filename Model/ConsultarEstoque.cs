using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGPPC.Model
{
    public class ConsultarEstoque
    {
        private Conexao objConexao;

        public ConsultarEstoque(Conexao conexao)
        {
            objConexao = conexao;
        }

        public DataTable LocalizarEstoque(string NomeProduto)
        {
            DataTable dt = new DataTable();

            string query = "SELECT P.Id, P.Nome_Produto, P.Descricao, PE.Preco_Unitario, PE.Quantidade, F.Nome, E.Data_Hora_Entrada " +
                "FROM Entrada E " +
                "INNER JOIN Produto_Entrada PE ON E.Id = PE.Id_Entrada " +
                "INNER JOIN Produto P ON PE.Id_Produto = P.Id " +
                "INNER JOIN Fornecedor F ON P.Id_Fornecedor = F.Id " +
                "WHERE P.Nome_Produto LIKE '%" + NomeProduto + "%' " +
                "ORDER BY E.Data_Hora_Entrada DESC";

            dt.Clear();
            SqlDataAdapter da = new SqlDataAdapter(query, objConexao.conectar());
            da.Fill(dt);
            return dt;
        }
    }
}
