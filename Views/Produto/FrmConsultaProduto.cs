using SGPPC.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SGPPC.Views.Consultas
{
    public partial class FrmConsultaProduto : Form
    {
        public FrmConsultaProduto()
        {
            InitializeComponent();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            Views.Produto.FrmCadastroProduto frmCadastroProduto = new Views.Produto.FrmCadastroProduto();
            frmCadastroProduto.ShowDialog();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            Conexao cx = new Conexao();

            ConsultaProduto colsulta = new ConsultaProduto(cx);

            dtgViewProduto.DataSource = colsulta.Localizar(txbPesquisa.Text);
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {

        }
    }
}
