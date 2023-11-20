using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGPPC.Class
{
    //public class ConsultaIdProduto
    //{
    //    public class ConsultarIdProduto
    //    {
    //        Conexao conexao = new Conexao();
    //        SqlCommand cmd = new SqlCommand();

    //        public String mensagem;
    //        public String resultado;

    //        public int ConsultaId(String nome)
    //        {
    //            cmd.Connection = conexao.conectar();
    //            cmd.CommandText = "SELECT Id FROM Produto WHERE Nome_Produto = @nome";
    //            cmd.Parameters.AddWithValue("@nome", nome);
    //            SqlDataReader consultar = cmd.ExecuteReader();

    //            consultar.Read();
    //            int prod = consultar.GetInt32(0);
    //            conexao.desconectar();
    //            return prod;
    //        }
    //    }
    //}

    public class ConsultarIdProduto
    {
        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();

        public int ConsultaId(string nome)
        {
            cmd.Connection = conexao.conectar();
            cmd.CommandText = "SELECT Id FROM Produto WHERE Nome_Produto = @nome";
            cmd.Parameters.AddWithValue("@nome", nome);

            using (SqlDataReader consultar = cmd.ExecuteReader())
            {
                if (consultar.Read())
                {
                    int prod = consultar.GetInt32(0);
                    conexao.desconectar();
                    return prod;
                }
            }

            conexao.desconectar();
            return -1; // Ou outra indicação de que nenhum resultado foi encontrado
        }
    }

}
