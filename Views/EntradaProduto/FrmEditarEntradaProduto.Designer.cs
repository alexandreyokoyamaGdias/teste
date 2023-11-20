namespace SGPPC.Views.EntradaProduto
{
    partial class FrmEditarEntradaProduto
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
            this.panelEntradaProduto = new System.Windows.Forms.Panel();
            this.lblEntradaProduto = new System.Windows.Forms.Label();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txbPreco = new System.Windows.Forms.TextBox();
            this.txbQuantidade = new System.Windows.Forms.TextBox();
            this.lblPreco = new System.Windows.Forms.Label();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.txbId = new System.Windows.Forms.TextBox();
            this.panelEntradaProduto.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelEntradaProduto
            // 
            this.panelEntradaProduto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelEntradaProduto.BackColor = System.Drawing.Color.Orange;
            this.panelEntradaProduto.Controls.Add(this.lblEntradaProduto);
            this.panelEntradaProduto.Location = new System.Drawing.Point(0, 0);
            this.panelEntradaProduto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelEntradaProduto.Name = "panelEntradaProduto";
            this.panelEntradaProduto.Size = new System.Drawing.Size(421, 31);
            this.panelEntradaProduto.TabIndex = 18;
            // 
            // lblEntradaProduto
            // 
            this.lblEntradaProduto.AutoSize = true;
            this.lblEntradaProduto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntradaProduto.ForeColor = System.Drawing.Color.White;
            this.lblEntradaProduto.Location = new System.Drawing.Point(3, 5);
            this.lblEntradaProduto.Name = "lblEntradaProduto";
            this.lblEntradaProduto.Size = new System.Drawing.Size(55, 21);
            this.lblEntradaProduto.TabIndex = 1;
            this.lblEntradaProduto.Text = "Editar";
            this.lblEntradaProduto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(8, 312);
            this.btnAlterar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(79, 27);
            this.btnAlterar.TabIndex = 45;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(98, 312);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(79, 27);
            this.btnCancelar.TabIndex = 44;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txbPreco
            // 
            this.txbPreco.Location = new System.Drawing.Point(8, 63);
            this.txbPreco.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbPreco.Name = "txbPreco";
            this.txbPreco.Size = new System.Drawing.Size(201, 20);
            this.txbPreco.TabIndex = 46;
            // 
            // txbQuantidade
            // 
            this.txbQuantidade.Location = new System.Drawing.Point(221, 63);
            this.txbQuantidade.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbQuantidade.Name = "txbQuantidade";
            this.txbQuantidade.Size = new System.Drawing.Size(194, 20);
            this.txbQuantidade.TabIndex = 47;
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Location = new System.Drawing.Point(8, 46);
            this.lblPreco.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(39, 13);
            this.lblPreco.TabIndex = 48;
            this.lblPreco.Text = "*Preço";
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Location = new System.Drawing.Point(218, 46);
            this.lblQuantidade.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(66, 13);
            this.lblQuantidade.TabIndex = 49;
            this.lblQuantidade.Text = "*Quantidade";
            // 
            // txbId
            // 
            this.txbId.Location = new System.Drawing.Point(376, 322);
            this.txbId.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbId.Name = "txbId";
            this.txbId.ReadOnly = true;
            this.txbId.Size = new System.Drawing.Size(39, 20);
            this.txbId.TabIndex = 50;
            this.txbId.Visible = false;
            // 
            // FrmEditarEntradaProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 347);
            this.Controls.Add(this.txbId);
            this.Controls.Add(this.lblQuantidade);
            this.Controls.Add(this.lblPreco);
            this.Controls.Add(this.txbQuantidade);
            this.Controls.Add(this.txbPreco);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.panelEntradaProduto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "FrmEditarEntradaProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmEditarEntradaProduto";
            this.Load += new System.EventHandler(this.FrmEditarEntradaProduto_Load);
            this.panelEntradaProduto.ResumeLayout(false);
            this.panelEntradaProduto.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelEntradaProduto;
        private System.Windows.Forms.Label lblEntradaProduto;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txbPreco;
        private System.Windows.Forms.TextBox txbQuantidade;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.TextBox txbId;
    }
}