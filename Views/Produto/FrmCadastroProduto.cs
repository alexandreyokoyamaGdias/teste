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

namespace SGPPC.Views.Produto
{
    public partial class FrmCadastroProduto : Form
    {
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
                ProdutoControle fornecedorControle = new ProdutoControle();
                String mensagem = fornecedorControle.CadastrarProd(txbNomeProd.Text.Trim(), txbDescricaoProd.Text.Trim(), txbValorProd.Text.Trim(), maskTxbDataProd.Text.Trim());

                if (fornecedorControle.tem)
                {
                    MessageBox.Show(mensagem, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimparFormulario.LimparForm(this);
                }
                else
                {
                    MessageBox.Show(fornecedorControle.mensagem);
                }
            }
        }

        private void cbFornecedorProd_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void FrmCadastroProduto_Load(object sender, EventArgs e)
        {
            
        }
    }
}
