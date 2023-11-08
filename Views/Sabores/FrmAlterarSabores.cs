using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;
using SGPPC.Class;
using SGPPC.Data;
using SGPPC.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGPPC.Views.Sabores
{
    public partial class FrmAlterarSabores : Form
    {
        public int UserID { get; private set; }

        public FrmAlterarSabores()
        {
            InitializeComponent();
        }

        public FrmAlterarSabores(string descricao, string id)
        {
            InitializeComponent();

            txbAlterarDescricao.Text = descricao;
            txbId.Text = id;
        }

        private void FrmAlterarSabores_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelarSabor_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimparSabor_Click(object sender, EventArgs e)
        {
            LimparFormulario.LimparForm(this);
        }

        private void btnAlterarSabor_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txbAlterarDescricao.Text))
            {
                MessageBox.Show("Preencha o campo Descrição!", "Cadastro do Sabor.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbAlterarDescricao.Text = "";
                txbAlterarDescricao.Focus();
                return;
            }

            FrmPrincipal principalForm = Application.OpenForms.OfType<FrmPrincipal>().FirstOrDefault();
            if (principalForm != null)
            {
                int userId = principalForm.UserID; // Obtenha o UserID da instância de FrmPrincipal
                if (Int32.TryParse(txbId.Text, out int id))
                {
                    SaborControlee saborControle = new SaborControlee();
                    string mensagem = saborControle.AlterarSabor(id, txbAlterarDescricao.Text.Trim());

                    if (saborControle.tem)
                    {
                        string tabelaAfetada = "Sabor";
                        DateTime dataHora = DateTime.Now;
                        string acao = "btnAlterarSabor_Click";
                        string descricao = "Alteração de sabor bem-sucedida";

                        InserirLogsComands inserirLogs = new InserirLogsComands(tabelaAfetada, dataHora, acao, descricao, userId);

                        MessageBox.Show(mensagem, "Alteração", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    else
                    {
                        MessageBox.Show(saborControle.mensagem);
                    }
                }
                else
                {
                    MessageBox.Show("ID inválido. O ID deve ser um número inteiro.", "Alteração do Sabor.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txbId.Text = "";
                    txbId.Focus();
                }
            }
        }
    }
}
