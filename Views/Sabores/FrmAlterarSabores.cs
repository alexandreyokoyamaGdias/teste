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

namespace SGPPC.Views.Sabores
{
    public partial class FrmAlterarSabores : Form
    {
        public FrmAlterarSabores()
        {
            InitializeComponent();
        }

        public FrmAlterarSabores(string descricao)
        {
            InitializeComponent();

            // Preencher os campos da tela de edição com os valores do produto
            txbAlterarDescricao.Text = descricao;

        }

        private void FrmAlterarSabores_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelarSabor_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimparSabor_Click(object sender, EventArgs e)
        {
            LimparFormulario.LimparForm(this);
        }
    }
}
