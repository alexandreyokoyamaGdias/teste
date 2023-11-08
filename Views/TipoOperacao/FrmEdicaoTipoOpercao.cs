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
    public partial class FrmEdicaoTipoOpercao : Form
    {
        public FrmEdicaoTipoOpercao()
        {
            InitializeComponent();
        }

        public FrmEdicaoTipoOpercao(string tipoOperacao, string descricao, string id)
        {
            InitializeComponent();

            txbEdtTipoOperacao.Text = descricao;
            txbEdtDescricao.Text = descricao;
            txbId.Text = id;
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
