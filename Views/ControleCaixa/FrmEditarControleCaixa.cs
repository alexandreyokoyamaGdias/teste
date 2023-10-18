using SGPPC.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGPPC.Views.ControleCaixa
{
    public partial class FrmEditarControleCaixa : Form
    {
        public FrmEditarControleCaixa()
        {
            InitializeComponent();
        }

        public FrmEditarControleCaixa(string motivo, string tipo, string valor, string data)
        {
            InitializeComponent();

            txbMotivoEditar.Text = motivo;
            txbTipoOperadcaoEditar.Text = tipo;
            txbValorEditar.Text = valor;
            maskDataHoraEditar.Text = data;
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
            //DateTime dataHoraAtual = DateTime.Now;

            //maskDataHorass.Text = dataHoraAtual.ToString("dd/MM/yyyy HH:mm:ss");
        }
    }
}
