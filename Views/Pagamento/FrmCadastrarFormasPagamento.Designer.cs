namespace SGPPC.Views.Pagamento
{
    partial class FrmCadastrarFormasPagamento
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
            this.lblPagamento = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.lblPagamentoNome = new System.Windows.Forms.Label();
            this.txbFormaNome = new System.Windows.Forms.TextBox();
            this.txbFormaDescricao = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.radioInativoPagamento = new System.Windows.Forms.RadioButton();
            this.radioAtivoPagamento = new System.Windows.Forms.RadioButton();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Orange;
            this.panel2.Controls.Add(this.lblPagamento);
            this.panel2.Location = new System.Drawing.Point(1, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(421, 31);
            this.panel2.TabIndex = 45;
            // 
            // lblPagamento
            // 
            this.lblPagamento.AutoSize = true;
            this.lblPagamento.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPagamento.ForeColor = System.Drawing.Color.White;
            this.lblPagamento.Location = new System.Drawing.Point(3, 5);
            this.lblPagamento.Name = "lblPagamento";
            this.lblPagamento.Size = new System.Drawing.Size(249, 21);
            this.lblPagamento.TabIndex = 1;
            this.lblPagamento.Text = "Cadastrar Forma de Pagamento";
            this.lblPagamento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(188, 309);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(79, 27);
            this.btnCancelar.TabIndex = 55;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(99, 309);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(79, 27);
            this.btnLimpar.TabIndex = 54;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(11, 309);
            this.btnCadastrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(79, 27);
            this.btnCadastrar.TabIndex = 53;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // lblPagamentoNome
            // 
            this.lblPagamentoNome.AutoSize = true;
            this.lblPagamentoNome.Location = new System.Drawing.Point(13, 42);
            this.lblPagamentoNome.Name = "lblPagamentoNome";
            this.lblPagamentoNome.Size = new System.Drawing.Size(112, 13);
            this.lblPagamentoNome.TabIndex = 52;
            this.lblPagamentoNome.Text = "*Forma de Pagamento";
            // 
            // txbFormaNome
            // 
            this.txbFormaNome.Location = new System.Drawing.Point(13, 58);
            this.txbFormaNome.Multiline = true;
            this.txbFormaNome.Name = "txbFormaNome";
            this.txbFormaNome.Size = new System.Drawing.Size(396, 23);
            this.txbFormaNome.TabIndex = 51;
            // 
            // txbFormaDescricao
            // 
            this.txbFormaDescricao.Location = new System.Drawing.Point(13, 117);
            this.txbFormaDescricao.Multiline = true;
            this.txbFormaDescricao.Name = "txbFormaDescricao";
            this.txbFormaDescricao.Size = new System.Drawing.Size(396, 23);
            this.txbFormaDescricao.TabIndex = 56;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(13, 101);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(59, 13);
            this.lblDescricao.TabIndex = 57;
            this.lblDescricao.Text = "*Descrição";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(13, 157);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(41, 13);
            this.lblStatus.TabIndex = 60;
            this.lblStatus.Text = "*Status";
            // 
            // radioInativoPagamento
            // 
            this.radioInativoPagamento.AutoSize = true;
            this.radioInativoPagamento.Location = new System.Drawing.Point(66, 175);
            this.radioInativoPagamento.Margin = new System.Windows.Forms.Padding(2);
            this.radioInativoPagamento.Name = "radioInativoPagamento";
            this.radioInativoPagamento.Size = new System.Drawing.Size(57, 17);
            this.radioInativoPagamento.TabIndex = 59;
            this.radioInativoPagamento.TabStop = true;
            this.radioInativoPagamento.Text = "Inativo";
            this.radioInativoPagamento.UseVisualStyleBackColor = true;
            // 
            // radioAtivoPagamento
            // 
            this.radioAtivoPagamento.AutoSize = true;
            this.radioAtivoPagamento.Location = new System.Drawing.Point(16, 175);
            this.radioAtivoPagamento.Margin = new System.Windows.Forms.Padding(2);
            this.radioAtivoPagamento.Name = "radioAtivoPagamento";
            this.radioAtivoPagamento.Size = new System.Drawing.Size(49, 17);
            this.radioAtivoPagamento.TabIndex = 58;
            this.radioAtivoPagamento.TabStop = true;
            this.radioAtivoPagamento.Text = "Ativo";
            this.radioAtivoPagamento.UseVisualStyleBackColor = true;
            // 
            // FrmCadastrarFormasPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 347);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.radioInativoPagamento);
            this.Controls.Add(this.radioAtivoPagamento);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.txbFormaDescricao);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.lblPagamentoNome);
            this.Controls.Add(this.txbFormaNome);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmCadastrarFormasPagamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCadastrarFormasPagamento";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblPagamento;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label lblPagamentoNome;
        private System.Windows.Forms.TextBox txbFormaNome;
        private System.Windows.Forms.TextBox txbFormaDescricao;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.RadioButton radioInativoPagamento;
        private System.Windows.Forms.RadioButton radioAtivoPagamento;
    }
}