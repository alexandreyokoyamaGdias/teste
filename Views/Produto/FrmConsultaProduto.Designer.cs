namespace SGPPC.Views.Consultas
{
    partial class FrmConsultaProduto
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
            this.panelProduto = new System.Windows.Forms.Panel();
            this.lblProduto = new System.Windows.Forms.Label();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txbPesquisa = new System.Windows.Forms.TextBox();
            this.lblPesquisa = new System.Windows.Forms.Label();
            this.comboBoxPesquisaProd = new System.Windows.Forms.ComboBox();
            this.dtgViewProduto = new System.Windows.Forms.DataGridView();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.panelProduto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgViewProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // panelProduto
            // 
            this.panelProduto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelProduto.BackColor = System.Drawing.Color.Orange;
            this.panelProduto.Controls.Add(this.lblProduto);
            this.panelProduto.Location = new System.Drawing.Point(2, 2);
            this.panelProduto.Name = "panelProduto";
            this.panelProduto.Size = new System.Drawing.Size(1110, 48);
            this.panelProduto.TabIndex = 8;
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduto.ForeColor = System.Drawing.Color.White;
            this.lblProduto.Location = new System.Drawing.Point(4, 8);
            this.lblProduto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(119, 32);
            this.lblProduto.TabIndex = 1;
            this.lblProduto.Text = "Produtos";
            this.lblProduto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(12, 582);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(118, 42);
            this.btnIncluir.TabIndex = 9;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(288, 582);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(118, 42);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txbPesquisa
            // 
            this.txbPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPesquisa.Location = new System.Drawing.Point(12, 85);
            this.txbPesquisa.Multiline = true;
            this.txbPesquisa.Name = "txbPesquisa";
            this.txbPesquisa.Size = new System.Drawing.Size(730, 38);
            this.txbPesquisa.TabIndex = 14;
            this.txbPesquisa.TextChanged += new System.EventHandler(this.txbPesquisa_TextChanged);
            // 
            // lblPesquisa
            // 
            this.lblPesquisa.AutoSize = true;
            this.lblPesquisa.Location = new System.Drawing.Point(12, 62);
            this.lblPesquisa.Name = "lblPesquisa";
            this.lblPesquisa.Size = new System.Drawing.Size(74, 20);
            this.lblPesquisa.TabIndex = 20;
            this.lblPesquisa.Text = "Pesquisa";
            // 
            // comboBoxPesquisaProd
            // 
            this.comboBoxPesquisaProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxPesquisaProd.FormattingEnabled = true;
            this.comboBoxPesquisaProd.Items.AddRange(new object[] {
            "Nome_Produto",
            "Descricao"});
            this.comboBoxPesquisaProd.Location = new System.Drawing.Point(750, 85);
            this.comboBoxPesquisaProd.Name = "comboBoxPesquisaProd";
            this.comboBoxPesquisaProd.Size = new System.Drawing.Size(342, 34);
            this.comboBoxPesquisaProd.TabIndex = 21;
            // 
            // dtgViewProduto
            // 
            this.dtgViewProduto.AllowUserToAddRows = false;
            this.dtgViewProduto.AllowUserToDeleteRows = false;
            this.dtgViewProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgViewProduto.Location = new System.Drawing.Point(12, 152);
            this.dtgViewProduto.Name = "dtgViewProduto";
            this.dtgViewProduto.ReadOnly = true;
            this.dtgViewProduto.RowHeadersWidth = 62;
            this.dtgViewProduto.RowTemplate.Height = 28;
            this.dtgViewProduto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgViewProduto.Size = new System.Drawing.Size(1086, 409);
            this.dtgViewProduto.TabIndex = 22;
            this.dtgViewProduto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgViewProduto_CellContentClick_1);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizar.Location = new System.Drawing.Point(150, 582);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(118, 42);
            this.btnAtualizar.TabIndex = 23;
            this.btnAtualizar.Text = "Consultar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click_1);
            // 
            // FrmConsultaProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1110, 635);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.dtgViewProduto);
            this.Controls.Add(this.comboBoxPesquisaProd);
            this.Controls.Add(this.lblPesquisa);
            this.Controls.Add(this.txbPesquisa);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(this.panelProduto);
            this.MaximizeBox = false;
            this.Name = "FrmConsultaProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmConsultaProduto";
            this.Load += new System.EventHandler(this.FrmConsultaProduto_Load);
            this.panelProduto.ResumeLayout(false);
            this.panelProduto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgViewProduto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelProduto;
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txbPesquisa;
        private System.Windows.Forms.Label lblPesquisa;
        private System.Windows.Forms.ComboBox comboBoxPesquisaProd;
        private System.Windows.Forms.DataGridView dtgViewProduto;
        private System.Windows.Forms.Button btnAtualizar;
    }
}