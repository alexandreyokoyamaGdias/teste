using SGPPC.Model;
using SGPPC.Views.Fornecedor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGPPC.Views.EntradaProduto
{
    public partial class FrmConsultaEntradaProduto : Form
    {
        private BindingSource bindingSource = new BindingSource();

        public FrmConsultaEntradaProduto()
        {
            InitializeComponent();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            Views.EntradaProduto.FrmCadastrarEntradaProduto frmCadastrarEntradaProduto = new FrmCadastrarEntradaProduto();
            frmCadastrarEntradaProduto.ShowDialog();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Conexao cx = new Conexao();

            ConsultaEntradaProduto consulta = new ConsultaEntradaProduto(cx);

            bindingSource.DataSource = consulta.LocalizarEntradaProduto(txtPesquisaEntradaProduto.Text);

            dgEntradaProduto.DataSource = bindingSource;
        }

        private void dgEntradaProduto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow row = dgEntradaProduto.Rows[e.RowIndex];

                string precoUnitario = row.Cells["Preco_Unitario"].Value.ToString();
                string quantidade = row.Cells["Quantidade"].Value.ToString();
                string id = row.Cells["Id"].Value.ToString();

                FrmEditarEntradaProduto telaEdicaoEntrada = new FrmEditarEntradaProduto(precoUnitario, quantidade, id);
                telaEdicaoEntrada.ShowDialog();
            }
        }

        private void txtPesquisaEntradaProduto_TextChanged(object sender, EventArgs e)
        {
            string filterColumn = comboBoxPesquisarEntradaProduto.Text;
            string filterValue = txtPesquisaEntradaProduto.Text;

            if (string.IsNullOrEmpty(filterValue))
            {
                bindingSource.RemoveFilter();
            }
            else
            {
                bindingSource.Filter = string.Format("{0} LIKE '%{1}%'", filterColumn, filterValue);
            }
        }

        private void FrmConsultaEntradaProduto_Load(object sender, EventArgs e)
        {
            comboBoxPesquisarEntradaProduto.SelectedIndex = 0;
        }
    }
}
