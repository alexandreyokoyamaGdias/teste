namespace SGPPC.Views.Produto
{
    partial class FrmAlterarProduto
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
            this.lblFornecedorAlt = new System.Windows.Forms.Label();
            this.lblDataAlt = new System.Windows.Forms.Label();
            this.lblValorAlt = new System.Windows.Forms.Label();
            this.lblDescricaoAlt = new System.Windows.Forms.Label();
            this.lblNomeAlt = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.cbFornecedorProdAlt = new System.Windows.Forms.ComboBox();
            this.maskTxbDataProdAlt = new System.Windows.Forms.MaskedTextBox();
            this.txbValorProdAlt = new System.Windows.Forms.TextBox();
            this.txbDescricaoProdAlt = new System.Windows.Forms.TextBox();
            this.txbNomeProdAlt = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblProduto = new System.Windows.Forms.Label();
            this.txbId = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFornecedorAlt
            // 
            this.lblFornecedorAlt.AutoSize = true;
            this.lblFornecedorAlt.Location = new System.Drawing.Point(8, 147);
            this.lblFornecedorAlt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFornecedorAlt.Name = "lblFornecedorAlt";
            this.lblFornecedorAlt.Size = new System.Drawing.Size(65, 13);
            this.lblFornecedorAlt.TabIndex = 43;
            this.lblFornecedorAlt.Text = "*Fornecedor";
            // 
            // lblDataAlt
            // 
            this.lblDataAlt.AutoSize = true;
            this.lblDataAlt.Location = new System.Drawing.Point(219, 96);
            this.lblDataAlt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDataAlt.Name = "lblDataAlt";
            this.lblDataAlt.Size = new System.Drawing.Size(34, 13);
            this.lblDataAlt.TabIndex = 42;
            this.lblDataAlt.Text = "*Data";
            // 
            // lblValorAlt
            // 
            this.lblValorAlt.AutoSize = true;
            this.lblValorAlt.Location = new System.Drawing.Point(8, 96);
            this.lblValorAlt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblValorAlt.Name = "lblValorAlt";
            this.lblValorAlt.Size = new System.Drawing.Size(35, 13);
            this.lblValorAlt.TabIndex = 41;
            this.lblValorAlt.Text = "*Valor";
            // 
            // lblDescricaoAlt
            // 
            this.lblDescricaoAlt.AutoSize = true;
            this.lblDescricaoAlt.Location = new System.Drawing.Point(219, 47);
            this.lblDescricaoAlt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescricaoAlt.Name = "lblDescricaoAlt";
            this.lblDescricaoAlt.Size = new System.Drawing.Size(59, 13);
            this.lblDescricaoAlt.TabIndex = 40;
            this.lblDescricaoAlt.Text = "*Descrição";
            // 
            // lblNomeAlt
            // 
            this.lblNomeAlt.AutoSize = true;
            this.lblNomeAlt.Location = new System.Drawing.Point(8, 47);
            this.lblNomeAlt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNomeAlt.Name = "lblNomeAlt";
            this.lblNomeAlt.Size = new System.Drawing.Size(39, 13);
            this.lblNomeAlt.TabIndex = 39;
            this.lblNomeAlt.Text = "*Nome";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(186, 312);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(79, 27);
            this.btnCancelar.TabIndex = 38;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(97, 312);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(79, 27);
            this.btnLimpar.TabIndex = 37;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(9, 312);
            this.btnAlterar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(79, 27);
            this.btnAlterar.TabIndex = 36;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // cbFornecedorProdAlt
            // 
            this.cbFornecedorProdAlt.FormattingEnabled = true;
            this.cbFornecedorProdAlt.Location = new System.Drawing.Point(8, 162);
            this.cbFornecedorProdAlt.Margin = new System.Windows.Forms.Padding(2);
            this.cbFornecedorProdAlt.Name = "cbFornecedorProdAlt";
            this.cbFornecedorProdAlt.Size = new System.Drawing.Size(193, 21);
            this.cbFornecedorProdAlt.TabIndex = 35;
            // 
            // maskTxbDataProdAlt
            // 
            this.maskTxbDataProdAlt.Location = new System.Drawing.Point(221, 110);
            this.maskTxbDataProdAlt.Margin = new System.Windows.Forms.Padding(2);
            this.maskTxbDataProdAlt.Mask = "00/00/0000";
            this.maskTxbDataProdAlt.Name = "maskTxbDataProdAlt";
            this.maskTxbDataProdAlt.Size = new System.Drawing.Size(193, 20);
            this.maskTxbDataProdAlt.TabIndex = 34;
            this.maskTxbDataProdAlt.ValidatingType = typeof(System.DateTime);
            // 
            // txbValorProdAlt
            // 
            this.txbValorProdAlt.Location = new System.Drawing.Point(8, 110);
            this.txbValorProdAlt.Margin = new System.Windows.Forms.Padding(2);
            this.txbValorProdAlt.Multiline = true;
            this.txbValorProdAlt.Name = "txbValorProdAlt";
            this.txbValorProdAlt.Size = new System.Drawing.Size(193, 18);
            this.txbValorProdAlt.TabIndex = 33;
            // 
            // txbDescricaoProdAlt
            // 
            this.txbDescricaoProdAlt.Location = new System.Drawing.Point(221, 62);
            this.txbDescricaoProdAlt.Margin = new System.Windows.Forms.Padding(2);
            this.txbDescricaoProdAlt.Multiline = true;
            this.txbDescricaoProdAlt.Name = "txbDescricaoProdAlt";
            this.txbDescricaoProdAlt.Size = new System.Drawing.Size(193, 21);
            this.txbDescricaoProdAlt.TabIndex = 32;
            // 
            // txbNomeProdAlt
            // 
            this.txbNomeProdAlt.Location = new System.Drawing.Point(8, 62);
            this.txbNomeProdAlt.Margin = new System.Windows.Forms.Padding(2);
            this.txbNomeProdAlt.Multiline = true;
            this.txbNomeProdAlt.Name = "txbNomeProdAlt";
            this.txbNomeProdAlt.Size = new System.Drawing.Size(193, 21);
            this.txbNomeProdAlt.TabIndex = 31;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Orange;
            this.panel2.Controls.Add(this.lblProduto);
            this.panel2.Location = new System.Drawing.Point(0, 1);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(421, 31);
            this.panel2.TabIndex = 44;
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduto.ForeColor = System.Drawing.Color.White;
            this.lblProduto.Location = new System.Drawing.Point(3, 5);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(72, 21);
            this.lblProduto.TabIndex = 1;
            this.lblProduto.Text = "Produto";
            this.lblProduto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txbId
            // 
            this.txbId.Location = new System.Drawing.Point(372, 319);
            this.txbId.Name = "txbId";
            this.txbId.ReadOnly = true;
            this.txbId.Size = new System.Drawing.Size(42, 20);
            this.txbId.TabIndex = 45;
            // 
            // FrmAlterarProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 347);
            this.Controls.Add(this.txbId);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblFornecedorAlt);
            this.Controls.Add(this.lblDataAlt);
            this.Controls.Add(this.lblValorAlt);
            this.Controls.Add(this.lblDescricaoAlt);
            this.Controls.Add(this.lblNomeAlt);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.cbFornecedorProdAlt);
            this.Controls.Add(this.maskTxbDataProdAlt);
            this.Controls.Add(this.txbValorProdAlt);
            this.Controls.Add(this.txbDescricaoProdAlt);
            this.Controls.Add(this.txbNomeProdAlt);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmAlterarProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAlterarProduto";
            this.Load += new System.EventHandler(this.FrmAlterarProduto_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFornecedorAlt;
        private System.Windows.Forms.Label lblDataAlt;
        private System.Windows.Forms.Label lblValorAlt;
        private System.Windows.Forms.Label lblDescricaoAlt;
        private System.Windows.Forms.Label lblNomeAlt;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.ComboBox cbFornecedorProdAlt;
        private System.Windows.Forms.MaskedTextBox maskTxbDataProdAlt;
        private System.Windows.Forms.TextBox txbValorProdAlt;
        private System.Windows.Forms.TextBox txbDescricaoProdAlt;
        private System.Windows.Forms.TextBox txbNomeProdAlt;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.TextBox txbId;
    }
}