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
    public partial class FrmRelatorioEstoque : Form
    {
        private DataTable dt;

        public FrmRelatorioEstoque()
        {
            InitializeComponent();
        }

        public FrmRelatorioEstoque(DataTable dt)
        {
            InitializeComponent();
            this.dt = dt;
        }

        private void FrmRelatorioEstoque_Load(object sender, EventArgs e)
        {
            this.reportViewerEstoque.LocalReport.DataSources.Clear();
            this.reportViewerEstoque.LocalReport.DataSources.Add(new
                Microsoft.Reporting.WinForms.ReportDataSource("DataEstoque", dt));

            this.reportViewerEstoque.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
