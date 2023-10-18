using SGPPC.Class;
using SGPPC.Controllerss;
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
            Close();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txbNome.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o campo Nome", "Cadastro de usuário", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbNome.Text = "";
                txbNome.Focus();
                return;
            }
            else if (txbEmail.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o campo email", "Cadastro de usuário", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbEmail.Text = "";
                txbEmail.Focus();
                return;
            }
            else if (cbFuncao.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o campo Cidade", "Cadastro de usuário", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbFuncao.Text = "";
                cbFuncao.Focus();
                return;
            }
            else if (maskCPF.Text == "   ,   ,   -  " || maskCPF.Text.Length < 14)
            {
                MessageBox.Show("Preencha o campo CPF com um CPF válido (entre 10 e 11 dígitos).", "Cadastro de usuário", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                maskCPF.Text = "";
                maskCPF.Focus();
                return;
            }
            else if (txbSenha.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o campo senha", "Cadastro de usuário", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbSenha.Text = "";
                txbSenha.Focus();
                return;
            }
            else if (maskDataHoraAdmissao.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o campo data/hora admissão", "Cadastro de usuário", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                maskDataHoraAdmissao.Text = "";
                maskDataHoraAdmissao.Focus();
                return;
            }
            else
            {
                Controle controle = new Controle();
                String mensagem = controle.Cadastrar(txbNome.Text, txbEmail.Text, cbFuncao.Text, maskCPF.Text, txbSenha.Text, maskDataHoraAdmissao.Text);

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

        private void FrmCadastro_Load(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparFormulario.LimparForm(this);
        }
    }
}
