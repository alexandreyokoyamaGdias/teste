using SGPPC.Model;
using SGPPC.Views.Fornecedor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGPPC.Views.ControleCaixa
{
    public partial class FrmConsultaControleCaixa : Form
    {
        private BindingSource bindingSource = new BindingSource();

        public FrmConsultaControleCaixa()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Views.ControleCaixa.FrmControleCaixa frmControleCaixa = new FrmControleCaixa();
            frmControleCaixa.ShowDialog();
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            string filterColumn = comboBoxPesquisarControleCaixa.Text;
            string filterValue = txtPesquisar.Text;

            if (string.IsNullOrEmpty(filterValue))
            {
                bindingSource.RemoveFilter();
            }
            else
            {
                bindingSource.Filter = string.Format("{0} LIKE '%{1}%'", filterColumn, filterValue);
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Conexao cx = new Conexao();

            ConsultaControleCaixa consulta = new ConsultaControleCaixa(cx);

            string pesquisa = txtPesquisar.Text;

            bindingSource.DataSource = consulta.LocalizarControleCaixa(pesquisa, pesquisa, pesquisa, pesquisa);

            dgControleCaixa.DataSource = bindingSource;
        }

        private void FrmConsultaControleCaixa_Load(object sender, EventArgs e)
        {
            comboBoxPesquisarControleCaixa.SelectedIndex = 0;
        }

        private void dgFornecedor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow row = dgControleCaixa.Rows[e.RowIndex];

                string motivo = row.Cells["Motivo"].Value.ToString();
                string tipo = row.Cells["Tipo_Operacao"].Value.ToString();
                string valor = row.Cells["Valor"].Value.ToString();
                string data = row.Cells["Data_Hora"].ToString();

                FrmEditarControleCaixa telaEdicao = new FrmEditarControleCaixa(motivo, tipo, valor, data);
                telaEdicao.ShowDialog();
            }
        }
    }
}
