using SGPPC.Class;
using SGPPC.Data;
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

namespace SGPPC.Views.Pagamento
{
    public partial class FrmCadastrarFormasPagamento : Form
    {
        public FrmCadastrarFormasPagamento()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparFormulario.LimparForm(this);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txbFormaNome.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o campo Nome", "Cadastro da forma de pagamento", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbFormaNome.Text = "";
                txbFormaNome.Focus();
                return;
            }
            else if (txbFormaDescricao.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o campo Descrição", "Cadastro da forma de pagamento", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbFormaDescricao.Text = "";
                txbFormaDescricao.Focus();
                return;
            }
            else
            {
                FormaPagamentoControle formaPagamentoControle = new FormaPagamentoControle();
                String mensagem = formaPagamentoControle.CadastrarPagamento(txbFormaNome.Text.Trim(), txbFormaDescricao.Text.Trim());

                if (formaPagamentoControle.tem)
                {
                    MessageBox.Show(mensagem, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimparFormulario.LimparForm(this);
                }
                else
                {
                    MessageBox.Show(formaPagamentoControle.mensagem);
                }
            }
        }
    }
}
