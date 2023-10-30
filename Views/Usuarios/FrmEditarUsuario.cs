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

namespace SGPPC.Views.Usuarios
{
    public partial class FrmEditarUsuario : Form
    {
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
                if (Int32.TryParse(txbIdUser.Text, out Int32 id))
                {
                    UsuarioEditarControle usuarioEditarControle = new UsuarioEditarControle();
                    String mensagem = usuarioEditarControle.EditarUsuario(txbNomeEdit.Text.Trim(), txbEmailEdit.Text.Trim(), maskCPFEdit.Text.Trim(), cbFuncaoEdit.Text.Trim(), txbSenhaEdit.Text.Trim(), id);

                    if (usuarioEditarControle.tem)
                    {
                        string tabelaAfetada = "Usuário";
                        DateTime dataHora = DateTime.Now;
                        string acao = "btnAlterar_Click";
                        string descricao = "Edição do Usuário bem-sucedido";

                        InserirLogsComands inserirLogs = new InserirLogsComands(tabelaAfetada, dataHora, acao, descricao);

                        MessageBox.Show(mensagem, "Alteração", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    else
                    {
                        MessageBox.Show(usuarioEditarControle.mensagem);
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

        }
    }
}
