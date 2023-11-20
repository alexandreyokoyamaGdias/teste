namespace SGPPC.Views.EntradaProduto
{
    partial class FrmCadastrarEntradaProduto
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
            this.panelCadastrarEntradaProduto = new System.Windows.Forms.Panel();
            this.lblCadastrarEmtrada = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxIdProduto = new System.Windows.Forms.TextBox();
            this.textBoxIdFornecedor = new System.Windows.Forms.TextBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.maskedTextBoxDataHora = new System.Windows.Forms.MaskedTextBox();
            this.comboBoxProduto = new System.Windows.Forms.ComboBox();
            this.comboBoxFornecedor = new System.Windows.Forms.ComboBox();
            this.txbQuantidade = new System.Windows.Forms.TextBox();
            this.txbPreco = new System.Windows.Forms.TextBox();
            this.txbNotaFiscal = new System.Windows.Forms.TextBox();
            this.labelProduto = new System.Windows.Forms.Label();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.lblPrecoUnit = new System.Windows.Forms.Label();
            this.lblFornecedor = new System.Windows.Forms.Label();
            this.lblDataHora = new System.Windows.Forms.Label();
            this.lblNotaFiscal = new System.Windows.Forms.Label();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.lblProdutoCad = new System.Windows.Forms.Label();
            this.dgEntradaProduto = new System.Windows.Forms.DataGridView();
            this.Nota_Fiscal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preco_Unitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_Fornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_Produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data_Hora_Entrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelCadastrarEntradaProduto.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgEntradaProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCadastrarEntradaProduto
            // 
            this.panelCadastrarEntradaProduto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelCadastrarEntradaProduto.BackColor = System.Drawing.Color.Orange;
            this.panelCadastrarEntradaProduto.Controls.Add(this.lblCadastrarEmtrada);
            this.panelCadastrarEntradaProduto.Location = new System.Drawing.Point(0, 0);
            this.panelCadastrarEntradaProduto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelCadastrarEntradaProduto.Name = "panelCadastrarEntradaProduto";
            this.panelCadastrarEntradaProduto.Size = new System.Drawing.Size(1095, 31);
            this.panelCadastrarEntradaProduto.TabIndex = 18;
            // 
            // lblCadastrarEmtrada
            // 
            this.lblCadastrarEmtrada.AutoSize = true;
            this.lblCadastrarEmtrada.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastrarEmtrada.ForeColor = System.Drawing.Color.White;
            this.lblCadastrarEmtrada.Location = new System.Drawing.Point(3, 5);
            this.lblCadastrarEmtrada.Name = "lblCadastrarEmtrada";
            this.lblCadastrarEmtrada.Size = new System.Drawing.Size(82, 21);
            this.lblCadastrarEmtrada.TabIndex = 1;
            this.lblCadastrarEmtrada.Text = "Cadastrar";
            this.lblCadastrarEmtrada.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.textBoxIdProduto);
            this.panel1.Controls.Add(this.textBoxIdFornecedor);
            this.panel1.Controls.Add(this.btnAdicionar);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.btnFinalizar);
            this.panel1.Controls.Add(this.maskedTextBoxDataHora);
            this.panel1.Controls.Add(this.comboBoxProduto);
            this.panel1.Controls.Add(this.comboBoxFornecedor);
            this.panel1.Controls.Add(this.txbQuantidade);
            this.panel1.Controls.Add(this.txbPreco);
            this.panel1.Controls.Add(this.txbNotaFiscal);
            this.panel1.Controls.Add(this.labelProduto);
            this.panel1.Controls.Add(this.lblQuantidade);
            this.panel1.Controls.Add(this.lblPrecoUnit);
            this.panel1.Controls.Add(this.lblFornecedor);
            this.panel1.Controls.Add(this.lblDataHora);
            this.panel1.Controls.Add(this.lblNotaFiscal);
            this.panel1.Location = new System.Drawing.Point(12, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(392, 500);
            this.panel1.TabIndex = 40;
            // 
            // textBoxIdProduto
            // 
            this.textBoxIdProduto.Location = new System.Drawing.Point(351, 317);
            this.textBoxIdProduto.Name = "textBoxIdProduto";
            this.textBoxIdProduto.ReadOnly = true;
            this.textBoxIdProduto.Size = new System.Drawing.Size(31, 20);
            this.textBoxIdProduto.TabIndex = 43;
            this.textBoxIdProduto.Visible = false;
            // 
            // textBoxIdFornecedor
            // 
            this.textBoxIdFornecedor.Location = new System.Drawing.Point(351, 291);
            this.textBoxIdFornecedor.Name = "textBoxIdFornecedor";
            this.textBoxIdFornecedor.ReadOnly = true;
            this.textBoxIdFornecedor.Size = new System.Drawing.Size(31, 20);
            this.textBoxIdFornecedor.TabIndex = 42;
            this.textBoxIdFornecedor.Visible = false;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(102, 461);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 27);
            this.btnAdicionar.TabIndex = 41;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(194, 461);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 27);
            this.btnCancelar.TabIndex = 40;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Location = new System.Drawing.Point(8, 461);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(75, 27);
            this.btnFinalizar.TabIndex = 39;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // maskedTextBoxDataHora
            // 
            this.maskedTextBoxDataHora.Location = new System.Drawing.Point(8, 258);
            this.maskedTextBoxDataHora.Mask = "00/00/0000 90:00";
            this.maskedTextBoxDataHora.Name = "maskedTextBoxDataHora";
            this.maskedTextBoxDataHora.ReadOnly = true;
            this.maskedTextBoxDataHora.Size = new System.Drawing.Size(374, 20);
            this.maskedTextBoxDataHora.TabIndex = 38;
            this.maskedTextBoxDataHora.ValidatingType = typeof(System.DateTime);
            // 
            // comboBoxProduto
            // 
            this.comboBoxProduto.FormattingEnabled = true;
            this.comboBoxProduto.Location = new System.Drawing.Point(8, 208);
            this.comboBoxProduto.Name = "comboBoxProduto";
            this.comboBoxProduto.Size = new System.Drawing.Size(376, 21);
            this.comboBoxProduto.TabIndex = 37;
            this.comboBoxProduto.SelectedIndexChanged += new System.EventHandler(this.comboBoxProduto_SelectedIndexChanged_1);
            // 
            // comboBoxFornecedor
            // 
            this.comboBoxFornecedor.FormattingEnabled = true;
            this.comboBoxFornecedor.Location = new System.Drawing.Point(8, 160);
            this.comboBoxFornecedor.Name = "comboBoxFornecedor";
            this.comboBoxFornecedor.Size = new System.Drawing.Size(378, 21);
            this.comboBoxFornecedor.TabIndex = 36;
            this.comboBoxFornecedor.SelectedIndexChanged += new System.EventHandler(this.comboBoxFornecedor_SelectedIndexChanged);
            // 
            // txbQuantidade
            // 
            this.txbQuantidade.Location = new System.Drawing.Point(8, 111);
            this.txbQuantidade.Name = "txbQuantidade";
            this.txbQuantidade.Size = new System.Drawing.Size(376, 20);
            this.txbQuantidade.TabIndex = 35;
            // 
            // txbPreco
            // 
            this.txbPreco.Location = new System.Drawing.Point(8, 69);
            this.txbPreco.Name = "txbPreco";
            this.txbPreco.Size = new System.Drawing.Size(376, 20);
            this.txbPreco.TabIndex = 34;
            // 
            // txbNotaFiscal
            // 
            this.txbNotaFiscal.Location = new System.Drawing.Point(8, 25);
            this.txbNotaFiscal.Name = "txbNotaFiscal";
            this.txbNotaFiscal.Size = new System.Drawing.Size(376, 20);
            this.txbNotaFiscal.TabIndex = 33;
            // 
            // labelProduto
            // 
            this.labelProduto.AutoSize = true;
            this.labelProduto.Location = new System.Drawing.Point(3, 192);
            this.labelProduto.Name = "labelProduto";
            this.labelProduto.Size = new System.Drawing.Size(48, 13);
            this.labelProduto.TabIndex = 31;
            this.labelProduto.Text = "*Produto";
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Location = new System.Drawing.Point(5, 95);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(66, 13);
            this.lblQuantidade.TabIndex = 30;
            this.lblQuantidade.Text = "*Quantidade";
            // 
            // lblPrecoUnit
            // 
            this.lblPrecoUnit.AutoSize = true;
            this.lblPrecoUnit.Location = new System.Drawing.Point(5, 53);
            this.lblPrecoUnit.Name = "lblPrecoUnit";
            this.lblPrecoUnit.Size = new System.Drawing.Size(78, 13);
            this.lblPrecoUnit.TabIndex = 29;
            this.lblPrecoUnit.Text = "*Preço Unitário";
            // 
            // lblFornecedor
            // 
            this.lblFornecedor.AutoSize = true;
            this.lblFornecedor.Location = new System.Drawing.Point(3, 144);
            this.lblFornecedor.Name = "lblFornecedor";
            this.lblFornecedor.Size = new System.Drawing.Size(65, 13);
            this.lblFornecedor.TabIndex = 28;
            this.lblFornecedor.Text = "*Fornecedor";
            // 
            // lblDataHora
            // 
            this.lblDataHora.AutoSize = true;
            this.lblDataHora.Location = new System.Drawing.Point(3, 242);
            this.lblDataHora.Name = "lblDataHora";
            this.lblDataHora.Size = new System.Drawing.Size(102, 13);
            this.lblDataHora.TabIndex = 27;
            this.lblDataHora.Text = "*Data/Hora Entrada";
            // 
            // lblNotaFiscal
            // 
            this.lblNotaFiscal.AutoSize = true;
            this.lblNotaFiscal.Location = new System.Drawing.Point(5, 9);
            this.lblNotaFiscal.Name = "lblNotaFiscal";
            this.lblNotaFiscal.Size = new System.Drawing.Size(64, 13);
            this.lblNotaFiscal.TabIndex = 26;
            this.lblNotaFiscal.Text = "*Nota Fiscal";
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.Orange;
            this.panelTitulo.Controls.Add(this.lblProdutoCad);
            this.panelTitulo.Location = new System.Drawing.Point(409, 50);
            this.panelTitulo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(675, 24);
            this.panelTitulo.TabIndex = 39;
            // 
            // lblProdutoCad
            // 
            this.lblProdutoCad.AutoSize = true;
            this.lblProdutoCad.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdutoCad.Location = new System.Drawing.Point(273, 0);
            this.lblProdutoCad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProdutoCad.Name = "lblProdutoCad";
            this.lblProdutoCad.Size = new System.Drawing.Size(99, 26);
            this.lblProdutoCad.TabIndex = 12;
            this.lblProdutoCad.Text = "Produtos";
            // 
            // dgEntradaProduto
            // 
            this.dgEntradaProduto.AllowUserToAddRows = false;
            this.dgEntradaProduto.AllowUserToDeleteRows = false;
            this.dgEntradaProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEntradaProduto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nota_Fiscal,
            this.Preco_Unitario,
            this.Quantidade,
            this.Id_Fornecedor,
            this.Id_Produto,
            this.Data_Hora_Entrada});
            this.dgEntradaProduto.Location = new System.Drawing.Point(409, 78);
            this.dgEntradaProduto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgEntradaProduto.Name = "dgEntradaProduto";
            this.dgEntradaProduto.ReadOnly = true;
            this.dgEntradaProduto.RowHeadersWidth = 62;
            this.dgEntradaProduto.RowTemplate.Height = 28;
            this.dgEntradaProduto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgEntradaProduto.Size = new System.Drawing.Size(675, 473);
            this.dgEntradaProduto.TabIndex = 38;
            this.dgEntradaProduto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgEntradaProduto_CellContentClick);
            // 
            // Nota_Fiscal
            // 
            this.Nota_Fiscal.HeaderText = "Nota_Fiscal";
            this.Nota_Fiscal.MinimumWidth = 8;
            this.Nota_Fiscal.Name = "Nota_Fiscal";
            this.Nota_Fiscal.ReadOnly = true;
            this.Nota_Fiscal.Width = 150;
            // 
            // Preco_Unitario
            // 
            this.Preco_Unitario.HeaderText = "Preco_Unitario";
            this.Preco_Unitario.MinimumWidth = 8;
            this.Preco_Unitario.Name = "Preco_Unitario";
            this.Preco_Unitario.ReadOnly = true;
            this.Preco_Unitario.Width = 150;
            // 
            // Quantidade
            // 
            this.Quantidade.HeaderText = "Quantidade";
            this.Quantidade.MinimumWidth = 8;
            this.Quantidade.Name = "Quantidade";
            this.Quantidade.ReadOnly = true;
            this.Quantidade.Width = 150;
            // 
            // Id_Fornecedor
            // 
            this.Id_Fornecedor.HeaderText = "Id_Fornecedor";
            this.Id_Fornecedor.MinimumWidth = 8;
            this.Id_Fornecedor.Name = "Id_Fornecedor";
            this.Id_Fornecedor.ReadOnly = true;
            this.Id_Fornecedor.Width = 150;
            // 
            // Id_Produto
            // 
            this.Id_Produto.HeaderText = "Id_Produto";
            this.Id_Produto.MinimumWidth = 8;
            this.Id_Produto.Name = "Id_Produto";
            this.Id_Produto.ReadOnly = true;
            this.Id_Produto.Width = 150;
            // 
            // Data_Hora_Entrada
            // 
            this.Data_Hora_Entrada.HeaderText = "Data_Hora_Entrada";
            this.Data_Hora_Entrada.MinimumWidth = 8;
            this.Data_Hora_Entrada.Name = "Data_Hora_Entrada";
            this.Data_Hora_Entrada.ReadOnly = true;
            this.Data_Hora_Entrada.Width = 150;
            // 
            // FrmCadastrarEntradaProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 562);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelTitulo);
            this.Controls.Add(this.dgEntradaProduto);
            this.Controls.Add(this.panelCadastrarEntradaProduto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "FrmCadastrarEntradaProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCadastrarEntradaProduto";
            this.Load += new System.EventHandler(this.FrmCadastrarEntradaProduto_Load);
            this.panelCadastrarEntradaProduto.ResumeLayout(false);
            this.panelCadastrarEntradaProduto.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgEntradaProduto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCadastrarEntradaProduto;
        private System.Windows.Forms.Label lblCadastrarEmtrada;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxIdProduto;
        private System.Windows.Forms.TextBox textBoxIdFornecedor;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxDataHora;
        private System.Windows.Forms.ComboBox comboBoxProduto;
        private System.Windows.Forms.ComboBox comboBoxFornecedor;
        private System.Windows.Forms.TextBox txbQuantidade;
        private System.Windows.Forms.TextBox txbPreco;
        private System.Windows.Forms.TextBox txbNotaFiscal;
        private System.Windows.Forms.Label labelProduto;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.Label lblPrecoUnit;
        private System.Windows.Forms.Label lblFornecedor;
        private System.Windows.Forms.Label lblDataHora;
        private System.Windows.Forms.Label lblNotaFiscal;
        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.Label lblProdutoCad;
        private System.Windows.Forms.DataGridView dgEntradaProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nota_Fiscal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Preco_Unitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Fornecedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data_Hora_Entrada;
    }
}