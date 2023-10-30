using SGPPC.Controllerss;
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
                return; // Não prossiga se o login ou senha estiver em branco
            }

            Controle controle = new Controle();

            if (controle.VerificarLogin(login, senha))
            {
                MessageBox.Show("Logado com sucesso", "Entrando", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Se o login for bem-sucedido, abra o formulário principal
                FrmPrincipal home = new FrmPrincipal();
                home.Show();
                this.Hide(); // Oculte o formulário de login
            }
            else
            {
                MessageBox.Show("Login não encontrado ou senha incorreta, verifique login e senha", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //private void btnEntrar_Click(object sender, EventArgs e)
        //{
        //    Controle controle = new Controle();
        //    string senhaFornecidaPeloUsuario = txbSenha.Text;

        //    if (controle.Acessar(txbLogin.Text, senhaFornecidaPeloUsuario))
        //    {
        //        MessageBox.Show("Logado com sucesso", "Entrando", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        FrmPrincipal home = new FrmPrincipal();
        //        home.Show();
        //    }
        //    else
        //    {
        //        MessageBox.Show("Login não encontrado ou senha incorreta, verifique login e senha", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

    }
}