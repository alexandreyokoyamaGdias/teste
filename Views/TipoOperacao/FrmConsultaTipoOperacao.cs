using SGPPC.Model;
using SGPPC.Views.Sabores;
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
    public partial class FrmConsultaTipoOperacao : Form
    {
        private BindingSource bindingSource = new BindingSource();

        public FrmConsultaTipoOperacao()
        {
            InitializeComponent();
        }

        private void FrmConsultaTipoOperacao_Load(object sender, EventArgs e)
        {
            comboBoxPesquisaTipoOperacoes.SelectedIndex = 0;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            Views.TipoOperacao.FrmCadastroTipoOperacao frmCadastroTipoOperacao = new Views.TipoOperacao.FrmCadastroTipoOperacao();
                frmCadastroTipoOperacao.ShowDialog();
        }

        private void dtgViewTipoOperacao_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dtgViewTipoOperacao.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dtgViewTipoOperacao.Rows[e.RowIndex];
                string tipoOperacao = selectedRow.Cells["Tipo_Operacao"].Value.ToString();
                string descricao = selectedRow.Cells["Descricao"].Value.ToString();
                string id = selectedRow.Cells["Id"].Value.ToString();

                FrmEdicaoTipoOpercao telaEdicao = new FrmEdicaoTipoOpercao(tipoOperacao, descricao, id);
                telaEdicao.ShowDialog();
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            Conexao cx = new Conexao();
            ConsultarTipoOpercao consulta = new ConsultarTipoOpercao(cx);

            bindingSource.DataSource = consulta.LocalizarTipoOperacao(txbPesquisaTipoOperacao.Text);
            dtgViewTipoOperacao.DataSource = bindingSource;
        }
    }
}
