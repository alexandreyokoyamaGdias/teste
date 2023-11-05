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

namespace SGPPC.Views.Relatorios
{
    public partial class FrmVendas : Form
    {
        private BindingSource bindingSource = new BindingSource();

        public FrmVendas()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            Conexao cx = new Conexao();

            ConsultarVendas consulta = new ConsultarVendas(cx);

            bindingSource.DataSource = consulta.LocalizarVendas(txtPesquisaVendas.Text);

            dgVendas.DataSource = bindingSource;
        }

        private void FrmVendas_Load(object sender, EventArgs e)
        {
            comboBoxPesquisarVendas.SelectedIndex = 0;
        }

        private void txtPesquisaVendas_TextChanged(object sender, EventArgs e)
        {
            string filterColumn = comboBoxPesquisarVendas.Text;
            string filterValue = txtPesquisaVendas.Text;

            if (string.IsNullOrEmpty(filterValue))
            {
                bindingSource.RemoveFilter();
            }
            else
            {
                bindingSource.Filter = string.Format("{0} LIKE '%{1}%'", filterColumn, filterValue);
            }
        }

        private void dgVendas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow row = dgVendas.Rows[e.RowIndex];

                string cnpj = row.Cells["Nome_Produto"].Value.ToString();
                //string nome = row.Cells["Nome"].Value.ToString();
                //string pais = row.Cells["Pais"].Value.ToString();
                //string cidade = row.Cells["Cidade"].Value.ToString();
                //string estado = row.Cells["Estado"].Value.ToString();
                //string status = row.Cells["Status"].Value.ToString();
            }
        }

        private void btnGerarRelatorio_Click(object sender, EventArgs e)
        {
            var dt = GerarDadosRelatorioVendas();

            using (var frm = new FrmVendasView(dt))
            {
                frm.ShowDialog();
            }
        }

        private DataTable GerarDadosRelatorioVendas()
        {
            var dt = new DataTable();
            dt.Columns.Add("Nome_Produto");
            dt.Columns.Add("Nome_Cliente");
            dt.Columns.Add("Data_Hora_Pedido");
            dt.Columns.Add("Id_FormasPagamento");
            dt.Columns.Add("Qunatidade");
            dt.Columns.Add("Valor");

            foreach (DataGridViewRow item in dgVendas.Rows)
            {
                dt.Rows.Add(item.Cells["Nome_Produto"].Value.ToString(), item.Cells["Nome_Cliente"].Value.ToString(), item.Cells["Data_Hora_Pedido"].Value.ToString(),
                    item.Cells["Id_FormasPagamento"].Value.ToString(), item.Cells["Quantidade"].Value.ToString(), item.Cells["Valor"].Value.ToString());
            }

            return dt;
        }
    }
}
