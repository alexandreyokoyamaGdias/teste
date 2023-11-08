using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;
using SGPPC.Class;
using SGPPC.Data;
using SGPPC.Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace SGPPC.Views.Produto
{
    public partial class FrmCadastroProduto : Form
    {
        public int UserID { get; private set; }

        public FrmCadastroProduto()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LimparFormulario.LimparForm(this);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txbNomeProd.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o campo Nome", "Cadastro produto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbNomeProd.Text = "";
                txbNomeProd.Focus();
                return;
            }
            else if (txbDescricaoProd.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o campo Descrição", "Cadastro produto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbDescricaoProd.Text = "";
                txbDescricaoProd.Focus();
                return;
            }
            else if (txbValorProd.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o campo Valor", "Cadastro produto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbValorProd.Text = "";
                txbValorProd.Focus();
                return;
            }
            else if (!DateTime.TryParseExact(maskTxbDataProd.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime data))
            {
                MessageBox.Show("Data inválida. Preencha o campo Data no formato dd/MM/yyyy.", "Cadastro produto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                maskTxbDataProd.Text = "";
                maskTxbDataProd.Focus();
                return;
            }
            else
            {
                FrmPrincipal principalForm = Application.OpenForms.OfType<FrmPrincipal>().FirstOrDefault();
                if (principalForm != null)
                {
                    ProdutoControle fornecedorControle = new ProdutoControle();
                    String mensagem = fornecedorControle.CadastrarProd(txbNomeProd.Text.Trim(), txbDescricaoProd.Text.Trim(), txbValorProd.Text.Trim(), maskTxbDataProd.Text.Trim(), txbIdFoornecedor.Text.Trim(), txbIdSabor.Text.Trim());

                    int userId = principalForm.UserID; // Obtenha o UserID da instância de FrmPrincipal
                    if (fornecedorControle.tem)
                    {
                        string tabelaAfetada = "Produto";
                        DateTime dataHora = DateTime.Now;
                        string acao = "button1_Click";
                        string descricao = "Cadastro de produto bem-sucedido";

                        InserirLogsComands inserirLogs = new InserirLogsComands(tabelaAfetada, dataHora, acao, descricao, userId);

                        MessageBox.Show(mensagem, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    else
                    {
                        string tabelaAfetada = "Produto";
                        DateTime dataHora = DateTime.Now;
                        string acao = "button1_Click";
                        string descricao = "Erro ao cadastrar produto";

                        InserirLogsComands inserirLogs = new InserirLogsComands(tabelaAfetada, dataHora, acao, descricao, userId);

                        MessageBox.Show(fornecedorControle.mensagem);
                    }

                }     
            }
        }

        private void cbFornecedorProd_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFornecedorProd.SelectedIndex != -1)
            {
                KeyValuePair<int, string> selectedFornecedor = (KeyValuePair<int, string>)cbFornecedorProd.SelectedItem;
                int fornecedorID = selectedFornecedor.Key;

                txbIdFoornecedor.Text = fornecedorID.ToString();
            }
        }

        private void FrmCadastroProduto_Load(object sender, EventArgs e)
        {
            string connectionString = "Data Source=ACF014\\SQLEXPRESS;Initial Catalog=SGPPC;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT Id, Nome FROM Fornecedor";
                string query2 = "SELECT Id, Descricao FROM Sabor";
                
                SqlCommand cmd2 = new SqlCommand(query2, connection);
                SqlCommand cmd = new SqlCommand(query, connection);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    cbFornecedorProd.Items.Clear();

                    while (reader.Read())
                    {
                        int fornecedorID = Convert.ToInt32(reader["Id"]);
                        string fornecedorNome = reader["Nome"].ToString();
                        cbFornecedorProd.Items.Add(new KeyValuePair<int, string>(fornecedorID, fornecedorNome));
                    }
                }

                using (SqlDataReader reader2 = cmd2.ExecuteReader())
                {
                    cmbSabor.Items.Clear();

                    while (reader2.Read())
                    {
                        int saborID = Convert.ToInt32(reader2["Id"]);
                        string saborDescricao = reader2["Descricao"].ToString();

                        cmbSabor.Items.Add(new KeyValuePair<int, string>(saborID, saborDescricao));
                    }
                }
            }
        }

        private void cmbSabor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSabor.SelectedIndex != -1)
            {
                KeyValuePair<int, string> selectedSabor = (KeyValuePair<int, string>)cmbSabor.SelectedItem;
                int saborID = selectedSabor.Key;

                txbIdSabor.Text = saborID.ToString();
            }
        }
    }
}
