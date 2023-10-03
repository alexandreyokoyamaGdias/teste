namespace SGPPC.Views.Produto
{
    partial class FrmCadastroProduto
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
            this.panelProduto = new System.Windows.Forms.Panel();
            this.lblProduto = new System.Windows.Forms.Label();
            this.txbNomeProd = new System.Windows.Forms.TextBox();
            this.txbDescricaoProd = new System.Windows.Forms.TextBox();
            this.txbValorProd = new System.Windows.Forms.TextBox();
            this.maskTxbDataProd = new System.Windows.Forms.MaskedTextBox();
            this.cbFornecedorProd = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.lblFornecedor = new System.Windows.Forms.Label();
            this.panelProduto.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelProduto
            // 
            this.panelProduto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelProduto.BackColor = System.Drawing.Color.Orange;
            this.panelProduto.Controls.Add(this.lblProduto);
            this.panelProduto.Location = new System.Drawing.Point(1, 1);
            this.panelProduto.Name = "panelProduto";
            this.panelProduto.Size = new System.Drawing.Size(631, 48);
            this.panelProduto.TabIndex = 17;
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduto.ForeColor = System.Drawing.Color.White;
            this.lblProduto.Location = new System.Drawing.Point(5, 8);
            this.lblProduto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(119, 32);
            this.lblProduto.TabIndex = 1;
            this.lblProduto.Text = "Produtos";
            this.lblProduto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txbNomeProd
            // 
            this.txbNomeProd.Location = new System.Drawing.Point(12, 82);
            this.txbNomeProd.Multiline = true;
            this.txbNomeProd.Name = "txbNomeProd";
            this.txbNomeProd.Size = new System.Drawing.Size(288, 30);
            this.txbNomeProd.TabIndex = 18;
            // 
            // txbDescricaoProd
            // 
            this.txbDescricaoProd.Location = new System.Drawing.Point(332, 82);
            this.txbDescricaoProd.Multiline = true;
            this.txbDescricaoProd.Name = "txbDescricaoProd";
            this.txbDescricaoProd.Size = new System.Drawing.Size(288, 30);
            this.txbDescricaoProd.TabIndex = 19;
            // 
            // txbValorProd
            // 
            this.txbValorProd.Location = new System.Drawing.Point(12, 156);
            this.txbValorProd.Multiline = true;
            this.txbValorProd.Name = "txbValorProd";
            this.txbValorProd.Size = new System.Drawing.Size(288, 26);
            this.txbValorProd.TabIndex = 20;
            // 
            // maskTxbDataProd
            // 
            this.maskTxbDataProd.Location = new System.Drawing.Point(332, 156);
            this.maskTxbDataProd.Mask = "00/00/0000";
            this.maskTxbDataProd.Name = "maskTxbDataProd";
            this.maskTxbDataProd.Size = new System.Drawing.Size(288, 26);
            this.maskTxbDataProd.TabIndex = 21;
            this.maskTxbDataProd.ValidatingType = typeof(System.DateTime);
            // 
            // cbFornecedorProd
            // 
            this.cbFornecedorProd.FormattingEnabled = true;
            this.cbFornecedorProd.Location = new System.Drawing.Point(12, 235);
            this.cbFornecedorProd.Name = "cbFornecedorProd";
            this.cbFornecedorProd.Size = new System.Drawing.Size(288, 28);
            this.cbFornecedorProd.TabIndex = 22;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 485);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 42);
            this.button1.TabIndex = 23;
            this.button1.Text = "Cadastrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(145, 485);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 42);
            this.button2.TabIndex = 24;
            this.button2.Text = "Limpar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(278, 485);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(118, 42);
            this.button3.TabIndex = 25;
            this.button3.Text = "Cancelar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(12, 59);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(51, 20);
            this.lblNome.TabIndex = 26;
            this.lblNome.Text = "Nome";
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(328, 59);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(80, 20);
            this.lblDescricao.TabIndex = 27;
            this.lblDescricao.Text = "Descrição";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(12, 133);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(46, 20);
            this.lblValor.TabIndex = 28;
            this.lblValor.Text = "Valor";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(328, 133);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(44, 20);
            this.lblData.TabIndex = 29;
            this.lblData.Text = "Data";
            // 
            // lblFornecedor
            // 
            this.lblFornecedor.AutoSize = true;
            this.lblFornecedor.Location = new System.Drawing.Point(12, 212);
            this.lblFornecedor.Name = "lblFornecedor";
            this.lblFornecedor.Size = new System.Drawing.Size(91, 20);
            this.lblFornecedor.TabIndex = 30;
            this.lblFornecedor.Text = "Fornecedor";
            // 
            // FrmCadastroProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 534);
            this.Controls.Add(this.lblFornecedor);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbFornecedorProd);
            this.Controls.Add(this.maskTxbDataProd);
            this.Controls.Add(this.txbValorProd);
            this.Controls.Add(this.txbDescricaoProd);
            this.Controls.Add(this.txbNomeProd);
            this.Controls.Add(this.panelProduto);
            this.Name = "FrmCadastroProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCadastroProduto";
            this.panelProduto.ResumeLayout(false);
            this.panelProduto.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelProduto;
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.TextBox txbNomeProd;
        private System.Windows.Forms.TextBox txbDescricaoProd;
        private System.Windows.Forms.TextBox txbValorProd;
        private System.Windows.Forms.MaskedTextBox maskTxbDataProd;
        private System.Windows.Forms.ComboBox cbFornecedorProd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblFornecedor;
    }
}