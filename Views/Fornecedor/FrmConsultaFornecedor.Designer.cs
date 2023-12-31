﻿namespace SGPPC.Views.Fornecedor
{
    partial class FrmConsultaFornecedor
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
            this.lblFornecedor = new System.Windows.Forms.Label();
            this.dgFornecedor = new System.Windows.Forms.DataGridView();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panelFornecedor = new System.Windows.Forms.Panel();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtPesquisaFornecedor = new System.Windows.Forms.TextBox();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.comboBoxPesquisarFornecedor = new System.Windows.Forms.ComboBox();
            this.lblPesquisar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgFornecedor)).BeginInit();
            this.panelFornecedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFornecedor
            // 
            this.lblFornecedor.AutoSize = true;
            this.lblFornecedor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFornecedor.ForeColor = System.Drawing.Color.White;
            this.lblFornecedor.Location = new System.Drawing.Point(4, 8);
            this.lblFornecedor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFornecedor.Name = "lblFornecedor";
            this.lblFornecedor.Size = new System.Drawing.Size(168, 32);
            this.lblFornecedor.TabIndex = 1;
            this.lblFornecedor.Text = "Fornecedores";
            this.lblFornecedor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgFornecedor
            // 
            this.dgFornecedor.AllowUserToAddRows = false;
            this.dgFornecedor.AllowUserToDeleteRows = false;
            this.dgFornecedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgFornecedor.Location = new System.Drawing.Point(12, 157);
            this.dgFornecedor.Name = "dgFornecedor";
            this.dgFornecedor.ReadOnly = true;
            this.dgFornecedor.RowHeadersWidth = 62;
            this.dgFornecedor.RowTemplate.Height = 28;
            this.dgFornecedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgFornecedor.Size = new System.Drawing.Size(1086, 409);
            this.dgFornecedor.TabIndex = 2;
            this.dgFornecedor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgFornecedor_CellContentClick);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(12, 582);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(118, 42);
            this.btnSalvar.TabIndex = 3;
            this.btnSalvar.Text = "Incluir";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(285, 582);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(118, 42);
            this.button4.TabIndex = 6;
            this.button4.Text = "Cancelar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // panelFornecedor
            // 
            this.panelFornecedor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelFornecedor.BackColor = System.Drawing.Color.Orange;
            this.panelFornecedor.Controls.Add(this.lblFornecedor);
            this.panelFornecedor.Location = new System.Drawing.Point(2, 2);
            this.panelFornecedor.Name = "panelFornecedor";
            this.panelFornecedor.Size = new System.Drawing.Size(1108, 51);
            this.panelFornecedor.TabIndex = 7;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPesquisar.Location = new System.Drawing.Point(795, 1309);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(118, 42);
            this.btnPesquisar.TabIndex = 8;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Nome",
            "CNPJ",
            "Pais",
            "Cidade",
            "Estado"});
            this.comboBox1.Location = new System.Drawing.Point(1362, 122);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(284, 40);
            this.comboBox1.TabIndex = 10;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtPesquisaFornecedor
            // 
            this.txtPesquisaFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisaFornecedor.Location = new System.Drawing.Point(12, 89);
            this.txtPesquisaFornecedor.Multiline = true;
            this.txtPesquisaFornecedor.Name = "txtPesquisaFornecedor";
            this.txtPesquisaFornecedor.Size = new System.Drawing.Size(730, 38);
            this.txtPesquisaFornecedor.TabIndex = 11;
            this.txtPesquisaFornecedor.TextChanged += new System.EventHandler(this.txtPesquisaFornecedor_TextChanged);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(148, 582);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(118, 42);
            this.btnAtualizar.TabIndex = 12;
            this.btnAtualizar.Text = "Consultar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // comboBoxPesquisarFornecedor
            // 
            this.comboBoxPesquisarFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxPesquisarFornecedor.FormattingEnabled = true;
            this.comboBoxPesquisarFornecedor.Items.AddRange(new object[] {
            "Nome",
            "CNPJ"});
            this.comboBoxPesquisarFornecedor.Location = new System.Drawing.Point(750, 89);
            this.comboBoxPesquisarFornecedor.Name = "comboBoxPesquisarFornecedor";
            this.comboBoxPesquisarFornecedor.Size = new System.Drawing.Size(346, 34);
            this.comboBoxPesquisarFornecedor.TabIndex = 13;
            // 
            // lblPesquisar
            // 
            this.lblPesquisar.AutoSize = true;
            this.lblPesquisar.Location = new System.Drawing.Point(8, 66);
            this.lblPesquisar.Name = "lblPesquisar";
            this.lblPesquisar.Size = new System.Drawing.Size(79, 20);
            this.lblPesquisar.TabIndex = 14;
            this.lblPesquisar.Text = "Pesquisar";
            // 
            // FrmConsultaFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(1108, 635);
            this.Controls.Add(this.lblPesquisar);
            this.Controls.Add(this.comboBoxPesquisarFornecedor);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.txtPesquisaFornecedor);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.panelFornecedor);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.dgFornecedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmConsultaFornecedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmConsultaFornecedor";
            this.Load += new System.EventHandler(this.FrmConsultaFornecedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgFornecedor)).EndInit();
            this.panelFornecedor.ResumeLayout(false);
            this.panelFornecedor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFornecedor;
        private System.Windows.Forms.DataGridView dgFornecedor;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panelFornecedor;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtPesquisaFornecedor;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.ComboBox comboBoxPesquisarFornecedor;
        private System.Windows.Forms.Label lblPesquisar;
    }
}