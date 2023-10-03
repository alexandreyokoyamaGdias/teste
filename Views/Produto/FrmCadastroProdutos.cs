using SGPPC.Model;
using System;
using System.Windows.Forms;

namespace SGPPC.Views.Cadastros
{
    public partial class FrmCadastroProdutos : Form
    {
        public FrmCadastroProdutos()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnProSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                string nome = txtNomePro.Text;
                string descricao = txtDescricaoPro.Text;
                decimal preco = decimal.Parse(txtPrecoPro.Text);
                DateTime dataValidade = DateTime.Parse(txtDataValidadePro.Text);

                CadastroProduto cad = new CadastroProduto(nome, descricao, preco, dataValidade);

                MessageBox.Show(cad.mensagem);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message);
            }
        }

        private void FrmCadastroProduto_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sGPPCDataSet2.Produto' table. You can move, or remove it, as needed.
            this.produtoTableAdapter1.Fill(this.sGPPCDataSet2.Produto);
            // TODO: This line of code loads data into the 'sGPPCDataSet.Produto' table. You can move, or remove it, as needed.
            this.produtoTableAdapter.Fill(this.sGPPCDataSet.Produto);

        }

        private void AtualizarDataGridView()
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AtualizarDataGridView();
        }
    }
}
