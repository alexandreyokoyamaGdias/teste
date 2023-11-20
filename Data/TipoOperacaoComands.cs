using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGPPC.Data
{
    public class TipoOperacaoComands
    {
        public bool tem = false;

        public String mensagem = "";

        SqlCommand cmd = new SqlCommand();

        Conexao con = new Conexao();

        SqlDataReader dr;

        public String CadastrarTipoOperacao(string tipoOperacao, string descricao)
        {
            tem = false;

            // Primeiro, verifique se o sabor já existe
            string consultaTipoOperacaoExistente = "SELECT COUNT(*) FROM TipoOperacao WHERE Tipo = @Tipo";

            try
            {
                cmd.Connection = con.conectar();
                cmd.CommandText = consultaTipoOperacaoExistente;
                cmd.Parameters.AddWithValue("@Tipo", descricao);

                int count = (int)cmd.ExecuteScalar();

                if (count > 0)
                {
                    // Tipo de Operação já existe, você pode exibir uma mensagem de erro aqui
                    this.mensagem = "Tipo de Operação já cadastrado!";
                }
                else
                {
                    // Tipo de Operação não existe, proceda com a inserção
                    cmd.Parameters.Clear();
                    cmd.CommandText = "INSERT INTO TipoOperacao (Tipo, Descricao) VALUES (@Tipo, @Descricao)";

                    cmd.Parameters.AddWithValue("@Tipo", tipoOperacao);
                    cmd.Parameters.AddWithValue("@Descricao", descricao);
                    cmd.ExecuteNonQuery();
                    this.mensagem = "Cadastrado com sucesso!";
                    tem = true;
                }

                con.desconectar();
            }
            catch (SqlException ex)
            {
                this.mensagem = "Erro com Banco de Dados!" + ex.Message;
            }

            return mensagem;
        }

        public String AlterarTipoOperacao(Int32 id, string tipoOperacao, string descricao)
        {
            tem = false;

            cmd.CommandText = "UPDATE TipoOperacao SET Tipo = @Tipo, Descricao = @Descricao WHERE Id = @Id";

            cmd.Parameters.AddWithValue("@Id", id);
            cmd.Parameters.AddWithValue("@Tipo", tipoOperacao);
            cmd.Parameters.AddWithValue("@Descricao", descricao);

            try
            {
                cmd.Connection = con.conectar();
                cmd.ExecuteNonQuery();
                con.desconectar();
                this.mensagem = "Atualizado com sucesso!";
                tem = true;
            }
            catch (SqlException ex)
            {
                this.mensagem = "Erro com Banco de Dados!" + ex.Message;
            }

            return mensagem;
        }
    }
}
