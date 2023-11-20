using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGPPC.Class
{
    public class ConsultarIdFornecedor
    {
        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();

        public String mensagem;
        public String resultado;

        public int ConsultaId(string nome)
        {
            cmd.Connection = conexao.conectar();
            cmd.CommandText = "SELECT Id FROM Fornecedor WHERE Nome = @nome";
            cmd.Parameters.AddWithValue("@nome", nome);
            //SqlDataReader consultar = cmd.ExecuteReader();

            using (SqlDataReader consultar = cmd.ExecuteReader())
            {
                if (consultar.Read())
                {
                    int forn = consultar.GetInt32(0);
                    conexao.desconectar();
                    return forn;
                }
            }

            conexao.desconectar();
            return -1; // Ou outra indicação de que nenhum resultado foi encontrado
        }
    }
}
