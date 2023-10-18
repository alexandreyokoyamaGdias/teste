using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGPPC.Data
{
    //public class PagamentoComands
    //{
    //    public bool tem = false;

    //    public String mensagem = "";

    //    SqlCommand cmd = new SqlCommand();

    //    Conexao con = new Conexao();

    //    SqlDataReader dr;


    //    public String CadastrarPagamento(String nome, String descricao)
    //    {
    //        tem = false;

    //        cmd.CommandText = "INSERT INTO FormasPagamento (Nome, Descricao) VALUES (@Nome, @Descricao);";

    //        cmd.Parameters.AddWithValue("@Nome", nome);
    //        cmd.Parameters.AddWithValue("@Descricao", descricao);

    //        try
    //        {
    //            cmd.Connection = con.conectar();
    //            cmd.ExecuteNonQuery();
    //            con.desconectar();
    //            this.mensagem = "Cadastrado com sucesso!";
    //            tem = true;
    //        }
    //        catch (SqlException ex)
    //        {
    //            this.mensagem = "Erro com Banco de Dados!" + ex.Message;
    //        }

    //        return mensagem;
    //    }
    //}

    public class PagamentoComands
    {
        public bool tem = false;
        public String mensagem = "";
        SqlCommand cmd = new SqlCommand();
        Conexao con = new Conexao();
        SqlDataReader dr;

        public String CadastrarPagamento(String nome, String descricao)
        {
            tem = false;

            if (NomeJaExiste(nome))
            {
                this.mensagem = "Forma de Pagamento já existe no banco de dados!";
            }
            else
            {
                cmd.CommandText = "INSERT INTO FormasPagamento (Nome, Descricao) VALUES (@Nome, @Descricao);";

                cmd.Parameters.AddWithValue("@Nome", nome);
                cmd.Parameters.AddWithValue("@Descricao", descricao);

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
            }

            return mensagem;
        }

        private bool NomeJaExiste(string nome)
        {
            cmd.CommandText = "SELECT COUNT(*) FROM FormasPagamento WHERE Nome = @Nome;";
            cmd.Parameters.AddWithValue("@Nome", nome);

            try
            {
                cmd.Connection = con.conectar();
                int count = (int)cmd.ExecuteScalar();
                con.desconectar();
                return count > 0;
            }
            catch (SqlException ex)
            {
                this.mensagem = "Erro com Banco de Dados!" + ex.Message;
                return false;
            }
        }
    }

}
