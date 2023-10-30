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
    public partial class FrmCadastroSabores : Form
    {
        public FrmCadastroSabores()
        {
            InitializeComponent();
        }

        private void FrmCadastroSabores_Load(object sender, EventArgs e)
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

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txbDescricao.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o campo Descrição", "Cadastro do Sabor!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbDescricao.Text = "";
                txbDescricao.Focus();
                return;
            }
            else
            {
                SaborControlee saborControle = new SaborControlee();
                String mensagem = saborControle.CadastrarSabor(txbDescricao.Text.Trim());

                if (saborControle.tem)
                {
                    string tabelaAfetada = "Sabor";
                    DateTime dataHora = DateTime.Now;
                    string acao = "btnCadastrar_Click";
                    string descricao = "Cadastro de sabor bem-sucedido";

                    InserirLogsComands inserirLogs = new InserirLogsComands(tabelaAfetada, dataHora, acao, descricao);

                    MessageBox.Show(mensagem, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimparFormulario.LimparForm(this);
                }
                else
                {
                    MessageBox.Show(saborControle.mensagem);
                }
            }
        }
    }
}
