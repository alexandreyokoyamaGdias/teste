using Microsoft.ReportingServices.Diagnostics.Internal;
using SGPPC.Class;
using SGPPC.Model;
using SGPPC.Views.EntradaProduto;
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
using static SGPPC.Views.ControleCaixa.FrmEditarControleCaixa;

namespace SGPPC.Views.Pedidos
{
    public partial class FrmPedido : Form
    {
        private int idProdutoSelecionado;

        public int UserID { get; set; }

        public FrmPedido()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmPedido_Load(object sender, EventArgs e)
        {
            txbIdUsuario.Text = UserID.ToString();

            string connectionString = "Data Source=ACF014\\SQLEXPRESS;Initial Catalog=SGPPC;Integrated Security=True";

            DateTime dataHoraAtual = DateTime.Now;
            maskedDataHora.Text = dataHoraAtual.ToString("dd/MM/yyyy HH:mm");

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT Id, Nome_Produto FROM Produto";
                string query2 = "SELECT Id, Nome FROM FormasPagamento WHERE Status = 'Ativo'";

                SqlCommand cmd = new SqlCommand(query, connection);
                SqlCommand cmd2 = new SqlCommand(query2, connection);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    cmbProduto.DisplayMember = "Value";
                    cmbProduto.ValueMember = "Key";

                    cmbProduto.Items.Clear();

                    while (reader.Read())
                    {
                        int produtoID = Convert.ToInt32(reader["Id"]);
                        string produtoNome = reader["Nome_Produto"].ToString();

                        cmbProduto.Items.Add(new KeyValuePair<int, string>(produtoID, produtoNome));
                    }
                }

