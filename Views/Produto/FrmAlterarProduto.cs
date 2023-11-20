using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;
using SGPPC.Class;
using SGPPC.Data;
using SGPPC.Modelo;
using System;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace SGPPC.Views.Produto
{
    public partial class FrmAlterarProduto : Form
    {
        private int idSaborSelecionado;

        private int idFornecedorSelecionado;

        private string fornecedor;

        private int fornecedorIdDoProduto;

        private string descricaoOriginalNome;

        private string descricaoOrignalDescricao;

        private string descricaoOriginalValor;

        private string descricaoOriginalData;

        private string descricaoOriginalFornecedor;

        private string descricaoOriginalSabor;

        public int UserID { get; private set; }

        public FrmAlterarProduto()
        {
            InitializeComponent();
        }

        public FrmAlterarProduto(string nome, string descricao, string valor, string data, string fornecedor, string sabor, string id)
        {
            InitializeComponent();

            txbNomeProdAlt.Text = nome;
            txbDescricaoProdAlt.Text = descricao;
            txbValorProdAlt.Text = valor;
            maskTxbDataProdAlt.Text = data;
            txbIdFornEdit.Text = fornecedor;
            txbIdSaborEdit.Text = sabor;
            txbId.Text = id;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LimparFormulario.LimparForm(this);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (txbNomeProdAlt.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o campo Nome", "Alteração produto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbNomeProdAlt.Text = "";
                txbNomeProdAlt.Focus();
                return;
            }
            else if (txbDescricaoProdAlt.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o campo Descrição", "Alteração produto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbDescricaoProdAlt.Text = "";
                txbDescricaoProdAlt.Focus();
                return;
            }
            else if (txbValorProdAlt.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o campo Valor", "Alteração produto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbValorProdAlt.Text = "";
                txbValorProdAlt.Focus();
                return;
            }
            else if (!DateTime.TryParseExact(maskTxbDataProdAlt.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime data))
            {
                MessageBox.Show("Data inválida. Preencha o campo Data no formato dd/MM/yyyy.", "Alteração produto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                maskTxbDataProdAlt.Text = "";
                maskTxbDataProdAlt.Focus();
                return;
            }
            else
            {
                FrmPrincipal principalForm = Application.OpenForms.OfType<FrmPrincipal>().FirstOrDefault();
                if (principalForm != null) 
                {
                    decimal.TryParse(txbValorProdAlt.Text, out decimal valorteste);
                    if (Int32.TryParse(txbId.Text, out Int32 id))
                    {
                        ProdutoAlterarControle produtoAlterarControle = new ProdutoAlterarControle();
                        String mensagem = produtoAlterarControle.AlterarProd(id, txbNomeProdAlt.Text.Trim(), txbDescricaoProdAlt.Text.Trim(), valorteste, idFornecedorSelecionado.ToString(), idSaborSelecionado.ToString(), maskTxbDataProdAlt.Text.Trim());


                        int userId = principalForm.UserID;
                        if (produtoAlterarControle.tem)
                        {
                            string tabelaAfetada = "Produto";
                            DateTime dataHora = DateTime.Now;
                            string acao = "btnAlterar_Click";
                            string descricao = "Alteração: ";

                            if (descricaoOriginalNome != txbNomeProdAlt.Text)
                            {
                                descricao += "O 'Nome do Produto' foi alterado de " + "'" + descricaoOriginalNome + "'" + " para " + "'" + txbNomeProdAlt.Text + "'.";
                            }
                            else if (descricaoOrignalDescricao != txbDescricaoProdAlt.Text)
                            {
                                descricao += "A 'Descrição' foi alterada de " + "'" + descricaoOrignalDescricao + "'" + " para " + "'" + txbDescricaoProdAlt.Text + "'.";
                            }
                            else if (descricaoOriginalValor != txbValorProdAlt.Text)
                            {
                                descricao += "O 'Valor' foi alterado de " + "'" + descricaoOriginalValor + "'" + " para " + "'" + txbValorProdAlt.Text + "'.";
                            }
                            else if (descricaoOriginalData != maskTxbDataProdAlt.Text)
                            {
                                descricao += "A 'Data' foi alterada de " + "'" + descricaoOriginalData + "'" + " para " + "'" + maskTxbDataProdAlt.Text + "'.";
                            }
                            else if (descricaoOriginalFornecedor != cbFornecedorProdAlt.Text)
                            {
                                descricao += "O 'Fornecedor' foi alterado de " + "'" + descricaoOriginalFornecedor + "'" + " para " + "'" + cbFornecedorProdAlt.Text + "'.";
                            }
                            else if (descricaoOriginalSabor != cmbSaborEdit.Text)
                            {
                                descricao += "O 'Sabor' foi alterado de " + "'" + descricaoOriginalSabor + "'" + " para " + "'" + cmbSaborEdit.Text + "'.";
                            }

                            InserirLogsComands inserirLogs = new InserirLogsComands(tabelaAfetada, dataHora, acao, descricao, userId);

                            MessageBox.Show(mensagem, "Alteração", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Close();    
                        }
                        else
                        {
                            string tabelaAfetada = "Produto";
                            DateTime dataHora = DateTime.Now;
                            string acao = "btnAlterar_Click";
                            string descricao = "Erro na alteração: ";

                            if (descricaoOriginalNome != txbNomeProdAlt.Text)
                            {
                                descricao += "O 'Nome do Produto' não pode ser alterado de " + "'" + descricaoOriginalNome + "'" + " para " + "'" + txbNomeProdAlt.Text + "'.";
                            }
                            else if (descricaoOrignalDescricao != txbDescricaoProdAlt.Text)
                            {
                                descricao += "A 'Descrição' não pode ser alterado de " + "'" + descricaoOrignalDescricao + "'" + " para " + "'" + txbDescricaoProdAlt.Text + "'.";
                            }
                            else if (descricaoOriginalValor != txbValorProdAlt.Text)
                            {
                                descricao += "O 'Valor' não pode ser alterado de " + "'" + descricaoOriginalValor + "'" + " para " + "'" + txbValorProdAlt.Text + "'.";
                            }
                            else if (descricaoOriginalData != maskTxbDataProdAlt.Text)
                            {
                                descricao += "A 'Data' não pode ser alterado de " + "'" + descricaoOriginalData + "'" + " para " + "'" + maskTxbDataProdAlt.Text + "'.";
                            }
                            else if (descricaoOriginalFornecedor != cbFornecedorProdAlt.Text)
                            {
                                descricao += "O 'Fornecedor' não pode ser alterado de " + "'" + descricaoOriginalFornecedor + "'" + " para " + "'" + cbFornecedorProdAlt.Text + "'.";
                            }
                            else if (descricaoOriginalSabor != cmbSaborEdit.Text)
                            {
                                descricao += "O 'Sabor' não pode ser alterado de " + "'" + descricaoOriginalSabor + "'" + " para " + "'" + cmbSaborEdit.Text + "'.";
                            }

                            InserirLogsComands inserirLogs = new InserirLogsComands(tabelaAfetada, dataHora, acao, descricao, userId);

                            MessageBox.Show(produtoAlterarControle.mensagem);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("ID inválido. O ID deve ser um número inteiro.", "Alteração produto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txbId.Text = "";
                    txbId.Focus();
                }
            }
        }

        private void FrmAlterarProduto_Load(object sender, EventArgs e)
        {
            descricaoOriginalNome = txbNomeProdAlt.Text;

            descricaoOrignalDescricao = txbDescricaoProdAlt.Text;

            descricaoOriginalValor = txbValorProdAlt.Text;

            descricaoOriginalData = maskTxbDataProdAlt.Text;

            descricaoOriginalFornecedor = cbFornecedorProdAlt.Text;

            descricaoOriginalSabor = cmbSaborEdit.Text;

            if (int.TryParse(txbIdSaborEdit.Text, out int selectedSaborID))
            {
                string connectionString = "Data Source = ACF014\\SQLEXPRESS; Initial Catalog = SGPPC; Integrated Security = True";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string queryTodosSabor = "SELECT Id, Descricao FROM Sabor";
                    using (SqlCommand cmdTodosSabor = new SqlCommand(queryTodosSabor, connection))
                    {
                        using (SqlDataReader reader = cmdTodosSabor.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int saborID = reader.GetInt32(reader.GetOrdinal("Id"));
                                string descricaoSabor = reader.GetString(reader.GetOrdinal("Descricao"));

                                SaborItem saborItem = new SaborItem(saborID, descricaoSabor);
                                cmbSaborEdit.Items.Add(saborItem);

                                if (saborID == selectedSaborID)
                                {
                                    idSaborSelecionado = saborID;
                                    cmbSaborEdit.SelectedIndex = cmbSaborEdit.Items.Count - 1;
                                }
                            }
                        }
                    }
                }
            }

            if (int.TryParse(txbIdFornEdit.Text, out int selectedFornecedorID))
            {
                string connectionString = "Data Source = ACF014\\SQLEXPRESS; Initial Catalog = SGPPC; Integrated Security = True";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string queryTodosFornecedores = "SELECT Id, Nome FROM Fornecedor";
                    using (SqlCommand cmdTodosFornecedores = new SqlCommand(queryTodosFornecedores, connection))
                    {
                        using (SqlDataReader reader = cmdTodosFornecedores.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int fornecedorID = reader.GetInt32(reader.GetOrdinal("Id"));
                                string nomeFornecedor = reader.GetString(reader.GetOrdinal("Nome"));

                                FornecedorItem fornecedorItem = new FornecedorItem(fornecedorID, nomeFornecedor);
                                cbFornecedorProdAlt.Items.Add(fornecedorItem);

                                if (fornecedorID == selectedFornecedorID)
                                {
                                    idFornecedorSelecionado = fornecedorID;
                                    cbFornecedorProdAlt.SelectedIndex = cbFornecedorProdAlt.Items.Count - 1;
                                }
                            }
                        }
                    }
                }
            }
        }

        public class FornecedorItem
        {
            public int Id { get; set; }
            public string Descricao { get; set; }

            public FornecedorItem(int id, string nome)
            {
                Id = id;
                Descricao = nome;
            }

            public override string ToString()
            {
                return Descricao;
            }
        }

        public class SaborItem
        {
            public int Id { get; set; }
            public string Nome { get; set; }

            public SaborItem(int id, string nome)
            {
                Id = id;
                Nome = nome;
            }

            public override string ToString()
            {
                return Nome;
            }
        }

        private void cbFornecedorProdAlt_SelectedIndexChanged(object sender, EventArgs e)
        {
            FornecedorItem fornecedorSelecionado = (FornecedorItem)cbFornecedorProdAlt.SelectedItem;
            idFornecedorSelecionado = fornecedorSelecionado.Id;
        }

        private void cmbSaborEdit_SelectedIndexChanged(object sender, EventArgs e)
        {
            SaborItem saborSelecionado = (SaborItem)cmbSaborEdit.SelectedItem;
            idSaborSelecionado = saborSelecionado.Id;
        }
    }
}
