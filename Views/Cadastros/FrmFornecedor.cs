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
            if (txtCNPJ.Text == "  ,   ,   /    -" || txtCNPJ.Text.Length < 18)
            {
                MessageBox.Show("Preencha o campo cnpj", "Cadastro fornecedor", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCNPJ.Text = "";
                txtCNPJ.Focus();
                return;
            }

            if (txtNome.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o campo nome", "Cadastro fornecedor", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNome.Text = "";
                txtNome.Focus();
                return;
            }

            if (txtPais.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o campo país", "Cadastro fornecedor", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPais.Text = "";
                txtPais.Focus();
                return;
            }

            if (txtCidade.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o campo cidade", "Cadastro fornecedor", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCidade.Text = "";
                txtCidade.Focus();
                return;
            }

            if (txtEstado.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o campo estado", "Cadastro fornecedor", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEstado.Text = "";
                txtEstado.Focus();
                return;
            }

            CadastroFornecedor cad = new CadastroFornecedor(
                txtNome.Text,
                txtCNPJ.Text,
                txtPais.Text,
                txtCidade.Text,
                txtEstado.Text);

            MessageBox.Show(cad.mensagem);
        }

        private void listViewFornecedor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FrmFornecedor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sGPPCDataSet1.Fornecedor' table. You can move, or remove it, as needed.
            this.fornecedorTableAdapter.Fill(this.sGPPCDataSet1.Fornecedor);

        }
    }
}