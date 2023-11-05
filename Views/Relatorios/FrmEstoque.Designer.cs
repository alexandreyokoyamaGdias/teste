namespace SGPPC.Views.Relatorios
{
    partial class FrmEstoque
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
            this.btnGerarRelatorio = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblPesquisar = new System.Windows.Forms.Label();
            this.comboBoxPesquisarEstoque = new System.Windows.Forms.ComboBox();
            this.txtPesquisaEstoque = new System.Windows.Forms.TextBox();
            this.dgEstoque = new System.Windows.Forms.DataGridView();
            this.panelEstoque = new System.Windows.Forms.Panel();
            this.lblEstoque = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgEstoque)).BeginInit();
            this.panelEstoque.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGerarRelatorio
            // 
            this.btnGerarRelatorio.Location = new System.Drawing.Point(287, 579);
            this.btnGerarRelatorio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGerarRelatorio.Name = "btnGerarRelatorio";
            this.btnGerarRelatorio.Size = new System.Drawing.Size(130, 42);
            this.btnGerarRelatorio.TabIndex = 31;
            this.btnGerarRelatorio.Text = "Gerar Relatório";
            this.btnGerarRelatorio.UseVisualStyleBackColor = true;
            this.btnGerarRelatorio.Click += new System.EventHandler(this.btnGerarRelatorio_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(12, 580);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(118, 42);
            this.btnConsultar.TabIndex = 30;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(149, 580);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(118, 42);
            this.btnCancelar.TabIndex = 29;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblPesquisar
            // 
            this.lblPesquisar.AutoSize = true;
            this.lblPesquisar.Location = new System.Drawing.Point(8, 65);
            this.lblPesquisar.Name = "lblPesquisar";
            this.lblPesquisar.Size = new System.Drawing.Size(79, 20);
            this.lblPesquisar.TabIndex = 28;
            this.lblPesquisar.Text = "Pesquisar";
            // 
            // comboBoxPesquisarEstoque
            // 
            this.comboBoxPesquisarEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxPesquisarEstoque.FormattingEnabled = true;
            this.comboBoxPesquisarEstoque.Items.AddRange(new object[] {
            "Nome_Produto"});
            this.comboBoxPesquisarEstoque.Location = new System.Drawing.Point(750, 88);
            this.comboBoxPesquisarEstoque.Name = "comboBoxPesquisarEstoque";
            this.comboBoxPesquisarEstoque.Size = new System.Drawing.Size(346, 34);
            this.comboBoxPesquisarEstoque.TabIndex = 27;
            // 
            // txtPesquisaEstoque
            // 
            this.txtPesquisaEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisaEstoque.Location = new System.Drawing.Point(12, 88);
            this.txtPesquisaEstoque.Multiline = true;
            this.txtPesquisaEstoque.Name = "txtPesquisaEstoque";
            this.txtPesquisaEstoque.Size = new System.Drawing.Size(730, 38);
            this.txtPesquisaEstoque.TabIndex = 26;
            // 
            // dgEstoque
            // 
            this.dgEstoque.AllowUserToAddRows = false;
            this.dgEstoque.AllowUserToDeleteRows = false;
            this.dgEstoque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEstoque.Location = new System.Drawing.Point(12, 156);
            this.dgEstoque.Name = "dgEstoque";
            this.dgEstoque.ReadOnly = true;
            this.dgEstoque.RowHeadersWidth = 62;
            this.dgEstoque.RowTemplate.Height = 28;
            this.dgEstoque.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgEstoque.Size = new System.Drawing.Size(1086, 409);
            this.dgEstoque.TabIndex = 25;
            // 
            // panelEstoque
            // 
            this.panelEstoque.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelEstoque.BackColor = System.Drawing.Color.Orange;
            this.panelEstoque.Controls.Add(this.lblEstoque);
            this.panelEstoque.Location = new System.Drawing.Point(2, 2);
            this.panelEstoque.Name = "panelEstoque";
            this.panelEstoque.Size = new System.Drawing.Size(1108, 51);
            this.panelEstoque.TabIndex = 32;
            // 
            // lblEstoque
            // 
            this.lblEstoque.AutoSize = true;
            this.lblEstoque.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstoque.ForeColor = System.Drawing.Color.White;
            this.lblEstoque.Location = new System.Drawing.Point(4, 8);
            this.lblEstoque.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEstoque.Name = "lblEstoque";
            this.lblEstoque.Size = new System.Drawing.Size(105, 32);
            this.lblEstoque.TabIndex = 1;
            this.lblEstoque.Text = "Estoque";
            this.lblEstoque.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 635);
            this.Controls.Add(this.panelEstoque);
            this.Controls.Add(this.btnGerarRelatorio);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblPesquisar);
            this.Controls.Add(this.comboBoxPesquisarEstoque);
            this.Controls.Add(this.txtPesquisaEstoque);
            this.Controls.Add(this.dgEstoque);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmEstoque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmEstoque";
            this.Load += new System.EventHandler(this.FrmEstoque_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgEstoque)).EndInit();
            this.panelEstoque.ResumeLayout(false);
            this.panelEstoque.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGerarRelatorio;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblPesquisar;
        private System.Windows.Forms.ComboBox comboBoxPesquisarEstoque;
        private System.Windows.Forms.TextBox txtPesquisaEstoque;
        private System.Windows.Forms.DataGridView dgEstoque;
        private System.Windows.Forms.Panel panelEstoque;
        private System.Windows.Forms.Label lblEstoque;
    }
}