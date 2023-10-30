namespace SGPPC.Views.ProdutoEntrada
{
    partial class FrmCadastroEntradaProduto
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblCadastroProduto = new System.Windows.Forms.Label();
            this.comboBoxProduto = new System.Windows.Forms.ComboBox();
            this.txbPreco = new System.Windows.Forms.TextBox();
            this.txbQuantidade = new System.Windows.Forms.TextBox();
            this.lblProduto = new System.Windows.Forms.Label();
            this.lblPreco = new System.Windows.Forms.Label();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.txbNotaFiscal = new System.Windows.Forms.TextBox();
            this.maskedTextBoxDataHoraEntrada = new System.Windows.Forms.MaskedTextBox();
            this.lblNotaFiscal = new System.Windows.Forms.Label();
            this.lblDataHora = new System.Windows.Forms.Label();
            this.btnLimparEntrada = new System.Windows.Forms.Button();
            this.btnCancelarEntrada = new System.Windows.Forms.Button();
            this.btnCadastrarEntrar = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Orange;
            this.panel2.Controls.Add(this.lblCadastroProduto);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(631, 48);
            this.panel2.TabIndex = 18;
            // 
            // lblCadastroProduto
            // 
            this.lblCadastroProduto.AutoSize = true;
            this.lblCadastroProduto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastroProduto.ForeColor = System.Drawing.Color.White;
            this.lblCadastroProduto.Location = new System.Drawing.Point(5, 8);
            this.lblCadastroProduto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCadastroProduto.Name = "lblCadastroProduto";
            this.lblCadastroProduto.Size = new System.Drawing.Size(311, 32);
            this.lblCadastroProduto.TabIndex = 1;
            this.lblCadastroProduto.Text = "Cadastro Produto Entrada";
            this.lblCadastroProduto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxProduto
            // 
            this.comboBoxProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxProduto.FormattingEnabled = true;
            this.comboBoxProduto.Location = new System.Drawing.Point(16, 87);
            this.comboBoxProduto.Name = "comboBoxProduto";
            this.comboBoxProduto.Size = new System.Drawing.Size(604, 33);
            this.comboBoxProduto.TabIndex = 19;
            // 
            // txbPreco
            // 
            this.txbPreco.Location = new System.Drawing.Point(16, 153);
            this.txbPreco.Multiline = true;
            this.txbPreco.Name = "txbPreco";
            this.txbPreco.Size = new System.Drawing.Size(604, 33);
            this.txbPreco.TabIndex = 20;
            // 
            // txbQuantidade
            // 
            this.txbQuantidade.Location = new System.Drawing.Point(16, 224);
            this.txbQuantidade.Multiline = true;
            this.txbQuantidade.Name = "txbQuantidade";
            this.txbQuantidade.Size = new System.Drawing.Size(604, 33);
            this.txbQuantidade.TabIndex = 21;
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Location = new System.Drawing.Point(15, 64);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(65, 20);
            this.lblProduto.TabIndex = 22;
            this.lblProduto.Text = "Produto";
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Location = new System.Drawing.Point(15, 130);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(50, 20);
            this.lblPreco.TabIndex = 23;
            this.lblPreco.Text = "Preço";
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Location = new System.Drawing.Point(15, 201);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(92, 20);
            this.lblQuantidade.TabIndex = 24;
            this.lblQuantidade.Text = "Quantidade";
            // 
            // txbNotaFiscal
            // 
            this.txbNotaFiscal.Location = new System.Drawing.Point(16, 295);
            this.txbNotaFiscal.Multiline = true;
            this.txbNotaFiscal.Name = "txbNotaFiscal";
            this.txbNotaFiscal.Size = new System.Drawing.Size(604, 33);
            this.txbNotaFiscal.TabIndex = 25;
            // 
            // maskedTextBoxDataHoraEntrada
            // 
            this.maskedTextBoxDataHoraEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBoxDataHoraEntrada.Location = new System.Drawing.Point(16, 367);
            this.maskedTextBoxDataHoraEntrada.Mask = "00/00/0000 90:00";
            this.maskedTextBoxDataHoraEntrada.Name = "maskedTextBoxDataHoraEntrada";
            this.maskedTextBoxDataHoraEntrada.ReadOnly = true;
            this.maskedTextBoxDataHoraEntrada.Size = new System.Drawing.Size(604, 30);
            this.maskedTextBoxDataHoraEntrada.TabIndex = 26;
            this.maskedTextBoxDataHoraEntrada.ValidatingType = typeof(System.DateTime);
            // 
            // lblNotaFiscal
            // 
            this.lblNotaFiscal.AutoSize = true;
            this.lblNotaFiscal.Location = new System.Drawing.Point(15, 272);
            this.lblNotaFiscal.Name = "lblNotaFiscal";
            this.lblNotaFiscal.Size = new System.Drawing.Size(88, 20);
            this.lblNotaFiscal.TabIndex = 27;
            this.lblNotaFiscal.Text = "Nota Fiscal";
            // 
            // lblDataHora
            // 
            this.lblDataHora.AutoSize = true;
            this.lblDataHora.Location = new System.Drawing.Point(15, 344);
            this.lblDataHora.Name = "lblDataHora";
            this.lblDataHora.Size = new System.Drawing.Size(144, 20);
            this.lblDataHora.TabIndex = 28;
            this.lblDataHora.Text = "Data/Hora Entrada";
            // 
            // btnLimparEntrada
            // 
            this.btnLimparEntrada.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLimparEntrada.Location = new System.Drawing.Point(150, 480);
            this.btnLimparEntrada.Name = "btnLimparEntrada";
            this.btnLimparEntrada.Size = new System.Drawing.Size(118, 42);
            this.btnLimparEntrada.TabIndex = 31;
            this.btnLimparEntrada.Text = "Limpar";
            this.btnLimparEntrada.UseVisualStyleBackColor = true;
            // 
            // btnCancelarEntrada
            // 
            this.btnCancelarEntrada.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancelarEntrada.Location = new System.Drawing.Point(282, 480);
            this.btnCancelarEntrada.Name = "btnCancelarEntrada";
            this.btnCancelarEntrada.Size = new System.Drawing.Size(118, 42);
            this.btnCancelarEntrada.TabIndex = 30;
            this.btnCancelarEntrada.Text = "Cancelar";
            this.btnCancelarEntrada.UseVisualStyleBackColor = true;
            this.btnCancelarEntrada.Click += new System.EventHandler(this.btnCancelarEntrada_Click);
            // 
            // btnCadastrarEntrar
            // 
            this.btnCadastrarEntrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCadastrarEntrar.Location = new System.Drawing.Point(16, 480);
            this.btnCadastrarEntrar.Name = "btnCadastrarEntrar";
            this.btnCadastrarEntrar.Size = new System.Drawing.Size(118, 42);
            this.btnCadastrarEntrar.TabIndex = 29;
            this.btnCadastrarEntrar.Text = "Cadastrar";
            this.btnCadastrarEntrar.UseVisualStyleBackColor = true;
            // 
            // FrmCadastroEntradaProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 534);
            this.Controls.Add(this.btnLimparEntrada);
            this.Controls.Add(this.btnCancelarEntrada);
            this.Controls.Add(this.btnCadastrarEntrar);
            this.Controls.Add(this.lblDataHora);
            this.Controls.Add(this.lblNotaFiscal);
            this.Controls.Add(this.maskedTextBoxDataHoraEntrada);
            this.Controls.Add(this.txbNotaFiscal);
            this.Controls.Add(this.lblQuantidade);
            this.Controls.Add(this.lblPreco);
            this.Controls.Add(this.lblProduto);
            this.Controls.Add(this.txbQuantidade);
            this.Controls.Add(this.txbPreco);
            this.Controls.Add(this.comboBoxProduto);
            this.Controls.Add(this.panel2);
            this.Name = "FrmCadastroEntradaProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCadastroEntradaProduto";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblCadastroProduto;
        private System.Windows.Forms.ComboBox comboBoxProduto;
        private System.Windows.Forms.TextBox txbPreco;
        private System.Windows.Forms.TextBox txbQuantidade;
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.TextBox txbNotaFiscal;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxDataHoraEntrada;
        private System.Windows.Forms.Label lblNotaFiscal;
        private System.Windows.Forms.Label lblDataHora;
        private System.Windows.Forms.Button btnLimparEntrada;
        private System.Windows.Forms.Button btnCancelarEntrada;
        private System.Windows.Forms.Button btnCadastrarEntrar;
    }
}