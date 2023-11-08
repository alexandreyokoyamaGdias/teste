
using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;
using SGPPC.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGPPC.Views.Usuarios
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string login = txbLogin.Text;
            string senha = txbSenha.Text;

            if (string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(senha))
            {
                MessageBox.Show("Por favor, preencha o campo de login e senha.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int userID; // Variável para armazenar o ID do usuário logado
            string userName; // Variável para armazenar o nome do usuário logado

            Controle controle = new Controle();

            if (controle.VerificarLogin(login, senha, out userID, out userName))
            {
                if (userID > 0) // Verifique se o ID do usuário é válido
                {
                    string tabelaAfetada = "Usuário";
                    DateTime dataHora = DateTime.Now;
                    string acao = "btnEntrar_Click";
                    string descricao = "Usuário logado com sucesso!";

                    InserirLogsComands inserirLogs = new InserirLogsComands(tabelaAfetada, dataHora, acao, descricao, userID);

                    MessageBox.Show("Logado com sucesso", "Entrando", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    FrmPrincipal home = new FrmPrincipal();
                    home.UserID = userID;
                    home.UserName = userName;
                    home.Show();
                    this.Hide();
                }
                else
                {
                    // Trate a situação de usuário não encontrado
                    MessageBox.Show("Usuário não encontrado", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                string tabelaAfetada = "Usuário";
                DateTime dataHora = DateTime.Now;
                string acao = "btnEntrar_Click";
                string descricao = "Senha incorreta ou login não encontrado";

                InserirLogsComands inserirLogs = new InserirLogsComands(tabelaAfetada, dataHora, acao, descricao, -1); // Use -1 ou outro valor apropriado para indicar erro

                MessageBox.Show("Senha incorreta ou login não encontrado, verifique login e senha", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}