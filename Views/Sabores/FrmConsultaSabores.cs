using SGPPC.Model;
using SGPPC.Views.Produto;
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
        private BindingSource bindingSource = new BindingSource();

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
            ConsulltarSabor consulta = new ConsulltarSabor(cx);

            bindingSource.DataSource = consulta.LocalizarSabor(txbPesquisaSabor.Text);
            dgSabor.DataSource = bindingSource;
        }

        private void FrmConsultaSabores_Load(object sender, EventArgs e)
        {
            comboBoxPesquisaSabor.SelectedIndex = 0;
        }

        private void txbPesquisaSabor_TextChanged(object sender, EventArgs e)
        {
            string filterColumn = comboBoxPesquisaSabor.Text;
            string filterValue = txbPesquisaSabor.Text;

            if (string.IsNullOrEmpty(filterValue))
            {
                bindingSource.RemoveFilter();
            }
            else
            {
                bindingSource.Filter = string.Format("{0} LIKE '%{1}%'", filterColumn, filterValue);
            }
        }

        private void dgSabor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgSabor.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgSabor.Rows[e.RowIndex];
                string descricao = selectedRow.Cells["Descricao"].Value.ToString();

                // Passe esses valores para a tela de edição
                FrmAlterarSabores telaEdicao = new FrmAlterarSabores(descricao);
                telaEdicao.ShowDialog();
            }
        }
    }
}
