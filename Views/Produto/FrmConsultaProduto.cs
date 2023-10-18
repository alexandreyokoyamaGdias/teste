using SGPPC.Model;
using SGPPC.Views.Produto;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace SGPPC.Views.Consultas
{
    public partial class FrmConsultaProduto : Form
    {
        private BindingSource bindingSource = new BindingSource();

        private string nomeProdutoSelecionado;
        private string descricaoProdutoSelecionado;
        private string valorProdutoSelecionado;
        private string dataProdutoSelecionado;

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
            ConsultaProduto consulta = new ConsultaProduto(cx);

            bindingSource.DataSource = consulta.Localizar(txbPesquisa.Text);

            dtgViewProduto.DataSource = bindingSource;
        }

        private void FrmConsultaProduto_Load(object sender, EventArgs e)
        {
            comboBoxPesquisaProd.SelectedIndex = 0;
        }

        private void txbPesquisa_TextChanged(object sender, EventArgs e)
        {
            string filterColumn = comboBoxPesquisaProd.Text;
            string filterValue = txbPesquisa.Text;

            if (string.IsNullOrEmpty(filterValue))
            {
                bindingSource.RemoveFilter();
            }
            else
            {
                bindingSource.Filter = string.Format("{0} LIKE '%{1}%'", filterColumn, filterValue);
            }
        }

        private void dtgViewProduto_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            dtgViewProduto.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dtgViewProduto.Rows[e.RowIndex];
                string nome = selectedRow.Cells["Nome_Produto"].Value.ToString();
                string descricao = selectedRow.Cells["Descricao"].Value.ToString();
                string valor = selectedRow.Cells["Valor"].Value.ToString();
                string data = selectedRow.Cells["Data_Validade"].Value.ToString();
                string id = selectedRow.Cells["Id"].Value.ToString();

                FrmAlterarProduto telaEdicao = new FrmAlterarProduto(nome, descricao, valor, data, id);
                telaEdicao.ShowDialog();
            }
        }

        private void btnAtualizar_Click_1(object sender, EventArgs e)
        {
            Conexao cx = new Conexao();
            ConsultaProduto consulta = new ConsultaProduto(cx);
            bindingSource.DataSource = consulta.Localizar(txbPesquisa.Text);

            dtgViewProduto.DataSource = bindingSource;
        }
    }
}
