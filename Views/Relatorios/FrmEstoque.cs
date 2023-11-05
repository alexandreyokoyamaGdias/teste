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
            dt.Columns.Add("NomeProduto");
            dt.Columns.Add("Descricao");
            dt.Columns.Add("PrecoUnitario");
            dt.Columns.Add("Quantidade");
            dt.Columns.Add("NomeFornecedor");
            dt.Columns.Add("DataHoraEntrada");

            foreach (DataGridViewRow item in dgEstoque.Rows)
            {
                dt.Rows.Add(item.Cells["Id"].Value.ToString(), item.Cells["NomeProduto"].Value.ToString(), item.Cells["Descricao"].Value.ToString(),
                    item.Cells["PrecoUnitario"].Value.ToString(), item.Cells["Quantidade"].Value.ToString(), item.Cells["NomeFornecedor"].Value.ToString(), item.Cells["DataHoraEntrada"].Value.ToString());
            }

            return dt;
        }
    }
}
