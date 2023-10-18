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

namespace SGPPC.Views.Pagamento
{
    public partial class FrmConsultaFormasPagamento : Form
    {
        private BindingSource bindingSource = new BindingSource();

        public FrmConsultaFormasPagamento()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Views.Pagamento.FrmCadastrarFormasPagamento frmCadastrarFormasPagamento = new Views.Pagamento.FrmCadastrarFormasPagamento();
            frmCadastrarFormasPagamento.ShowDialog();
        }

        private void dgPagamento_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgPagamento.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgPagamento.Rows[e.RowIndex];
                string nome = selectedRow.Cells["Nome"].Value.ToString();
                string descricao = selectedRow.Cells["Descricao"].Value.ToString();

                // Passe esses valores para a tela de edição
                FrmAlterarFormasPagamento telaEdicaoPagamento = new FrmAlterarFormasPagamento(nome, descricao);
                telaEdicaoPagamento.ShowDialog();
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            Conexao cx = new Conexao();
            ConsultarPagamento consulta = new ConsultarPagamento(cx);

            string pesquisa = txtPesquisaPagamento.Text;

            bindingSource.DataSource = consulta.LocalizarPagamento(pesquisa, pesquisa);

            dgPagamento.DataSource = bindingSource;
        }

        private void FrmConsultaFormasPagamento_Load(object sender, EventArgs e)
        {
            comboBoxPesquisarPagamento.SelectedIndex = 0;
        }

        private void txtPesquisaPagamento_TextChanged(object sender, EventArgs e)
        {
            string filterColumn = comboBoxPesquisarPagamento.Text;
            string filterValue = txtPesquisaPagamento.Text;

            if (string.IsNullOrEmpty(filterValue))
            {
                bindingSource.RemoveFilter();
            }
            else
            {
                bindingSource.Filter = string.Format("{0} LIKE '%{1}%'", filterColumn, filterValue);
            }
        }
    }
}