                using (SqlDataReader reader2 = cmd2.ExecuteReader())
                {
                    comboPagamento.DisplayMember = "Value";
                    comboPagamento.ValueMember = "Key";

                    comboPagamento.Items.Clear();

                    while (reader2.Read())
                    {
                        int pagamentoID = Convert.ToInt32(reader2["Id"]);
                        string pagamentoNome = reader2["Nome"].ToString();

                        comboPagamento.Items.Add(new KeyValuePair<int, string>(pagamentoID, pagamentoNome));
                    }
                }
            }
        }

        private void cmbProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProduto.SelectedItem != null)
            {
                KeyValuePair<int, string> selectedProduto = (KeyValuePair<int, string>)cmbProduto.SelectedItem;

                int produtoID = selectedProduto.Key;

                txbIdProduto.Text = produtoID.ToString();

                string connectionString = "Data Source=ACF014\\SQLEXPRESS;Initial Catalog=SGPPC;Integrated Security=True";
                string query = "SELECT Valor FROM Produto WHERE Id = @ProdutoID";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@ProdutoID", produtoID);

                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        txbValor.Text = result.ToString();
                    }
                    else
                    {
                        txbValor.Text = string.Empty;
                    }
                }
            }
        }

        private void dgPagamento_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow row = dgPedido.Rows[e.RowIndex];

                string nomeCliente = row.Cells["Nome"].Value.ToString();
                string nomeProduto = row.Cells["Produto"].Value.ToString();
                string descricao = row.Cells["Descricao"].Value.ToString();
                string pagamento = row.Cells["FormaPagamento"].Value.ToString();
                string quantidade = row.Cells["Quantidade"].Value.ToString();
                string valor = row.Cells["Valor"].Value.ToString();
                string dataHora = row.Cells["DataHora"].Value.ToString();
                string idUsuario = row.Cells["Id_Usuario"].Value.ToString();
                string id = row.Cells["Id"].Value.ToString();
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (txbNomeCliente.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o campo Nome do cliente.", "Pedido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbNomeCliente.Text = "";
                txbNomeCliente.Focus();
                return;
            }
            else if (cmbProduto.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Selecione um produto.", "Pedido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbProduto.Text = "";
                cmbProduto.Focus();
                return;
            }
            else if (comboPagamento.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Selecione a forma de pagamento.", "Pedido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboPagamento.Text = "";
                comboPagamento.Focus();
                return;
            }
            else if (txbQuantidade.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o campo quantidade.", "Pedido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbQuantidade.Text = "";
                txbQuantidade.Focus();
                return;
            }
            else if (txbValor.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o campo valor.", "Pedido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbValor.Text = "";
                txbValor.Focus();
                return;
            }
            else if (maskedDataHora.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o campo data/hora.", "Pedido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                maskedDataHora.Text = "";
                maskedDataHora.Focus();
                return;
            }
            else
            {
                int produtoID = Convert.ToInt32(txbIdProduto.Text);

                int quantidadeDesejada = Convert.ToInt32(txbQuantidade.Text);

                if (!VerificarQuantidadeDisponivel(produtoID, quantidadeDesejada))
                {
                    MessageBox.Show("Quantidade insuficiente do produto selecionado.", "Pedido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string Nome = txbNomeCliente.Text;
                string Produto = txbIdProduto.Text;
                string Quantidade = txbQuantidade.Text;
                string FormPagamento = txbIdPagamento.Text;
                string Valor = txbTotal.Text;
                string DataHora = maskedDataHora.Text;
                string idUse = txbIdUsuario.Text;

                dgPedido.Rows.Add(Nome, Produto, Quantidade, FormPagamento, Valor, DataHora, idUse);

                cmbProduto.SelectedIndex = -1;
                txbQuantidade.Clear();
                comboPagamento.SelectedIndex = -1;
                txbValor.Clear();
                txbTotal.Clear();
                txbIdPagamento.Clear();
            }
        }

        private bool VerificarQuantidadeDisponivel(int produtoID, int quantidadeDesejada)
        {
            try
            {
                string connectionString = "Data Source=ACF014\\SQLEXPRESS;Initial Catalog=SGPPC;Integrated Security=True";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string queryNomeProduto = "SELECT Nome_Produto FROM Produto WHERE Id = @ProdutoID";
                    string nomeProduto;
                    using (SqlCommand cmdNomeProduto = new SqlCommand(queryNomeProduto, connection))
                    {
                        cmdNomeProduto.Parameters.AddWithValue("@ProdutoID", produtoID);
                        nomeProduto = cmdNomeProduto.ExecuteScalar() as string;
                    }

                    if (nomeProduto == null)
                    {
                        MessageBox.Show("Produto não encontrado.", "Pedido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }

                    string queryQuantidadeProdutoEntrada = "SELECT SUM(Quantidade) AS QuantidadeTotal FROM Produto_Entrada WHERE Id_Produto = @ProdutoID";
                    using (SqlCommand cmdQuantidadeProdutoEntrada = new SqlCommand(queryQuantidadeProdutoEntrada, connection))
                    {
                        cmdQuantidadeProdutoEntrada.Parameters.AddWithValue("@ProdutoID", produtoID);
                        int quantidadeProdutoEntrada = Convert.ToInt32(cmdQuantidadeProdutoEntrada.ExecuteScalar());

                        if (quantidadeProdutoEntrada < quantidadeDesejada)
                        {
                            MessageBox.Show($"Quantidade insuficiente do produto '{nomeProduto}'.", "Pedido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return false;
                        }
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao verificar a quantidade disponível: " + ex.Message, "Pedido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void txbIdProduto_TextChanged(object sender, EventArgs e)
        {
            if (cmbProduto.SelectedIndex != -1)
            {
                KeyValuePair<int, string> produtoNome = (KeyValuePair<int, string>)cmbProduto.SelectedItem;
                int produtoID = produtoNome.Key;

                txbIdProduto.Text = produtoID.ToString();
            }
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dgPedido.Rows)
                {
                    PedidoClass modelo = new PedidoClass
                    {
                        NomeCliente = row.Cells["Nome_Cliente"].Value.ToString(),
                        IdProduto = Convert.ToInt32(row.Cells["Id_Produto"].Value),
                        Quantidade = Convert.ToInt32(row.Cells["Quantidade"].Value),
                        IdFormasPagamento = Convert.ToInt32(row.Cells["Id_FormasPagamento"].Value),
                        Valor = Convert.ToDecimal(row.Cells["Valor"].Value),
                        DataHoraPedido = Convert.ToDateTime(row.Cells["Data_Hora_Pedido"].Value),
                        IdUsuario = Convert.ToInt32(row.Cells["Id_Usuario"].Value)
                    };

                    int idPedidoInserido = InserirDadosNoBancoPedido(modelo);

                    InserirDadosNoBancoPedidoItem(modelo, idPedidoInserido);
                }

                dgPedido.Rows.Clear();

                MessageBox.Show("Pedido inserido(s) com sucesso.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao inserir os dados no banco: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int InserirDadosNoBancoPedido(PedidoClass modelo)
        {
            try
            {
                string query = "INSERT INTO Pedido (Nome_Cliente, Data_Hora_Pedido, Id_Usuario, Id_FormasPagamento) " +
                               "VALUES (@Nome_Cliente, @Data_Hora_Pedido, @Id_Usuario, @Id_FormasPagamento); " +
                               "SELECT SCOPE_IDENTITY();";

                using (SqlConnection conexao = new SqlConnection("Data Source=ACF014\\SQLEXPRESS;Initial Catalog=SGPPC;Integrated Security=True"))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conexao))
                    {
                        conexao.Open();

                        cmd.Parameters.AddWithValue("@Nome_Cliente", modelo.NomeCliente);
                        cmd.Parameters.AddWithValue("@Data_Hora_Pedido", modelo.DataHoraPedido);
                        cmd.Parameters.AddWithValue("@Id_Usuario", modelo.IdUsuario);
                        cmd.Parameters.AddWithValue("@Id_FormasPagamento", modelo.IdFormasPagamento);

                        return Convert.ToInt32(cmd.ExecuteScalar());
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao inserir os dados na tabela Pedido: " + ex.Message);
            }
        }

        private void InserirDadosNoBancoPedidoItem(PedidoClass modelo, int idPedido)
        {
            try
            {
                string query = "INSERT INTO Pedido_Item (Quantidade, Valor, Id_Produto, Id_Pedido) " +
                               "VALUES (@Quantidade, @Valor, @Id_Produto, @Id_Pedido)";

                using (SqlConnection conexao = new SqlConnection("Data Source=ACF014\\SQLEXPRESS;Initial Catalog=SGPPC;Integrated Security=True"))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conexao))
                    {
                        conexao.Open();

                        cmd.Parameters.AddWithValue("@Quantidade", modelo.Quantidade);
                        cmd.Parameters.AddWithValue("@Valor", modelo.Valor);
                        cmd.Parameters.AddWithValue("@Id_Produto", modelo.IdProduto);
                        cmd.Parameters.AddWithValue("@Id_Pedido", idPedido);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao inserir os dados na tabela Pedido_Item: " + ex.Message);
            }
        }

        private void CalcularTotal()
        {
            if (int.TryParse(txbQuantidade.Text, out int quantidade) && decimal.TryParse(txbValor.Text, out decimal valor))
            {
                decimal total = quantidade * valor;
                txbTotal.Text = total.ToString();
            }
            else
            {
                txbTotal.Text = "Calculando...";
            }
        }

        private void txbQuantidade_TextChanged(object sender, EventArgs e)
        {
            CalcularTotal();
        }

        private void txbValor_TextChanged(object sender, EventArgs e)
        {
            CalcularTotal();
        }

        private void comboPagamento_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (comboPagamento.SelectedItem != null)
            {
                KeyValuePair<int, string> selectedPagamento = (KeyValuePair<int, string>)comboPagamento.SelectedItem;
                int pagamentoID = selectedPagamento.Key;

                txbIdPagamento.Text = pagamentoID.ToString();
            }
        }
    }
}
