namespace SGPPC.Views.ControleCaixa
{
    partial class FrmEditarControleCaixa
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
            this.lblData = new System.Windows.Forms.Label();
            this.maskDataHoraEditar = new System.Windows.Forms.MaskedTextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.txbValorEditar = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.lblMotivo = new System.Windows.Forms.Label();
            this.txbMotivoEditar = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblControleCaixa = new System.Windows.Forms.Label();
            this.txbIdEdit = new System.Windows.Forms.TextBox();
            this.cbbTipoOperadcaoEditar = new System.Windows.Forms.ComboBox();
            this.txbIdTipoOperacao = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(319, 134);
            this.lblData.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(83, 20);
            this.lblData.TabIndex = 85;
            this.lblData.Text = "Data/Hora";
            // 
            // maskDataHoraEditar
            // 
            this.maskDataHoraEditar.Location = new System.Drawing.Point(323, 158);
            this.maskDataHoraEditar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.maskDataHoraEditar.Mask = "00/00/0000 90:00";
            this.maskDataHoraEditar.Name = "maskDataHoraEditar";
            this.maskDataHoraEditar.ReadOnly = true;
            this.maskDataHoraEditar.Size = new System.Drawing.Size(288, 26);
            this.maskDataHoraEditar.TabIndex = 84;
            this.maskDataHoraEditar.ValidatingType = typeof(System.DateTime);
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(15, 134);
            this.lblValor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(52, 20);
            this.lblValor.TabIndex = 83;
            this.lblValor.Text = "*Valor";
            // 
            // txbValorEditar
            // 
            this.txbValorEditar.Location = new System.Drawing.Point(20, 158);
            this.txbValorEditar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbValorEditar.Name = "txbValorEditar";
            this.txbValorEditar.Size = new System.Drawing.Size(283, 26);
            this.txbValorEditar.TabIndex = 82;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(319, 69);
            this.lblDescricao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(141, 20);
            this.lblDescricao.TabIndex = 81;
            this.lblDescricao.Text = "*Tipo de Operação";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(278, 480);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(118, 42);
            this.btnCancelar.TabIndex = 79;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click_1);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(145, 480);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(118, 42);
            this.btnLimpar.TabIndex = 78;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click_1);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(13, 480);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(118, 42);
            this.btnEditar.TabIndex = 77;
            this.btnEditar.Text = "Alterar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // lblMotivo
            // 
            this.lblMotivo.AutoSize = true;
            this.lblMotivo.Location = new System.Drawing.Point(15, 69);
            this.lblMotivo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMotivo.Name = "lblMotivo";
            this.lblMotivo.Size = new System.Drawing.Size(61, 20);
            this.lblMotivo.TabIndex = 76;
            this.lblMotivo.Text = "*Motivo";
            // 
            // txbMotivoEditar
            // 
            this.txbMotivoEditar.Location = new System.Drawing.Point(15, 94);
            this.txbMotivoEditar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbMotivoEditar.Multiline = true;
            this.txbMotivoEditar.Name = "txbMotivoEditar";
            this.txbMotivoEditar.Size = new System.Drawing.Size(288, 33);
            this.txbMotivoEditar.TabIndex = 75;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Orange;
            this.panel2.Controls.Add(this.lblControleCaixa);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(632, 48);
            this.panel2.TabIndex = 74;
            // 
            // lblControleCaixa
            // 
            this.lblControleCaixa.AutoSize = true;
            this.lblControleCaixa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblControleCaixa.ForeColor = System.Drawing.Color.White;
            this.lblControleCaixa.Location = new System.Drawing.Point(4, 8);
            this.lblControleCaixa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblControleCaixa.Name = "lblControleCaixa";
            this.lblControleCaixa.Size = new System.Drawing.Size(216, 32);
            this.lblControleCaixa.TabIndex = 1;
            this.lblControleCaixa.Text = "Controle de Caixa";
            this.lblControleCaixa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txbIdEdit
            // 
            this.txbIdEdit.Location = new System.Drawing.Point(550, 496);
            this.txbIdEdit.Name = "txbIdEdit";
            this.txbIdEdit.ReadOnly = true;
            this.txbIdEdit.Size = new System.Drawing.Size(62, 26);
            this.txbIdEdit.TabIndex = 86;
            this.txbIdEdit.Visible = false;
            // 
            // cbbTipoOperadcaoEditar
            // 
            this.cbbTipoOperadcaoEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTipoOperadcaoEditar.FormattingEnabled = true;
            this.cbbTipoOperadcaoEditar.Location = new System.Drawing.Point(323, 94);
            this.cbbTipoOperadcaoEditar.Name = "cbbTipoOperadcaoEditar";
            this.cbbTipoOperadcaoEditar.Size = new System.Drawing.Size(288, 33);
            this.cbbTipoOperadcaoEditar.TabIndex = 87;
            this.cbbTipoOperadcaoEditar.SelectedIndexChanged += new System.EventHandler(this.txbTipoOperadcaoEditar_SelectedIndexChanged);
            // 
            // txbIdTipoOperacao
            // 
            this.txbIdTipoOperacao.Location = new System.Drawing.Point(550, 464);
            this.txbIdTipoOperacao.Name = "txbIdTipoOperacao";
            this.txbIdTipoOperacao.ReadOnly = true;
            this.txbIdTipoOperacao.Size = new System.Drawing.Size(62, 26);
            this.txbIdTipoOperacao.TabIndex = 88;
            this.txbIdTipoOperacao.Visible = false;
            // 
            // FrmEditarControleCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 534);
            this.Controls.Add(this.txbIdTipoOperacao);
            this.Controls.Add(this.cbbTipoOperadcaoEditar);
            this.Controls.Add(this.txbIdEdit);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.maskDataHoraEditar);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.txbValorEditar);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.lblMotivo);
            this.Controls.Add(this.txbMotivoEditar);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FrmEditarControleCaixa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmEditarControleCaixa";
            this.Load += new System.EventHandler(this.FrmEditarControleCaixa_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.MaskedTextBox maskDataHoraEditar;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.TextBox txbValorEditar;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Label lblMotivo;
        private System.Windows.Forms.TextBox txbMotivoEditar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblControleCaixa;
        private System.Windows.Forms.TextBox txbIdEdit;
        private System.Windows.Forms.ComboBox cbbTipoOperadcaoEditar;
        private System.Windows.Forms.TextBox txbIdTipoOperacao;
    }
}