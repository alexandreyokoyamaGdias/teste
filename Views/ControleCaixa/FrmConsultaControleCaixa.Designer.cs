namespace SGPPC.Views.ControleCaixa
{
    partial class FrmConsultaControleCaixa
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
            this.lblPesquisar = new System.Windows.Forms.Label();
            this.comboBoxPesquisarControleCaixa = new System.Windows.Forms.ComboBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.panelFornecedor = new System.Windows.Forms.Panel();
            this.lblFornecedor = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.dgControleCaixa = new System.Windows.Forms.DataGridView();
            this.btnGerarRelatorio = new System.Windows.Forms.Button();
            this.panelFornecedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgControleCaixa)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPesquisar
            // 
            this.lblPesquisar.AutoSize = true;
            this.lblPesquisar.Location = new System.Drawing.Point(6, 71);
            this.lblPesquisar.Name = "lblPesquisar";
            this.lblPesquisar.Size = new System.Drawing.Size(79, 20);
            this.lblPesquisar.TabIndex = 22;
            this.lblPesquisar.Text = "Pesquisar";
            // 
            // comboBoxPesquisarControleCaixa
            // 
            this.comboBoxPesquisarControleCaixa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxPesquisarControleCaixa.FormattingEnabled = true;
            this.comboBoxPesquisarControleCaixa.Items.AddRange(new object[] {
            "Motivo",
            "Tipo_Operacao",
            "Data_Hora"});
            this.comboBoxPesquisarControleCaixa.Location = new System.Drawing.Point(748, 94);
            this.comboBoxPesquisarControleCaixa.Name = "comboBoxPesquisarControleCaixa";
            this.comboBoxPesquisarControleCaixa.Size = new System.Drawing.Size(346, 34);
            this.comboBoxPesquisarControleCaixa.TabIndex = 21;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(147, 586);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(118, 42);
            this.btnConsultar.TabIndex = 20;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisar.Location = new System.Drawing.Point(10, 94);
            this.txtPesquisar.Multiline = true;
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(730, 38);
            this.txtPesquisar.TabIndex = 19;
            this.txtPesquisar.TextChanged += new System.EventHandler(this.txtPesquisar_TextChanged);
            // 
            // panelFornecedor
            // 
            this.panelFornecedor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelFornecedor.BackColor = System.Drawing.Color.Orange;
            this.panelFornecedor.Controls.Add(this.lblFornecedor);
            this.panelFornecedor.Location = new System.Drawing.Point(0, 6);
            this.panelFornecedor.Name = "panelFornecedor";
            this.panelFornecedor.Size = new System.Drawing.Size(1108, 51);
            this.panelFornecedor.TabIndex = 18;
            // 
            // lblFornecedor
            // 
            this.lblFornecedor.AutoSize = true;
            this.lblFornecedor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFornecedor.ForeColor = System.Drawing.Color.White;
            this.lblFornecedor.Location = new System.Drawing.Point(4, 8);
            this.lblFornecedor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFornecedor.Name = "lblFornecedor";
            this.lblFornecedor.Size = new System.Drawing.Size(216, 32);
            this.lblFornecedor.TabIndex = 1;
            this.lblFornecedor.Text = "Controle de Caixa";
            this.lblFornecedor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(284, 586);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(118, 42);
            this.btnCancelar.TabIndex = 17;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(10, 586);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(118, 42);
            this.btnIncluir.TabIndex = 16;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // dgControleCaixa
            // 
            this.dgControleCaixa.AllowUserToAddRows = false;
            this.dgControleCaixa.AllowUserToDeleteRows = false;
            this.dgControleCaixa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgControleCaixa.Location = new System.Drawing.Point(10, 162);
            this.dgControleCaixa.Name = "dgControleCaixa";
            this.dgControleCaixa.ReadOnly = true;
            this.dgControleCaixa.RowHeadersWidth = 62;
            this.dgControleCaixa.RowTemplate.Height = 28;
            this.dgControleCaixa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgControleCaixa.Size = new System.Drawing.Size(1086, 409);
            this.dgControleCaixa.TabIndex = 15;
            this.dgControleCaixa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgFornecedor_CellContentClick);
            // 
            // btnGerarRelatorio
            // 
            this.btnGerarRelatorio.Location = new System.Drawing.Point(423, 585);
            this.btnGerarRelatorio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGerarRelatorio.Name = "btnGerarRelatorio";
            this.btnGerarRelatorio.Size = new System.Drawing.Size(130, 42);
            this.btnGerarRelatorio.TabIndex = 23;
            this.btnGerarRelatorio.Text = "Gerar Relatório";
            this.btnGerarRelatorio.UseVisualStyleBackColor = true;
            this.btnGerarRelatorio.Click += new System.EventHandler(this.btnGerarRelatorio_Click);
            // 
            // FrmConsultaControleCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 635);
            this.Controls.Add(this.btnGerarRelatorio);
            this.Controls.Add(this.lblPesquisar);
            this.Controls.Add(this.comboBoxPesquisarControleCaixa);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.panelFornecedor);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(this.dgControleCaixa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FrmConsultaControleCaixa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmConsultaControleCaixa";
            this.Load += new System.EventHandler(this.FrmConsultaControleCaixa_Load);
            this.panelFornecedor.ResumeLayout(false);
            this.panelFornecedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgControleCaixa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPesquisar;
        private System.Windows.Forms.ComboBox comboBoxPesquisarControleCaixa;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Panel panelFornecedor;
        private System.Windows.Forms.Label lblFornecedor;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.DataGridView dgControleCaixa;
        private System.Windows.Forms.Button btnGerarRelatorio;
    }
}