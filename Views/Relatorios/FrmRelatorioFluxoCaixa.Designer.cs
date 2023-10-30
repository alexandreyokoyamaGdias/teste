namespace SGPPC.Views.Relatorios
{
    partial class FrmRelatorioFluxoCaixa
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
            this.panelFluxoCaixa = new System.Windows.Forms.Panel();
            this.lblFluxoCaixa = new System.Windows.Forms.Label();
            this.reportViewerFluxoCaixa = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panelFluxoCaixa.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelFluxoCaixa
            // 
            this.panelFluxoCaixa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelFluxoCaixa.BackColor = System.Drawing.Color.Orange;
            this.panelFluxoCaixa.Controls.Add(this.lblFluxoCaixa);
            this.panelFluxoCaixa.Location = new System.Drawing.Point(1, 0);
            this.panelFluxoCaixa.Margin = new System.Windows.Forms.Padding(2);
            this.panelFluxoCaixa.Name = "panelFluxoCaixa";
            this.panelFluxoCaixa.Size = new System.Drawing.Size(738, 33);
            this.panelFluxoCaixa.TabIndex = 10;
            // 
            // lblFluxoCaixa
            // 
            this.lblFluxoCaixa.AutoSize = true;
            this.lblFluxoCaixa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFluxoCaixa.ForeColor = System.Drawing.Color.White;
            this.lblFluxoCaixa.Location = new System.Drawing.Point(3, 5);
            this.lblFluxoCaixa.Name = "lblFluxoCaixa";
            this.lblFluxoCaixa.Size = new System.Drawing.Size(218, 21);
            this.lblFluxoCaixa.TabIndex = 1;
            this.lblFluxoCaixa.Text = "Relatório de Fluxo de Caixa";
            this.lblFluxoCaixa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // reportViewerFluxoCaixa
            // 
            this.reportViewerFluxoCaixa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewerFluxoCaixa.LocalReport.ReportEmbeddedResource = "SGPPC.Views.Relatorios.Modelos.RelatorioFluxoCaixa.rdlc";
            this.reportViewerFluxoCaixa.Location = new System.Drawing.Point(0, 0);
            this.reportViewerFluxoCaixa.Name = "reportViewerFluxoCaixa";
            this.reportViewerFluxoCaixa.ServerReport.BearerToken = null;
            this.reportViewerFluxoCaixa.Size = new System.Drawing.Size(739, 413);
            this.reportViewerFluxoCaixa.TabIndex = 11;
            this.reportViewerFluxoCaixa.Load += new System.EventHandler(this.reportViewerFluxoCaixa_Load);
            // 
            // FrmRelatorioFluxoCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 413);
            this.Controls.Add(this.reportViewerFluxoCaixa);
            this.Controls.Add(this.panelFluxoCaixa);
            this.Name = "FrmRelatorioFluxoCaixa";
            this.Text = "FrmRelatorioFluxoCaixa";
            this.Load += new System.EventHandler(this.FrmRelatorioFluxoCaixa_Load);
            this.panelFluxoCaixa.ResumeLayout(false);
            this.panelFluxoCaixa.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelFluxoCaixa;
        private System.Windows.Forms.Label lblFluxoCaixa;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerFluxoCaixa;
    }
}