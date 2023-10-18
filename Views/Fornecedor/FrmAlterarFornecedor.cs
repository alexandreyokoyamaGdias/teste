using SGPPC.Class;
using SGPPC.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SGPPC.Views.Fornecedor
{
    public partial class FrmAlterarFornecedor : Form
    {
        public FrmAlterarFornecedor()
        {
            InitializeComponent();
        }

        public FrmAlterarFornecedor(string cnpj, string nome, string pais, string cidade, string estado, string id)
        {
            InitializeComponent();

            txbCNPJ.Text = cnpj;
            txbNome.Text = nome;
            txbPais.Text = pais;
            txbCidade.Text = cidade;
            txbEstado.Text = estado;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmAlterarFornecedor_Load(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (txbCNPJ.Text == "  ,   ,   /    -" || txbCNPJ.Text.Length < 18)
            {
                MessageBox.Show("Preencha o campo CNPJ com um CNPJ válido (entre 13 e 14 dígitos).", "Alteração fornecedor", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbCNPJ.Text = "";
                txbCNPJ.Focus();
                return;
            }
            else if (txbNome.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o campo Descrição", "Alteração fornecedor", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbNome.Text = "";
                txbNome.Focus();
                return;
            }
            else if (txbPais.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o campo Valor", "Alteração fornecedor", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbPais.Text = "";
                txbPais.Focus();
                return;
            }
            else if (txbCidade.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o campo Valor", "Alteração fornecedor", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbCidade.Text = "";
                txbCidade.Focus();
                return;
            }
            else if (txbCidade.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o campo Valor", "Alteração fornecedor", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbCidade.Text = "";
                txbCidade.Focus();
                return;
            }
            else if (txbEstado.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o campo Valor", "Alteração fornecedor", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbEstado.Text = "";
                txbEstado.Focus();
                return;
            }
            else if (radioAtivo.Checked == false && radioInativo.Checked == false)
            {
                MessageBox.Show("Preencha o campo Status", "Alteração fornecedor", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                radioAtivo.Focus();
                radioInativo.Focus();
                return;
            }
            else
            {
                if (Int32.TryParse(txbId.Text, out Int32 id))
                {
                    FornecedorEditarControle fornecedorEditarControle = new FornecedorEditarControle();
                    String mensagem = fornecedorEditarControle.AlterarForn(id, txbCNPJ.Text.Trim(), txbNome.Text.Trim(), txbPais.Text.Trim(), txbCidade.Text.Trim(), txbEstado.Text.Trim(), radioAtivo.Text.Trim(), radioInativo.Text.Trim());

                    if (fornecedorEditarControle.tem)
                    {
                        MessageBox.Show(mensagem, "Alteração", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimparFormulario.LimparForm(this);
                    }
                    else
                    {
                        MessageBox.Show(fornecedorEditarControle.mensagem);
                    }
                }
                else
                {
                    MessageBox.Show("ID inválido. O ID deve ser um número inteiro.", "Alteração produto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txbId.Text = "";
                    txbId.Focus();
                }
            }
        }
    }
}


