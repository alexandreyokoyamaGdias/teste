using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGPPC.Controller
{
    public class EntradaProdutoController
    {
        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();

        public String mensagem;

        public EntradaProdutoController(Decimal Preco, Int32 Quantidade, Int32 Id_Produto, Int32 Id_Entrada)
        {
            try
            {
                cmd.Connection = conexao.conectar();
                cmd.CommandText = "INSERT INTO Produto_Entrada (Preco_Unitario, Quantidade, Id_Produtos, Id_EntradProd) VALUES (@preco, @quantidade, @idprod, @ident)";
                cmd.Parameters.AddWithValue("@preco", Preco);
                cmd.Parameters.AddWithValue("@quantidade", Quantidade);
                cmd.Parameters.AddWithValue("@idprod", Id_Produto);
                cmd.Parameters.AddWithValue("@ident", Id_Entrada);

                cmd.ExecuteNonQuery();

                conexao.desconectar();
                this.mensagem = "Cadastrado com sucesso!";
            }
            catch (SqlException e)
            {
                this.mensagem = "Erro ao se conectar com o banco de dados";
            }

        }
    }
}
