using SGPPC.Model;
using System;
using System.Windows.Forms;

namespace SGPPC.Views.Cadastros
{
    public partial class FrmCadastroProduto : Form
    {
        public FrmCadastroProduto()
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

        }
    }
}
