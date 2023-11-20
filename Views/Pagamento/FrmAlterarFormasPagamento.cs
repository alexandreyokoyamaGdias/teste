using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;
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

namespace SGPPC.Views.Pagamento
{
    public partial class FrmAlterarFormasPagamento : Form
    {
        private string descricaoOriginalFormaPagamento;

        private string descricaoOrignalDescricao;

        private string descricaoOriginalAtivo;

        private string descricaoOriginalInativo;

        public int UserID { get; private set; }

        public FrmAlterarFormasPagamento()
        {
            InitializeComponent();
        }

        public FrmAlterarFormasPagamento(string nome, string descricao, string status, string id)
        {
            InitializeComponent();

            txbFormaNome.Text = nome;
            txbFormaPDescricaoo.Text = descricao;
            txbId.Text = id;

            if (status == "Ativo")
            {
                radioAtivoPagamentoAlterar.Checked = true;
                radioInativoPagamentoAlterar.Checked = false;
            }
            else if (status == "Inativo")
            {
                radioAtivoPagamentoAlterar.Checked = false;
                radioInativoPagamentoAlterar.Checked = true;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparFormulario.LimparForm(this);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmAlterarFormasPagamento_Load(object sender, EventArgs e)
        {
            descricaoOriginalFormaPagamento = txbFormaNome.Text;

            descricaoOrignalDescricao = txbFormaPDescricaoo.Text;

            descricaoOriginalAtivo = radioAtivoPagamentoAlterar.Text;

            descricaoOriginalInativo = radioInativoPagamentoAlterar.Text;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txbFormaNome.Text))
            {
                MessageBox.Show("Preencha o campo Nome!", "Alteração da Forma de Pagamento!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbFormaNome.Text = "";
                txbFormaNome.Focus();
                return;
            }
            else if (string.IsNullOrWhiteSpace(txbFormaPDescricaoo.Text))
            {
                MessageBox.Show("Preencha o campo Descrição!", "Alteração da Forma de Pagamento!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbFormaPDescricaoo.Text = "";
                txbFormaPDescricaoo.Focus();
                return;
            }
            else if (!radioAtivoPagamentoAlterar.Checked && !radioInativoPagamentoAlterar.Checked)
            {
                MessageBox.Show("Selecione um status (ativo ou inativo)!", "Alteração da Forma de Pagamento!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                FrmPrincipal principalForm = Application.OpenForms.OfType<FrmPrincipal>().FirstOrDefault();
                if (principalForm != null)
                {
                    if (int.TryParse(txbId.Text, out int id))
                    {
                        PagamentoAlterarControle pagamentoAlterarControle = new PagamentoAlterarControle();
                        string status = radioAtivoPagamentoAlterar.Checked ? "Ativo" : "Inativo";
                        string mensagem = pagamentoAlterarControle.AlterarPagamento(id, txbFormaNome.Text.Trim(), txbFormaPDescricaoo.Text.Trim(), status);

                        int userId = principalForm.UserID;
                        if (pagamentoAlterarControle.tem)
                        {
                            string tabelaAfetada = "Pagamento";
                            DateTime dataHora = DateTime.Now;
                            string acao = "btnAlterar_Click";
                            string descricao = "Alteração: ";

                            if (descricaoOriginalFormaPagamento != txbFormaNome.Text)
                            {
                                descricao += "O 'Tipo de Pagamento' foi alterado de " + "'" + descricaoOriginalFormaPagamento + "'" + " para " + "'" + txbFormaNome.Text + "'.";
                            }
                            else if (descricaoOrignalDescricao != txbFormaPDescricaoo.Text)
                            {
                                descricao += "A 'Descrição' foi alterada de " + "'" + descricaoOrignalDescricao + "'" + " para " + "'" + txbFormaPDescricaoo.Text + "'.";
                            }
                            else if (descricaoOriginalAtivo != radioAtivoPagamentoAlterar.Text)
                            {
                                descricao += "O 'Status' foi alterado de " + "'" + descricaoOriginalAtivo + "'" + " para " + "'" + radioAtivoPagamentoAlterar.Text + "'.";
                            }
                            else if (descricaoOriginalInativo != radioInativoPagamentoAlterar.Text)
                            {
                                descricao += "O 'Status' foi alterado de " + "'" + descricaoOriginalInativo + "'" + " para " + "'" + radioInativoPagamentoAlterar.Text + "'.";
                            }

                            InserirLogsComands inserirLogs = new InserirLogsComands(tabelaAfetada, dataHora, acao, descricao, userId);

                            MessageBox.Show(mensagem, "Alteração", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Close();
                        }
                        else
                        {
                            string tabelaAfetada = "Pagamento";
                            DateTime dataHora = DateTime.Now;
                            string acao = "btnAlterar_Click";
                            string descricao = "Erro na alteração: ";

                            if (descricaoOriginalFormaPagamento != txbFormaNome.Text)
                            {
                                descricao += "O 'Tipo de Pagamento' não pode ser alterado de " + "'" + descricaoOriginalFormaPagamento + "'" + " para " + "'" + txbFormaNome.Text + "'.";
                            }
                            else if (descricaoOrignalDescricao != txbFormaPDescricaoo.Text)
                            {
                                descricao += "A 'Descrição' não pode ser alterado de " + "'" + descricaoOrignalDescricao + "'" + " para " + "'" + txbFormaPDescricaoo.Text + "'.";
                            }
                            else if (descricaoOriginalAtivo != radioAtivoPagamentoAlterar.Text)
                            {
                                descricao += "O 'Status' não pode ser alterado de " + "'" + descricaoOriginalAtivo + "'" + " para " + "'" + radioAtivoPagamentoAlterar.Text + "'.";
                            }
                            else if (descricaoOriginalInativo != radioInativoPagamentoAlterar.Text)
                            {
                                descricao += "O 'Status' não pode ser alterado de " + "'" + descricaoOriginalInativo + "'" + " para " + "'" + radioInativoPagamentoAlterar.Text + "'.";
                            }

                            InserirLogsComands inserirLogs = new InserirLogsComands(tabelaAfetada, dataHora, acao, descricao, userId);
                            MessageBox.Show(pagamentoAlterarControle.mensagem);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("ID inválido. O ID deve ser um número inteiro.", "Alteração da Forma de Pagamento!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txbId.Text = "";
                    txbId.Focus();
                }
            }
        }
    }
}
