using SGPPC.Class;
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

namespace SGPPC.Views.Fornecedor
{
    public partial class FrmConsultaFornecedor : Form
    {
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

            dgFornecedor.DataSource = colsulta.LocalizarAtivos(textBox1.Text);
        }

        private void dgFornecedor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow row = dgFornecedor.Rows[e.RowIndex];

                string id = row.Cells["Id"].Value.ToString();
                string nome = row.Cells["Nome"].Value.ToString();
                string cnpj = row.Cells["CNPJ"].Value.ToString();
                string pais = row.Cells["Pais"].Value.ToString();
                string cidade = row.Cells["Cidade"].ToString();
                string estado = row.Cells["Estado"].ToString();
                string status = row.Cells["Status"].ToString();

                
                //txbCNPJ.Text = cnpj;
                //txbNome.Text = nome;
                //txbPais.Text = pais;
                //txbCidade.Text = cidade;
                //txbEstado.Text = estado;
                //if(status == "Ativo")
                //{radioativo.checked = true;
                //else{
                //radioinativo.checked = true;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmConsultaFornecedor_Load(object sender, EventArgs e)
        {

        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            Conexao cx = new Conexao();

            ColsultaFornecedor colsulta = new ColsultaFornecedor(cx);

            dgFornecedor.DataSource = colsulta.LocalizarAtivos(textBox1.Text);
        }
    }
}
