using SGPPC.Class;
using SGPPC.Data;
using SGPPC.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGPPC.Views.ControleCaixa
{
    public partial class FrmEditarControleCaixa : Form
    {
        public FrmEditarControleCaixa()
        {
            InitializeComponent();
        }

        public FrmEditarControleCaixa(string motivo, string tipo, string valor, string data, string id)
        {
            InitializeComponent();

            txbMotivoEditar.Text = motivo;
            txbTipoOperadcaoEditar.Text = tipo;
            txbValorEditar.Text = valor;
            maskDataHoraEditar.Text = data;
            txbId.Text = id;
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpar_Click_1(object sender, EventArgs e)
        {
            LimparFormulario.LimparForm(this);
        }

        private void FrmEditarControleCaixa_Load(object sender, EventArgs e)
        {
            DateTime dataHoraAtual = DateTime.Now;

            maskDataHoraEditar.Text = dataHoraAtual.ToString("dd/MM/yyyy HH:mm");
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (txbMotivoEditar.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o campo Motivo.", "Controle de Caixa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbMotivoEditar.Text = "";
                txbMotivoEditar.Focus();
                return;
            }
            else if (txbTipoOperadcaoEditar.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o campo Tipo de Operação.", "Controle de Caixa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbTipoOperadcaoEditar.Text = "";
                txbTipoOperadcaoEditar.Focus();
                return;
            }
            else if (txbValorEditar.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o campo Valor.", "Controle de Caixa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbValorEditar.Text = "";
                txbValorEditar.Focus();
                return;
            }
            else
            {
                if (Int32.TryParse(txbId.Text, out Int32 id))
                {
                    CaixaControle controle = new CaixaControle();
                    String mensagem = controle.EditarCaixa(txbMotivoEditar.Text, txbTipoOperadcaoEditar.Text, txbValorEditar.Text, id);

                    if (controle.tem)
                    {
                        string tabelaAfetada = "Controle de Caixa";
                        DateTime dataHora = DateTime.Now;
                        string acao = "btnEditar_Click";
                        string descricao = "Alteração bem-sucedido";

                        InserirLogsComands inserirLogs = new InserirLogsComands(tabelaAfetada, dataHora, acao, descricao);

                        MessageBox.Show(mensagem, "Alteração", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    else
                    {
                        MessageBox.Show(controle.mensagem);
                    }
                }
                else
                {
                    MessageBox.Show("ID inválido. O ID deve ser um número inteiro.", "Alteração do caixa.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txbId.Text = "";
                    txbId.Focus();
                }
            }
        }
    }
}
