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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SGPPC.Views.Produto.FrmAlterarProduto;

namespace SGPPC.Views.ControleCaixa
{
    public partial class FrmEditarControleCaixa : Form
    {
        private int idTipoOperacaoSelecionado;

        private string descricaoOriginalMotivo;

        private string descricaoOrignalTipoOperacao;

        private string descricaoOriginalValor;

        public int UserID { get; private set; }

        public FrmEditarControleCaixa()
        {
            InitializeComponent();
        }

        public FrmEditarControleCaixa(string motivo, string tipo, string valor, string data, string id)
        {
            InitializeComponent();

            txbMotivoEditar.Text = motivo;
            cbbTipoOperadcaoEditar.Text = tipo;
            txbValorEditar.Text = valor;
            maskDataHoraEditar.Text = data;
            txbIdEdit.Text = id;
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpar_Click_1(object sender, EventArgs e)
        {
            LimparFormulario.LimparForm(this);
        }

        private void FrmEditarControleCaixa_Load(object sender, EventArgs e)
        {
            descricaoOriginalMotivo = txbMotivoEditar.Text;
            descricaoOrignalTipoOperacao = cbbTipoOperadcaoEditar.Text;
            descricaoOriginalValor = txbValorEditar.Text;

            DateTime dataHoraAtual = DateTime.Now;
            maskDataHoraEditar.Text = dataHoraAtual.ToString("dd/MM/yyyy HH:mm");

            if (int.TryParse(txbIdTipoOperacao.Text, out int selectedTipoID))
            {
                string connectionString = "Data Source = ACF014\\SQLEXPRESS; Initial Catalog = SGPPC; Integrated Security = True";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string queryTodosSabor = "SELECT Id, Descricao FROM TipoOperacao";
                    using (SqlCommand cmdTodosSabor = new SqlCommand(queryTodosSabor, connection))
                    {
                        using (SqlDataReader reader = cmdTodosSabor.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int tipoID = reader.GetInt32(reader.GetOrdinal("Id"));
                                string tipoNome = reader.GetString(reader.GetOrdinal("Descricao"));

                                TipoOperacaoItem tipoItem = new TipoOperacaoItem(tipoID, tipoNome);
                                cbbTipoOperadcaoEditar.Items.Add(tipoItem);

                                if (tipoID == selectedTipoID)
                                {
                                    idTipoOperacaoSelecionado = tipoID;
                                    cbbTipoOperadcaoEditar.SelectedIndex = cbbTipoOperadcaoEditar.Items.Count - 1;
                                }
                            }
                        }
                    }
                }
            }
        }

        public class TipoOperacaoItem
        {
            public int Id { get; set; }
            public string Descricao { get; set; }

            public TipoOperacaoItem(int id, string nome)
            {
                Id = id;
                Descricao = nome;
            }

            public override string ToString()
            {
                return Descricao;
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (txbMotivoEditar.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o campo Motivo.", "Controle de Caixa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbMotivoEditar.Text = "";
                txbMotivoEditar.Focus();
                return;
            }
            else if (cbbTipoOperadcaoEditar.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o campo Tipo de Operação.", "Controle de Caixa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbbTipoOperadcaoEditar.Text = "";
                cbbTipoOperadcaoEditar.Focus();
                return;
            }
            else if (txbValorEditar.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o campo Valor.", "Controle de Caixa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbValorEditar.Text = "";
                txbValorEditar.Focus();
                return;
            }
            else
            {
                FrmPrincipal principalForm = Application.OpenForms.OfType<FrmPrincipal>().FirstOrDefault();
                if (principalForm != null)
                {
                    if (Int32.TryParse(txbIdEdit.Text, out Int32 id))
                    {
                        CaixaControle controle = new CaixaControle();
                        String mensagem = controle.EditarCaixa(txbMotivoEditar.Text, txbIdTipoOperacao.Text, txbValorEditar.Text, id);

                        int userId = principalForm.UserID;
                        if (controle.tem)
                        {
                            string tabelaAfetada = "Controle de Caixa";
                            DateTime dataHora = DateTime.Now;
                            string acao = "btnEditar_Click";
                            string descricao = "Alteração: ";

                            if (descricaoOriginalMotivo != txbMotivoEditar.Text)
                            {
                                descricao += "O 'Motivo' foi alterado de " + "'" + descricaoOriginalMotivo + "'" + " para " + "'" + txbMotivoEditar.Text + "'.";
                            }
                            else if (descricaoOrignalTipoOperacao != cbbTipoOperadcaoEditar.Text)
                            {
                                descricao += "O 'Tipo de Operação' foi alterado de " + "'" + descricaoOrignalTipoOperacao + "'" + " para " + "'" + cbbTipoOperadcaoEditar.Text + "'.";
                            }
                            else if (descricaoOriginalValor != txbValorEditar.Text)
                            {
                                descricao += "O 'Valor' foi alterado de " + "'" + descricaoOriginalValor + "'" + " para " + "'" + txbValorEditar.Text + "'.";
                            }

                            InserirLogsComands inserirLogs = new InserirLogsComands(tabelaAfetada, dataHora, acao, descricao, userId);

                            MessageBox.Show(mensagem, "Alteração", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Close();
                        }
                        else
                        {
                            string tabelaAfetada = "Controle de Caixa";
                            DateTime dataHora = DateTime.Now;
                            string acao = "btnEditar_Click";
                            string descricao = "Erro na alteração: ";

                            if (descricaoOriginalMotivo != txbMotivoEditar.Text)
                            {
                                descricao += "O 'Motivo' não pode ser alterado de " + "'" + descricaoOriginalMotivo + "'" + " para " + "'" + txbMotivoEditar.Text + "'.";
                            }
                            else if (descricaoOrignalTipoOperacao != cbbTipoOperadcaoEditar.Text)
                            {
                                descricao += "O 'Tipo de Operação' não pode ser alterado de " + "'" + descricaoOrignalTipoOperacao + "'" + " para " + "'" + cbbTipoOperadcaoEditar.Text + "'.";
                            }
                            else if (descricaoOriginalValor != txbValorEditar.Text)
                            {
                                descricao += "O 'Valor' não pode ser alterado de " + "'" + descricaoOriginalValor + "'" + " para " + "'" + txbValorEditar.Text + "'.";
                            }

                            InserirLogsComands inserirLogs = new InserirLogsComands(tabelaAfetada, dataHora, acao, descricao, userId);

                            MessageBox.Show(controle.mensagem);
                        }
                    }
                    else
                    {
                        MessageBox.Show("ID inválido. O ID deve ser um número inteiro.", "Alteração do caixa.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txbIdEdit.Text = "";
                        txbIdEdit.Focus();
                    }
                }
            }
        }

        private void txbTipoOperadcaoEditar_SelectedIndexChanged(object sender, EventArgs e)
        {
            TipoOperacaoItem tipoOperacaoSelecionado = (TipoOperacaoItem)cbbTipoOperadcaoEditar.SelectedItem;
            idTipoOperacaoSelecionado = tipoOperacaoSelecionado.Id;
        }

        private int ObterIdPelaDescricaos(string descricao)
        {
            if (descricao == "Descrição1")
            {
                return 1;
            }
            else if (descricao == "Descrição2")
            {
                return 2;
            }
            return 0;
        }
    }
}
