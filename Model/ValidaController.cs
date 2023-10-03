using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGPPC.Model
{
    public class ValidaController
    {
        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();

        public String mensagem;
        public String resultado;

        public ValidaController(string CNPJ)
        {
            cmd.Connection = conexao.conectar();
            cmd.CommandText = "SELECT CNPJ FROM Fornecedor WHERE CNPJ = @CNPJ";
            cmd.Parameters.AddWithValue("@CNPJ", CNPJ);
            SqlDataReader consultar = cmd.ExecuteReader();
            while (consultar.Read())
            {
                this.mensagem = "Ja existe este CNPJ";

                if (mensagem == "Ja existe este CNPJ")
                {
                    resultado = this.mensagem = "Já existe um cadastro com este CNPJ";

                }
            }
        }
    }
}
