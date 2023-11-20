namespace SGPPC.Views.Relatorios
{
    partial class FrmRelatorioEstoque
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.reportViewerEstoque = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reportViewerEstoque
            // 
            this.reportViewerEstoque.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewerEstoque.LocalReport.ReportEmbeddedResource = "SGPPC.Views.Relatorios.Modelos.RelatorioEstoque.rdlc";
            this.reportViewerEstoque.Location = new System.Drawing.Point(0, 0);
            this.reportViewerEstoque.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.reportViewerEstoque.Name = "reportViewerEstoque";
            this.reportViewerEstoque.ServerReport.BearerToken = null;
            this.reportViewerEstoque.Size = new System.Drawing.Size(1108, 635);
            this.reportViewerEstoque.TabIndex = 0;
            this.reportViewerEstoque.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // FrmRelatorioEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 635);
            this.Controls.Add(this.reportViewerEstoque);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FrmRelatorioEstoque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmRelatorioEstoque";
            this.Load += new System.EventHandler(this.FrmRelatorioEstoque_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerEstoque;
    }
}