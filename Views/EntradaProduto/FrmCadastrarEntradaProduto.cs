using Org.BouncyCastle.Utilities;
using SGPPC.Class;
using SGPPC.Controller;
using SGPPC.Data;
using SGPPC.Model;
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

namespace SGPPC.Views.EntradaProduto
{
    public partial class FrmCadastrarEntradaProduto : Form
    {
        public int UserID { get; private set; }

        public FrmCadastrarEntradaProduto()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparFormulario.LimparForm(this);
        }

        private void FrmCadastrarEntradaProduto_Load(object sender, EventArgs e)
        {
            DateTime dataHoraAtual = DateTime.Now;
            maskedTextBoxDataHora.Text = dataHoraAtual.ToString("dd/MM/yyyy HH:mm");

            string connectionString = "Data Source=ACF014\\SQLEXPRESS;Initial Catalog=SGPPC;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query2 = "SELECT Id, Nome_Produto FROM Produto";
                string query = "SELECT Id, Nome FROM Fornecedor";

                SqlCommand cmd2 = new SqlCommand(query2, connection);
                SqlCommand cmd = new SqlCommand(query, connection);

                using (SqlDataReader reader2 = cmd2.ExecuteReader())
                {
                    comboBoxProduto.Items.Clear();

                    while (reader2.Read())
                    {
                        int produtoID = Convert.ToInt32(reader2["Id"]);
                        string produtoNome = reader2["Nome_Produto"].ToString();

                        ProdutoComboBoxItem produtoItem = new ProdutoComboBoxItem
                        {
                            ProdutoID = produtoID,
                            ProdutoNome = produtoNome
                        };

                        comboBoxProduto.Items.Add(produtoItem);
                    }
                }

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    comboBoxFornecedor.Items.Clear();

                    while (reader.Read())
                    {
                        int fornecedorID = Convert.ToInt32(reader["Id"]);
                        string fornecedorNome = reader["Nome"].ToString();

                        FornecedorComboBoxItem fornecedorItem = new FornecedorComboBoxItem
                        {
                            FornecedorID = fornecedorID,
                            FornecedorNome = fornecedorNome
                        };

                        comboBoxFornecedor.Items.Add(fornecedorItem);
                    }
                }
            }
        }

        public class ProdutoComboBoxItem
        {
            public int ProdutoID { get; set; }
            public string ProdutoNome { get; set; }

            public override string ToString()
            {
                return ProdutoNome;
            }
        }

        public class FornecedorComboBoxItem
        {
            public int FornecedorID { get; set; }
            public string FornecedorNome { get; set; }

            public override string ToString()
            {
                return FornecedorNome;
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txbNotaFiscal.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o campo Nota Fiscal", "Entrada produto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbNotaFiscal.Text = "";
                txbNotaFiscal.Focus();
                return;
            }
            else if (txbPreco.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o campo Preço", "Entrada produto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbPreco.Text = "";
                txbPreco.Focus();
                return;
            }
            else if (txbQuantidade.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o campo Quantidade", "Entrada produto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbQuantidade.Text = "";
                txbQuantidade.Focus();
                return;
            }
            else if (comboBoxFornecedor.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o campo Fornecedor", "Entrada produto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboBoxFornecedor.Text = "";
                comboBoxFornecedor.Focus();
                return;
            }
            else if (comboBoxProduto.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o campo Produto", "Entrada produto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboBoxProduto.Text = "";
                comboBoxProduto.Focus();
                return;
            }
            else
            {
                FrmPrincipal principalForm = Application.OpenForms.OfType<FrmPrincipal>().FirstOrDefault();
                if (principalForm != null)
                {
                    
                    EntadaProdutoControle entradaprodutoControle = new EntadaProdutoControle();

                    int userId = principalForm.UserID;
                    if (entradaprodutoControle.tem)
                    {
                        string tabelaAfetada = "Cadastro Entrada de Produto";
                        DateTime dataHora = DateTime.Now;
                        string acao = "btnCadastrar_Click";
                        string descricao = "Cadastro de entrada do produto bem-sucedido";

                        InserirLogsComands inserirLogs = new InserirLogsComands(tabelaAfetada, dataHora, acao, descricao, userId);

                        LimparFormulario.LimparForm(this);
                    }
                    else
                    {
                        string tabelaAfetada = "Cadastro Entrada de Produto";
                        DateTime dataHora = DateTime.Now;
                        string acao = "btnCadastrar_Click";
                        string descricao = "Erro ao tentar cadastrar entrada do produto";

                        InserirLogsComands inserirLogs = new InserirLogsComands(tabelaAfetada, dataHora, acao, descricao, userId);

                        MessageBox.Show(entradaprodutoControle.mensagem);
                    }
                }
            }
        }

        //private void comboBoxFornecedor_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (comboBoxFornecedor.SelectedIndex != -1)
        //    {
        //        KeyValuePair<int, string> selectedProduto = (KeyValuePair<int, string>)comboBoxFornecedor.SelectedItem;
        //        int saborID = selectedProduto.Key;

        //        textBoxIdFornecedor.Text = saborID.ToString();
        //    }
        //}

        //private void comboBoxProduto_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (comboBoxProduto.SelectedIndex != -1)
        //    {
        //        KeyValuePair<int, string> selectedProduto = (KeyValuePair<int, string>)comboBoxProduto.SelectedItem;
        //        int saborID = selectedProduto.Key;

        //        textBoxIdProduto.Text = saborID.ToString();
        //    }
        //}

        //private void btnFinalizar_Click(object sender, EventArgs e)
        //{
        //    DialogResult resultado = MessageBox.Show("Deseja realmente incluir estes produtos ao estoque?", "Confirmação", MessageBoxButtons.YesNo);
        //    if (resultado == DialogResult.Yes)
        //    {
        //        var qtdlinhas = dgEntradaProduto.Rows.Count;

        //        for (int i = 0; i < qtdlinhas; i++)
        //        {
        //            DataGridViewRow row = dgEntradaProduto.Rows[0];

        //            DataGridViewCell cell2 = row.Cells["Nota_Fiscal"];
        //            DataGridViewCell cell3 = row.Cells["Preco_Unitario"];
        //            DataGridViewCell cell4 = row.Cells["Quantidade"];
        //            DataGridViewCell cell5 = row.Cells["Id_Fornecedor"];
        //            DataGridViewCell cell6 = row.Cells["Id_Produto"];
        //            DataGridViewCell cell7 = row.Cells["Data_Hora_Entrada"];

        //            var notaFiscal = "";
        //            var preco = "";
        //            var quantidade = "";
        //            var id = "";
        //            var idprod = "";
        //            var data = "";

        //            notaFiscal = cell2.Value.ToString();
        //            preco = cell3.Value.ToString();
        //            quantidade = cell4.Value.ToString();
        //            id = cell5.Value.ToString();
        //            idprod = cell6.Value.ToString();
        //            data = cell7.Value.ToString();

        //            ConsultarIdProduto clt = new ConsultarIdProduto();
        //            int iditem = clt.ConsultaId(idprod);

        //            ConsultarIdFornecedor conslt = new ConsultarIdFornecedor();
        //            var resultidfor = conslt.ConsultaId(id);

        //            EntradaController cadprod = new EntradaController(notaFiscal, DateTime.Now, resultidfor);

        //            Conexao conexao = new Conexao();
        //            SqlCommand cmd = new SqlCommand();

        //            cmd.Connection = conexao.conectar();
        //            cmd.CommandText = @"SELECT TOP 1 *  FROM Entrada ORDER BY Id DESC";

        //            SqlDataReader consultar = cmd.ExecuteReader();
        //            consultar.Read();
        //            int resultadoidprod = (int)consultar.GetValue(0);
        //            conexao.desconectar();

        //            Int32.TryParse(quantidade, out Int32 quantidadeproduto);
        //            Decimal.TryParse(preco, out decimal valordocusto);

        //            EntradaProdutoController caditem = new EntradaProdutoController(valordocusto, quantidadeproduto, resultidfor, resultadoidprod);

        //            dgEntradaProduto.Rows.RemoveAt(0);
        //            MessageBox.Show($"{dgEntradaProduto.Rows.Count}");
        //            if (dgEntradaProduto.Rows.Count == 0)
        //            {
        //                qtdlinhas = 1;
        //            }
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("Ok!");
        //    }
        //}

        //Novas validações
        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dgEntradaProduto.Rows)
                {
                    ProdutoEntradaClass modelo = new ProdutoEntradaClass
                    {
                        NotaFiscal = row.Cells["Nota_Fiscal"].Value.ToString(),
                        DataHoraEntrada = Convert.ToDateTime(row.Cells["Data_Hora_Entrada"].Value),
                        IdFornecedor = Convert.ToInt32(row.Cells["Id_Fornecedor"].Value),
                        PrecoUnitario = Convert.ToDecimal(row.Cells["Preco_Unitario"].Value),
                        Quantidade = Convert.ToInt32(row.Cells["Quantidade"].Value),
                        IdProduto = Convert.ToInt32(row.Cells["Id_Produto"].Value),
                    };

                    int idProdutoInserido = InserirDadosNoBancoEntrada(modelo);

                    InserirDadosNoBancoProdutoEntrada(modelo, idProdutoInserido);
                }

                dgEntradaProduto.Rows.Clear();

                MessageBox.Show("Produto inserido(s) com sucesso.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao inserir os dados no banco: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int InserirDadosNoBancoEntrada(ProdutoEntradaClass modelo)
        {
            try
            {
                string query = "INSERT INTO Entrada (Nota_Fiscal, Data_Hora_Entrada, Id_Fornecedor) " +
                               "VALUES (@Nota_Fiscal, @Data_Hora_Entrada, @Id_Fornecedor); " +
                               "SELECT SCOPE_IDENTITY();";

                using (SqlConnection conexao = new SqlConnection("Data Source=ACF014\\SQLEXPRESS;Initial Catalog=SGPPC;Integrated Security=True"))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conexao))
                    {
                        conexao.Open();

                        cmd.Parameters.AddWithValue("@Nota_Fiscal", modelo.NotaFiscal);
                        cmd.Parameters.AddWithValue("@Data_Hora_Entrada", modelo.DataHoraEntrada);
                        cmd.Parameters.AddWithValue("@Id_Fornecedor", modelo.IdFornecedor);

                        return Convert.ToInt32(cmd.ExecuteScalar());
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao inserir os dados na tabela Entrada: " + ex.Message);
            }
        }

        private void InserirDadosNoBancoProdutoEntrada(ProdutoEntradaClass modelo, int idEntrada)
        {
            try
            {
                string query = "INSERT INTO Produto_Entrada (Preco_Unitario, Quantidade, Id_Produto, Id_Entrada) " +
                               "VALUES (@Preco_Unitario, @Quantidade, @Id_Produto, @Id_Entrada)";

                using (SqlConnection conexao = new SqlConnection("Data Source=ACF014\\SQLEXPRESS;Initial Catalog=SGPPC;Integrated Security=True"))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conexao))
                    {
                        conexao.Open();

                        cmd.Parameters.AddWithValue("@Preco_Unitario", modelo.PrecoUnitario);
                        cmd.Parameters.AddWithValue("@Quantidade", modelo.Quantidade);
                        cmd.Parameters.AddWithValue("@Id_Produto", modelo.IdProduto);
                        cmd.Parameters.AddWithValue("@Id_Entrada", idEntrada);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao inserir os dados na tabela Produto_Entrada: " + ex.Message);
            }
        }

        //Fim das novas validações

        private void InserirDadosNoBanco(PedidoClass modelo)
        {
            SqlConnection conexao;

            conexao = new SqlConnection("Data Source=ACF014\\SQLEXPRESS;Initial Catalog=SGPPC;Integrated Security=True");

            try
            {
                conexao.Open();

                string query = "INSERT INTO Entrada (NomeCliente, Produto, Descricao, Quantidade, Valor, Data) " +
                                "VALUES (@NomeCliente, @Produto, @Descricao, @Quantidade, @Valor, @Data)";

                SqlCommand cmd = new SqlCommand(query, conexao);

                cmd.Parameters.AddWithValue("@NomeCliente", modelo.NomeCliente);
                cmd.Parameters.AddWithValue("@Produto", modelo.IdProduto);
                cmd.Parameters.AddWithValue("@Quantidade", modelo.Quantidade);
                cmd.Parameters.AddWithValue("@Valor", modelo.Valor);
                cmd.Parameters.AddWithValue("@Data", modelo.DataHoraPedido);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao inserir os dados: " + ex.Message);
            }
            finally
            {
                conexao.Close();
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (txbNotaFiscal.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Insira a nota fiscal.", "Entrada de produto.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbNotaFiscal.Text = "";
                txbNotaFiscal.Focus();
                return;
            }
            else if (txbPreco.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Insira o preço.", "Entrada de produto.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbPreco.Text = "";
                txbPreco.Focus();
                return;
            }
            else if (txbQuantidade.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Insira a quantidade.", "Entrada de produto.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbQuantidade.Text = "";
                txbQuantidade.Focus();
                return;
            }
            else if (comboBoxFornecedor.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Selecione o fornecedor.", "Entrada de produto.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboBoxFornecedor.Text = "";
                comboBoxFornecedor.Focus();
                return;
            }
            else if (comboBoxProduto.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Selecione o produto.", "Entrada de produto.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboBoxProduto.Text = "";
                comboBoxProduto.Focus();
                return;
            }
            else if (maskedTextBoxDataHora.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o campo data/hora.", "Entrada de produto.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                maskedTextBoxDataHora.Text = "";
                maskedTextBoxDataHora.Focus();
                return;
            }
            else
            {
                string NotaFiscal = txbNotaFiscal.Text;
                string Preco = txbPreco.Text;
                string Quantidade = txbQuantidade.Text;
                string Fornecedor = textBoxIdFornecedor.Text;
                string Produto = textBoxIdProduto.Text;
                string DataHora = maskedTextBoxDataHora.Text;

                dgEntradaProduto.Rows.Add(NotaFiscal, Preco, Quantidade, Fornecedor, Produto, DataHora);

                txbPreco.Clear();
                comboBoxProduto.SelectedIndex = -1;
                txbQuantidade.Clear();
            }
        }

        private void dgEntradaProduto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow row = dgEntradaProduto.Rows[e.RowIndex];

                string notaFiscal = row.Cells["NotaFiscal"].Value.ToString();
                string preco = row.Cells["Preco"].Value.ToString();
                string quantidade = row.Cells["Quantidade"].Value.ToString();
                string fornecedor = row.Cells["Fornecedor"].Value.ToString();
                string produto = row.Cells["Produto"].Value.ToString();
                string dataHora = row.Cells["DataHora"].Value.ToString();
                string id = row.Cells["Id"].Value.ToString();
            }
        }

        private void comboBoxProduto_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (comboBoxProduto.SelectedItem != null)
            {
                ProdutoComboBoxItem selectedProduto = (ProdutoComboBoxItem)comboBoxProduto.SelectedItem;

                textBoxIdProduto.Text = selectedProduto.ProdutoID.ToString();
            }
        }

        private void comboBoxFornecedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxFornecedor.SelectedItem != null)
            {
                FornecedorComboBoxItem selectedFornecedor = (FornecedorComboBoxItem)comboBoxFornecedor.SelectedItem;

                textBoxIdFornecedor.Text = selectedFornecedor.FornecedorID.ToString();
            }
        }
    }
}
