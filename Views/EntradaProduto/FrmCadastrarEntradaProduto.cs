using SGPPC.Class;
using SGPPC.Data;
using SGPPC.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGPPC.Views.EntradaProduto
{
    public partial class FrmCadastrarEntradaProduto : Form
    {
        public FrmCadastrarEntradaProduto()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparFormulario.LimparForm(this);
        }

        private void FrmCadastrarEntradaProduto_Load(object sender, EventArgs e)
        {
            DateTime dataHoraAtual = DateTime.Now;
            maskedDataHoraEntrada.Text = dataHoraAtual.ToString("dd/MM/yyyy HH:mm");

            string connectionString = "Data Source=ACF014\\SQLEXPRESS;Initial Catalog=SGPPC;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT Id, Nome_Produto FROM Produto";

                SqlCommand cmd = new SqlCommand(query, connection);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    cbbProdutoEntrada.Items.Clear();

                    while (reader.Read())
                    {
                        int produtoEntradaID = Convert.ToInt32(reader["Id"]);
                        string produtoEntradaNome = reader["Nome_Produto"].ToString();
                        cbbProdutoEntrada.Items.Add(new KeyValuePair<int, string>(produtoEntradaID, produtoEntradaNome));
                    }
                }
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txbPreco.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o campo Preço.", "Cadastro Entrada Produto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbPreco.Text = "";
                txbPreco.Focus();
                return;
            }
            else if (txbQuantidade.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o campo Quantidade.", "Cadastro Entrada Produto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbQuantidade.Text = "";
                txbQuantidade.Focus();
                return;
            }
            else if (cbbProdutoEntrada.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Selecione o Produto.", "Cadastro Entrada Produto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbbProdutoEntrada.Text = "";
                cbbProdutoEntrada.Focus();
                return;
            }
            else
            {
                EntadaProdutoControle entradaprodutoControle = new EntadaProdutoControle();
                String mensagem = entradaprodutoControle.CadastrarEntProd(txbPreco.Text.Trim(), txbQuantidade.Text.Trim(), maskedDataHoraEntrada.Text.Trim());

                if (entradaprodutoControle.tem)
                {
                    string tabelaAfetada = "Cadastro Entrada de Produto";
                    DateTime dataHora = DateTime.Now;
                    string acao = "btnCadastrar_Click";
                    string descricao = "Cadastro de entrada do produto bem-sucedido";

                    InserirLogsComands inserirLogs = new InserirLogsComands(tabelaAfetada, dataHora, acao, descricao);

                    MessageBox.Show(mensagem, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimparFormulario.LimparForm(this);
                }
                else
                {
                    string tabelaAfetada = "Cadastro Entrada de Produto";
                    DateTime dataHora = DateTime.Now;
                    string acao = "btnCadastrar_Click";
                    string descricao = "Erro ao tentar cadastrar entrada do produto";

                    InserirLogsComands inserirLogs = new InserirLogsComands(tabelaAfetada, dataHora, acao, descricao);

                    MessageBox.Show(entradaprodutoControle.mensagem);
                }
            }
        }
    }
}
