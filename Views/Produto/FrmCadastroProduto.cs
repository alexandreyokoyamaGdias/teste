using SGPPC.Class;
using SGPPC.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            ProdutoControle fornecedorControle = new ProdutoControle();
            String mensagem = fornecedorControle.CadastrarProd(txbNomeProd.Text, txbDescricaoProd.Text, txbValorProd.Text, maskTxbDataProd.Text);

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
}
