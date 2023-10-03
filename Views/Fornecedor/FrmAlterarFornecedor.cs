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
    public partial class FrmAlterarFornecedor : Form
    {
        public FrmAlterarFornecedor(string teste)
        {
            InitializeComponent();

            txbEstado.Text = teste;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmAlterarFornecedor_Load(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}


