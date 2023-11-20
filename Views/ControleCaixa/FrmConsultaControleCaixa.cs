using SGPPC.Model;
using SGPPC.Views.Fornecedor;
using SGPPC.Views.Relatorios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGPPC.Views.ControleCaixa
{
    public partial class FrmConsultaControleCaixa : Form
    {
        private BindingSource bindingSource = new BindingSource();

        public FrmConsultaControleCaixa()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Views.ControleCaixa.FrmControleCaixa frmControleCaixa = new FrmControleCaixa();
            frmControleCaixa.ShowDialog();
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            string filterColumn = comboBoxPesquisarControleCaixa.Text;
            string filterValue = txtPesquisar.Text;

            if (string.IsNullOrEmpty(filterValue))
            {
                bindingSource.RemoveFilter();
            }
            else
            {
                bindingSource.Filter = string.Format("{0} LIKE '%{1}%'", filterColumn, filterValue);
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Conexao cx = new Conexao();

            ConsultaControleCaixa consulta = new ConsultaControleCaixa(cx);

            string pesquisa = txtPesquisar.Text;

            bindingSource.DataSource = consulta.LocalizarControleCaixa(pesquisa, pesquisa, pesquisa, pesquisa);

            dgControleCaixa.DataSource = bindingSource;

            AtualizarTotalDebitos();

            AtualizarTotalCreditos();
        }

        private void AtualizarTotalDebitos()
        {
            decimal totalDebitos = 0;

            SqlConnection con = new SqlConnection();

            string connectionString = "Data Source=ACF014\\SQLEXPRESS;Initial Catalog=SGPPC;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT SUM(Valor) AS TotalDebitos FROM Controle_Caixa_Pedido WHERE Tipo_Operacao = 'Débito'";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    object result = command.ExecuteScalar();

                    if (result != null && decimal.TryParse(result.ToString(), out decimal valorConvertido))
                    {
                        totalDebitos = valorConvertido;
                    }
                    else
                    {
                        lblValorTotal.Text = "Nenhum débito encontrado.";
                        return;
                    }
                }
            }

            lblValorTotal.Text = $"Total de Débitos: {totalDebitos:C2}";
        }

        private void AtualizarTotalCreditos()
        {
            decimal totalCreditos = 0;

            SqlConnection con = new SqlConnection();

            string connectionString = "Data Source=ACF014\\SQLEXPRESS;Initial Catalog=SGPPC;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT SUM(Valor) AS TotalCreditos FROM Controle_Caixa_Pedido WHERE Tipo_Operacao = 'Crédito'";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    object result = command.ExecuteScalar();

                    if (result != null && decimal.TryParse(result.ToString(), out decimal valorConvertido))
                    {
                        totalCreditos = valorConvertido;
                    }
                    else
                    {
                        lblCredito.Text = "Nenhum crédito encontrado.";
                        return;
                    }
                }
            }

            lblCredito.Text = $"Total de Créditos: {totalCreditos:C2}";
        }

        private void FrmConsultaControleCaixa_Load(object sender, EventArgs e)
        {
            comboBoxPesquisarControleCaixa.SelectedIndex = 0;

            AtualizarTotalDebitos();

            AtualizarTotalCreditos();
        }       

        private void dgFornecedor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow row = dgControleCaixa.Rows[e.RowIndex];

                string motivo = row.Cells["Motivo"].Value.ToString();
                string tipo = row.Cells["Tipo_Operacao"].Value.ToString();
                string valor = row.Cells["Valor"].Value.ToString();
                string data = row.Cells["Data_Hora"].Value.ToString();
                string id = row.Cells["Id"].Value.ToString();

                FrmEditarControleCaixa telaEdicao = new FrmEditarControleCaixa(motivo, tipo, valor, data, id);
                telaEdicao.ShowDialog();
            }
        }

        private void btnGerarRelatorio_Click(object sender, EventArgs e)
        {
            var dt = GerarDadosRelatorioFluxoCaixa();

            using (var frm = new FrmRelatorioFluxoCaixa(dt))
            {
                frm.ShowDialog();
            }
        }

        private DataTable GerarDadosRelatorioFluxoCaixa()
        {
            var dt = new DataTable();
            dt.Columns.Add("Motivo");
            dt.Columns.Add("Tipo_Operacao");
            dt.Columns.Add("Valor");
            dt.Columns.Add("Data_Hora");

            foreach (DataGridViewRow item in dgControleCaixa.Rows)
            {
                dt.Rows.Add(item.Cells["Motivo"].Value.ToString(), item.Cells["Tipo_Operacao"].Value.ToString(), item.Cells["Valor"].Value.ToString(),
                    item.Cells["Data_Hora"].Value.ToString());
            }

            return dt;
        }
    }
}
