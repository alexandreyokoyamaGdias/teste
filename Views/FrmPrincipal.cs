using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGPPC
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
            atualizarDataHora();
        }
        private void MenuSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CadastroPedidos_Click(object sender, EventArgs e)
        {
            Views.Cadastros.FrmCadastroPedido frmCadastroPedido = new Views.Cadastros.FrmCadastroPedido();
            frmCadastroPedido.ShowDialog();
        }

        private void CadastroProdutos_Click(object sender, EventArgs e)
        {
            Views.Cadastros.FrmCadastroProduto frmCadastroProduto = new Views.Cadastros.FrmCadastroProduto();
            frmCadastroProduto.ShowDialog();
        }

        private void ConsultaProdutoMenu_Click(object sender, EventArgs e)
        {
            Views.Consultas.FrmConsultaProduto frmConsultaProduto = new Views.Consultas.FrmConsultaProduto();
            frmConsultaProduto.ShowDialog();
        }

        private void btnVendas_Click(object sender, EventArgs e)
        {
            Views.Vendas.FrmVenda frmVenda = new Views.Vendas.FrmVenda();
            frmVenda.ShowDialog();
        }

        private void btnCadastroFuncionario_Click(object sender, EventArgs e)
        {
            Views.Cadastros.FrmCadastroFuncionario frmCadastroFuncionario = new Views.Cadastros.FrmCadastroFuncionario();
            frmCadastroFuncionario.ShowDialog();
        }

        private void fornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Views.Cadastros.FrmFornecedor frmFornecedor = new Views.Cadastros.FrmFornecedor();
            frmFornecedor.ShowDialog();
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Views.Cadastros.FrmCadastroProduto frmCadastroProduto = new Views.Cadastros.FrmCadastroProduto();
            frmCadastroProduto.ShowDialog(); // ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            atualizarDataHora();
        }

        public void atualizarDataHora() 
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();
            lblData.Text = DateTime.Now.ToLongDateString();
        }
    }
}
