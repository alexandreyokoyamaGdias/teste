using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGPPC.Data
{
    public class CaixaComands
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

        public String CadastrarCaixa(string motivo, string tipo, string valor, string data)
        {
            tem = false;

            data = RemoverCaracteresNaoNumericos(data);

            //cmd.CommandText = "INSERT INTO Controle_Caixa_Pedido (Motivo, Tipo_Operacao, Valor, Data_Hora) VALUES (@Motivo, @Tipo_Operacao, @Valor, @Data_Hora);";
            cmd.CommandText = "INSERT INTO Controle_Caixa_Pedido (Motivo, Tipo_Operacao, Valor, Data_Hora) " +
                              "VALUES (@Nome, @Descricao, @Valor, @Data);";

            cmd.Parameters.AddWithValue("@Motivo", motivo);
            cmd.Parameters.AddWithValue("@Tipo_Operacao", tipo);
            cmd.Parameters.AddWithValue("@Valor", valor);
            cmd.Parameters.AddWithValue("@Data_Hora", data);

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

        public String EditarCaixa(string motivo, string tipo, string valor, Int32 id)
        {
            tem = false;
            cmd.CommandText = "UPDATE Controle_Caixa_Pedido SET Motivo = @Motivo, Tipo_Operacao = @Tipo_Operacao, Valor = @Valor WHERE Id = @Id";

            cmd.Parameters.AddWithValue("@Motivo", motivo);
            cmd.Parameters.AddWithValue("@Tipo_Operacao", tipo);
            cmd.Parameters.AddWithValue("@Valor", valor);
            cmd.Parameters.AddWithValue("@Id", id);

            try
            {
                cmd.Connection = con.conectar();
                cmd.ExecuteNonQuery();
                con.desconectar();
                this.mensagem = "Alterado com sucesso!";
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
