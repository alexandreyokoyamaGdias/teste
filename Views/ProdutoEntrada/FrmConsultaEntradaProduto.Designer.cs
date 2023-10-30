namespace SGPPC.Views.ProdutoEntrada
{
    partial class FrmConsultaEntradaProduto
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
            this.lblProdutoEntrada = new System.Windows.Forms.Label();
            this.dgEntradaProduto = new System.Windows.Forms.DataGridView();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.lblPesquisarEntrada = new System.Windows.Forms.Label();
            this.comboBoxPesquisarEntradaProduto = new System.Windows.Forms.ComboBox();
            this.txtPesquisaEntradaProduto = new System.Windows.Forms.TextBox();
            this.panelFornecedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgEntradaProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // panelFornecedor
            // 
            this.panelFornecedor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelFornecedor.BackColor = System.Drawing.Color.Orange;
            this.panelFornecedor.Controls.Add(this.lblProdutoEntrada);
            this.panelFornecedor.Location = new System.Drawing.Point(2, 2);
            this.panelFornecedor.Name = "panelFornecedor";
            this.panelFornecedor.Size = new System.Drawing.Size(1108, 51);
            this.panelFornecedor.TabIndex = 8;
            // 
            // lblProdutoEntrada
            // 
            this.lblProdutoEntrada.AutoSize = true;
            this.lblProdutoEntrada.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdutoEntrada.ForeColor = System.Drawing.Color.White;
            this.lblProdutoEntrada.Location = new System.Drawing.Point(4, 8);
            this.lblProdutoEntrada.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProdutoEntrada.Name = "lblProdutoEntrada";
            this.lblProdutoEntrada.Size = new System.Drawing.Size(310, 32);
            this.lblProdutoEntrada.TabIndex = 1;
            this.lblProdutoEntrada.Text = "Consulta Produto Entrada";
            this.lblProdutoEntrada.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgEntradaProduto
            // 
            this.dgEntradaProduto.AllowUserToAddRows = false;
            this.dgEntradaProduto.AllowUserToDeleteRows = false;
            this.dgEntradaProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEntradaProduto.Location = new System.Drawing.Point(12, 157);
            this.dgEntradaProduto.Name = "dgEntradaProduto";
            this.dgEntradaProduto.ReadOnly = true;
            this.dgEntradaProduto.RowHeadersWidth = 62;
            this.dgEntradaProduto.RowTemplate.Height = 28;
            this.dgEntradaProduto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgEntradaProduto.Size = new System.Drawing.Size(1086, 409);
            this.dgEntradaProduto.TabIndex = 9;
            this.dgEntradaProduto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgEntradaProduto_CellContentClick);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(148, 581);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(118, 42);
            this.btnConsultar.TabIndex = 15;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(285, 581);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(118, 42);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(12, 581);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(118, 42);
            this.btnIncluir.TabIndex = 13;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // lblPesquisarEntrada
            // 
            this.lblPesquisarEntrada.AutoSize = true;
            this.lblPesquisarEntrada.Location = new System.Drawing.Point(8, 66);
            this.lblPesquisarEntrada.Name = "lblPesquisarEntrada";
            this.lblPesquisarEntrada.Size = new System.Drawing.Size(79, 20);
            this.lblPesquisarEntrada.TabIndex = 18;
            this.lblPesquisarEntrada.Text = "Pesquisar";
            // 
            // comboBoxPesquisarEntradaProduto
            // 
            this.comboBoxPesquisarEntradaProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxPesquisarEntradaProduto.FormattingEnabled = true;
            this.comboBoxPesquisarEntradaProduto.Items.AddRange(new object[] {
            "Preco_Unitario",
            "Quantidade"});
            this.comboBoxPesquisarEntradaProduto.Location = new System.Drawing.Point(750, 89);
            this.comboBoxPesquisarEntradaProduto.Name = "comboBoxPesquisarEntradaProduto";
            this.comboBoxPesquisarEntradaProduto.Size = new System.Drawing.Size(346, 34);
            this.comboBoxPesquisarEntradaProduto.TabIndex = 17;
            // 
            // txtPesquisaEntradaProduto
            // 
            this.txtPesquisaEntradaProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisaEntradaProduto.Location = new System.Drawing.Point(12, 89);
            this.txtPesquisaEntradaProduto.Multiline = true;
            this.txtPesquisaEntradaProduto.Name = "txtPesquisaEntradaProduto";
            this.txtPesquisaEntradaProduto.Size = new System.Drawing.Size(730, 38);
            this.txtPesquisaEntradaProduto.TabIndex = 16;
            this.txtPesquisaEntradaProduto.TextChanged += new System.EventHandler(this.txtPesquisaEntradaProduto_TextChanged);
            // 
            // FrmConsultaEntradaProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 635);
            this.Controls.Add(this.lblPesquisarEntrada);
            this.Controls.Add(this.comboBoxPesquisarEntradaProduto);
            this.Controls.Add(this.txtPesquisaEntradaProduto);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(this.dgEntradaProduto);
            this.Controls.Add(this.panelFornecedor);
            this.Name = "FrmConsultaEntradaProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmConsultaEntradaProduto";
            this.Load += new System.EventHandler(this.FrmConsultaEntradaProduto_Load);
            this.panelFornecedor.ResumeLayout(false);
            this.panelFornecedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgEntradaProduto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelFornecedor;
        private System.Windows.Forms.Label lblProdutoEntrada;
        private System.Windows.Forms.DataGridView dgEntradaProduto;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Label lblPesquisarEntrada;
        private System.Windows.Forms.ComboBox comboBoxPesquisarEntradaProduto;
        private System.Windows.Forms.TextBox txtPesquisaEntradaProduto;
    }
}