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
            if (txbNomeProdCadastro.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o campo Nota Fiscal", "Entrada produto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbNomeProdCadastro.Text = "";
                txbNomeProdCadastro.Focus();
                return;
            }
            else if (txbDescricaoProdCadastrado.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o campo Preço", "Entrada produto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbDescricaoProdCadastrado.Text = "";
                txbDescricaoProdCadastrado.Focus();
                return;
            }
            else if (txbValorProdCadastro.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o campo Quantidade", "Entrada produto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbValorProdCadastro.Text = "";
                txbValorProdCadastro.Focus();
                return;
            }
            else if (maskTxbDataProdCadastro.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o campo Fornecedor", "Entrada produto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                maskTxbDataProdCadastro.Text = "";
                maskTxbDataProdCadastro.Focus();
                return;
            }
            else if (cbFornecedorProdCadastro.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o campo Produto", "Entrada produto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbFornecedorProdCadastro.Text = "";
                cbFornecedorProdCadastro.Focus();
                return;
            }
            else if (cmbSaborCadastro.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o campo Produto", "Entrada produto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbSaborCadastro.Text = "";
                cmbSaborCadastro.Focus();
                return;
            }
            else
            {
                FrmPrincipal principalForm = Application.OpenForms.OfType<FrmPrincipal>().FirstOrDefault();
                if (principalForm != null)
                {
                    ProdutoControle fornecedorControle = new ProdutoControle();
                    String mensagem = fornecedorControle.CadastrarProd(txbNomeProdCadastro.Text.Trim(), txbDescricaoProdCadastrado.Text.Trim(), txbValorProdCadastro.Text.Trim(), maskTxbDataProdCadastro.Text.Trim(), cbFornecedorProdCadastro.Text.Trim(), cmbSaborCadastro.Text.Trim());

                    int userId = principalForm.UserID;
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

        //private void FrmCadastroProduto_Load(object sender, EventArgs e)
        //{
        //    string connectionString = "Data Source=ACF014\\SQLEXPRESS;Initial Catalog=SGPPC;Integrated Security=True";

        //    using (SqlConnection connection = new SqlConnection(connectionString))
        //    {
        //        connection.Open();

        //        string query = "SELECT Id, Nome FROM Fornecedor";
        //        string query2 = "SELECT Id, Descricao FROM Sabor";
                
        //        SqlCommand cmd2 = new SqlCommand(query2, connection);
        //        SqlCommand cmd = new SqlCommand(query, connection);

        //        using (SqlDataReader reader = cmd.ExecuteReader())
        //        {
        //            cbFornecedorProdCadastro.Items.Clear();

        //            while (reader.Read())
        //            {
        //                int fornecedorID = Convert.ToInt32(reader["Id"]);
        //                string fornecedorNome = reader["Nome"].ToString();
        //                cbFornecedorProdCadastro.Items.Add(new KeyValuePair<int, string>(fornecedorID, fornecedorNome));
        //            }
        //        }

        //        using (SqlDataReader reader2 = cmd2.ExecuteReader())
        //        {
        //            cmbSaborCadastro.Items.Clear();

        //            while (reader2.Read())
        //            {
        //                int produtoID = Convert.ToInt32(reader2["Id"]);
        //                string produtoDescricao = reader2["Descricao"].ToString();

        //                cmbSaborCadastro.Items.Add(new KeyValuePair<int, string>(produtoID, produtoDescricao));
        //            }
        //        }
        //    }
        //}

        private void FrmCadastroProduto_Load_1(object sender, EventArgs e)
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
                    cbFornecedorProdCadastro.Items.Clear();

                    while (reader.Read())
                    {
                        int fornecedorID = Convert.ToInt32(reader["Id"]);
                        string fornecedorNome = reader["Nome"].ToString();
                        cbFornecedorProdCadastro.Items.Add(new KeyValuePair<int, string>(fornecedorID, fornecedorNome));
                    }
                }

                using (SqlDataReader reader2 = cmd2.ExecuteReader())
                {
                    cmbSaborCadastro.Items.Clear();

                    while (reader2.Read())
                    {
                        int produtoID = Convert.ToInt32(reader2["Id"]);
                        string produtoDescricao = reader2["Descricao"].ToString();

                        cmbSaborCadastro.Items.Add(new KeyValuePair<int, string>(produtoID, produtoDescricao));
                    }
                }
            }
        }

        private void cbFornecedorProdCadastro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFornecedorProdCadastro.SelectedIndex != -1)
            {
                KeyValuePair<int, string> selectedFornecedor = (KeyValuePair<int, string>)cbFornecedorProdCadastro.SelectedItem;
                int fornecedorID = selectedFornecedor.Key;

                txbIdFornCadastro.Text = fornecedorID.ToString();
            }
        }

        private void cmbSaborCadastro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSaborCadastro.SelectedIndex != -1)
            {
                KeyValuePair<int, string> selectedSabor = (KeyValuePair<int, string>)cmbSaborCadastro.SelectedItem;
                int saborID = selectedSabor.Key;

                txbIdSaborCadastro.Text = saborID.ToString();
            }
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparFormulario.LimparForm(this);
        }
    }
}
