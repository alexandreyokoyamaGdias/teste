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

namespace SGPPC.Views.Relatorios
{
    public partial class FrmEstoque : Form
    {
        private BindingSource bindingSource = new BindingSource();

        private DataTable dt;

        public FrmEstoque()
        {
            InitializeComponent();
        }

        public FrmEstoque(DataTable dt)
        {
            InitializeComponent();
            this.dt = dt;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Conexao cx = new Conexao();

            ConsultarEstoque consulta = new ConsultarEstoque(cx);

            bindingSource.DataSource = consulta.LocalizarEstoque(txtPesquisaEstoque.Text);

            dgEstoque.DataSource = bindingSource;
        }

        private void FrmEstoque_Load(object sender, EventArgs e)
        {
            comboBoxPesquisarEstoque.SelectedIndex = 0;
        }

        private void btnGerarRelatorio_Click(object sender, EventArgs e)
        {
            var dt = GerarDadosRelatorioEstoque();

            using (var frm = new FrmRelatorioEstoque(dt))
            {
                frm.ShowDialog();
            }
        }

        private DataTable GerarDadosRelatorioEstoque()
        {
            var dt = new DataTable();
            dt.Columns.Add("Id");
            dt.Columns.Add("Nome_Produto");
            dt.Columns.Add("Descricao");
            dt.Columns.Add("Preco_Unitario");
            dt.Columns.Add("Quantidade");
            dt.Columns.Add("Id_Fornecedor");
            dt.Columns.Add("Data_Hora_Entrada");

            foreach (DataGridViewRow item in dgEstoque.Rows)
            {
                dt.Rows.Add(item.Cells["Id"].Value.ToString(), item.Cells["Nome_Produto"].Value.ToString(), item.Cells["Descricao"].Value.ToString(),
                    item.Cells["Preco_Unitario"].Value.ToString(), item.Cells["Quantidade"].Value.ToString(), item.Cells["Id_Fornecedor"].Value.ToString(), item.Cells["Data_Hora_Entrada"].Value.ToString());
            }

            return dt;
        }



        private void dgEstoque_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtPesquisaEstoque_TextChanged(object sender, EventArgs e)
        {
            string filterColumn = comboBoxPesquisarEstoque.Text;
            string filterValue = txtPesquisaEstoque.Text;

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
