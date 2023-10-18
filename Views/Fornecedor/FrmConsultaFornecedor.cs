using SGPPC.Class;
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

namespace SGPPC.Views.Fornecedor
{
    public partial class FrmConsultaFornecedor : Form
    {
        private BindingSource bindingSource = new BindingSource();

        public FrmConsultaFornecedor()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Views.Fornecedor.FrmCadastroFornecedor frmCadastroFornecedor = new Views.Fornecedor.FrmCadastroFornecedor();
            frmCadastroFornecedor.ShowDialog();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Conexao cx = new Conexao();

            ColsultaFornecedor colsulta = new ColsultaFornecedor(cx);

            dgFornecedor.DataSource = colsulta.LocalizarAtivos(txtPesquisaFornecedor.Text);
        }

        private void dgFornecedor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow row = dgFornecedor.Rows[e.RowIndex];

                string nome = row.Cells["Nome"].Value.ToString();
                string cnpj = row.Cells["CNPJ"].Value.ToString();
                string pais = row.Cells["Pais"].Value.ToString();
                string cidade = row.Cells["Cidade"].Value.ToString();
                string estado = row.Cells["Estado"].Value.ToString();
                string id = row.Cells["Id"].Value.ToString();

                FrmAlterarFornecedor telaEdicao = new FrmAlterarFornecedor(cnpj, nome, pais, cidade, estado, id);
                telaEdicao.ShowDialog();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmConsultaFornecedor_Load(object sender, EventArgs e)
        {
            comboBoxPesquisarFornecedor.SelectedIndex = 0;
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            Conexao cx = new Conexao();

            ColsultaFornecedor consulta = new ColsultaFornecedor(cx);

            bindingSource.DataSource = consulta.LocalizarAtivos(txtPesquisaFornecedor.Text);

            dgFornecedor.DataSource = bindingSource;
        }

        private void txtPesquisaFornecedor_TextChanged(object sender, EventArgs e)
        {
            string filterColumn = comboBoxPesquisarFornecedor.Text;
            string filterValue = txtPesquisaFornecedor.Text;

            if (string.IsNullOrEmpty(filterValue))
            {
                bindingSource.RemoveFilter();
            }
            else
            {
                bindingSource.Filter = string.Format("{0} LIKE '%{1}%'", filterColumn, filterValue);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void comboBoxPesquisarFornecedor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
