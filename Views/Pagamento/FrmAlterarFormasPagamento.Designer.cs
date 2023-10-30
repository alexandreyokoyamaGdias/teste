namespace SGPPC.Views.Pagamento
{
    partial class FrmAlterarFormasPagamento
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
            this.txbFormaNome = new System.Windows.Forms.TextBox();
            this.lblPagamentoF = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.txbFormaPDescricaoo = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.radioInativoPagamentoAlterar = new System.Windows.Forms.RadioButton();
            this.radioAtivoPagamentoAlterar = new System.Windows.Forms.RadioButton();
            this.txbId = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Orange;
            this.panel2.Controls.Add(this.lblPagamento);
            this.panel2.Location = new System.Drawing.Point(1, 1);
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
            this.lblPagamento.Size = new System.Drawing.Size(222, 21);
            this.lblPagamento.TabIndex = 1;
            this.lblPagamento.Text = "Editar Forma de Pagamento";
            this.lblPagamento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txbFormaNome
            // 
            this.txbFormaNome.Location = new System.Drawing.Point(12, 58);
            this.txbFormaNome.Multiline = true;
            this.txbFormaNome.Name = "txbFormaNome";
            this.txbFormaNome.Size = new System.Drawing.Size(396, 23);
            this.txbFormaNome.TabIndex = 46;
            // 
            // lblPagamentoF
            // 
            this.lblPagamentoF.AutoSize = true;
            this.lblPagamentoF.Location = new System.Drawing.Point(12, 42);
            this.lblPagamentoF.Name = "lblPagamentoF";
            this.lblPagamentoF.Size = new System.Drawing.Size(112, 13);
            this.lblPagamentoF.TabIndex = 47;
            this.lblPagamentoF.Text = "*Forma de Pagamento";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(187, 309);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(79, 27);
            this.btnCancelar.TabIndex = 50;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(98, 309);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(79, 27);
            this.btnLimpar.TabIndex = 49;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(10, 309);
            this.btnAlterar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(79, 27);
            this.btnAlterar.TabIndex = 48;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(15, 100);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(59, 13);
            this.lblDescricao.TabIndex = 61;
            this.lblDescricao.Text = "*Descrição";
            // 
            // txbFormaPDescricaoo
            // 
            this.txbFormaPDescricaoo.Location = new System.Drawing.Point(15, 116);
            this.txbFormaPDescricaoo.Multiline = true;
            this.txbFormaPDescricaoo.Name = "txbFormaPDescricaoo";
            this.txbFormaPDescricaoo.Size = new System.Drawing.Size(396, 23);
            this.txbFormaPDescricaoo.TabIndex = 60;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(13, 157);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(41, 13);
            this.lblStatus.TabIndex = 64;
            this.lblStatus.Text = "*Status";
            // 
            // radioInativoPagamentoAlterar
            // 
            this.radioInativoPagamentoAlterar.AutoSize = true;
            this.radioInativoPagamentoAlterar.Location = new System.Drawing.Point(66, 175);
            this.radioInativoPagamentoAlterar.Margin = new System.Windows.Forms.Padding(2);
            this.radioInativoPagamentoAlterar.Name = "radioInativoPagamentoAlterar";
            this.radioInativoPagamentoAlterar.Size = new System.Drawing.Size(57, 17);
            this.radioInativoPagamentoAlterar.TabIndex = 63;
            this.radioInativoPagamentoAlterar.TabStop = true;
            this.radioInativoPagamentoAlterar.Text = "Inativo";
            this.radioInativoPagamentoAlterar.UseVisualStyleBackColor = true;
            // 
            // radioAtivoPagamentoAlterar
            // 
            this.radioAtivoPagamentoAlterar.AutoSize = true;
            this.radioAtivoPagamentoAlterar.Location = new System.Drawing.Point(16, 175);
            this.radioAtivoPagamentoAlterar.Margin = new System.Windows.Forms.Padding(2);
            this.radioAtivoPagamentoAlterar.Name = "radioAtivoPagamentoAlterar";
            this.radioAtivoPagamentoAlterar.Size = new System.Drawing.Size(49, 17);
            this.radioAtivoPagamentoAlterar.TabIndex = 62;
            this.radioAtivoPagamentoAlterar.TabStop = true;
            this.radioAtivoPagamentoAlterar.Text = "Ativo";
            this.radioAtivoPagamentoAlterar.UseVisualStyleBackColor = true;
            // 
            // txbId
            // 
            this.txbId.Location = new System.Drawing.Point(364, 313);
            this.txbId.Name = "txbId";
            this.txbId.ReadOnly = true;
            this.txbId.Size = new System.Drawing.Size(47, 20);
            this.txbId.TabIndex = 65;
            this.txbId.Visible = false;
            // 
            // FrmAlterarFormasPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 347);
            this.Controls.Add(this.txbId);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.radioInativoPagamentoAlterar);
            this.Controls.Add(this.radioAtivoPagamentoAlterar);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.txbFormaPDescricaoo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.lblPagamentoF);
            this.Controls.Add(this.txbFormaNome);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmAlterarFormasPagamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAlterarFormasPagamento";
            this.Load += new System.EventHandler(this.FrmAlterarFormasPagamento_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblPagamento;
        private System.Windows.Forms.TextBox txbFormaNome;
        private System.Windows.Forms.Label lblPagamentoF;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.TextBox txbFormaPDescricaoo;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.RadioButton radioInativoPagamentoAlterar;
        private System.Windows.Forms.RadioButton radioAtivoPagamentoAlterar;
        private System.Windows.Forms.TextBox txbId;
    }
}