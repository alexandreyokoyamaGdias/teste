using SGPPC.Class;
using SGPPC.Data;
using SGPPC.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGPPC.Views.TipoOperacao
{
    public partial class FrmCadastroTipoOperacao : Form
    {
        public FrmCadastroTipoOperacao()
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

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txbTipoOperacao.Text))
            {
                MessageBox.Show("Preencha o campo Tipo de Operação!", "Cadastro da Operação.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbTipoOperacao.Text = "";
                txbTipoOperacao.Focus();
                return;
            }
            else if (string.IsNullOrWhiteSpace(txbDescricao.Text))
            {
                MessageBox.Show("Preencha o campo Descrição!", "Cadastro da Operação.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbDescricao.Text = "";
                txbDescricao.Focus();
                return;
            }

            FrmPrincipal principalForm = Application.OpenForms.OfType<FrmPrincipal>().FirstOrDefault();
            if (principalForm != null)
            {
                int userId = principalForm.UserID; // Obtenha o UserID da instância de FrmPrincipal

                TipoOperacaoControle tipoOperacaoControle = new TipoOperacaoControle();
                string mensagem = tipoOperacaoControle.CadastrarTipoOperacao(txbTipoOperacao.Text.Trim(), txbDescricao.Text.Trim());

                if (tipoOperacaoControle.tem)
                {
                    string tabelaAfetada = "TipoOperação";
                    DateTime dataHora = DateTime.Now;
                    string acao = "btnCadastrar_Click";
                    string descricao = "Cadastro da Operação bem-sucedido";

                    InserirLogsComands inserirLogs = new InserirLogsComands(tabelaAfetada, dataHora, acao, descricao, userId);

                    MessageBox.Show(mensagem, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    MessageBox.Show(tipoOperacaoControle.mensagem);
                }
            }
        }
    }
}
