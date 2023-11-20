namespace SGPPC.Views.TipoOperacao
{
    partial class FrmEdicaoTipoOpercao
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
            this.lblProduto = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblEdtTipoOperacao = new System.Windows.Forms.Label();
            this.lblEdtDescricao = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txbEdtTipoOperacao = new System.Windows.Forms.TextBox();
            this.txbEdtDescricao = new System.Windows.Forms.TextBox();
            this.txbId = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Orange;
            this.panel2.Controls.Add(this.lblProduto);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(421, 31);
            this.panel2.TabIndex = 45;
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
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(193, 312);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(79, 27);
            this.btnCancelar.TabIndex = 59;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblEdtTipoOperacao
            // 
            this.lblEdtTipoOperacao.AutoSize = true;
            this.lblEdtTipoOperacao.Location = new System.Drawing.Point(9, 39);
            this.lblEdtTipoOperacao.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEdtTipoOperacao.Name = "lblEdtTipoOperacao";
            this.lblEdtTipoOperacao.Size = new System.Drawing.Size(93, 13);
            this.lblEdtTipoOperacao.TabIndex = 58;
            this.lblEdtTipoOperacao.Text = "Tipo de Operação";
            // 
            // lblEdtDescricao
            // 
            this.lblEdtDescricao.AutoSize = true;
            this.lblEdtDescricao.Location = new System.Drawing.Point(9, 79);
            this.lblEdtDescricao.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEdtDescricao.Name = "lblEdtDescricao";
            this.lblEdtDescricao.Size = new System.Drawing.Size(55, 13);
            this.lblEdtDescricao.TabIndex = 57;
            this.lblEdtDescricao.Text = "Descrição";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(101, 312);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(79, 27);
            this.btnLimpar.TabIndex = 56;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(9, 312);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(79, 27);
            this.btnSalvar.TabIndex = 55;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txbEdtTipoOperacao
            // 
            this.txbEdtTipoOperacao.Location = new System.Drawing.Point(8, 54);
            this.txbEdtTipoOperacao.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbEdtTipoOperacao.Multiline = true;
            this.txbEdtTipoOperacao.Name = "txbEdtTipoOperacao";
            this.txbEdtTipoOperacao.Size = new System.Drawing.Size(407, 21);
            this.txbEdtTipoOperacao.TabIndex = 54;
            // 
            // txbEdtDescricao
            // 
            this.txbEdtDescricao.Location = new System.Drawing.Point(8, 94);
            this.txbEdtDescricao.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbEdtDescricao.Multiline = true;
            this.txbEdtDescricao.Name = "txbEdtDescricao";
            this.txbEdtDescricao.Size = new System.Drawing.Size(407, 21);
            this.txbEdtDescricao.TabIndex = 53;
            // 
            // txbId
            // 
            this.txbId.Location = new System.Drawing.Point(381, 322);
            this.txbId.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbId.Name = "txbId";
            this.txbId.ReadOnly = true;
            this.txbId.Size = new System.Drawing.Size(33, 20);
            this.txbId.TabIndex = 60;
            this.txbId.Visible = false;
            // 
            // FrmEdicaoTipoOpercao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 347);
            this.Controls.Add(this.txbId);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblEdtTipoOperacao);
            this.Controls.Add(this.lblEdtDescricao);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txbEdtTipoOperacao);
            this.Controls.Add(this.txbEdtDescricao);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmEdicaoTipoOpercao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmEdicaoTipoOpercao";
            this.Load += new System.EventHandler(this.FrmEdicaoTipoOpercao_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblEdtTipoOperacao;
        private System.Windows.Forms.Label lblEdtDescricao;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txbEdtTipoOperacao;
        private System.Windows.Forms.TextBox txbEdtDescricao;
        private System.Windows.Forms.TextBox txbId;
    }
}