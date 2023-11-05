namespace SGPPC.Views.EntradaProduto
{
    partial class FrmCadastrarEntradaProduto
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
            this.panelCadastrarEntradaProduto = new System.Windows.Forms.Panel();
            this.lblCadastrarEmtrada = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.lblPreco = new System.Windows.Forms.Label();
            this.txbQuantidade = new System.Windows.Forms.TextBox();
            this.txbPreco = new System.Windows.Forms.TextBox();
            this.maskedDataHoraEntrada = new System.Windows.Forms.MaskedTextBox();
            this.cbbProdutoEntrada = new System.Windows.Forms.ComboBox();
            this.lblProdutoEntrada = new System.Windows.Forms.Label();
            this.lblDataHoraEntrada = new System.Windows.Forms.Label();
            this.txbId = new System.Windows.Forms.TextBox();
            this.panelCadastrarEntradaProduto.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCadastrarEntradaProduto
            // 
            this.panelCadastrarEntradaProduto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelCadastrarEntradaProduto.BackColor = System.Drawing.Color.Orange;
            this.panelCadastrarEntradaProduto.Controls.Add(this.lblCadastrarEmtrada);
            this.panelCadastrarEntradaProduto.Location = new System.Drawing.Point(0, 0);
            this.panelCadastrarEntradaProduto.Name = "panelCadastrarEntradaProduto";
            this.panelCadastrarEntradaProduto.Size = new System.Drawing.Size(631, 48);
            this.panelCadastrarEntradaProduto.TabIndex = 18;
            // 
            // lblCadastrarEmtrada
            // 
            this.lblCadastrarEmtrada.AutoSize = true;
            this.lblCadastrarEmtrada.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastrarEmtrada.ForeColor = System.Drawing.Color.White;
            this.lblCadastrarEmtrada.Location = new System.Drawing.Point(5, 8);
            this.lblCadastrarEmtrada.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCadastrarEmtrada.Name = "lblCadastrarEmtrada";
            this.lblCadastrarEmtrada.Size = new System.Drawing.Size(123, 32);
            this.lblCadastrarEmtrada.TabIndex = 1;
            this.lblCadastrarEmtrada.Text = "Cadastrar";
            this.lblCadastrarEmtrada.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLimpar.Location = new System.Drawing.Point(149, 480);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(118, 42);
            this.btnLimpar.TabIndex = 28;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancelar.Location = new System.Drawing.Point(281, 480);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(118, 42);
            this.btnCancelar.TabIndex = 27;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCadastrar.Location = new System.Drawing.Point(15, 480);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(118, 42);
            this.btnCadastrar.TabIndex = 26;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Location = new System.Drawing.Point(326, 73);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(98, 20);
            this.lblQuantidade.TabIndex = 53;
            this.lblQuantidade.Text = "*Quantidade";
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Location = new System.Drawing.Point(11, 73);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(56, 20);
            this.lblPreco.TabIndex = 52;
            this.lblPreco.Text = "*Preço";
            // 
            // txbQuantidade
            // 
            this.txbQuantidade.Location = new System.Drawing.Point(330, 99);
            this.txbQuantidade.Name = "txbQuantidade";
            this.txbQuantidade.Size = new System.Drawing.Size(289, 26);
            this.txbQuantidade.TabIndex = 51;
            // 
            // txbPreco
            // 
            this.txbPreco.Location = new System.Drawing.Point(11, 99);
            this.txbPreco.Name = "txbPreco";
            this.txbPreco.Size = new System.Drawing.Size(300, 26);
            this.txbPreco.TabIndex = 50;
            // 
            // maskedDataHoraEntrada
            // 
            this.maskedDataHoraEntrada.Location = new System.Drawing.Point(330, 163);
            this.maskedDataHoraEntrada.Mask = "00/00/0000 90:00";
            this.maskedDataHoraEntrada.Name = "maskedDataHoraEntrada";
            this.maskedDataHoraEntrada.ReadOnly = true;
            this.maskedDataHoraEntrada.Size = new System.Drawing.Size(289, 26);
            this.maskedDataHoraEntrada.TabIndex = 54;
            this.maskedDataHoraEntrada.ValidatingType = typeof(System.DateTime);
            // 
            // cbbProdutoEntrada
            // 
            this.cbbProdutoEntrada.FormattingEnabled = true;
            this.cbbProdutoEntrada.Location = new System.Drawing.Point(15, 161);
            this.cbbProdutoEntrada.Name = "cbbProdutoEntrada";
            this.cbbProdutoEntrada.Size = new System.Drawing.Size(296, 28);
            this.cbbProdutoEntrada.TabIndex = 55;
            this.cbbProdutoEntrada.SelectedIndexChanged += new System.EventHandler(this.cbbProdutoEntrada_SelectedIndexChanged);
            // 
            // lblProdutoEntrada
            // 
            this.lblProdutoEntrada.AutoSize = true;
            this.lblProdutoEntrada.Location = new System.Drawing.Point(12, 138);
            this.lblProdutoEntrada.Name = "lblProdutoEntrada";
            this.lblProdutoEntrada.Size = new System.Drawing.Size(71, 20);
            this.lblProdutoEntrada.TabIndex = 56;
            this.lblProdutoEntrada.Text = "*Produto";
            // 
            // lblDataHoraEntrada
            // 
            this.lblDataHoraEntrada.AutoSize = true;
            this.lblDataHoraEntrada.Location = new System.Drawing.Point(326, 140);
            this.lblDataHoraEntrada.Name = "lblDataHoraEntrada";
            this.lblDataHoraEntrada.Size = new System.Drawing.Size(144, 20);
            this.lblDataHoraEntrada.TabIndex = 57;
            this.lblDataHoraEntrada.Text = "Data/Hora Entrada";
            // 
            // txbId
            // 
            this.txbId.Location = new System.Drawing.Point(553, 488);
            this.txbId.Name = "txbId";
            this.txbId.Size = new System.Drawing.Size(66, 26);
            this.txbId.TabIndex = 58;
            // 
            // FrmCadastrarEntradaProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 534);
            this.Controls.Add(this.txbId);
            this.Controls.Add(this.lblDataHoraEntrada);
            this.Controls.Add(this.lblProdutoEntrada);
            this.Controls.Add(this.cbbProdutoEntrada);
            this.Controls.Add(this.maskedDataHoraEntrada);
            this.Controls.Add(this.lblQuantidade);
            this.Controls.Add(this.lblPreco);
            this.Controls.Add(this.txbQuantidade);
            this.Controls.Add(this.txbPreco);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.panelCadastrarEntradaProduto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmCadastrarEntradaProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCadastrarEntradaProduto";
            this.Load += new System.EventHandler(this.FrmCadastrarEntradaProduto_Load);
            this.panelCadastrarEntradaProduto.ResumeLayout(false);
            this.panelCadastrarEntradaProduto.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelCadastrarEntradaProduto;
        private System.Windows.Forms.Label lblCadastrarEmtrada;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.TextBox txbQuantidade;
        private System.Windows.Forms.TextBox txbPreco;
        private System.Windows.Forms.MaskedTextBox maskedDataHoraEntrada;
        private System.Windows.Forms.ComboBox cbbProdutoEntrada;
        private System.Windows.Forms.Label lblProdutoEntrada;
        private System.Windows.Forms.Label lblDataHoraEntrada;
        private System.Windows.Forms.TextBox txbId;
    }
}