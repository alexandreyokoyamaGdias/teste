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
        private string fornecedor;
        private int fornecedorIdDoProduto;

        public int UserID { get; private set; }

        public FrmAlterarProduto()
        {
            InitializeComponent();
        }

        //public FrmAlterarProduto(string nome, string descricao, string valor, string data, string id)
        //{
        //    InitializeComponent();

        //    // Preencher os campos da tela de edição com os valores do produto
        //    txbNomeProdAlt.Text = nome;
        //    txbDescricaoProdAlt.Text = descricao;
        //    txbValorProdAlt.Text = valor;
        //    maskTxbDataProdAlt.Text = data;
        //    //cbFornecedorProdAlt.SelectedItem = fornecedor;
        //    txbId.Text = id;
        //}

        public FrmAlterarProduto(string nome, string descricao, string valor, string data, string fornecedor, string id)
        {
            InitializeComponent();

            // Preencher os campos da tela de edição com os valores do produto
            txbNomeProdAlt.Text = nome;
            txbDescricaoProdAlt.Text = descricao;
            txbValorProdAlt.Text = valor;
            maskTxbDataProdAlt.Text = data;
            cbFornecedorProdAlt.SelectedItem = fornecedor;
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
                        String mensagem = produtoAlterarControle.AlterarProd(id, txbNomeProdAlt.Text.Trim(), txbDescricaoProdAlt.Text.Trim(), valorteste, maskTxbDataProdAlt.Text.Trim());

                        int userId = principalForm.UserID; // Obtenha o UserID da instância de FrmPrincipal
                        if (produtoAlterarControle.tem)
                        {
                            string tabelaAfetada = "Produto";
                            DateTime dataHora = DateTime.Now;
                            string acao = "btnAlterar_Click";
                            string descricao = "Alteração de produto bem-sucedida";

                            InserirLogsComands inserirLogs = new InserirLogsComands(tabelaAfetada, dataHora, acao, descricao, userId);

                            MessageBox.Show(mensagem, "Alteração", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Close();
                        }
                        else
                        {
                            string tabelaAfetada = "Produto";
                            DateTime dataHora = DateTime.Now;
                            string acao = "btnAlterar_Click";
                            string descricao = "Erro na alteração do produto";

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
            string connectionString = "Data Source = ACF014\\SQLEXPRESS; Initial Catalog = SGPPC; Integrated Security = True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT Nome FROM Fornecedor";
                SqlCommand cmd = new SqlCommand(query, connection);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    cbFornecedorProdAlt.Items.Clear();

                    while (reader.Read())
                    {
                        cbFornecedorProdAlt.Items.Add(reader["Nome"].ToString());
                    }
                }
            }
        }
    }
}





////using SGPPC.Class;
////using SGPPC.Modelo;
////using System;
////using System.Collections.Generic;
////using System.ComponentModel;
////using System.Data;
////using System.Drawing;
////using System.Globalization;
////using System.Linq;
////using System.Text;
////using System.Threading.Tasks;
////using System.Windows.Forms;
////using static System.Windows.Forms.VisualStyles.VisualStyleElement;

////namespace SGPPC.Views.Produto
////{
////    public partial class FrmAlterarProduto : Form
////    {
////        public FrmAlterarProduto()
////        {
////            InitializeComponent();
////        }

////        public FrmAlterarProduto(string nome, string descricao, string valor, string data, string id)
////        {
////            InitializeComponent();

////            // Preencher os campos da tela de edição com os valores do produto
////            txbNomeProdAlt.Text = nome;
////            txbDescricaoProdAlt.Text = descricao;
////            txbValorProdAlt.Text = valor;
////            maskTxbDataProdAlt.Text = data;
////            txbId.Text = id;
////        }

////        private void button2_Click(object sender, EventArgs e)
////        {
////            LimparFormulario.LimparForm(this);
////        }

////        private void button3_Click(object sender, EventArgs e)
////        {
////            Close();
////        }

////        private void btnAlterar_Click(object sender, EventArgs e)
////        {
////            if (txbNomeProdAlt.Text.ToString().Trim() == "")
////            {
////                MessageBox.Show("Preencha o campo Nome", "Alteração produto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
////                txbNomeProdAlt.Text = "";
////                txbNomeProdAlt.Focus();
////                return;
////            }
////            else if (txbDescricaoProdAlt.Text.ToString().Trim() == "")
////            {
////                MessageBox.Show("Preencha o campo Descrição", "Alteração produto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
////                txbDescricaoProdAlt.Text = "";
////                txbDescricaoProdAlt.Focus();
////                return;
////            }
////            else if (txbValorProdAlt.Text.ToString().Trim() == "")
////            {
////                MessageBox.Show("Preencha o campo Valor", "Alteração produto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
////                txbValorProdAlt.Text = "";
////                txbValorProdAlt.Focus();
////                return;
////            }
////            else if (!DateTime.TryParseExact(maskTxbDataProdAlt.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime data))
////            {
////                MessageBox.Show("Data inválida. Preencha o campo Data no formato dd/MM/yyyy.", "Alteração produto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
////                maskTxbDataProdAlt.Text = "";
////                maskTxbDataProdAlt.Focus();
////                return;
////            }
////            else
////            {
////                ProdutoAlterarControle produtoAlterarControle = new ProdutoAlterarControle();
////                String mensagem = produtoAlterarControle.AlterarProd(txbNomeProdAlt.Text.Trim(), txbDescricaoProdAlt.Text.Trim(), txbValorProdAlt.Text.Trim(), maskTxbDataProdAlt.Text.Trim(), txbId.Text);

