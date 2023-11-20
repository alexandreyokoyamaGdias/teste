using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;
using SGPPC.Class;
using SGPPC.Data;
using SGPPC.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGPPC.Views.Usuarios
{
    public partial class FrmEditarUsuario : Form
    {

        private string descricaoOriginalNome;

        private string descricaoOrignalEmail;

        private string descricaoOriginalCPF;

        private string descricaoOrignalFuncao;

        public int UserID { get; private set; }

        public FrmEditarUsuario()
        {
            InitializeComponent();
        }

        public FrmEditarUsuario(string nome, string email, string cpf, string funcao, string senha, string dataAd, string id)
        {
            InitializeComponent();

            txbNomeEdit.Text = nome;
            txbEmailEdit.Text = email;
            maskCPFEdit.Text = cpf;
            cbFuncaoEdit.Text = funcao;
            txbSenhaEdit.Text = senha;
            maskDataHoraAdmissaoEdit.Text = dataAd;
            txbIdUser.Text = id;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparFormulario.LimparForm(this);
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (txbNomeEdit.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o campo Nome.", "Usuário", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbNomeEdit.Text = "";
                txbNomeEdit.Focus();
                return;
            }
            else if (txbEmailEdit.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o campo E-mail.", "Usuário", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbEmailEdit.Text = "";
                txbEmailEdit.Focus();
                return;
            }
            else if (maskCPFEdit.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o campo CPF.", "Usuário", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                maskCPFEdit.Text = "";
                maskCPFEdit.Focus();
                return;
            }
            else if (cbFuncaoEdit.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o campo Função.", "Usuário", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbFuncaoEdit.Text = "";
                cbFuncaoEdit.Focus();
                return;
            }
            else if (txbSenhaEdit.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o campo Senha", "Usuário", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbSenhaEdit.Text = "";
                txbSenhaEdit.Focus();
                return;
            }
            else
            {
                FrmPrincipal principalForm = Application.OpenForms.OfType<FrmPrincipal>().FirstOrDefault();
                if (principalForm != null)
                {
                    int userId = principalForm.UserID;
                    if (Int32.TryParse(txbIdUser.Text, out Int32 id))
                    {
                        UsuarioEditarControle usuarioEditarControle = new UsuarioEditarControle();
                        String mensagem = usuarioEditarControle.EditarUsuario(txbNomeEdit.Text.Trim(), txbEmailEdit.Text.Trim(), maskCPFEdit.Text.Trim(), cbFuncaoEdit.Text.Trim(), txbSenhaEdit.Text.Trim(), id);

                        if (usuarioEditarControle.tem)
                        {
                            string tabelaAfetada = "Usuário";
                            DateTime dataHora = DateTime.Now;
                            string acao = "btnAlterar_Click";
                            string descricao = "Alteração: ";

                            if (descricaoOriginalNome != txbNomeEdit.Text)
                            {
                                descricao += "O 'Nome' foi alterado de " + "'" + descricaoOriginalNome + "'" + " para " + "'" + txbNomeEdit.Text + "'.";
                            }
                            else if (descricaoOrignalEmail != txbEmailEdit.Text)
                            {
                                descricao += "O 'E-mail' foi alterado de " + "'" + descricaoOrignalEmail + "'" + " para " + "'" + txbEmailEdit.Text + "'.";
                            }                         
                            else if (descricaoOriginalCPF != maskCPFEdit.Text)
                            {
                                descricao += "O 'CPF' foi alterado de " + "'" + descricaoOriginalCPF + "'" + " para " + "'" + maskCPFEdit.Text + "'.";
                            }
                            else if (descricaoOrignalFuncao != cbFuncaoEdit.Text)
                            {
                                descricao += "A 'Função' foi alterado de " + "'" + descricaoOrignalFuncao + "'" + " para " + "'" + cbFuncaoEdit.Text + "'.";
                            }

                            InserirLogsComands inserirLogs = new InserirLogsComands(tabelaAfetada, dataHora, acao, descricao, userId);

                            MessageBox.Show(mensagem, "Alteração", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Close();
                        }
                        else
                        {
                            string tabelaAfetada = "Usuário";
                            DateTime dataHora = DateTime.Now;
                            string acao = "btnAlterar_Click";
                            string descricao = "Erro na alteração: ";

                            if (descricaoOriginalNome != txbNomeEdit.Text)
                            {
                                descricao += "O 'Nome' não pode ser alterado de " + "'" + descricaoOriginalNome + "'" + " para " + "'" + txbNomeEdit.Text + "'.";
                            }
                            else if (descricaoOrignalEmail != txbEmailEdit.Text)
                            {
                                descricao += "O 'E-mail' não pode ser alterado de " + "'" + descricaoOrignalEmail + "'" + " para " + "'" + txbEmailEdit.Text + "'.";
                            }
                            else if (descricaoOriginalCPF != maskCPFEdit.Text)
                            {
                                descricao += "O 'CPF' não pode ser alterado de " + "'" + descricaoOriginalCPF + "'" + " para " + "'" + maskCPFEdit.Text + "'.";
                            }
                            else if (descricaoOrignalFuncao != cbFuncaoEdit.Text)
                            {
                                descricao += "A 'Função' não pode ser alterada de " + "'" + descricaoOrignalFuncao + "'" + " para " + "'" + cbFuncaoEdit.Text + "'.";
                            }

                            InserirLogsComands inserirLogs = new InserirLogsComands(tabelaAfetada, dataHora, acao, descricao, userId);
                            MessageBox.Show(usuarioEditarControle.mensagem);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("ID inválido. O ID deve ser um número inteiro.", "Alteração do Usuário", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txbIdUser.Text = "";
                    txbIdUser.Focus();
                }
            }
        }

        private void FrmEditarUsuario_Load(object sender, EventArgs e)
        {
            descricaoOriginalNome = txbNomeEdit.Text;

            descricaoOrignalEmail = txbEmailEdit.Text;

            descricaoOriginalCPF = maskCPFEdit.Text;

            descricaoOrignalFuncao = cbFuncaoEdit.Text;
        }
    }
}
