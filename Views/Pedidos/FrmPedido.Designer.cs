namespace SGPPC.Views.Pedidos
{
    partial class FrmPedido
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
            this.pnlCabecalhoSistema = new System.Windows.Forms.Panel();
            this.lblPedidos = new System.Windows.Forms.Label();
            this.dgPedido = new System.Windows.Forms.DataGridView();
            this.Nome_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_Produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_FormasPagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data_Hora_Pedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txbTotal = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txbIdUsuario = new System.Windows.Forms.TextBox();
            this.txbIdProduto = new System.Windows.Forms.TextBox();
            this.txbIdPagamento = new System.Windows.Forms.TextBox();
            this.comboPagamento = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.maskedDataHora = new System.Windows.Forms.MaskedTextBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.lblFormaPagamento = new System.Windows.Forms.Label();
            this.lblProduto = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.txbValor = new System.Windows.Forms.TextBox();
            this.txbQuantidade = new System.Windows.Forms.TextBox();
            this.cmbProduto = new System.Windows.Forms.ComboBox();
            this.txbNomeCliente = new System.Windows.Forms.TextBox();
            this.lblPedido = new System.Windows.Forms.Label();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.pnlCabecalhoSistema.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPedido)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCabecalhoSistema
            // 
            this.pnlCabecalhoSistema.BackColor = System.Drawing.Color.Orange;
            this.pnlCabecalhoSistema.Controls.Add(this.lblPedidos);
            this.pnlCabecalhoSistema.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCabecalhoSistema.Location = new System.Drawing.Point(0, 0);
            this.pnlCabecalhoSistema.Margin = new System.Windows.Forms.Padding(2);
            this.pnlCabecalhoSistema.Name = "pnlCabecalhoSistema";
            this.pnlCabecalhoSistema.Size = new System.Drawing.Size(1095, 40);
            this.pnlCabecalhoSistema.TabIndex = 2;
            // 
            // lblPedidos
            // 
            this.lblPedidos.AutoSize = true;
            this.lblPedidos.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPedidos.ForeColor = System.Drawing.Color.White;
            this.lblPedidos.Location = new System.Drawing.Point(7, 7);
            this.lblPedidos.Name = "lblPedidos";
            this.lblPedidos.Size = new System.Drawing.Size(74, 25);
            this.lblPedidos.TabIndex = 7;
            this.lblPedidos.Text = "Pedido";
            this.lblPedidos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgPedido
            // 
            this.dgPedido.AllowUserToAddRows = false;
            this.dgPedido.AllowUserToDeleteRows = false;
            this.dgPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPedido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome_Cliente,
            this.Id_Produto,
            this.Quantidade,
            this.Id_FormasPagamento,
            this.Valor,
            this.Data_Hora_Pedido,
            this.Id_Usuario});
            this.dgPedido.Location = new System.Drawing.Point(409, 78);
            this.dgPedido.Margin = new System.Windows.Forms.Padding(2);
            this.dgPedido.Name = "dgPedido";
            this.dgPedido.ReadOnly = true;
            this.dgPedido.RowHeadersWidth = 62;
            this.dgPedido.RowTemplate.Height = 28;
            this.dgPedido.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgPedido.Size = new System.Drawing.Size(675, 473);
            this.dgPedido.TabIndex = 10;
            this.dgPedido.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPagamento_CellContentClick);
            // 
            // Nome_Cliente
            // 
            this.Nome_Cliente.HeaderText = "Nome_Cliente";
            this.Nome_Cliente.MinimumWidth = 8;
            this.Nome_Cliente.Name = "Nome_Cliente";
            this.Nome_Cliente.ReadOnly = true;
            this.Nome_Cliente.Visible = false;
            // 
            // Id_Produto
            // 
            this.Id_Produto.HeaderText = "Id_Produto";
            this.Id_Produto.MinimumWidth = 8;
            this.Id_Produto.Name = "Id_Produto";
            this.Id_Produto.ReadOnly = true;
            // 
            // Quantidade
            // 
            this.Quantidade.HeaderText = "Quantidade";
            this.Quantidade.MinimumWidth = 8;
            this.Quantidade.Name = "Quantidade";
            this.Quantidade.ReadOnly = true;
            // 
            // Id_FormasPagamento
            // 
            this.Id_FormasPagamento.HeaderText = "Id_FormasPagamento";
            this.Id_FormasPagamento.MinimumWidth = 8;
            this.Id_FormasPagamento.Name = "Id_FormasPagamento";
            this.Id_FormasPagamento.ReadOnly = true;
            // 
            // Valor
            // 
            this.Valor.HeaderText = "Valor";
            this.Valor.MinimumWidth = 8;
            this.Valor.Name = "Valor";
            this.Valor.ReadOnly = true;
            // 
            // Data_Hora_Pedido
            // 
            this.Data_Hora_Pedido.HeaderText = "Data_Hora_Pedido";
            this.Data_Hora_Pedido.MinimumWidth = 8;
            this.Data_Hora_Pedido.Name = "Data_Hora_Pedido";
            this.Data_Hora_Pedido.ReadOnly = true;
            this.Data_Hora_Pedido.Width = 110;
            // 
            // Id_Usuario
            // 
            this.Id_Usuario.HeaderText = "Id_Usuario";
            this.Id_Usuario.MinimumWidth = 8;
            this.Id_Usuario.Name = "Id_Usuario";
            this.Id_Usuario.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.txbTotal);
            this.panel1.Controls.Add(this.lblTotal);
            this.panel1.Controls.Add(this.txbIdUsuario);
            this.panel1.Controls.Add(this.txbIdProduto);
            this.panel1.Controls.Add(this.txbIdPagamento);
            this.panel1.Controls.Add(this.comboPagamento);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.maskedDataHora);
            this.panel1.Controls.Add(this.btnAdicionar);
            this.panel1.Controls.Add(this.lblValor);
            this.panel1.Controls.Add(this.lblQuantidade);
            this.panel1.Controls.Add(this.lblFormaPagamento);
            this.panel1.Controls.Add(this.lblProduto);
            this.panel1.Controls.Add(this.lblNome);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.btnFinalizar);
            this.panel1.Controls.Add(this.txbValor);
            this.panel1.Controls.Add(this.txbQuantidade);
            this.panel1.Controls.Add(this.cmbProduto);
            this.panel1.Controls.Add(this.txbNomeCliente);
            this.panel1.Location = new System.Drawing.Point(12, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(392, 498);
            this.panel1.TabIndex = 11;
            // 
            // txbTotal
            // 
            this.txbTotal.Location = new System.Drawing.Point(12, 269);
            this.txbTotal.Name = "txbTotal";
            this.txbTotal.Size = new System.Drawing.Size(370, 20);
            this.txbTotal.TabIndex = 21;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(13, 253);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(58, 13);
            this.lblTotal.TabIndex = 20;
            this.lblTotal.Text = "Valor Total";
            // 
            // txbIdUsuario
            // 
            this.txbIdUsuario.Location = new System.Drawing.Point(344, 342);
            this.txbIdUsuario.Name = "txbIdUsuario";
            this.txbIdUsuario.Size = new System.Drawing.Size(38, 20);
            this.txbIdUsuario.TabIndex = 19;
            this.txbIdUsuario.Visible = false;
            // 
            // txbIdProduto
            // 
            this.txbIdProduto.Location = new System.Drawing.Point(302, 342);
            this.txbIdProduto.Name = "txbIdProduto";
            this.txbIdProduto.Size = new System.Drawing.Size(38, 20);
            this.txbIdProduto.TabIndex = 18;
            this.txbIdProduto.Visible = false;
            // 
            // txbIdPagamento
            // 
            this.txbIdPagamento.Location = new System.Drawing.Point(260, 342);
            this.txbIdPagamento.Name = "txbIdPagamento";
            this.txbIdPagamento.Size = new System.Drawing.Size(38, 20);
            this.txbIdPagamento.TabIndex = 17;
            this.txbIdPagamento.Visible = false;
            // 
            // comboPagamento
            // 
            this.comboPagamento.FormattingEnabled = true;
            this.comboPagamento.Location = new System.Drawing.Point(12, 119);
            this.comboPagamento.Name = "comboPagamento";
            this.comboPagamento.Size = new System.Drawing.Size(370, 21);
            this.comboPagamento.TabIndex = 16;
            this.comboPagamento.SelectedIndexChanged += new System.EventHandler(this.comboPagamento_SelectedIndexChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 302);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "*Data/Hora";
            // 
            // maskedDataHora
            // 
            this.maskedDataHora.Location = new System.Drawing.Point(12, 317);
            this.maskedDataHora.Margin = new System.Windows.Forms.Padding(2);
            this.maskedDataHora.Mask = "00/00/0000 90:00";
            this.maskedDataHora.Name = "maskedDataHora";
            this.maskedDataHora.ReadOnly = true;
            this.maskedDataHora.Size = new System.Drawing.Size(370, 20);
            this.maskedDataHora.TabIndex = 14;
            this.maskedDataHora.ValidatingType = typeof(System.DateTime);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(106, 458);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 27);
            this.btnAdicionar.TabIndex = 13;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(9, 205);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(55, 13);
            this.lblValor.TabIndex = 12;
            this.lblValor.Text = "*Valor Unt";
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Location = new System.Drawing.Point(9, 154);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(66, 13);
            this.lblQuantidade.TabIndex = 11;
            this.lblQuantidade.Text = "*Quantidade";
            // 
            // lblFormaPagamento
            // 
            this.lblFormaPagamento.AutoSize = true;
            this.lblFormaPagamento.Location = new System.Drawing.Point(9, 103);
            this.lblFormaPagamento.Name = "lblFormaPagamento";
            this.lblFormaPagamento.Size = new System.Drawing.Size(112, 13);
            this.lblFormaPagamento.TabIndex = 10;
            this.lblFormaPagamento.Text = "*Forma de Pagamento";
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Location = new System.Drawing.Point(9, 59);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(48, 13);
            this.lblProduto.TabIndex = 9;
            this.lblProduto.Text = "*Produto";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(9, 10);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(74, 13);
            this.lblNome.TabIndex = 8;
            this.lblNome.Text = "*Nome Cliente";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(198, 458);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 27);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Location = new System.Drawing.Point(12, 458);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(75, 27);
            this.btnFinalizar.TabIndex = 5;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // txbValor
            // 
            this.txbValor.Location = new System.Drawing.Point(12, 221);
            this.txbValor.Multiline = true;
            this.txbValor.Name = "txbValor";
            this.txbValor.Size = new System.Drawing.Size(370, 20);
            this.txbValor.TabIndex = 4;
            this.txbValor.TextChanged += new System.EventHandler(this.txbValor_TextChanged);
            // 
            // txbQuantidade
            // 
            this.txbQuantidade.Location = new System.Drawing.Point(12, 170);
            this.txbQuantidade.Multiline = true;
            this.txbQuantidade.Name = "txbQuantidade";
            this.txbQuantidade.Size = new System.Drawing.Size(370, 20);
            this.txbQuantidade.TabIndex = 3;
            this.txbQuantidade.TextChanged += new System.EventHandler(this.txbQuantidade_TextChanged);
            // 
            // cmbProduto
            // 
            this.cmbProduto.FormattingEnabled = true;
            this.cmbProduto.Location = new System.Drawing.Point(12, 75);
            this.cmbProduto.Name = "cmbProduto";
            this.cmbProduto.Size = new System.Drawing.Size(370, 21);
            this.cmbProduto.TabIndex = 1;
            this.cmbProduto.SelectedIndexChanged += new System.EventHandler(this.cmbProduto_SelectedIndexChanged);
            // 
            // txbNomeCliente
            // 
            this.txbNomeCliente.Location = new System.Drawing.Point(12, 26);
            this.txbNomeCliente.Multiline = true;
            this.txbNomeCliente.Name = "txbNomeCliente";
            this.txbNomeCliente.Size = new System.Drawing.Size(370, 20);
            this.txbNomeCliente.TabIndex = 0;
            // 
            // lblPedido
            // 
            this.lblPedido.AutoSize = true;
            this.lblPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPedido.Location = new System.Drawing.Point(273, 0);
            this.lblPedido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPedido.Name = "lblPedido";
            this.lblPedido.Size = new System.Drawing.Size(163, 26);
            this.lblPedido.TabIndex = 12;
            this.lblPedido.Text = "Itens do Pedido";
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.Orange;
            this.panelTitulo.Controls.Add(this.lblPedido);
            this.panelTitulo.Location = new System.Drawing.Point(409, 53);
            this.panelTitulo.Margin = new System.Windows.Forms.Padding(2);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(675, 24);
            this.panelTitulo.TabIndex = 13;
            // 
            // FrmPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 562);
            this.Controls.Add(this.panelTitulo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgPedido);
            this.Controls.Add(this.pnlCabecalhoSistema);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPedido";
            this.Load += new System.EventHandler(this.FrmPedido_Load);
            this.pnlCabecalhoSistema.ResumeLayout(false);
            this.pnlCabecalhoSistema.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPedido)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCabecalhoSistema;
        private System.Windows.Forms.DataGridView dgPedido;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.Label lblFormaPagamento;
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.TextBox txbValor;
        private System.Windows.Forms.TextBox txbQuantidade;
        private System.Windows.Forms.ComboBox cmbProduto;
        private System.Windows.Forms.TextBox txbNomeCliente;
        private System.Windows.Forms.Label lblPedidos;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox maskedDataHora;
        private System.Windows.Forms.ComboBox comboPagamento;
        private System.Windows.Forms.TextBox txbIdPagamento;
        private System.Windows.Forms.TextBox txbIdProduto;
        private System.Windows.Forms.Label lblPedido;
        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.TextBox txbIdUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome_Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_FormasPagamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data_Hora_Pedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Usuario;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txbTotal;
    }
}