using SGPPC.Class;
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
using BCrypt.Net;
using SGPPC.Data;
using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;
using System.Data.SqlClient;
using static SGPPC.Views.EntradaProduto.FrmCadastrarEntradaProduto;

namespace SGPPC.Views.Usuarios
{
    public partial class FrmCadastro : Form
    {
        public int UserID { get; private set; }

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
            if (string.IsNullOrWhiteSpace(txbNome.Text))
            {
                MessageBox.Show("Preencha o campo Nome", "Cadastro de usuário", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbNome.Focus();
                return;
            }
            else if (string.IsNullOrWhiteSpace(txbEmail.Text))
            {
                MessageBox.Show("Preencha o campo email", "Cadastro de usuário", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbEmail.Focus();
                return;
            }
            else if (string.IsNullOrWhiteSpace(cbFuncao.Text))
            {
                MessageBox.Show("Preencha o campo Função", "Cadastro de usuário", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbFuncao.Focus();
                return;
            }
            else if (string.IsNullOrWhiteSpace(maskCPF.Text) || maskCPF.Text.Length < 14)
            {
                MessageBox.Show("Preencha o campo CPF com um CPF válido (entre 10 e 11 dígitos).", "Cadastro de usuário", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                maskCPF.Focus();
                return;
            }
            else if (string.IsNullOrWhiteSpace(txbSenha.Text))
            {
                MessageBox.Show("Preencha o campo senha", "Cadastro de usuário", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbSenha.Focus();
                return;
            }
            else if (string.IsNullOrWhiteSpace(maskDataHoraAdmissao.Text))
            {
                MessageBox.Show("Preencha o campo data/hora admissão", "Cadastro de usuário", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                maskDataHoraAdmissao.Focus();
                return;
            }
            else if (string.IsNullOrWhiteSpace(comboBoxNivelPermissao.Text))
            {
                MessageBox.Show("Preencha o campo Nível de Permissão", "Cadastro de usuário", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboBoxNivelPermissao.Focus();
                return;
            }

            string salt = BCrypt.Net.BCrypt.GenerateSalt();

            string senhaDoUsuario = txbSenha.Text;

            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(senhaDoUsuario, salt);

            FrmPrincipal principalForm = Application.OpenForms.OfType<FrmPrincipal>().FirstOrDefault();
            if (principalForm != null)
            {
                int userId = principalForm.UserID; // Obtenha o UserID da instância de FrmPrincipal

                Controle controle = new Controle();
                string mensagem = controle.Cadastrar(txbNome.Text, txbEmail.Text, cbFuncao.Text, maskCPF.Text, hashedPassword, maskDataHoraAdmissao.Text, textBoxId.Text.Trim());
                
                if (controle.tem)
                {
                    string tabelaAfetada = "Usuário";
                    DateTime dataHora = DateTime.Now;
                    string acao = "btnCadastrar_Click";
                    string descricao = "Cadastro de Usuário bem-sucedido";

                    InserirLogsComands inserirLogs = new InserirLogsComands(tabelaAfetada, dataHora, acao, descricao, userId);

                    MessageBox.Show(mensagem, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    MessageBox.Show(mensagem);
                }
            }    
        }

        private void FrmCadastro_Load(object sender, EventArgs e)
        {
            DateTime dataHoraAtual = DateTime.Now;
            maskDataHoraAdmissao.Text = dataHoraAtual.ToString("dd/MM/yyyy HH:mm");

            string connectionString = "Data Source=ACF014\\SQLEXPRESS;Initial Catalog=SGPPC;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT Id, Descricao FROM Perfil";

                SqlCommand cmd = new SqlCommand(query, connection);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    comboBoxNivelPermissao.Items.Clear();

                    while (reader.Read())
                    {
                        int nivelID = Convert.ToInt32(reader["Id"]);
                        string nivelDescricao = reader["Descricao"].ToString();

                        // Cria um objeto ProdutoComboBoxItem para armazenar ID e Nome
                        NivelComboBoxItem nivelItem = new NivelComboBoxItem
                        {
                            NivelID = nivelID,
                            NivelDescricao = nivelDescricao
                        };

                        // Adiciona o objeto ao ComboBox
                        comboBoxNivelPermissao.Items.Add(nivelItem);
                    }
                }
            }
        }

        public class NivelComboBoxItem
        {
            public int NivelID { get; set; }
            public string NivelDescricao { get; set; }

            public override string ToString()
            {
                return NivelDescricao; // Apenas para exibição no ComboBox
            }
        }

        private void comboBoxNivelPermissao_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Verifica se há um item selecionado no ComboBox
            if (comboBoxNivelPermissao.SelectedItem != null)
            {
                // Obtém o objeto ProdutoComboBoxItem do item selecionado
                NivelComboBoxItem selectedFornecedor = (NivelComboBoxItem)comboBoxNivelPermissao.SelectedItem;

                // Atualiza o textBoxIdProduto com o ID correspondente
                textBoxId.Text = selectedFornecedor.NivelID.ToString();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparFormulario.LimparForm(this);
        }
    }
}