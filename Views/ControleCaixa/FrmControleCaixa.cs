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
    public partial class FrmControleCaixa : Form
    {
        public FrmControleCaixa()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparFormulario.LimparForm(this);
        }

        private void FrmControleCaixa_Load(object sender, EventArgs e)
        {
            DateTime dataHoraAtual = DateTime.Now;

            maskDataHoras.Text = dataHoraAtual.ToString("dd/MM/yyyy HH:mm");
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txbMotivo.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o campo Motivo", "Controle de Caixa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbMotivo.Text = "";
                txbMotivo.Focus();
                return;
            }
            else if (txbTipoOperadcao.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o campo Tipo de Operação", "Controle de Caixa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbTipoOperadcao.Text = "";
                txbTipoOperadcao.Focus();
                return;
            }
            else if (txbValor.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o campo Valor", "Controle de Caixa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbValor.Text = "";
                txbValor.Focus();
                return;
            }
            else if (!DateTime.TryParseExact(maskDataHoras.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime data))
            {
                MessageBox.Show("Data inválida. Preencha o campo Data no formato dd/MM/yyyy.", "Cadastro produto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                maskDataHoras.Text = "";
                maskDataHoras.Focus();
                return;
            }
            else
            {
                CaixaControle controle = new CaixaControle();
                String mensagem = controle.CadastrarCaixa(txbMotivo.Text, txbTipoOperadcao.Text, txbValor.Text, maskDataHoras.Text);

                if (controle.tem)
                {
                    string tabelaAfetada = "Controle de Caixa";
                    DateTime dataHora = DateTime.Now;
                    string acao = "btnCadastrar_Click";
                    string descricao = "Cadastro de Controle de Caixa bem-sucedido";

                    InserirLogsComands inserirLogs = new InserirLogsComands(tabelaAfetada, dataHora, acao, descricao);

                    MessageBox.Show(mensagem, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    MessageBox.Show(controle.mensagem);
                }
            }
        }
    }
}
