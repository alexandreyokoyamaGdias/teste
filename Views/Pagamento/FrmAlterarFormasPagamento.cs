using SGPPC.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGPPC.Views.Pagamento
{
    public partial class FrmAlterarFormasPagamento : Form
    {
        public FrmAlterarFormasPagamento()
        {
            InitializeComponent();
        }

        public FrmAlterarFormasPagamento(string nome, string descricao)
        {
            InitializeComponent();

            txbFormaNome.Text = nome;
            txbFormaPDescricaoo.Text = descricao;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparFormulario.LimparForm(this);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmAlterarFormasPagamento_Load(object sender, EventArgs e)
        {

        }
    }
}
