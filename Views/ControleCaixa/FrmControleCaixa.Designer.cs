namespace SGPPC.Views.ControleCaixa
{
    partial class FrmControleCaixa
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
            this.lblDescricao = new System.Windows.Forms.Label();
            this.txbTipoOperadcao = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.lblMotivo = new System.Windows.Forms.Label();
            this.txbMotivo = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblControleCaixa = new System.Windows.Forms.Label();
            this.txbValor = new System.Windows.Forms.TextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.maskDataHoras = new System.Windows.Forms.MaskedTextBox();
            this.lblData = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(213, 47);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(97, 13);
            this.lblDescricao.TabIndex = 69;
            this.lblDescricao.Text = "*Tipo de Operação";
            // 
            // txbTipoOperadcao
            // 
            this.txbTipoOperadcao.Location = new System.Drawing.Point(216, 63);
            this.txbTipoOperadcao.Multiline = true;
            this.txbTipoOperadcao.Name = "txbTipoOperadcao";
            this.txbTipoOperadcao.Size = new System.Drawing.Size(193, 23);
            this.txbTipoOperadcao.TabIndex = 68;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(186, 314);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(79, 27);
            this.btnCancelar.TabIndex = 67;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(97, 314);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(79, 27);
            this.btnLimpar.TabIndex = 66;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(9, 314);
            this.btnCadastrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(79, 27);
            this.btnCadastrar.TabIndex = 65;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // lblMotivo
            // 
            this.lblMotivo.AutoSize = true;
            this.lblMotivo.Location = new System.Drawing.Point(11, 47);
            this.lblMotivo.Name = "lblMotivo";
            this.lblMotivo.Size = new System.Drawing.Size(43, 13);
            this.lblMotivo.TabIndex = 64;
            this.lblMotivo.Text = "*Motivo";
            // 
            // txbMotivo
            // 
            this.txbMotivo.Location = new System.Drawing.Point(11, 63);
            this.txbMotivo.Multiline = true;
            this.txbMotivo.Name = "txbMotivo";
            this.txbMotivo.Size = new System.Drawing.Size(193, 23);
            this.txbMotivo.TabIndex = 63;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Orange;
            this.panel2.Controls.Add(this.lblControleCaixa);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(421, 31);
            this.panel2.TabIndex = 62;
            // 
            // lblControleCaixa
            // 
            this.lblControleCaixa.AutoSize = true;
            this.lblControleCaixa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblControleCaixa.ForeColor = System.Drawing.Color.White;
            this.lblControleCaixa.Location = new System.Drawing.Point(3, 5);
            this.lblControleCaixa.Name = "lblControleCaixa";
            this.lblControleCaixa.Size = new System.Drawing.Size(145, 21);
            this.lblControleCaixa.TabIndex = 1;
            this.lblControleCaixa.Text = "Controle de Caixa";
            this.lblControleCaixa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txbValor
            // 
            this.txbValor.Location = new System.Drawing.Point(14, 105);
            this.txbValor.Name = "txbValor";
            this.txbValor.Size = new System.Drawing.Size(190, 20);
            this.txbValor.TabIndex = 70;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(11, 89);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(35, 13);
            this.lblValor.TabIndex = 71;
            this.lblValor.Text = "*Valor";
            // 
            // maskDataHoras
            // 
            this.maskDataHoras.Location = new System.Drawing.Point(216, 105);
            this.maskDataHoras.Mask = "00/00/0000";
            this.maskDataHoras.Name = "maskDataHoras";
            this.maskDataHoras.Size = new System.Drawing.Size(193, 20);
            this.maskDataHoras.TabIndex = 72;
            this.maskDataHoras.ValidatingType = typeof(System.DateTime);
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(213, 89);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(58, 13);
            this.lblData.TabIndex = 73;
            this.lblData.Text = "Data/Hora";
            // 
            // FrmControleCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 347);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.maskDataHoras);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.txbValor);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.txbTipoOperadcao);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.lblMotivo);
            this.Controls.Add(this.txbMotivo);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "FrmControleCaixa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmControleCaixa";
            this.Load += new System.EventHandler(this.FrmControleCaixa_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.TextBox txbTipoOperadcao;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label lblMotivo;
        private System.Windows.Forms.TextBox txbMotivo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblControleCaixa;
        private System.Windows.Forms.TextBox txbValor;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.MaskedTextBox maskDataHoras;
        private System.Windows.Forms.Label lblData;
    }
}