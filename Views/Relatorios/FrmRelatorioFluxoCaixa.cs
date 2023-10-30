using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGPPC.Views.Relatorios
{
    public partial class FrmRelatorioFluxoCaixa : Form
    {
        DataTable dt = new DataTable();

        public FrmRelatorioFluxoCaixa()
        {
            InitializeComponent();
        }

        public FrmRelatorioFluxoCaixa(DataTable dt)
        {
            InitializeComponent();
            this.dt = dt;
        }

        private void reportViewerFluxoCaixa_Load(object sender, EventArgs e)
        {
            
        }

        private void FrmRelatorioFluxoCaixa_Load(object sender, EventArgs e)
        {
            this.reportViewerFluxoCaixa.LocalReport.DataSources.Clear();
            this.reportViewerFluxoCaixa.LocalReport.DataSources.Add(new
                Microsoft.Reporting.WinForms.ReportDataSource("DataGastosFluxoCaixa", dt));


            this.reportViewerFluxoCaixa.RefreshReport();
        }
    }
}