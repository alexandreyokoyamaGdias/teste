using SGPPC.Class;
using SGPPC.Controllerss;
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

namespace SGPPC.Views.Usuarios
{
    public partial class FrmCadastro : Form
    {
        public FrmCadastro()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Views.Usuarios.FrmLogin frmLogin = new Views.Usuarios.FrmLogin();
            frmLogin.ShowDialog();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            String mensagem = controle.Cadastrar(txbLogin.Text, txbSenha.Text, txbComfirmarSenha.Text);

            if (controle.tem)
            {
                MessageBox.Show(mensagem, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparFormulario.LimparForm(this);
            }
            else
            {
                MessageBox.Show(controle.mensagem);
            }
        }
    }
}
