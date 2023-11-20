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
        public string UserName { get; set; }

        public int UserID { get; set; }

        public string userFunction { get; set; }

        public FrmPrincipal()
        {
            InitializeComponent();
            atualizarDataHora();
        }
        private void MenuSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ConsultaProdutoMenu_Click(object sender, EventArgs e)
        {
            Views.Consultas.FrmConsultaProduto frmConsultaProduto = new Views.Consultas.FrmConsultaProduto();
            frmConsultaProduto.ShowDialog();
        }

        private void btnVendas_Click(object sender, EventArgs e)
        {
        }

        private void fornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Views.Cadastros.FrmFornecedor frmFornecedor = new Views.Cadastros.FrmFornecedor();
            frmFornecedor.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            atualizarDataHora();
        }

        public void atualizarDataHora() 
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();
            lblData.Text = DateTime.Now.ToLongDateString();

            StatusHora.Text = DateTime.Now.ToLongTimeString();
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
            frmPedido.UserID = this.UserID;
            frmPedido.ShowDialog();
        }

        private void controleDeCaixaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Views.ControleCaixa.FrmConsultaControleCaixa frmConsultaControleCaixa = new Views.ControleCaixa.FrmConsultaControleCaixa();
            frmConsultaControleCaixa.ShowDialog();
        }

        private void RelatórioFluxoDeCaixa_Click(object sender, EventArgs e)
        {
            Views.Relatorios.FrmRelatorioFluxoCaixa frmRelatorioFluxoCaixa = new Views.Relatorios.FrmRelatorioFluxoCaixa();
            frmRelatorioFluxoCaixa.ShowDialog();
        }

        private void RelatórioVenda_Click(object sender, EventArgs e)
        {
            Views.Relatorios.FrmVendas frmVendas = new Views.Relatorios.FrmVendas();
            frmVendas.ShowDialog();
        }

        private void RelatórioEstoque_Click(object sender, EventArgs e)
        {
            Views.Relatorios.FrmEstoque frmEstoque = new Views.Relatorios.FrmEstoque();
            frmEstoque.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Views.Usuarios.FrmCadastro frmCadastro = new Views.Usuarios.FrmCadastro();
            frmCadastro.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Views.Pedidos.FrmPedido frmPedido = new Views.Pedidos.FrmPedido();
            frmPedido.ShowDialog();
        }

        private void entradaDeProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Views.EntradaProduto.FrmConsultaEntradaProduto frmConsultaEntradaProduto = new Views.EntradaProduto.FrmConsultaEntradaProduto();
            frmConsultaEntradaProduto.ShowDialog();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            StatusHora.Text = DateTime.Now.ToString("HH:mm:ss");
            StatusData.Text = DateTime.Today.ToString("dd/MM/yyyy");

            StatusUsuarioLogado.Text = UserName;
            StripLabelId.Text = UserID.ToString();

            toolStripTextBoxFuncao.Text = userFunction;

            if (userFunction == "Padrão")
            {
                MenuRelatorios.Visible = false;
                controleDeCaixaToolStripMenuItem.Visible = false;
                formasDePagamentoToolStripMenuItem.Visible = false;
                tipoDeOperaçãoToolStripMenuItem.Visible = false;
                entradaDeProdutoToolStripMenuItem.Visible = false;
                pedidoToolStripMenuItem.Visible = false;
                cadastrarToolStripMenuItemCadastrar.Visible = false;
                consultarToolStripMenuItemUsuario.Visible = false;

                saboresToolStripMenuItem.Visible = true;
                produtoToolStripMenu.Visible = true;
                consultaToolStripMenuItemFornecedor.Visible = true;
                pedidoToolStripMenuItem.Visible = true;
                perfilToolStripMenuItem.Visible = true;

            }
            else if (userFunction == "Administrador")
            {
                MenuRelatorios.Visible = true;
                produtoToolStripMenuItem1.Visible = true;
                pedidoToolStripMenuItem.Visible = true;
                usuarioToolStripMenuItem.Visible = true;
                entradaProdutoToolStripMenuItem.Visible = true;
                perfilToolStripMenuItem.Visible = true;
            }
        }

        private void timerStatus_Tick(object sender, EventArgs e)
        {
            StatusHora.Text = DateTime.Now.ToString("HH:mm:ss");
            StatusData.Text = DateTime.Today.ToString("dd/MM/yyyy");
        }

        private void tipoDeOperaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Views.TipoOperacao.FrmConsultaTipoOperacao frmConsultaTipoOperacao = new Views.TipoOperacao.FrmConsultaTipoOperacao();
            frmConsultaTipoOperacao.ShowDialog();
        }

        private void entradaProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Views.EntradaProduto.FrmCadastrarEntradaProduto frmCadastrarEntradaProduto = new Views.EntradaProduto.FrmCadastrarEntradaProduto();
            frmCadastrarEntradaProduto.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void StripLabelId_Click(object sender, EventArgs e)
        {

        }

        private void perfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Views.Perfil.FrmPerfilUsuario frmPerfilUsuario = new Views.Perfil.FrmPerfilUsuario();
            frmPerfilUsuario.UserID = this.UserID;
            frmPerfilUsuario.ShowDialog();
        }


    }
}