namespace SGPPC.Views.ProdutoEntrada
{
    partial class FrmEdicaoEntradaProduto
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
            this.lblProdutoEntrada = new System.Windows.Forms.Label();
            this.lblDataHora = new System.Windows.Forms.Label();
            this.lblNotaFiscal = new System.Windows.Forms.Label();
            this.maskedTextBoxDataHoraEntradaEdicao = new System.Windows.Forms.MaskedTextBox();
            this.txbNataFiscalEdicao = new System.Windows.Forms.TextBox();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.lblPreco = new System.Windows.Forms.Label();
            this.lblProduto = new System.Windows.Forms.Label();
            this.txbQuantidadeEdicao = new System.Windows.Forms.TextBox();
            this.txbPrecoEdicao = new System.Windows.Forms.TextBox();
            this.comboBoxProdutoEdicao = new System.Windows.Forms.ComboBox();
            this.btnAlterarEntrada = new System.Windows.Forms.Button();
            this.btnCancelarEntrada = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Orange;
            this.panel2.Controls.Add(this.lblProdutoEntrada);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(631, 48);
            this.panel2.TabIndex = 18;
            // 
            // lblProdutoEntrada
            // 
            this.lblProdutoEntrada.AutoSize = true;
            this.lblProdutoEntrada.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdutoEntrada.ForeColor = System.Drawing.Color.White;
            this.lblProdutoEntrada.Location = new System.Drawing.Point(5, 8);
            this.lblProdutoEntrada.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProdutoEntrada.Name = "lblProdutoEntrada";
            this.lblProdutoEntrada.Size = new System.Drawing.Size(322, 32);
            this.lblProdutoEntrada.TabIndex = 1;
            this.lblProdutoEntrada.Text = "Edição do Produto Entrada";
            this.lblProdutoEntrada.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDataHora
            // 
            this.lblDataHora.AutoSize = true;
            this.lblDataHora.Location = new System.Drawing.Point(12, 345);
            this.lblDataHora.Name = "lblDataHora";
            this.lblDataHora.Size = new System.Drawing.Size(144, 20);
            this.lblDataHora.TabIndex = 38;
            this.lblDataHora.Text = "Data/Hora Entrada";
            // 
            // lblNotaFiscal
            // 
            this.lblNotaFiscal.AutoSize = true;
            this.lblNotaFiscal.Location = new System.Drawing.Point(12, 273);
            this.lblNotaFiscal.Name = "lblNotaFiscal";
            this.lblNotaFiscal.Size = new System.Drawing.Size(88, 20);
            this.lblNotaFiscal.TabIndex = 37;
            this.lblNotaFiscal.Text = "Nota Fiscal";
            // 
            // maskedTextBoxDataHoraEntradaEdicao
            // 
            this.maskedTextBoxDataHoraEntradaEdicao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBoxDataHoraEntradaEdicao.Location = new System.Drawing.Point(13, 368);
            this.maskedTextBoxDataHoraEntradaEdicao.Mask = "00/00/0000 90:00";
            this.maskedTextBoxDataHoraEntradaEdicao.Name = "maskedTextBoxDataHoraEntradaEdicao";
            this.maskedTextBoxDataHoraEntradaEdicao.ReadOnly = true;
            this.maskedTextBoxDataHoraEntradaEdicao.Size = new System.Drawing.Size(604, 30);
            this.maskedTextBoxDataHoraEntradaEdicao.TabIndex = 36;
            this.maskedTextBoxDataHoraEntradaEdicao.ValidatingType = typeof(System.DateTime);
            // 
            // txbNataFiscalEdicao
            // 
            this.txbNataFiscalEdicao.Location = new System.Drawing.Point(13, 296);
            this.txbNataFiscalEdicao.Multiline = true;
            this.txbNataFiscalEdicao.Name = "txbNataFiscalEdicao";
            this.txbNataFiscalEdicao.Size = new System.Drawing.Size(604, 33);
            this.txbNataFiscalEdicao.TabIndex = 35;
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Location = new System.Drawing.Point(12, 202);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(92, 20);
            this.lblQuantidade.TabIndex = 34;
            this.lblQuantidade.Text = "Quantidade";
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Location = new System.Drawing.Point(12, 131);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(50, 20);
            this.lblPreco.TabIndex = 33;
            this.lblPreco.Text = "Preço";
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Location = new System.Drawing.Point(12, 65);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(65, 20);
            this.lblProduto.TabIndex = 32;
            this.lblProduto.Text = "Produto";
            // 
            // txbQuantidadeEdicao
            // 
            this.txbQuantidadeEdicao.Location = new System.Drawing.Point(13, 225);
            this.txbQuantidadeEdicao.Multiline = true;
            this.txbQuantidadeEdicao.Name = "txbQuantidadeEdicao";
            this.txbQuantidadeEdicao.Size = new System.Drawing.Size(604, 33);
            this.txbQuantidadeEdicao.TabIndex = 31;
            // 
            // txbPrecoEdicao
            // 
            this.txbPrecoEdicao.Location = new System.Drawing.Point(13, 154);
            this.txbPrecoEdicao.Multiline = true;
            this.txbPrecoEdicao.Name = "txbPrecoEdicao";
            this.txbPrecoEdicao.Size = new System.Drawing.Size(604, 33);
            this.txbPrecoEdicao.TabIndex = 30;
            // 
            // comboBoxProdutoEdicao
            // 
            this.comboBoxProdutoEdicao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxProdutoEdicao.FormattingEnabled = true;
            this.comboBoxProdutoEdicao.Location = new System.Drawing.Point(13, 88);
            this.comboBoxProdutoEdicao.Name = "comboBoxProdutoEdicao";
            this.comboBoxProdutoEdicao.Size = new System.Drawing.Size(604, 33);
            this.comboBoxProdutoEdicao.TabIndex = 29;
            // 
            // btnAlterarEntrada
            // 
            this.btnAlterarEntrada.Location = new System.Drawing.Point(13, 480);
            this.btnAlterarEntrada.Name = "btnAlterarEntrada";
            this.btnAlterarEntrada.Size = new System.Drawing.Size(118, 42);
            this.btnAlterarEntrada.TabIndex = 45;
            this.btnAlterarEntrada.Text = "Alterar";
            this.btnAlterarEntrada.UseVisualStyleBackColor = true;
            // 
            // btnCancelarEntrada
            // 
            this.btnCancelarEntrada.Location = new System.Drawing.Point(148, 480);
            this.btnCancelarEntrada.Name = "btnCancelarEntrada";
            this.btnCancelarEntrada.Size = new System.Drawing.Size(118, 42);
            this.btnCancelarEntrada.TabIndex = 44;
            this.btnCancelarEntrada.Text = "Cancelar";
            this.btnCancelarEntrada.UseVisualStyleBackColor = true;
            this.btnCancelarEntrada.Click += new System.EventHandler(this.btnCancelarEntrada_Click);
            // 
            // FrmEdicaoEntradaProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 534);
            this.Controls.Add(this.btnAlterarEntrada);
            this.Controls.Add(this.btnCancelarEntrada);
            this.Controls.Add(this.lblDataHora);
            this.Controls.Add(this.lblNotaFiscal);
            this.Controls.Add(this.maskedTextBoxDataHoraEntradaEdicao);
            this.Controls.Add(this.txbNataFiscalEdicao);
            this.Controls.Add(this.lblQuantidade);
            this.Controls.Add(this.lblPreco);
            this.Controls.Add(this.lblProduto);
            this.Controls.Add(this.txbQuantidadeEdicao);
            this.Controls.Add(this.txbPrecoEdicao);
            this.Controls.Add(this.comboBoxProdutoEdicao);
            this.Controls.Add(this.panel2);
            this.Name = "FrmEdicaoEntradaProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmEdicaoEntradaProduto";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblProdutoEntrada;
        private System.Windows.Forms.Label lblDataHora;
        private System.Windows.Forms.Label lblNotaFiscal;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxDataHoraEntradaEdicao;
        private System.Windows.Forms.TextBox txbNataFiscalEdicao;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.TextBox txbQuantidadeEdicao;
        private System.Windows.Forms.TextBox txbPrecoEdicao;
        private System.Windows.Forms.ComboBox comboBoxProdutoEdicao;
        private System.Windows.Forms.Button btnAlterarEntrada;
        private System.Windows.Forms.Button btnCancelarEntrada;
    }
}