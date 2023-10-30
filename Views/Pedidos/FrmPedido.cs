using Microsoft.ReportingServices.Diagnostics.Internal;
using SGPPC.Class;
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

namespace SGPPC.Views.Pedidos
{
    public partial class FrmPedido : Form
    {
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
            string connectionString = "Data Source=ACF014\\SQLEXPRESS;Initial Catalog=SGPPC;Integrated Security=True";

            DateTime dataHoraAtual = DateTime.Now;
            maskedDataHora.Text = dataHoraAtual.ToString("dd/MM/yyyy HH:mm");

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                //string query = "SELECT Id, Nome_Produto FROM Produto";
                string query = "SELECT Id, Nome_Produto FROM Produto";
                string query2 = "SELECT Id, Nome FROM FormasPagamento";

                SqlCommand cmd = new SqlCommand(query, connection);
                SqlCommand cmd2 = new SqlCommand(query2, connection);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
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

        private void dgPagamento_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow row = dgPedido.Rows[e.RowIndex];

                string nomeCliente = row.Cells["Nome"].Value.ToString();
                string nomeProduto = row.Cells["Produto"].Value.ToString();
                string pagamento = row.Cells["FormaPagamento"].Value.ToString();
                string quantidade = row.Cells["Quantidade"].Value.ToString();
                string valor = row.Cells["Valor"].Value.ToString();
                string dataHora = row.Cells["DataHora"].Value.ToString();
                string id = row.Cells["Id"].Value.ToString();
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            string Nome = txbNomeCliente.Text;
            string Produto = cmbProduto.Text;
            string Quantidade = txbQuantidade.Text;
            string FormPagamento = comboPagamento.Text;
            string Valor = txbValor.Text;
            string DataHora = maskedDataHora.Text;

            dgPedido.Rows.Add(Nome, Produto, Quantidade, FormPagamento, Valor, DataHora);

            txbNomeCliente.Clear();
            cmbProduto.SelectedIndex = -1;
            txbQuantidade.Clear();
            comboPagamento.SelectedIndex = -1;
            txbValor.Clear();
        }

        private void comboPagamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboPagamento.SelectedIndex != -1)
            {
                KeyValuePair<int, string> pagamentoNome = (KeyValuePair<int, string>)comboPagamento.SelectedItem;
                int pagamentoID = pagamentoNome.Key;

                txbIdPagamento.Text = pagamentoID.ToString();
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
    }
}
