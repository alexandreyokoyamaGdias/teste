using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGPPC
{
    public class Conexao
    {
        //Instância de sqlconnection
        SqlConnection con = new SqlConnection();

        //Construtor
        public Conexao() 
        {
            //con.ConnectionString = "Data Source=MININT-0LFO6EI\\SQLEXPRESS;Initial Catalog=SGPPC;User Id=sa;Password=123456";
            con.ConnectionString = "Data Source=ACF014\\SQLEXPRESS;Initial Catalog=SGPPC;Integrated Security=True";
        }

        //Método para conectar
        public SqlConnection conectar()
        {
            //Verificar se já está conectado
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }

            return con;
        }

        //Método para desconectar
        public void desconectar() 
        {
            //Verificar se já está conectado
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}
