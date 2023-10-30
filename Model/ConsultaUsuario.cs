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

        public DataTable LocalizarUsuario(string Nome, string CPF, string Funcao)
        {
            DataTable dtt = new DataTable();

            dtt.Clear();
            SqlDataAdapter das = new SqlDataAdapter("SELECT Id, Nome, Email as 'E-mail', CPF, Funcao as 'Função', Senha, Data_Admissao as 'Data Admissão' FROM Usuario WHERE Nome LIKE '%" + Nome + "%' OR CPF LIKE '%" + CPF + "%' OR Funcao LIKE '%" + Funcao + "%'", objConexao.conectar());
            das.Fill(dtt);
            return dtt;
        }
    }
}
