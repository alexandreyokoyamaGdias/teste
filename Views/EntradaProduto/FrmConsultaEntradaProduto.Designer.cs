namespace SGPPC.Views.EntradaProduto
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
            this.panelEntradaProduto = new System.Windows.Forms.Panel();
            this.lblEntradaProduto = new System.Windows.Forms.Label();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.dgEntradaProduto = new System.Windows.Forms.DataGridView();
            this.lblPesquisar = new System.Windows.Forms.Label();
            this.comboBoxPesquisarEntradaProduto = new System.Windows.Forms.ComboBox();
            this.txtPesquisaEntradaProduto = new System.Windows.Forms.TextBox();
            this.panelEntradaProduto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgEntradaProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEntradaProduto
            // 
            this.panelEntradaProduto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelEntradaProduto.BackColor = System.Drawing.Color.Orange;
            this.panelEntradaProduto.Controls.Add(this.lblEntradaProduto);
            this.panelEntradaProduto.Location = new System.Drawing.Point(2, 2);
            this.panelEntradaProduto.Name = "panelEntradaProduto";
            this.panelEntradaProduto.Size = new System.Drawing.Size(1108, 51);
            this.panelEntradaProduto.TabIndex = 8;
            // 
            // lblEntradaProduto
            // 
            this.lblEntradaProduto.AutoSize = true;
            this.lblEntradaProduto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntradaProduto.ForeColor = System.Drawing.Color.White;
            this.lblEntradaProduto.Location = new System.Drawing.Point(4, 8);
            this.lblEntradaProduto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEntradaProduto.Name = "lblEntradaProduto";
            this.lblEntradaProduto.Size = new System.Drawing.Size(124, 32);
            this.lblEntradaProduto.TabIndex = 1;
            this.lblEntradaProduto.Text = "Consultar";
            this.lblEntradaProduto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.dgEntradaProduto.TabIndex = 16;
            this.dgEntradaProduto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgEntradaProduto_CellContentClick);
            // 
            // lblPesquisar
            // 
            this.lblPesquisar.AutoSize = true;
            this.lblPesquisar.Location = new System.Drawing.Point(8, 66);
            this.lblPesquisar.Name = "lblPesquisar";
            this.lblPesquisar.Size = new System.Drawing.Size(79, 20);
            this.lblPesquisar.TabIndex = 19;
            this.lblPesquisar.Text = "Pesquisar";
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
            this.comboBoxPesquisarEntradaProduto.TabIndex = 18;
            // 
            // txtPesquisaEntradaProduto
            // 
            this.txtPesquisaEntradaProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisaEntradaProduto.Location = new System.Drawing.Point(12, 89);
            this.txtPesquisaEntradaProduto.Multiline = true;
            this.txtPesquisaEntradaProduto.Name = "txtPesquisaEntradaProduto";
            this.txtPesquisaEntradaProduto.Size = new System.Drawing.Size(730, 38);
            this.txtPesquisaEntradaProduto.TabIndex = 17;
            this.txtPesquisaEntradaProduto.TextChanged += new System.EventHandler(this.txtPesquisaEntradaProduto_TextChanged);
            // 
            // FrmConsultaEntradaProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 635);
            this.Controls.Add(this.lblPesquisar);
            this.Controls.Add(this.comboBoxPesquisarEntradaProduto);
            this.Controls.Add(this.txtPesquisaEntradaProduto);
            this.Controls.Add(this.dgEntradaProduto);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(this.panelEntradaProduto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmConsultaEntradaProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmConsultaEntradaProduto";
            this.Load += new System.EventHandler(this.FrmConsultaEntradaProduto_Load);
            this.panelEntradaProduto.ResumeLayout(false);
            this.panelEntradaProduto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgEntradaProduto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelEntradaProduto;
        private System.Windows.Forms.Label lblEntradaProduto;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.DataGridView dgEntradaProduto;
        private System.Windows.Forms.Label lblPesquisar;
        private System.Windows.Forms.ComboBox comboBoxPesquisarEntradaProduto;
        private System.Windows.Forms.TextBox txtPesquisaEntradaProduto;
    }
}