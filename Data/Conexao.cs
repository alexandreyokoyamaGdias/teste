using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
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

        public static string Criptografar(string senha)
        {
            MD5 md5Has = MD5.Create();

            byte[] data = md5Has.ComputeHash(Encoding.UTF8.GetBytes(senha));

            StringBuilder sBuilder = new StringBuilder();

            for(int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            return sBuilder.ToString();
        }
    }
}
