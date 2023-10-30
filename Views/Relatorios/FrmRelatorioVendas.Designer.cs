namespace SGPPC.Views.Relatorios
{
    partial class FrmRelatorioVendas
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
            this.panelVendas = new System.Windows.Forms.Panel();
            this.lblVendas = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panelVendas.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelVendas
            // 
            this.panelVendas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelVendas.BackColor = System.Drawing.Color.Orange;
            this.panelVendas.Controls.Add(this.lblVendas);
            this.panelVendas.Location = new System.Drawing.Point(1, 0);
            this.panelVendas.Margin = new System.Windows.Forms.Padding(2);
            this.panelVendas.Name = "panelVendas";
            this.panelVendas.Size = new System.Drawing.Size(738, 33);
            this.panelVendas.TabIndex = 10;
            // 
            // lblVendas
            // 
            this.lblVendas.AutoSize = true;
            this.lblVendas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVendas.ForeColor = System.Drawing.Color.White;
            this.lblVendas.Location = new System.Drawing.Point(3, 5);
            this.lblVendas.Name = "lblVendas";
            this.lblVendas.Size = new System.Drawing.Size(162, 21);
            this.lblVendas.TabIndex = 1;
            this.lblVendas.Text = "Relatório de Vendas";
            this.lblVendas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SGPPC.Views.Relatorios.RelatorioVendas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(739, 413);
            this.reportViewer1.TabIndex = 11;
            // 
            // FrmRelatorioVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 413);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.panelVendas);
            this.Name = "FrmRelatorioVendas";
            this.Text = "FrmRelatorioVendas";
            this.Load += new System.EventHandler(this.FrmRelatorioVendas_Load);
            this.panelVendas.ResumeLayout(false);
            this.panelVendas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelVendas;
        private System.Windows.Forms.Label lblVendas;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}