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
            this.txbIdFornCadastro = new System.Windows.Forms.TextBox();
            this.txbIdSaborCadastro = new System.Windows.Forms.TextBox();
            this.lblSabor = new System.Windows.Forms.Label();
            this.cmbSaborCadastro = new System.Windows.Forms.ComboBox();
            this.txbId = new System.Windows.Forms.TextBox();
            this.lblFornecedorAlt = new System.Windows.Forms.Label();
            this.lblDataAlt = new System.Windows.Forms.Label();
            this.lblValorAlt = new System.Windows.Forms.Label();
            this.lblDescricaoAlt = new System.Windows.Forms.Label();
            this.lblNomeAlt = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCadastro = new System.Windows.Forms.Button();
            this.cbFornecedorProdCadastro = new System.Windows.Forms.ComboBox();
            this.maskTxbDataProdCadastro = new System.Windows.Forms.MaskedTextBox();
            this.txbValorProdCadastro = new System.Windows.Forms.TextBox();
            this.txbDescricaoProdCadastrado = new System.Windows.Forms.TextBox();
            this.txbNomeProdCadastro = new System.Windows.Forms.TextBox();
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
            this.panelProduto.Margin = new System.Windows.Forms.Padding(2);
            this.panelProduto.Name = "panelProduto";
            this.panelProduto.Size = new System.Drawing.Size(422, 31);
            this.panelProduto.TabIndex = 17;
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduto.ForeColor = System.Drawing.Color.White;
            this.lblProduto.Location = new System.Drawing.Point(3, 5);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(79, 21);
            this.lblProduto.TabIndex = 1;
            this.lblProduto.Text = "Produtos";
            this.lblProduto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txbIdFornCadastro
            // 
            this.txbIdFornCadastro.Location = new System.Drawing.Point(8, 181);
            this.txbIdFornCadastro.Name = "txbIdFornCadastro";
            this.txbIdFornCadastro.ReadOnly = true;
            this.txbIdFornCadastro.Size = new System.Drawing.Size(43, 20);
            this.txbIdFornCadastro.TabIndex = 67;
            this.txbIdFornCadastro.Visible = false;
            // 
            // txbIdSaborCadastro
            // 
            this.txbIdSaborCadastro.Location = new System.Drawing.Point(221, 181);
            this.txbIdSaborCadastro.Name = "txbIdSaborCadastro";
            this.txbIdSaborCadastro.ReadOnly = true;
            this.txbIdSaborCadastro.Size = new System.Drawing.Size(43, 20);
            this.txbIdSaborCadastro.TabIndex = 66;
            this.txbIdSaborCadastro.Visible = false;
            // 
            // lblSabor
            // 
            this.lblSabor.AutoSize = true;
            this.lblSabor.Location = new System.Drawing.Point(219, 140);
            this.lblSabor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSabor.Name = "lblSabor";
            this.lblSabor.Size = new System.Drawing.Size(39, 13);
            this.lblSabor.TabIndex = 65;
            this.lblSabor.Text = "*Sabor";
            // 
            // cmbSaborCadastro
            // 
            this.cmbSaborCadastro.FormattingEnabled = true;
            this.cmbSaborCadastro.Location = new System.Drawing.Point(221, 155);
            this.cmbSaborCadastro.Margin = new System.Windows.Forms.Padding(2);
            this.cmbSaborCadastro.Name = "cmbSaborCadastro";
            this.cmbSaborCadastro.Size = new System.Drawing.Size(193, 21);
            this.cmbSaborCadastro.TabIndex = 64;
            this.cmbSaborCadastro.SelectedIndexChanged += new System.EventHandler(this.cmbSaborCadastro_SelectedIndexChanged);
            // 
            // txbId
            // 
            this.txbId.Location = new System.Drawing.Point(372, 312);
            this.txbId.Name = "txbId";
            this.txbId.ReadOnly = true;
            this.txbId.Size = new System.Drawing.Size(42, 20);
            this.txbId.TabIndex = 63;
            this.txbId.Visible = false;
            // 
            // lblFornecedorAlt
            // 
            this.lblFornecedorAlt.AutoSize = true;
            this.lblFornecedorAlt.Location = new System.Drawing.Point(8, 140);
            this.lblFornecedorAlt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFornecedorAlt.Name = "lblFornecedorAlt";
            this.lblFornecedorAlt.Size = new System.Drawing.Size(65, 13);
            this.lblFornecedorAlt.TabIndex = 62;
            this.lblFornecedorAlt.Text = "*Fornecedor";
            // 
            // lblDataAlt
            // 
            this.lblDataAlt.AutoSize = true;
            this.lblDataAlt.Location = new System.Drawing.Point(219, 89);
            this.lblDataAlt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDataAlt.Name = "lblDataAlt";
            this.lblDataAlt.Size = new System.Drawing.Size(34, 13);
            this.lblDataAlt.TabIndex = 61;
            this.lblDataAlt.Text = "*Data";
            // 
            // lblValorAlt
            // 
            this.lblValorAlt.AutoSize = true;
            this.lblValorAlt.Location = new System.Drawing.Point(8, 89);
            this.lblValorAlt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblValorAlt.Name = "lblValorAlt";
            this.lblValorAlt.Size = new System.Drawing.Size(35, 13);
            this.lblValorAlt.TabIndex = 60;
            this.lblValorAlt.Text = "*Valor";
            // 
            // lblDescricaoAlt
            // 
            this.lblDescricaoAlt.AutoSize = true;
            this.lblDescricaoAlt.Location = new System.Drawing.Point(219, 40);
            this.lblDescricaoAlt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescricaoAlt.Name = "lblDescricaoAlt";
            this.lblDescricaoAlt.Size = new System.Drawing.Size(59, 13);
            this.lblDescricaoAlt.TabIndex = 59;
            this.lblDescricaoAlt.Text = "*Descrição";
            // 
            // lblNomeAlt
            // 
            this.lblNomeAlt.AutoSize = true;
            this.lblNomeAlt.Location = new System.Drawing.Point(8, 40);
            this.lblNomeAlt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNomeAlt.Name = "lblNomeAlt";
            this.lblNomeAlt.Size = new System.Drawing.Size(39, 13);
            this.lblNomeAlt.TabIndex = 58;
            this.lblNomeAlt.Text = "*Nome";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(186, 305);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(79, 27);
            this.btnCancelar.TabIndex = 57;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(97, 305);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(79, 27);
            this.btnLimpar.TabIndex = 56;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // btnCadastro
            // 
            this.btnCadastro.Location = new System.Drawing.Point(9, 305);
            this.btnCadastro.Margin = new System.Windows.Forms.Padding(2);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Size = new System.Drawing.Size(79, 27);
            this.btnCadastro.TabIndex = 55;
            this.btnCadastro.Text = "Alterar";
            this.btnCadastro.UseVisualStyleBackColor = true;
            this.btnCadastro.Click += new System.EventHandler(this.btnCadastro_Click);
            // 
            // cbFornecedorProdCadastro
            // 
            this.cbFornecedorProdCadastro.FormattingEnabled = true;
            this.cbFornecedorProdCadastro.Location = new System.Drawing.Point(8, 155);
            this.cbFornecedorProdCadastro.Margin = new System.Windows.Forms.Padding(2);
            this.cbFornecedorProdCadastro.Name = "cbFornecedorProdCadastro";
            this.cbFornecedorProdCadastro.Size = new System.Drawing.Size(193, 21);
            this.cbFornecedorProdCadastro.TabIndex = 54;
            this.cbFornecedorProdCadastro.SelectedIndexChanged += new System.EventHandler(this.cbFornecedorProdCadastro_SelectedIndexChanged);
            // 
            // maskTxbDataProdCadastro
            // 
            this.maskTxbDataProdCadastro.Location = new System.Drawing.Point(221, 103);
            this.maskTxbDataProdCadastro.Margin = new System.Windows.Forms.Padding(2);
            this.maskTxbDataProdCadastro.Mask = "00/00/0000";
            this.maskTxbDataProdCadastro.Name = "maskTxbDataProdCadastro";
            this.maskTxbDataProdCadastro.Size = new System.Drawing.Size(193, 20);
            this.maskTxbDataProdCadastro.TabIndex = 53;
            this.maskTxbDataProdCadastro.ValidatingType = typeof(System.DateTime);
            // 
            // txbValorProdCadastro
            // 
            this.txbValorProdCadastro.Location = new System.Drawing.Point(8, 103);
            this.txbValorProdCadastro.Margin = new System.Windows.Forms.Padding(2);
            this.txbValorProdCadastro.Multiline = true;
            this.txbValorProdCadastro.Name = "txbValorProdCadastro";
            this.txbValorProdCadastro.Size = new System.Drawing.Size(193, 18);
            this.txbValorProdCadastro.TabIndex = 52;
            // 
            // txbDescricaoProdCadastrado
            // 
            this.txbDescricaoProdCadastrado.Location = new System.Drawing.Point(221, 55);
            this.txbDescricaoProdCadastrado.Margin = new System.Windows.Forms.Padding(2);
            this.txbDescricaoProdCadastrado.Multiline = true;
            this.txbDescricaoProdCadastrado.Name = "txbDescricaoProdCadastrado";
            this.txbDescricaoProdCadastrado.Size = new System.Drawing.Size(193, 21);
            this.txbDescricaoProdCadastrado.TabIndex = 51;
            // 
            // txbNomeProdCadastro
            // 
            this.txbNomeProdCadastro.Location = new System.Drawing.Point(8, 55);
            this.txbNomeProdCadastro.Margin = new System.Windows.Forms.Padding(2);
            this.txbNomeProdCadastro.Multiline = true;
            this.txbNomeProdCadastro.Name = "txbNomeProdCadastro";
            this.txbNomeProdCadastro.Size = new System.Drawing.Size(193, 21);
            this.txbNomeProdCadastro.TabIndex = 50;
            // 
            // FrmCadastroProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(422, 340);
            this.Controls.Add(this.txbIdFornCadastro);
            this.Controls.Add(this.txbIdSaborCadastro);
            this.Controls.Add(this.lblSabor);
            this.Controls.Add(this.cmbSaborCadastro);
            this.Controls.Add(this.txbId);
            this.Controls.Add(this.lblFornecedorAlt);
            this.Controls.Add(this.lblDataAlt);
            this.Controls.Add(this.lblValorAlt);
            this.Controls.Add(this.lblDescricaoAlt);
            this.Controls.Add(this.lblNomeAlt);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCadastro);
            this.Controls.Add(this.cbFornecedorProdCadastro);
            this.Controls.Add(this.maskTxbDataProdCadastro);
            this.Controls.Add(this.txbValorProdCadastro);
            this.Controls.Add(this.txbDescricaoProdCadastrado);
            this.Controls.Add(this.txbNomeProdCadastro);
            this.Controls.Add(this.panelProduto);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "FrmCadastroProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCadastroProduto";
            this.Load += new System.EventHandler(this.FrmCadastroProduto_Load_1);
            this.panelProduto.ResumeLayout(false);
            this.panelProduto.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelProduto;
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.TextBox txbIdFornCadastro;
        private System.Windows.Forms.TextBox txbIdSaborCadastro;
        private System.Windows.Forms.Label lblSabor;
        private System.Windows.Forms.ComboBox cmbSaborCadastro;
        private System.Windows.Forms.TextBox txbId;
        private System.Windows.Forms.Label lblFornecedorAlt;
        private System.Windows.Forms.Label lblDataAlt;
        private System.Windows.Forms.Label lblValorAlt;
        private System.Windows.Forms.Label lblDescricaoAlt;
        private System.Windows.Forms.Label lblNomeAlt;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnCadastro;
        private System.Windows.Forms.ComboBox cbFornecedorProdCadastro;
        private System.Windows.Forms.MaskedTextBox maskTxbDataProdCadastro;
        private System.Windows.Forms.TextBox txbValorProdCadastro;
        private System.Windows.Forms.TextBox txbDescricaoProdCadastrado;
        private System.Windows.Forms.TextBox txbNomeProdCadastro;
    }
}