namespace SGPPC.Views.Usuarios
{
    partial class FrmConsultaUsuario
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
            this.btnConsultar = new System.Windows.Forms.Button();
            this.dtgViewUsuarios = new System.Windows.Forms.DataGridView();
            this.comboBoxPesquisaUsuario = new System.Windows.Forms.ComboBox();
            this.lblPesquisa = new System.Windows.Forms.Label();
            this.txbPesquisaUsuario = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.panelProduto = new System.Windows.Forms.Panel();
            this.lblUsuarios = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgViewUsuarios)).BeginInit();
            this.panelProduto.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConsultar
            // 
            this.btnConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.Location = new System.Drawing.Point(99, 381);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(2);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(79, 27);
            this.btnConsultar.TabIndex = 31;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // dtgViewUsuarios
            // 
            this.dtgViewUsuarios.AllowUserToAddRows = false;
            this.dtgViewUsuarios.AllowUserToDeleteRows = false;
            this.dtgViewUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgViewUsuarios.Location = new System.Drawing.Point(7, 102);
            this.dtgViewUsuarios.Margin = new System.Windows.Forms.Padding(2);
            this.dtgViewUsuarios.Name = "dtgViewUsuarios";
            this.dtgViewUsuarios.ReadOnly = true;
            this.dtgViewUsuarios.RowHeadersWidth = 62;
            this.dtgViewUsuarios.RowTemplate.Height = 28;
            this.dtgViewUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgViewUsuarios.Size = new System.Drawing.Size(724, 266);
            this.dtgViewUsuarios.TabIndex = 30;
            this.dtgViewUsuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgViewUsuarios_CellContentClick);
            // 
            // comboBoxPesquisaUsuario
            // 
            this.comboBoxPesquisaUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxPesquisaUsuario.FormattingEnabled = true;
            this.comboBoxPesquisaUsuario.Items.AddRange(new object[] {
            "Nome",
            "CPF",
            "Funcao"});
            this.comboBoxPesquisaUsuario.Location = new System.Drawing.Point(499, 58);
            this.comboBoxPesquisaUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxPesquisaUsuario.Name = "comboBoxPesquisaUsuario";
            this.comboBoxPesquisaUsuario.Size = new System.Drawing.Size(229, 26);
            this.comboBoxPesquisaUsuario.TabIndex = 29;
            // 
            // lblPesquisa
            // 
            this.lblPesquisa.AutoSize = true;
            this.lblPesquisa.Location = new System.Drawing.Point(7, 43);
            this.lblPesquisa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPesquisa.Name = "lblPesquisa";
            this.lblPesquisa.Size = new System.Drawing.Size(50, 13);
            this.lblPesquisa.TabIndex = 28;
            this.lblPesquisa.Text = "Pesquisa";
            // 
            // txbPesquisaUsuario
            // 
            this.txbPesquisaUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPesquisaUsuario.Location = new System.Drawing.Point(7, 58);
            this.txbPesquisaUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.txbPesquisaUsuario.Multiline = true;
            this.txbPesquisaUsuario.Name = "txbPesquisaUsuario";
            this.txbPesquisaUsuario.Size = new System.Drawing.Size(488, 26);
            this.txbPesquisaUsuario.TabIndex = 27;
            this.txbPesquisaUsuario.TextChanged += new System.EventHandler(this.txbPesquisaUsuario_TextChanged);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(191, 381);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(79, 27);
            this.btnCancelar.TabIndex = 26;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(7, 381);
            this.btnIncluir.Margin = new System.Windows.Forms.Padding(2);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(79, 27);
            this.btnIncluir.TabIndex = 25;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // panelProduto
            // 
            this.panelProduto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelProduto.BackColor = System.Drawing.Color.Orange;
            this.panelProduto.Controls.Add(this.lblUsuarios);
            this.panelProduto.Location = new System.Drawing.Point(0, 0);
            this.panelProduto.Margin = new System.Windows.Forms.Padding(2);
            this.panelProduto.Name = "panelProduto";
            this.panelProduto.Size = new System.Drawing.Size(740, 31);
            this.panelProduto.TabIndex = 24;
            // 
            // lblUsuarios
            // 
            this.lblUsuarios.AutoSize = true;
            this.lblUsuarios.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarios.ForeColor = System.Drawing.Color.White;
            this.lblUsuarios.Location = new System.Drawing.Point(3, 5);
            this.lblUsuarios.Name = "lblUsuarios";
            this.lblUsuarios.Size = new System.Drawing.Size(76, 21);
            this.lblUsuarios.TabIndex = 1;
            this.lblUsuarios.Text = "Usuários";
            this.lblUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmConsultaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 413);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.dtgViewUsuarios);
            this.Controls.Add(this.comboBoxPesquisaUsuario);
            this.Controls.Add(this.lblPesquisa);
            this.Controls.Add(this.txbPesquisaUsuario);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(this.panelProduto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmConsultaUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmConsultaUsuario";
            this.Load += new System.EventHandler(this.FrmConsultaUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgViewUsuarios)).EndInit();
            this.panelProduto.ResumeLayout(false);
            this.panelProduto.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.DataGridView dtgViewUsuarios;
        private System.Windows.Forms.ComboBox comboBoxPesquisaUsuario;
        private System.Windows.Forms.Label lblPesquisa;
        private System.Windows.Forms.TextBox txbPesquisaUsuario;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Panel panelProduto;
        private System.Windows.Forms.Label lblUsuarios;
    }
}