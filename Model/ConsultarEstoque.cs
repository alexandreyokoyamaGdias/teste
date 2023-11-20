using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Org.BouncyCastle.Asn1.X509;
using SGPPC.Class;

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

            string query = "SELECT P.Id, P.Nome_Produto, P.Descricao, PE.Preco_Unitario, PE.Quantidade, F.Nome, E.Data_Hora_Entrada, P.Id_Fornecedor " +
                           "FROM Produto P " +
                           "LEFT JOIN Produto_Entrada PE ON P.Id = PE.Id_Produto " +
                           "LEFT JOIN Entrada E ON PE.Id_Entrada = E.Id " +
                           "LEFT JOIN Fornecedor F ON P.Id_Fornecedor = F.Id " +
                           "WHERE P.Nome_Produto LIKE '%" + NomeProduto + "%' " +
                           "ORDER BY E.Data_Hora_Entrada DESC";

            dt.Clear();
            SqlDataAdapter da = new SqlDataAdapter(query, objConexao.conectar());
            da.Fill(dt);
            return dt;
        }

    }
}
