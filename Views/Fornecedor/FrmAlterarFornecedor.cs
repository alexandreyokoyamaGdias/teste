using SGPPC.Class;
using SGPPC.Data;
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
        private string descricaoOriginalCNPJ;

        private string descricaoOrignalNome;

        private string descricaoOriginalPais;

        private string descricaoOriginalCidade;
            
        private string descricaoOriginalEstado;

        private string descricaoOriginalAtivo;

        private string descricaoOriginalInativo;

        public int UserID { get; private set; }

        public FrmAlterarFornecedor()
        {
            InitializeComponent();
        }

        public FrmAlterarFornecedor(string cnpj, string nome, string pais, string cidade, string estado, string status, string id)
        {
            InitializeComponent();

            txbCNPJ.Text = cnpj;
            txbNome.Text = nome;
            txbPais.Text = pais;
            txbCidade.Text = cidade;
            txbEstado.Text = estado;
            txbId.Text = id;

            if (status == "Ativo")
            {
                radioAtivo.Checked = true;
                radioAtivo.Checked = false;
            }
            else if (status == "Inativo")
            {
                radioInativo.Checked = false;
                radioInativo.Checked = true;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
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
            else if (string.IsNullOrWhiteSpace(txbNome.Text))
            {
                MessageBox.Show("Preencha o campo Descrição", "Alteração fornecedor", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbNome.Text = "";
                txbNome.Focus();
                return;
            }
            else if (string.IsNullOrWhiteSpace(txbPais.Text))
            {
                MessageBox.Show("Preencha o campo País", "Alteração fornecedor", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbPais.Text = "";
                txbPais.Focus();
                return;
            }
            else if (string.IsNullOrWhiteSpace(txbCidade.Text))
            {
                MessageBox.Show("Preencha o campo Cidade", "Alteração fornecedor", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbCidade.Text = "";
                txbCidade.Focus();
                return;
            }
            else if (string.IsNullOrWhiteSpace(txbEstado.Text))
            {
                MessageBox.Show("Preencha o campo Estado", "Alteração fornecedor", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbEstado.Text = "";
                txbEstado.Focus();
                return;
            }
            else if (!radioAtivo.Checked && !radioInativo.Checked)
            {
                MessageBox.Show("Selecione um status (Ativo ou Inativo)", "Alteração fornecedor", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                radioAtivo.Focus();
                radioInativo.Focus();
                return;
            }
            else
            {
                FrmPrincipal principalForm = Application.OpenForms.OfType<FrmPrincipal>().FirstOrDefault();
                if (principalForm != null)
                {
                    if (Int32.TryParse(txbId.Text, out int id))
                    {
                        FornecedorEditarControle fornecedorEditarControle = new FornecedorEditarControle();
                        string status = radioAtivo.Checked ? "Ativo" : "Inativo";
                        String mensagem = fornecedorEditarControle.AlterarForn(id, txbCNPJ.Text.Trim(), txbNome.Text.Trim(), txbPais.Text.Trim(), txbCidade.Text.Trim(), txbEstado.Text.Trim(), status);

                        int userId = principalForm.UserID;
                        if (fornecedorEditarControle.tem)
                        {
                            string tabelaAfetada = "Fornecedor";
                            DateTime dataHora = DateTime.Now;
                            string acao = "button1_Click";
                            string descricao = "Alteração: ";

                            if (descricaoOriginalCNPJ != txbCNPJ.Text)
                            {
                                descricao += "O 'CNPJ' foi alterado de " + "'" + descricaoOriginalCNPJ + "'" + " para " + "'" + txbCNPJ.Text + "'.";
                            }
                            else if (descricaoOrignalNome != txbNome.Text)
                            {
                                descricao += "O 'Nome' foi alterado de " + "'" + descricaoOrignalNome + "'" + " para " + "'" + txbNome.Text + "'.";
                            }
                            else if (descricaoOriginalPais != txbPais.Text)
                            {
                                descricao += "O 'País' foi alterado de " + "'" + descricaoOriginalPais + "'" + " para " + "'" + txbPais.Text + "'.";
                            }
                            else if (descricaoOriginalCidade != txbCidade.Text)
                            {
                                descricao += "A 'Cidade' foi alterada de " + "'" + descricaoOriginalCidade + "'" + " para " + "'" + txbCidade.Text + "'.";
                            }
                            else if (descricaoOriginalEstado != txbEstado.Text)
                            {
                                descricao += "O 'Estado' foi alterado de " + "'" + descricaoOriginalEstado + "'" + " para " + "'" + txbEstado.Text + "'.";
                            }
                            else if (descricaoOriginalAtivo != radioAtivo.Text)
                            {
                                descricao += "O 'Status' foi alterado de " + "'" + descricaoOriginalAtivo + "'" + " para " + "'" + radioAtivo.Text + "'.";
                            }
                            else if (descricaoOriginalInativo != radioInativo.Text)
                            {
                                descricao += "O 'Status' foi alterado de " + "'" + descricaoOriginalInativo + "'" + " para " + "'" + radioInativo.Text + "'.";
                            }

                            InserirLogsComands inserirLogs = new InserirLogsComands(tabelaAfetada, dataHora, acao, descricao, userId);

                            MessageBox.Show(mensagem, "Alteração", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Close();
                        }
                        else
                        {
                            string tabelaAfetada = "Fornecedor";
                            DateTime dataHora = DateTime.Now;
                            string acao = "button1_Click";
                            string descricao = "Erro na alteração: ";

                            if (descricaoOriginalCNPJ != txbCNPJ.Text)
                            {
                                descricao += "O 'CNPJ' não pode ser alterado de " + "'" + descricaoOriginalCNPJ + "'" + " para " + "'" + txbCNPJ.Text + "'.";
                            }
                            else if (descricaoOrignalNome != txbNome.Text)
                            {
                                descricao += "O 'Nome' não pode ser alterado de " + "'" + descricaoOrignalNome + "'" + " para " + "'" + txbNome.Text + "'.";
                            }
                            else if (descricaoOriginalPais != txbPais.Text)
                            {
                                descricao += "O 'País' não pode ser alterado de " + "'" + descricaoOriginalPais + "'" + " para " + "'" + txbPais.Text + "'.";
                            }
                            else if (descricaoOriginalCidade != txbCidade.Text)
                            {
                                descricao += "A 'Cidade' não pode ser alterada de " + "'" + descricaoOriginalCidade + "'" + " para " + "'" + txbCidade.Text + "'.";
                            }
                            else if (descricaoOriginalEstado != txbEstado.Text)
                            {
                                descricao += "O 'Estado' não pode ser alterado de " + "'" + descricaoOriginalEstado + "'" + " para " + "'" + txbEstado.Text + "'.";
                            }
                            else if (descricaoOriginalAtivo != radioAtivo.Text)
                            {
                                descricao += "O 'Status' não pode ser alterado de " + "'" + descricaoOriginalAtivo + "'" + " para " + "'" + radioAtivo.Text + "'.";
                            }
                            else if (descricaoOriginalInativo != radioInativo.Text)
                            {
                                descricao += "O 'Status' não pode ser alterado de " + "'" + descricaoOriginalInativo + "'" + " para " + "'" + radioInativo.Text + "'.";
                            }

                            InserirLogsComands inserirLogs = new InserirLogsComands(tabelaAfetada, dataHora, acao, descricao, userId);
                            MessageBox.Show(fornecedorEditarControle.mensagem);
                        }
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

        private void FrmAlterarFornecedor_Load(object sender, EventArgs e)
        {
            descricaoOriginalCNPJ = txbCNPJ.Text;
            
            descricaoOrignalNome = txbNome.Text;
            
            descricaoOriginalPais = txbPais.Text;
            
            descricaoOriginalCidade = txbCidade.Text;
            
            descricaoOriginalEstado = txbEstado.Text;

            descricaoOriginalAtivo = radioAtivo.Text;

            descricaoOriginalInativo = radioInativo.Text;
        }
    }
}


