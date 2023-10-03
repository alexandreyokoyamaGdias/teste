using SGPPC.Class;
using SGPPC.Controllerss;
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
            if (maskCNPJ.Text == "  ,   ,   /    -" || maskCNPJ.Text.Length < 15)
            {
                MessageBox.Show("Preencha o campo cnpj", "Cadastro fornecedor", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                maskCNPJ.Text = "";
                maskCNPJ.Focus();
                return;
            }
            else if (txbNome.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o campo nome", "Cadastro fornecedor", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbNome.Text = "";
                txbNome.Focus();
                return;
            }
            else if (txbPais.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o campo país", "Cadastro fornecedor", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbPais.Text = "";
                txbPais.Focus();
                return;
            }
            else if (txbCidade.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o campo cidade", "Cadastro fornecedor", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbCidade.Text = "";
                txbCidade.Focus();
                return;
            }
            else if (txbEstado.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o campo estado", "Cadastro fornecedor", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbEstado.Text = "";
                txbEstado.Focus();
                return;
            }
            else if (radioAtivo.Checked == false || radioInativo.Checked == false)
            {
                MessageBox.Show("Preencha o campo status", "Cadastro fornecedor", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbEstado.Text = "";
                txbEstado.Focus();
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
                        MessageBox.Show(mensagem, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimparFormulario.LimparForm(this);
                    }
                    else
                    {
                        MessageBox.Show(fornecedorControle.mensagem);
                    }
                }
            }





            //if (radioAtivo.Checked)
            //{
            //    FornecedorControle fornecedorControle = new FornecedorControle();
            //    String mensagem = fornecedorControle.CadastrarFor(txbNome.Text.Trim(), maskCNPJ.Text.Trim(), txbPais.Text.Trim(), txbCidade.Text.Trim(), txbEstado.Text.Trim(), radioAtivo.Text.Trim());

            //    if (fornecedorControle.tem)
            //    {
            //        MessageBox.Show(mensagem, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        LimparFormulario.LimparForm(this);
            //    }
            //    else
            //    {
            //        MessageBox.Show(fornecedorControle.mensagem);
            //    }
            //}
            //else
            //{
            //    FornecedorControle fornecedorControle = new FornecedorControle();
            //    String mensagem = fornecedorControle.CadastrarFor(txbNome.Text.Trim(), maskCNPJ.Text.Trim(), txbPais.Text.Trim(), txbCidade.Text.Trim(), txbEstado.Text.Trim(), radioInativo.Text.Trim());

            //    if (fornecedorControle.tem)
            //    {
            //        MessageBox.Show(mensagem, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        LimparFormulario.LimparForm(this);
            //    }
            //    else
            //    {
            //        MessageBox.Show(fornecedorControle.mensagem);
            //    }
            //}

            //if (maskCNPJ.Text == "  ,   ,   /    -" || maskCNPJ.Text.Length < 15)
            //{
            //    MessageBox.Show("Preencha o campo cnpj", "Cadastro fornecedor", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    maskCNPJ.Text = "";
            //    maskCNPJ.Focus();
            //    return;
            //}

            //if (txbNome.Text.ToString().Trim() == "")
            //{
            //    MessageBox.Show("Preencha o campo nome", "Cadastro fornecedor", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    txbNome.Text = "";
            //    txbNome.Focus();
            //    return;
            //}

            //if (txbPais.Text.ToString().Trim() == "")
            //{
            //    MessageBox.Show("Preencha o campo país", "Cadastro fornecedor", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    txbPais.Text = "";
            //    txbPais.Focus();
            //    return;
            //}

            //if (txbCidade.Text.ToString().Trim() == "")
            //{
            //    MessageBox.Show("Preencha o campo cidade", "Cadastro fornecedor", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    txbCidade.Text = "";
            //    txbCidade.Focus();
            //    return;
            //}

            //if (txbEstado.Text.ToString().Trim() == "")
            //{
            //    MessageBox.Show("Preencha o campo estado", "Cadastro fornecedor", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    txbEstado.Text = "";
            //    txbEstado.Focus();
            //    return;
            //}

            //FornecedorControle fornecedorControle = new FornecedorControle();
            //String mensagem = fornecedorControle.CadastrarFor(txbNome.Text, maskCNPJ.Text, txbPais.Text, txbCidade.Text, txbEstado.Text);

            //if (fornecedorControle.tem)
            //{
            //    MessageBox.Show(mensagem, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    LimparFormulario.LimparForm(this);
            //}
            //else
            //{
            //    MessageBox.Show(fornecedorControle.mensagem);
            //}

            //ValidaController verifica = new ValidaController(maskCNPJ.Text);
            //MessageBox.Show(verifica.mensagem);
            //ProjetaLogs logs = new ProjetaLogs(DateTime.Now, "Cadastrar", $"Nome:{maskCNPJ.Text}", "Tentativa de inclusão de Fornecedor");
            //if (verifica.mensagem != "Já existe um cadastro com este CNPJ")
            //{
            //    if (radioAtivo.Checked)
            //    {
            //        CadastroFornecedor cad = new CadastroFornecedor(txbNome.Text, maskCNPJ.Text, txbPais.Text, txbCidade.Text, txbEstado.Text, radioAtivo.Text);
            //        MessageBox.Show(cad.mensagem);
            //        logs = new ProjetaLogs(DateTime.Now, "Cadastrar", $"CNPJ:{maskCNPJ.Text} Nome:{txbNome.Text} País:{txbPais.Text} Cidade:{txbCidade.Text} Estado:{txbEstado.Text} Status:{radioAtivo.Text}", "Conclusão de inclusão de Fornecedor");
            //    }
            //    else
            //    {
            //        CadastroFornecedor cad = new CadastroFornecedor(txbNome.Text, maskCNPJ.Text, txbPais.Text, txbCidade.Text, txbEstado.Text, radioInativo.Text);
            //        MessageBox.Show(cad.mensagem);
            //        logs = new ProjetaLogs(DateTime.Now, "Cadastrar", $"CNPJ:{maskCNPJ.Text} Nome:{txbNome.Text} País:{txbPais.Text} Cidade:{txbCidade.Text} Estado:{txbEstado.Text} Status:{radioInativo.Text}", "Conclusão de inclusão de Perfil");
            //    }
            //}
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
    }
}
