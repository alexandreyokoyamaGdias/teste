namespace SGPPC.Views.TipoOperacao
{
    partial class FrmConsultaTipoOperacao
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
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.dtgViewTipoOperacao = new System.Windows.Forms.DataGridView();
            this.comboBoxPesquisaTipoOperacoes = new System.Windows.Forms.ComboBox();
            this.lblPesquisa = new System.Windows.Forms.Label();
            this.txbPesquisaTipoOperacao = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.panelProduto = new System.Windows.Forms.Panel();
            this.lblTipoOperacao = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgViewTipoOperacao)).BeginInit();
            this.panelProduto.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizar.Location = new System.Drawing.Point(148, 586);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(118, 42);
            this.btnAtualizar.TabIndex = 31;
            this.btnAtualizar.Text = "Consultar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // dtgViewTipoOperacao
            // 
            this.dtgViewTipoOperacao.AllowUserToAddRows = false;
            this.dtgViewTipoOperacao.AllowUserToDeleteRows = false;
            this.dtgViewTipoOperacao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgViewTipoOperacao.Location = new System.Drawing.Point(10, 156);
            this.dtgViewTipoOperacao.Name = "dtgViewTipoOperacao";
            this.dtgViewTipoOperacao.ReadOnly = true;
            this.dtgViewTipoOperacao.RowHeadersWidth = 62;
            this.dtgViewTipoOperacao.RowTemplate.Height = 28;
            this.dtgViewTipoOperacao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgViewTipoOperacao.Size = new System.Drawing.Size(1086, 409);
            this.dtgViewTipoOperacao.TabIndex = 30;
            this.dtgViewTipoOperacao.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgViewTipoOperacao_CellContentClick);
            // 
            // comboBoxPesquisaTipoOperacoes
            // 
            this.comboBoxPesquisaTipoOperacoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxPesquisaTipoOperacoes.FormattingEnabled = true;
            this.comboBoxPesquisaTipoOperacoes.Items.AddRange(new object[] {
            "Tipo_Operacao",
            "Descricao"});
            this.comboBoxPesquisaTipoOperacoes.Location = new System.Drawing.Point(748, 89);
            this.comboBoxPesquisaTipoOperacoes.Name = "comboBoxPesquisaTipoOperacoes";
            this.comboBoxPesquisaTipoOperacoes.Size = new System.Drawing.Size(342, 34);
            this.comboBoxPesquisaTipoOperacoes.TabIndex = 29;
            // 
            // lblPesquisa
            // 
            this.lblPesquisa.AutoSize = true;
            this.lblPesquisa.Location = new System.Drawing.Point(10, 66);
            this.lblPesquisa.Name = "lblPesquisa";
            this.lblPesquisa.Size = new System.Drawing.Size(74, 20);
            this.lblPesquisa.TabIndex = 28;
            this.lblPesquisa.Text = "Pesquisa";
            // 
            // txbPesquisaTipoOperacao
            // 
            this.txbPesquisaTipoOperacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPesquisaTipoOperacao.Location = new System.Drawing.Point(10, 89);
            this.txbPesquisaTipoOperacao.Multiline = true;
            this.txbPesquisaTipoOperacao.Name = "txbPesquisaTipoOperacao";
            this.txbPesquisaTipoOperacao.Size = new System.Drawing.Size(730, 38);
            this.txbPesquisaTipoOperacao.TabIndex = 27;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(286, 586);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(118, 42);
            this.btnCancelar.TabIndex = 26;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(10, 586);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(118, 42);
            this.btnIncluir.TabIndex = 25;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // panelProduto
            // 
            this.panelProduto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelProduto.BackColor = System.Drawing.Color.Orange;
            this.panelProduto.Controls.Add(this.lblTipoOperacao);
            this.panelProduto.Location = new System.Drawing.Point(0, 0);
            this.panelProduto.Name = "panelProduto";
            this.panelProduto.Size = new System.Drawing.Size(1110, 48);
            this.panelProduto.TabIndex = 24;
            // 
            // lblTipoOperacao
            // 
            this.lblTipoOperacao.AutoSize = true;
            this.lblTipoOperacao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoOperacao.ForeColor = System.Drawing.Color.White;
            this.lblTipoOperacao.Location = new System.Drawing.Point(4, 8);
            this.lblTipoOperacao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipoOperacao.Name = "lblTipoOperacao";
            this.lblTipoOperacao.Size = new System.Drawing.Size(216, 32);
            this.lblTipoOperacao.TabIndex = 1;
            this.lblTipoOperacao.Text = "Tipo de Operação";
            this.lblTipoOperacao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmConsultaTipoOperacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 635);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.dtgViewTipoOperacao);
            this.Controls.Add(this.comboBoxPesquisaTipoOperacoes);
            this.Controls.Add(this.lblPesquisa);
            this.Controls.Add(this.txbPesquisaTipoOperacao);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(this.panelProduto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmConsultaTipoOperacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmConsultaTipoOperacao";
            this.Load += new System.EventHandler(this.FrmConsultaTipoOperacao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgViewTipoOperacao)).EndInit();
            this.panelProduto.ResumeLayout(false);
            this.panelProduto.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.DataGridView dtgViewTipoOperacao;
        private System.Windows.Forms.ComboBox comboBoxPesquisaTipoOperacoes;
        private System.Windows.Forms.Label lblPesquisa;
        private System.Windows.Forms.TextBox txbPesquisaTipoOperacao;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Panel panelProduto;
        private System.Windows.Forms.Label lblTipoOperacao;
    }
}