////                if (produtoAlterarControle.tem)
////                {
////                    MessageBox.Show(mensagem, "Alteração", MessageBoxButtons.OK, MessageBoxIcon.Information);
////                    LimparFormulario.LimparForm(this);
////                }
////                else
////                {
////                    MessageBox.Show(produtoAlterarControle.mensagem);
////                }
////            }
////        }

////        private void FrmAlterarProduto_Load(object sender, EventArgs e)
////        {

////        }
////    }
////}

//using SGPPC.Class;
//using SGPPC.Modelo;
//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Data.SqlClient;
//using System.Drawing;
//using System.Globalization;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;

//namespace SGPPC.Views.Produto
//{
//    public partial class FrmAlterarProduto : Form
//    {
//        public FrmAlterarProduto()
//        {
//            InitializeComponent();
//        }

//        public FrmAlterarProduto(string nome, string descricao, string valor, string data, string id)
//        {
//            InitializeComponent();

//            // Preencher os campos da tela de edição com os valores do produto
//            txbNomeProdAlt.Text = nome;
//            txbDescricaoProdAlt.Text = descricao;
//            txbValorProdAlt.Text = valor;
//            maskTxbDataProdAlt.Text = data;
//            txbId.Text = id;
//        }

//        private void button2_Click(object sender, EventArgs e)
//        {
//            LimparFormulario.LimparForm(this);
//        }

//        private void button3_Click(object sender, EventArgs e)
//        {
//            Close();
//        }

//        private void btnAlterar_Click(object sender, EventArgs e)
//        {
//            if (txbNomeProdAlt.Text.ToString().Trim() == "")
//            {
//                MessageBox.Show("Preencha o campo Nome", "Alteração produto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
//                txbNomeProdAlt.Text = "";
//                txbNomeProdAlt.Focus();
//                return;
//            }
//            else if (txbDescricaoProdAlt.Text.ToString().Trim() == "")
//            {
//                MessageBox.Show("Preencha o campo Descrição", "Alteração produto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
//                txbDescricaoProdAlt.Text = "";
//                txbDescricaoProdAlt.Focus();
//                return;
//            }
//            else if (txbValorProdAlt.Text.ToString().Trim() == "")
//            {
//                MessageBox.Show("Preencha o campo Valor", "Alteração produto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
//                txbValorProdAlt.Text = "";
//                txbValorProdAlt.Focus();
//                return;
//            }
//            else if (!DateTime.TryParseExact(maskTxbDataProdAlt.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime data))
//            {
//                MessageBox.Show("Data inválida. Preencha o campo Data no formato dd/MM/yyyy.", "Alteração produto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
//                maskTxbDataProdAlt.Text = "";
//                maskTxbDataProdAlt.Focus();
//                return;
//            }
//            else
//            {
//                decimal.TryParse(txbValorProdAlt.Text, out decimal valorteste);
//                if (Int32.TryParse(txbId.Text, out Int32 id))
//                {
//                    ProdutoAlterarControle produtoAlterarControle = new ProdutoAlterarControle();
//                    String mensagem = produtoAlterarControle.AlterarProd(id, txbNomeProdAlt.Text.Trim(), txbDescricaoProdAlt.Text.Trim(), valorteste, maskTxbDataProdAlt.Text.Trim());

//                    if (produtoAlterarControle.tem)
//                    {
//                        MessageBox.Show(mensagem, "Alteração", MessageBoxButtons.OK, MessageBoxIcon.Information);
//                        Close();
//                    }
//                    else
//                    {
//                        MessageBox.Show(produtoAlterarControle.mensagem);
//                    }
//                }
//                else
//                {
//                    MessageBox.Show("ID inválido. O ID deve ser um número inteiro.", "Alteração produto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
//                    txbId.Text = "";
//                    txbId.Focus();
//                }
//            }
//        }

//        private void FrmAlterarProduto_Load(object sender, EventArgs e)
//        {
//            // Configurar a conexão com o banco de dados (substitua a string de conexão conforme necessário)
//            string connectionString = "Data Source = ACF014\\SQLEXPRESS; Initial Catalog = SGPPC; Integrated Security = True";
//            using (SqlConnection connection = new SqlConnection(connectionString))
//            {
//                connection.Open();

//                // Defina sua consulta SQL para recuperar os usuários da tabela do banco de dados
//                string query = "SELECT Nome FROM Fornecedor";
//                SqlCommand cmd = new SqlCommand(query, connection);

//                // Crie um leitor de dados para ler os resultados da consulta
//                using (SqlDataReader reader = cmd.ExecuteReader())
//                {
//                    // Limpe os itens existentes no ComboBox, se houver algum
//                    cbFornecedorProdAlt.Items.Clear();

//                    // Preencha o ComboBox com os resultados da consulta
//                    while (reader.Read())
//                    {
//                        cbFornecedorProdAlt.Items.Add(reader["Nome"].ToString());
//                    }
//                }
//            }
//        }
//    }
//}

