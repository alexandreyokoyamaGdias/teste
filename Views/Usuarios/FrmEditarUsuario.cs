using SGPPC.Class;
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
    public partial class FrmEditarUsuario : Form
    {
        public FrmEditarUsuario()
        {
            InitializeComponent();
        }

        public FrmEditarUsuario(string nome, string email, string cpf, string funcao, string senha, string dataAd)
        {
            InitializeComponent();

            txbNomeEdit.Text = nome;
            txbEmailEdit.Text = email;
            maskCPFEdit.Text = cpf;
            cbFuncaoEdit.Text = funcao;
            txbSenhaEdit.Text = senha;
            maskDataHoraAdmissaoEdit.Text = dataAd;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparFormulario.LimparForm(this);
        }
    }
}
