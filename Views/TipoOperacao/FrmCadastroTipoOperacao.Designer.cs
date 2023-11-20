namespace SGPPC.Views.TipoOperacao
{
    partial class FrmCadastroTipoOperacao
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
            this.lblTipoOperacaol = new System.Windows.Forms.Label();
            this.txbDescricao = new System.Windows.Forms.TextBox();
            this.txbTipoOperacao = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.lblTipoOperacao = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Orange;
            this.panel2.Controls.Add(this.lblTipoOperacaol);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(632, 48);
            this.panel2.TabIndex = 45;
            // 
            // lblTipoOperacaol
            // 
            this.lblTipoOperacaol.AutoSize = true;
            this.lblTipoOperacaol.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoOperacaol.ForeColor = System.Drawing.Color.White;
            this.lblTipoOperacaol.Location = new System.Drawing.Point(4, 8);
            this.lblTipoOperacaol.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipoOperacaol.Name = "lblTipoOperacaol";
            this.lblTipoOperacaol.Size = new System.Drawing.Size(216, 32);
            this.lblTipoOperacaol.TabIndex = 1;
            this.lblTipoOperacaol.Text = "Tipo de Operação";
            this.lblTipoOperacaol.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txbDescricao
            // 
            this.txbDescricao.Location = new System.Drawing.Point(10, 145);
            this.txbDescricao.Multiline = true;
            this.txbDescricao.Name = "txbDescricao";
            this.txbDescricao.Size = new System.Drawing.Size(608, 30);
            this.txbDescricao.TabIndex = 46;
            // 
            // txbTipoOperacao
            // 
            this.txbTipoOperacao.Location = new System.Drawing.Point(10, 83);
            this.txbTipoOperacao.Multiline = true;
            this.txbTipoOperacao.Name = "txbTipoOperacao";
            this.txbTipoOperacao.Size = new System.Drawing.Size(608, 30);
            this.txbTipoOperacao.TabIndex = 47;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(12, 480);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(118, 42);
            this.btnCadastrar.TabIndex = 48;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(150, 480);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(118, 42);
            this.btnLimpar.TabIndex = 49;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(12, 122);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(80, 20);
            this.lblDescricao.TabIndex = 50;
            this.lblDescricao.Text = "Descrição";
            // 
            // lblTipoOperacao
            // 
            this.lblTipoOperacao.AutoSize = true;
            this.lblTipoOperacao.Location = new System.Drawing.Point(12, 60);
            this.lblTipoOperacao.Name = "lblTipoOperacao";
            this.lblTipoOperacao.Size = new System.Drawing.Size(135, 20);
            this.lblTipoOperacao.TabIndex = 51;
            this.lblTipoOperacao.Text = "Tipo de Operação";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(287, 480);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(118, 42);
            this.btnCancelar.TabIndex = 52;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FrmCadastroTipoOperacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 534);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblTipoOperacao);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.txbTipoOperacao);
            this.Controls.Add(this.txbDescricao);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmCadastroTipoOperacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCadastroTipoOperacao";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTipoOperacaol;
        private System.Windows.Forms.TextBox txbDescricao;
        private System.Windows.Forms.TextBox txbTipoOperacao;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label lblTipoOperacao;
        private System.Windows.Forms.Button btnCancelar;
    }
}