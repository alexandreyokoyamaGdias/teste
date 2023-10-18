namespace SGPPC.Views.Pagamento
{
    partial class FrmConsultaFormasPagamento
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
            this.panelFornecedor = new System.Windows.Forms.Panel();
            this.lblPagamento = new System.Windows.Forms.Label();
            this.dgPagamento = new System.Windows.Forms.DataGridView();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnCancela = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lblPesquisar = new System.Windows.Forms.Label();
            this.comboBoxPesquisarPagamento = new System.Windows.Forms.ComboBox();
            this.txtPesquisaPagamento = new System.Windows.Forms.TextBox();
            this.panelFornecedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPagamento)).BeginInit();
            this.SuspendLayout();
            // 
            // panelFornecedor
            // 
            this.panelFornecedor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelFornecedor.BackColor = System.Drawing.Color.Orange;
            this.panelFornecedor.Controls.Add(this.lblPagamento);
            this.panelFornecedor.Location = new System.Drawing.Point(1, 0);
            this.panelFornecedor.Margin = new System.Windows.Forms.Padding(2);
            this.panelFornecedor.Name = "panelFornecedor";
            this.panelFornecedor.Size = new System.Drawing.Size(738, 33);
            this.panelFornecedor.TabIndex = 8;
            // 
            // lblPagamento
            // 
            this.lblPagamento.AutoSize = true;
            this.lblPagamento.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPagamento.ForeColor = System.Drawing.Color.White;
            this.lblPagamento.Location = new System.Drawing.Point(3, 5);
            this.lblPagamento.Name = "lblPagamento";
            this.lblPagamento.Size = new System.Drawing.Size(180, 21);
            this.lblPagamento.TabIndex = 1;
            this.lblPagamento.Text = "Formas de Pagamento";
            this.lblPagamento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgPagamento
            // 
            this.dgPagamento.AllowUserToAddRows = false;
            this.dgPagamento.AllowUserToDeleteRows = false;
            this.dgPagamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPagamento.Location = new System.Drawing.Point(8, 96);
            this.dgPagamento.Margin = new System.Windows.Forms.Padding(2);
            this.dgPagamento.Name = "dgPagamento";
            this.dgPagamento.ReadOnly = true;
            this.dgPagamento.RowHeadersWidth = 62;
            this.dgPagamento.RowTemplate.Height = 28;
            this.dgPagamento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgPagamento.Size = new System.Drawing.Size(724, 266);
            this.dgPagamento.TabIndex = 9;
            this.dgPagamento.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPagamento_CellContentClick);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(99, 375);
            this.btnAtualizar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(79, 27);
            this.btnAtualizar.TabIndex = 15;
            this.btnAtualizar.Text = "Consultar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnCancela
            // 
            this.btnCancela.Location = new System.Drawing.Point(190, 375);
            this.btnCancela.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancela.Name = "btnCancela";
            this.btnCancela.Size = new System.Drawing.Size(79, 27);
            this.btnCancela.TabIndex = 14;
            this.btnCancela.Text = "Cancelar";
            this.btnCancela.UseVisualStyleBackColor = true;
            this.btnCancela.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(8, 375);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(79, 27);
            this.btnSalvar.TabIndex = 13;
            this.btnSalvar.Text = "Incluir";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // lblPesquisar
            // 
            this.lblPesquisar.AutoSize = true;
            this.lblPesquisar.Location = new System.Drawing.Point(5, 42);
            this.lblPesquisar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPesquisar.Name = "lblPesquisar";
            this.lblPesquisar.Size = new System.Drawing.Size(53, 13);
            this.lblPesquisar.TabIndex = 18;
            this.lblPesquisar.Text = "Pesquisar";
            // 
            // comboBoxPesquisarPagamento
            // 
            this.comboBoxPesquisarPagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxPesquisarPagamento.FormattingEnabled = true;
            this.comboBoxPesquisarPagamento.Items.AddRange(new object[] {
            "Nome",
            "Descricao"});
            this.comboBoxPesquisarPagamento.Location = new System.Drawing.Point(500, 57);
            this.comboBoxPesquisarPagamento.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxPesquisarPagamento.Name = "comboBoxPesquisarPagamento";
            this.comboBoxPesquisarPagamento.Size = new System.Drawing.Size(232, 26);
            this.comboBoxPesquisarPagamento.TabIndex = 17;
            // 
            // txtPesquisaPagamento
            // 
            this.txtPesquisaPagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisaPagamento.Location = new System.Drawing.Point(8, 57);
            this.txtPesquisaPagamento.Margin = new System.Windows.Forms.Padding(2);
            this.txtPesquisaPagamento.Multiline = true;
            this.txtPesquisaPagamento.Name = "txtPesquisaPagamento";
            this.txtPesquisaPagamento.Size = new System.Drawing.Size(488, 26);
            this.txtPesquisaPagamento.TabIndex = 16;
            this.txtPesquisaPagamento.TextChanged += new System.EventHandler(this.txtPesquisaPagamento_TextChanged);
            // 
            // FrmConsultaFormasPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 413);
            this.Controls.Add(this.lblPesquisar);
            this.Controls.Add(this.comboBoxPesquisarPagamento);
            this.Controls.Add(this.txtPesquisaPagamento);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnCancela);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.dgPagamento);
            this.Controls.Add(this.panelFornecedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmConsultaFormasPagamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmConsultaFormasPagamento";
            this.Load += new System.EventHandler(this.FrmConsultaFormasPagamento_Load);
            this.panelFornecedor.ResumeLayout(false);
            this.panelFornecedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPagamento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelFornecedor;
        private System.Windows.Forms.Label lblPagamento;
        private System.Windows.Forms.DataGridView dgPagamento;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnCancela;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lblPesquisar;
        private System.Windows.Forms.ComboBox comboBoxPesquisarPagamento;
        private System.Windows.Forms.TextBox txtPesquisaPagamento;
    }
}