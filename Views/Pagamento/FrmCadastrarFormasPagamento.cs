using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;
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

namespace SGPPC.Views.Pagamento
{
    public partial class FrmCadastrarFormasPagamento : Form
    {
        public int UserID { get; private set; }

        public FrmCadastrarFormasPagamento()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparFormulario.LimparForm(this);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txbFormaNome.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o campo Nome", "Cadastro da forma de pagamento", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbFormaNome.Text = "";
                txbFormaNome.Focus();
                return;
            }
            else if (txbFormaDescricao.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o campo Descrição", "Cadastro da forma de pagamento", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbFormaDescricao.Text = "";
                txbFormaDescricao.Focus();
                return;
            }
            else if (radioAtivoPagamento.Checked == false && radioInativoPagamento.Checked == false)
            {
                MessageBox.Show("Preencha o campo Status", "Cadastro Forma de Pagamento", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                radioAtivoPagamento.Focus();
                radioInativoPagamento.Focus();
                return;
            }
            else
            {
                FrmPrincipal principalForm = Application.OpenForms.OfType<FrmPrincipal>().FirstOrDefault();
                if (principalForm != null)
                {
                    if (radioAtivoPagamento.Checked)
                    {
                        FormaPagamentoControle formaPagamentoControle = new FormaPagamentoControle();
                        String mensagem = formaPagamentoControle.CadastrarPagamento(txbFormaNome.Text.Trim(), txbFormaDescricao.Text.Trim(), radioAtivoPagamento.Text.Trim());

                        int userId = principalForm.UserID; // Obtenha o UserID da instância de FrmPrincipal
                        if (formaPagamentoControle.tem)
                        {
                            string tabelaAfetada = "Pagamento";
                            DateTime dataHora = DateTime.Now;
                            string acao = "btnCadastrar_Click";
                            string descricao = "Cadastro de Pagamento bem-sucedido";

                            InserirLogsComands inserirLogs = new InserirLogsComands(tabelaAfetada, dataHora, acao, descricao, userId);

                            MessageBox.Show(mensagem, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Close();
                        }
                        else
                        {
                            MessageBox.Show(formaPagamentoControle.mensagem);
                        }
                    }
                    else
                    {
                        FormaPagamentoControle formaPagamentoControle = new FormaPagamentoControle();
                        String mensagem = formaPagamentoControle.CadastrarPagamento(txbFormaNome.Text.Trim(), txbFormaDescricao.Text.Trim(), radioInativoPagamento.Text.Trim());

                        int userId = principalForm.UserID; // Obtenha o UserID da instância de FrmPrincipal
                        if (formaPagamentoControle.tem)
                        {
                            string tabelaAfetada = "Pagamento";
                            DateTime dataHora = DateTime.Now;
                            string acao = "btnCadastrar_Click";
                            string descricao = "Cadastro de Pagamento bem-sucedido";

                            InserirLogsComands inserirLogs = new InserirLogsComands(tabelaAfetada, dataHora, acao, descricao, userId);

                            MessageBox.Show(mensagem, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Close();
                        }
                        else
                        {
                            MessageBox.Show(formaPagamentoControle.mensagem);
                        }
                    }
                }                     
            }
        }
    }
}
