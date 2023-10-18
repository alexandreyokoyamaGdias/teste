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
            Views.Cadastros.FrmCadastroProdutos frmCadastroProduto = new Views.Cadastros.FrmCadastroProdutos();
            frmCadastroProduto.ShowDialog();
        }

        private void ConsultaProdutoMenu_Click(object sender, EventArgs e)
        {
            Views.Consultas.FrmConsultaProduto frmConsultaProduto = new Views.Consultas.FrmConsultaProduto();
            frmConsultaProduto.ShowDialog();
        }

        private void btnVendas_Click(object sender, EventArgs e)
        {
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
            Views.Cadastros.FrmCadastroProdutos frmCadastroProduto = new Views.Cadastros.FrmCadastroProdutos();
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

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Views.Fornecedor.FrmConsultaFornecedor frmConsultaFornecedor = new Views.Fornecedor.FrmConsultaFornecedor();
            frmConsultaFornecedor.ShowDialog();
        }

        private void produtoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Views.Consultas.FrmConsultaProduto frmConsultaProduto = new Views.Consultas.FrmConsultaProduto();
            frmConsultaProduto.ShowDialog();
        }

        private void saboresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Views.Sabores.FrmConsultaSabores frmConsultaSabores = new Views.Sabores.FrmConsultaSabores();
            frmConsultaSabores.ShowDialog();
        }

        private void formasDePagamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Views.Pagamento.FrmConsultaFormasPagamento frmConsultaFormasPagamento = new Views.Pagamento.FrmConsultaFormasPagamento();
            frmConsultaFormasPagamento.ShowDialog();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Views.Usuarios.FrmConsultaUsuario frmConsultaUsuario = new Views.Usuarios.FrmConsultaUsuario();
            frmConsultaUsuario.ShowDialog();
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Views.Usuarios.FrmCadastro frmCadastro = new Views.Usuarios.FrmCadastro();
            frmCadastro.ShowDialog();
        }

        private void pedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Views.Pedidos.FrmPedido frmPedido = new Views.Pedidos.FrmPedido();
            frmPedido.ShowDialog();
        }

        private void controleDeCaixaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Views.ControleCaixa.FrmConsultaControleCaixa frmConsultaControleCaixa = new Views.ControleCaixa.FrmConsultaControleCaixa();
            frmConsultaControleCaixa.ShowDialog();
        }
    }
}
