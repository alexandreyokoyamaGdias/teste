using SGPPC.Class;
using SGPPC.Modelo;
using SGPPC.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BCrypt.Net;
using SGPPC.Data;
using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;

namespace SGPPC.Views.Usuarios
{
    public partial class FrmCadastro : Form
    {
        public int UserID { get; private set; }

        public FrmCadastro()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txbNome.Text))
            {
                MessageBox.Show("Preencha o campo Nome", "Cadastro de usuário", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbNome.Focus();
                return;
            }
            else if (string.IsNullOrWhiteSpace(txbEmail.Text))
            {
                MessageBox.Show("Preencha o campo email", "Cadastro de usuário", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbEmail.Focus();
                return;
            }
            else if (string.IsNullOrWhiteSpace(cbFuncao.Text))
            {
                MessageBox.Show("Preencha o campo Função", "Cadastro de usuário", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbFuncao.Focus();
                return;
            }
            else if (string.IsNullOrWhiteSpace(maskCPF.Text) || maskCPF.Text.Length < 14)
            {
                MessageBox.Show("Preencha o campo CPF com um CPF válido (entre 10 e 11 dígitos).", "Cadastro de usuário", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                maskCPF.Focus();
                return;
            }
            else if (string.IsNullOrWhiteSpace(txbSenha.Text))
            {
                MessageBox.Show("Preencha o campo senha", "Cadastro de usuário", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbSenha.Focus();
                return;
            }
            else if (string.IsNullOrWhiteSpace(maskDataHoraAdmissao.Text))
            {
                MessageBox.Show("Preencha o campo data/hora admissão", "Cadastro de usuário", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                maskDataHoraAdmissao.Focus();
                return;
            }

            string salt = BCrypt.Net.BCrypt.GenerateSalt();

            string senhaDoUsuario = txbSenha.Text;

            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(senhaDoUsuario, salt);

            FrmPrincipal principalForm = Application.OpenForms.OfType<FrmPrincipal>().FirstOrDefault();
            if (principalForm != null)
            {
                int userId = principalForm.UserID; // Obtenha o UserID da instância de FrmPrincipal

                Controle controle = new Controle();
                string mensagem = controle.Cadastrar(txbNome.Text, txbEmail.Text, cbFuncao.Text, maskCPF.Text, hashedPassword, maskDataHoraAdmissao.Text);
                
                if (controle.tem)
                {
                    string tabelaAfetada = "Usuário";
                    DateTime dataHora = DateTime.Now;
                    string acao = "btnCadastrar_Click";
                    string descricao = "Cadastro de Usuário bem-sucedido";

                    InserirLogsComands inserirLogs = new InserirLogsComands(tabelaAfetada, dataHora, acao, descricao, userId);

                    MessageBox.Show(mensagem, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    MessageBox.Show(mensagem);
                }
            }    
        }

        private void FrmCadastro_Load(object sender, EventArgs e)
        {
            DateTime dataHoraAtual = DateTime.Now;
            maskDataHoraAdmissao.Text = dataHoraAtual.ToString("dd/MM/yyyy HH:mm");
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparFormulario.LimparForm(this);
        }
    }
}
