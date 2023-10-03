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

namespace SGPPC.Views.Sabores
{
    public partial class FrmConsultaSabores : Form
    {
        public FrmConsultaSabores()
        {
            InitializeComponent();
        }

        private void btnCancelarSabor_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSalvarSabor_Click(object sender, EventArgs e)
        {
            Views.Sabores.FrmCadastroSabores frmCadastroSabores = new Views.Sabores.FrmCadastroSabores();
            frmCadastroSabores.ShowDialog();
        }

        private void btnAtualizarSabor_Click(object sender, EventArgs e)
        {
            Conexao cx = new Conexao();

            ConsulltarSabor colsulta = new ConsulltarSabor(cx);

            dgSabor.DataSource = colsulta.LocalizarSabor(txbPesquisa.Text);
        }
    }
}
