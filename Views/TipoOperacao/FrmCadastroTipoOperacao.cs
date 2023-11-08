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

namespace SGPPC.Views.TipoOperacao
{
    public partial class FrmCadastroTipoOperacao : Form
    {
        public FrmCadastroTipoOperacao()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparFormulario.LimparForm(this);
        }
    }
}
