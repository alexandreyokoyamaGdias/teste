namespace SGPPC.Views.Relatorios
{
    partial class FrmVendas
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
            this.dgVendas = new System.Windows.Forms.DataGridView();
            this.lblPesquisar = new System.Windows.Forms.Label();
            this.comboBoxPesquisarVendas = new System.Windows.Forms.ComboBox();
            this.txtPesquisaVendas = new System.Windows.Forms.TextBox();
            this.panelFornecedor = new System.Windows.Forms.Panel();
            this.lblVendas = new System.Windows.Forms.Label();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnGerarRelatorio = new System.Windows.Forms.Button();
            this.sGPPCDataSet = new SGPPC.SGPPCDataSet();
            this.NomeCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdFormasPagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgVendas)).BeginInit();
            this.panelFornecedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sGPPCDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgVendas
            // 
            this.dgVendas.AllowUserToAddRows = false;
            this.dgVendas.AllowUserToDeleteRows = false;
            this.dgVendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVendas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NomeCliente,
            this.NomeProduto,
            this.IdFormasPagamento});
            this.dgVendas.Location = new System.Drawing.Point(8, 102);
            this.dgVendas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgVendas.Name = "dgVendas";
            this.dgVendas.ReadOnly = true;
            this.dgVendas.RowHeadersWidth = 62;
            this.dgVendas.RowTemplate.Height = 28;
            this.dgVendas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgVendas.Size = new System.Drawing.Size(724, 266);
            this.dgVendas.TabIndex = 3;
            this.dgVendas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgVendas_CellContentClick);
            // 
            // lblPesquisar
            // 
            this.lblPesquisar.AutoSize = true;
            this.lblPesquisar.Location = new System.Drawing.Point(5, 43);
            this.lblPesquisar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPesquisar.Name = "lblPesquisar";
            this.lblPesquisar.Size = new System.Drawing.Size(53, 13);
            this.lblPesquisar.TabIndex = 17;
            this.lblPesquisar.Text = "Pesquisar";
            // 
            // comboBoxPesquisarVendas
            // 
            this.comboBoxPesquisarVendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxPesquisarVendas.FormattingEnabled = true;
            this.comboBoxPesquisarVendas.Items.AddRange(new object[] {
            "Nome_Produto"});
            this.comboBoxPesquisarVendas.Location = new System.Drawing.Point(500, 58);
            this.comboBoxPesquisarVendas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxPesquisarVendas.Name = "comboBoxPesquisarVendas";
            this.comboBoxPesquisarVendas.Size = new System.Drawing.Size(232, 26);
            this.comboBoxPesquisarVendas.TabIndex = 16;
            // 
            // txtPesquisaVendas
            // 
            this.txtPesquisaVendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisaVendas.Location = new System.Drawing.Point(8, 58);
            this.txtPesquisaVendas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPesquisaVendas.Multiline = true;
            this.txtPesquisaVendas.Name = "txtPesquisaVendas";
            this.txtPesquisaVendas.Size = new System.Drawing.Size(488, 26);
            this.txtPesquisaVendas.TabIndex = 15;
            this.txtPesquisaVendas.TextChanged += new System.EventHandler(this.txtPesquisaVendas_TextChanged);
            // 
            // panelFornecedor
            // 
            this.panelFornecedor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelFornecedor.BackColor = System.Drawing.Color.Orange;
            this.panelFornecedor.Controls.Add(this.lblVendas);
            this.panelFornecedor.Location = new System.Drawing.Point(1, 1);
            this.panelFornecedor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelFornecedor.Name = "panelFornecedor";
            this.panelFornecedor.Size = new System.Drawing.Size(739, 33);
            this.panelFornecedor.TabIndex = 18;
            // 
            // lblVendas
            // 
            this.lblVendas.AutoSize = true;
            this.lblVendas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVendas.ForeColor = System.Drawing.Color.White;
            this.lblVendas.Location = new System.Drawing.Point(3, 5);
            this.lblVendas.Name = "lblVendas";
            this.lblVendas.Size = new System.Drawing.Size(65, 21);
            this.lblVendas.TabIndex = 1;
            this.lblVendas.Text = "Vendas";
            this.lblVendas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(8, 378);
            this.btnAtualizar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(79, 27);
            this.btnAtualizar.TabIndex = 21;
            this.btnAtualizar.Text = "Consultar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(99, 378);
            this.button4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(79, 27);
            this.button4.TabIndex = 20;
            this.button4.Text = "Cancelar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnGerarRelatorio
            // 
            this.btnGerarRelatorio.Location = new System.Drawing.Point(191, 377);
            this.btnGerarRelatorio.Name = "btnGerarRelatorio";
            this.btnGerarRelatorio.Size = new System.Drawing.Size(87, 27);
            this.btnGerarRelatorio.TabIndex = 24;
            this.btnGerarRelatorio.Text = "Gerar Relatório";
            this.btnGerarRelatorio.UseVisualStyleBackColor = true;
            this.btnGerarRelatorio.Click += new System.EventHandler(this.btnGerarRelatorio_Click);
            // 
            // sGPPCDataSet
            // 
            this.sGPPCDataSet.DataSetName = "SGPPCDataSet";
            this.sGPPCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // NomeCliente
            // 
            this.NomeCliente.HeaderText = "NomeCliente";
            this.NomeCliente.Name = "NomeCliente";
            this.NomeCliente.ReadOnly = true;
            this.NomeCliente.Visible = false;
            // 
            // NomeProduto
            // 
            this.NomeProduto.HeaderText = "NomeProduto";
            this.NomeProduto.Name = "NomeProduto";
            this.NomeProduto.ReadOnly = true;
            this.NomeProduto.Visible = false;
            // 
            // IdFormasPagamento
            // 
            this.IdFormasPagamento.HeaderText = "IdFormasPagamento";
            this.IdFormasPagamento.Name = "IdFormasPagamento";
            this.IdFormasPagamento.ReadOnly = true;
            this.IdFormasPagamento.Visible = false;
            // 
            // FrmVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 413);
            this.Controls.Add(this.btnGerarRelatorio);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.panelFornecedor);
            this.Controls.Add(this.lblPesquisar);
            this.Controls.Add(this.comboBoxPesquisarVendas);
            this.Controls.Add(this.txtPesquisaVendas);
            this.Controls.Add(this.dgVendas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmVendas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmVendas";
            this.Load += new System.EventHandler(this.FrmVendas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgVendas)).EndInit();
            this.panelFornecedor.ResumeLayout(false);
            this.panelFornecedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sGPPCDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgVendas;
        private System.Windows.Forms.Label lblPesquisar;
        private System.Windows.Forms.ComboBox comboBoxPesquisarVendas;
        private System.Windows.Forms.TextBox txtPesquisaVendas;
        private System.Windows.Forms.Panel panelFornecedor;
        private System.Windows.Forms.Label lblVendas;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnGerarRelatorio;
        private SGPPCDataSet sGPPCDataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdFormasPagamento;
    }
}