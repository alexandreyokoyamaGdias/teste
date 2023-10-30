using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGPPC.Views.ProdutoEntrada
{
    public partial class FrmEdicaoEntradaProduto : Form
    {
        public FrmEdicaoEntradaProduto()
        {
            InitializeComponent();
        }

        private void btnCancelarEntrada_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
