using SGPPC.Controllerss;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace SGPPC.Data
{
    public class FornecedorComands
    {
        public bool tem = false;

        public String mensagem = "";

        SqlCommand cmd = new SqlCommand();

        Conexao con = new Conexao();

        SqlDataReader dr;

        private string RemoverCaracteresNaoNumericos(string input)
        {
            return new string(input.Where(char.IsDigit).ToArray());
        }

        public String CadastrarFor(String nome, String cnpj, String pais, String cidade, String estado, String status)
        {
            tem = false;

            // Remove caracteres não numéricos do CNPJ
            cnpj = RemoverCaracteresNaoNumericos(cnpj);

            cmd.CommandText = "INSERT INTO Fornecedor (Nome, CNPJ, Pais, Cidade, Estado, Status) VALUES (@Nome, @CNPJ, @Pais, @Cidade, @Estado,@Status );";

            cmd.Parameters.AddWithValue("@Nome", nome);
            cmd.Parameters.AddWithValue("@CNPJ", cnpj);
            cmd.Parameters.AddWithValue("@Pais", pais);
            cmd.Parameters.AddWithValue("@Cidade", cidade);
            cmd.Parameters.AddWithValue("@Estado", estado);
            cmd.Parameters.AddWithValue("@Status", status);

            try
            {
                cmd.Connection = con.conectar();
                cmd.ExecuteNonQuery();
                con.desconectar();
                this.mensagem = "Cadastrado com sucesso!";
                tem = true;
            }
            catch (SqlException ex)
            {
                this.mensagem = "Erro com Banco de Dados!" + ex.Message;
            }

            return mensagem;
        }

        //public String CadastrarFor(String nome, String cnpj, String pais, String cidade, String estado)
        //{
        //    tem = false;

        //    // Remove caracteres não numéricos do CNPJ
        //    cnpj = RemoverCaracteresNaoNumericos(cnpj);

        //    cmd.CommandText = "INSERT INTO Fornecedor (Nome, CNPJ, Pais, Cidade, Estado) VALUES (@Nome, @CNPJ, @Pais, @Cidade, @Estado);";

        //    cmd.Parameters.AddWithValue("@Nome", nome);
        //    cmd.Parameters.AddWithValue("@CNPJ", cnpj);
        //    cmd.Parameters.AddWithValue("@Pais", pais);
        //    cmd.Parameters.AddWithValue("@Cidade", cidade);
        //    cmd.Parameters.AddWithValue("@Estado", estado);

        //    try
        //    {
        //        cmd.Connection = con.conectar();
        //        cmd.ExecuteNonQuery();
        //        con.desconectar();
        //        this.mensagem = "Cadastrado com sucesso!";
        //        tem = true;
        //    }
        //    catch (SqlException ex)
        //    {
        //        this.mensagem = "Erro com Banco de Dados!" + ex.Message;
        //    }

        //    return mensagem;
        //}

    }
}
