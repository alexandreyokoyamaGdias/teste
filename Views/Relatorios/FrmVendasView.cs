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
    public partial class FrmVendasView : Form
    {
        DataTable dt = new DataTable();

        public FrmVendasView(DataTable dt)
        {
            InitializeComponent();

            this.dt = dt;
        }

        private void FrmVendasView_Load(object sender, EventArgs e)
        {
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(new
                Microsoft.Reporting.WinForms.ReportDataSource("DataVendas", dt));

            this.reportViewer1.RefreshReport();
        }
    }
}
