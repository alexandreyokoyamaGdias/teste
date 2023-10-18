//using SGPPC.Class;
//using SGPPC.Modelo;
//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
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
//                ProdutoAlterarControle produtoAlterarControle = new ProdutoAlterarControle();
//                String mensagem = produtoAlterarControle.AlterarProd(txbNomeProdAlt.Text.Trim(), txbDescricaoProdAlt.Text.Trim(), txbValorProdAlt.Text.Trim(), maskTxbDataProdAlt.Text.Trim(), txbId.Text);

//                if (produtoAlterarControle.tem)
//                {
//                    MessageBox.Show(mensagem, "Alteração", MessageBoxButtons.OK, MessageBoxIcon.Information);
//                    LimparFormulario.LimparForm(this);
//                }
//                else
//                {
//                    MessageBox.Show(produtoAlterarControle.mensagem);
//                }
//            }
//        }

//        private void FrmAlterarProduto_Load(object sender, EventArgs e)
//        {

//        }
//    }
//}

using SGPPC.Class;
using SGPPC.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SGPPC.Views.Produto
{
    public partial class FrmAlterarProduto : Form
    {
        public FrmAlterarProduto()
        {
            InitializeComponent();
        }

        public FrmAlterarProduto(string nome, string descricao, string valor, string data, string id)
        {
            InitializeComponent();

            // Preencher os campos da tela de edição com os valores do produto
            txbNomeProdAlt.Text = nome;
            txbDescricaoProdAlt.Text = descricao;
            txbValorProdAlt.Text = valor;
            maskTxbDataProdAlt.Text = data;
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
                decimal.TryParse(txbValorProdAlt.Text, out decimal valorteste);
                if (Int32.TryParse(txbId.Text, out Int32 id))
                {
                    ProdutoAlterarControle produtoAlterarControle = new ProdutoAlterarControle();
                    String mensagem = produtoAlterarControle.AlterarProd(id, txbNomeProdAlt.Text.Trim(), txbDescricaoProdAlt.Text.Trim(), valorteste, maskTxbDataProdAlt.Text.Trim());

                    if (produtoAlterarControle.tem)
                    {
                        MessageBox.Show(mensagem, "Alteração", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimparFormulario.LimparForm(this);
                    }
                    else
                    {
                        MessageBox.Show(produtoAlterarControle.mensagem);
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

        }
    }
}

