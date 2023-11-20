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
    public partial class FrmEdicaoTipoOpercao : Form
    {
        private string descricaoOriginalTipoOperacao;

        private string descricaoOrignalDescricao;

        public FrmEdicaoTipoOpercao()
        {
            InitializeComponent();
        }

        public FrmEdicaoTipoOpercao(string tipoOperacao, string descricao, string id)
        {
            InitializeComponent();

            txbEdtTipoOperacao.Text = descricao;
            txbEdtDescricao.Text = descricao;
            txbId.Text = id;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparFormulario.LimparForm(this);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txbEdtTipoOperacao.Text))
            {
                MessageBox.Show("Preencha o campo Tipo de Operação!", "Edição da Operação.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbEdtTipoOperacao.Text = "";
                txbEdtTipoOperacao.Focus();
                return;
            }
            else if (string.IsNullOrWhiteSpace(txbEdtDescricao.Text))
            {
                MessageBox.Show("Preencha o campo Descrição!", "Edição da Operação.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbEdtDescricao.Text = "";
                txbEdtDescricao.Focus();
                return;
            }

            FrmPrincipal principalForm = Application.OpenForms.OfType<FrmPrincipal>().FirstOrDefault();
            if (principalForm != null)
            {
                int userId = principalForm.UserID;
                if (Int32.TryParse(txbId.Text, out int id))
                {
                    TipoOperacaoControle tipoOperacaoControle = new TipoOperacaoControle();
                    string mensagem = tipoOperacaoControle.AlterarTipoOperacao(id, txbEdtTipoOperacao.Text.Trim(), txbEdtDescricao.Text.Trim());

                    if (tipoOperacaoControle.tem)
                    {
                        string tabelaAfetada = "Tipo de Operaçaõ";
                        DateTime dataHora = DateTime.Now;
                        string acao = "btnSalvar_Click";
                        string descricao = "Alteração da Operação bem-sucedida";

                        if (descricaoOriginalTipoOperacao != txbEdtTipoOperacao.Text)
                        {
                            descricao += "O 'Tipo de Operação' foi alterado de " + "'" + descricaoOriginalTipoOperacao + "'" + " para " + "'" + txbEdtTipoOperacao.Text + "'.";
                        }
                        else if (descricaoOrignalDescricao != txbEdtDescricao.Text)
                        {
                            descricao += "A 'Descrição' foi alterada de " + "'" + descricaoOrignalDescricao + "'" + " para " + "'" + txbEdtDescricao.Text + "'.";
                        }

                        InserirLogsComands inserirLogs = new InserirLogsComands(tabelaAfetada, dataHora, acao, descricao, userId);

                        MessageBox.Show(mensagem, "Alteração", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    else
                    {
                        string tabelaAfetada = "Tipo de Operação";
                        DateTime dataHora = DateTime.Now;
                        string acao = "btnSalvar_Click";
                        string descricao = "Erro na alteração: ";

                        if (descricaoOriginalTipoOperacao != txbEdtTipoOperacao.Text)
                        {
                            descricao += "O 'Tipo de Operação' não pode ser alterado de " + "'" + descricaoOriginalTipoOperacao + "'" + " para " + "'" + txbEdtTipoOperacao.Text + "'.";
                        }
                        else if (descricaoOrignalDescricao != txbEdtDescricao.Text)
                        {
                            descricao += "A 'Descrição' não pode ser alterado de " + "'" + descricaoOrignalDescricao + "'" + " para " + "'" + txbEdtDescricao.Text + "'.";
                        }

                        InserirLogsComands inserirLogs = new InserirLogsComands(tabelaAfetada, dataHora, acao, descricao, userId);
                        MessageBox.Show(tipoOperacaoControle.mensagem);
                    }
                }
                else
                {
                    MessageBox.Show("ID inválido. O ID deve ser um número inteiro.", "Alteração da Operação.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txbId.Text = "";
                    txbId.Focus();
                }
            }
        }

        private void FrmEdicaoTipoOpercao_Load(object sender, EventArgs e)
        {
            descricaoOriginalTipoOperacao = txbEdtTipoOperacao.Text;

            descricaoOrignalDescricao = txbEdtDescricao.Text;
        }
    }
}
