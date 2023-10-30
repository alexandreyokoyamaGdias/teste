using SGPPC.Model;
using SGPPC.Views.Pagamento;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGPPC.Views.Usuarios
{
    public partial class FrmConsultaUsuario : Form
    {
        private BindingSource bindingSource = new BindingSource();

        public FrmConsultaUsuario()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            Views.Usuarios.FrmCadastro frmCadastro = new Views.Usuarios.FrmCadastro();
            frmCadastro.ShowDialog();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Conexao cx = new Conexao();
            ConsultaUsuario consulta = new ConsultaUsuario(cx);

            string pesquisa = txbPesquisaUsuario.Text;

            bindingSource.DataSource = consulta.LocalizarUsuario(pesquisa, pesquisa, pesquisa);

            dtgViewUsuarios.DataSource = bindingSource;
        }

        private void txbPesquisaUsuario_TextChanged(object sender, EventArgs e)
        {
            string filterColumn = comboBoxPesquisaUsuario.Text;
            string filterValue = txbPesquisaUsuario.Text;

            if (string.IsNullOrEmpty(filterValue))
            {
                bindingSource.RemoveFilter();
            }
            else
            {
                bindingSource.Filter = string.Format("{0} LIKE '%{1}%'", filterColumn, filterValue);
            }
        }

        private void FrmConsultaUsuario_Load(object sender, EventArgs e)
        {
            comboBoxPesquisaUsuario.SelectedIndex = 0;
        }

        private void dtgViewUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dtgViewUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dtgViewUsuarios.Rows[e.RowIndex];
                string nome = selectedRow.Cells["Nome"].Value.ToString();
                string email = selectedRow.Cells["E-mail"].Value.ToString();
                string cpf = selectedRow.Cells["CPF"].Value.ToString();
                string funcao = selectedRow.Cells["Função"].Value.ToString();
                string senha = selectedRow.Cells["Senha"].Value.ToString();
                string dataAd = selectedRow.Cells["Data Admissão"].Value.ToString();
                string id = selectedRow.Cells["Id"].Value.ToString();

                FrmEditarUsuario frmEditarUsuario = new FrmEditarUsuario(nome, email, cpf, funcao, senha, dataAd, id);
                frmEditarUsuario.ShowDialog();
            }
        }
    }
}
