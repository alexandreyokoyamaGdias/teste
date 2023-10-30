using SGPPC.Class;
using SGPPC.Controllerss;
using SGPPC.Data;
using SGPPC.Model;
using SGPPC.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGPPC.Views.Fornecedor
{
    public partial class FrmCadastroFornecedor : Form
    {
        public FrmCadastroFornecedor()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (maskCNPJ.Text == "  ,   ,   /    -" || maskCNPJ.Text.Length < 18)
            {
                MessageBox.Show("Preencha o campo CNPJ com um CNPJ válido (entre 13 e 14 dígitos).", "Cadastro fornecedor", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                maskCNPJ.Text = "";
                maskCNPJ.Focus();
                return;
            }
            else if (txbNome.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o campo Nome", "Cadastro fornecedor", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbNome.Text = "";
                txbNome.Focus();
                return;
            }
            else if (txbPais.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o campo País", "Cadastro fornecedor", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbPais.Text = "";
                txbPais.Focus();
                return;
            }
            else if (txbCidade.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o campo Cidade", "Cadastro fornecedor", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbCidade.Text = "";
                txbCidade.Focus();
                return;
            }
            else if (txbEstado.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o campo Estado", "Cadastro fornecedor", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbEstado.Text = "";
                txbEstado.Focus();
                return;
            }
            else if (radioAtivo.Checked == false && radioInativo.Checked == false)
            {
                MessageBox.Show("Preencha o campo Status", "Cadastro fornecedor", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                radioAtivo.Focus();
                radioInativo.Focus();
                return;
            }
            else
            {
                if (radioAtivo.Checked)
                {
                    FornecedorControle fornecedorControle = new FornecedorControle();
                    String mensagem = fornecedorControle.CadastrarFor(txbNome.Text.Trim(), maskCNPJ.Text.Trim(), txbPais.Text.Trim(), txbCidade.Text.Trim(), txbEstado.Text.Trim(), radioAtivo.Text.Trim());

                    if (fornecedorControle.tem)
                    {
                        string tabelaAfetada = "Fornecedor";
                        DateTime dataHora = DateTime.Now;
                        string acao = "btnCadastrar_Click";
                        string descricao = "Cadastro de Fornecedor bem-sucedido";

                        InserirLogsComands inserirLogs = new InserirLogsComands(tabelaAfetada, dataHora, acao, descricao);

                        MessageBox.Show(mensagem, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimparFormulario.LimparForm(this);
                    }
                    else
                    {
                        MessageBox.Show(fornecedorControle.mensagem);
                    }
                }
                else
                {
                    FornecedorControle fornecedorControle = new FornecedorControle();
                    String mensagem = fornecedorControle.CadastrarFor(txbNome.Text.Trim(), maskCNPJ.Text.Trim(), txbPais.Text.Trim(), txbCidade.Text.Trim(), txbEstado.Text.Trim(), radioInativo.Text.Trim());

                    if (fornecedorControle.tem)
                    {
                        string tabelaAfetada = "Fornecedor";
                        DateTime dataHora = DateTime.Now;
                        string acao = "btnCadastrar_Click";
                        string descricao = "Cadastro de Fornecedor bem-sucedido";

                        InserirLogsComands inserirLogs = new InserirLogsComands(tabelaAfetada, dataHora, acao, descricao);

                        MessageBox.Show(mensagem, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimparFormulario.LimparForm(this);
                    }
                    else
                    {
                        MessageBox.Show(fornecedorControle.mensagem);
                    }
                }
            }
        }

        private void radioInativo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparFormulario.LimparForm(this);
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpar_Click_1(object sender, EventArgs e)
        {
            LimparFormulario.LimparForm(this);
        }

        private void FrmCadastroFornecedor_Load(object sender, EventArgs e)
        {

        }
    }
}
