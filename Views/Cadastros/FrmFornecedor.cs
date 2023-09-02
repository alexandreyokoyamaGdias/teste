using SGPPC.Model;
using System;
using System.Windows.Forms;

namespace SGPPC.Views.Cadastros
{
    public partial class FrmFornecedor : Form
    {
        public FrmFornecedor()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnForSalvar_Click(object sender, EventArgs e)
        {
            CadastroFornecedor cad = new CadastroFornecedor(
                txtNome.Text,
                txtCNPJ.Text,
                txtPais.Text,
                txtCidade.Text,
                txtEstado.Text);

            MessageBox.Show(cad.mensagem);
        }
    }
}
