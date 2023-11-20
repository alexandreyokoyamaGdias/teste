using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using SGPPC.Repository;

namespace SGPPC.Views.Perfil
{
    public partial class FrmPerfilUsuario : Form
    {
        private LoginDalComands loginDal = new LoginDalComands();

        public int UserID { get; set; }

        public FrmPerfilUsuario()
        {
            InitializeComponent();
        }

        private void FrmPerfilUsuario_Load(object sender, EventArgs e)
        {
            try
            {
                if (loginDal.ObterInformacoesUsuarioPorID(UserID, out string nome, out string email, out string cpf, out string funcao, out DateTime dataAdmissao))
                {
                    // Se as informações foram obtidas com sucesso, exiba nos controles da tela de perfil
                    textBoxNome.Text = nome;
                    textBoxEmail.Text = email;
                    textBoxCPF.Text = cpf;
                    textBoxFuncao.Text = funcao;
                    maskedTextBoxData.Text = dataAdmissao.ToString("dd/MM/yyyy"); // Ajuste o formato conforme necessário
                }
                else
                {
                    // Lide com a situação em que as informações do usuário não puderam ser recuperadas
                    MessageBox.Show("Não foi possível obter as informações do usuário.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close(); // Feche a tela ou tome alguma ação apropriada
                }
            }
            catch (Exception ex)
            {
                // Lide com exceções de forma genérica, mostrando uma mensagem de erro ao usuário
                MessageBox.Show($"Ocorreu um erro ao carregar as informações do usuário: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close(); // Feche a tela ou tome alguma ação apropriada
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
