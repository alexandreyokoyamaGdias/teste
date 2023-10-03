namespace SGPPC.Views.Sabores
{
    partial class FrmConsultaSabores
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblSabores = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.btnAtualizarSabor = new System.Windows.Forms.Button();
            this.txbPesquisa = new System.Windows.Forms.TextBox();
            this.btnCancelarSabor = new System.Windows.Forms.Button();
            this.btnEditarSabor = new System.Windows.Forms.Button();
            this.btnSalvarSabor = new System.Windows.Forms.Button();
            this.dgSabor = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSabor)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Orange;
            this.panel2.Controls.Add(this.lblSabores);
            this.panel2.Location = new System.Drawing.Point(2, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1108, 48);
            this.panel2.TabIndex = 17;
            // 
            // lblSabores
            // 
            this.lblSabores.AutoSize = true;
            this.lblSabores.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSabores.ForeColor = System.Drawing.Color.White;
            this.lblSabores.Location = new System.Drawing.Point(5, 8);
            this.lblSabores.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSabores.Name = "lblSabores";
            this.lblSabores.Size = new System.Drawing.Size(80, 32);
            this.lblSabores.TabIndex = 1;
            this.lblSabores.Text = "Sabor";
            this.lblSabores.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(854, 77);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(176, 28);
            this.comboBox2.TabIndex = 24;
            // 
            // btnAtualizarSabor
            // 
            this.btnAtualizarSabor.Location = new System.Drawing.Point(422, 578);
            this.btnAtualizarSabor.Name = "btnAtualizarSabor";
            this.btnAtualizarSabor.Size = new System.Drawing.Size(118, 41);
            this.btnAtualizarSabor.TabIndex = 23;
            this.btnAtualizarSabor.Text = "Consultar";
            this.btnAtualizarSabor.UseVisualStyleBackColor = true;
            this.btnAtualizarSabor.Click += new System.EventHandler(this.btnAtualizarSabor_Click);
            // 
            // txbPesquisa
            // 
            this.txbPesquisa.Location = new System.Drawing.Point(11, 77);
            this.txbPesquisa.Multiline = true;
            this.txbPesquisa.Name = "txbPesquisa";
            this.txbPesquisa.Size = new System.Drawing.Size(818, 42);
            this.txbPesquisa.TabIndex = 22;
            // 
            // btnCancelarSabor
            // 
            this.btnCancelarSabor.Location = new System.Drawing.Point(284, 578);
            this.btnCancelarSabor.Name = "btnCancelarSabor";
            this.btnCancelarSabor.Size = new System.Drawing.Size(118, 42);
            this.btnCancelarSabor.TabIndex = 21;
            this.btnCancelarSabor.Text = "Cancelar";
            this.btnCancelarSabor.UseVisualStyleBackColor = true;
            this.btnCancelarSabor.Click += new System.EventHandler(this.btnCancelarSabor_Click);
            // 
            // btnEditarSabor
            // 
            this.btnEditarSabor.Location = new System.Drawing.Point(147, 578);
            this.btnEditarSabor.Name = "btnEditarSabor";
            this.btnEditarSabor.Size = new System.Drawing.Size(118, 42);
            this.btnEditarSabor.TabIndex = 20;
            this.btnEditarSabor.Text = "Alterar";
            this.btnEditarSabor.UseVisualStyleBackColor = true;
            // 
            // btnSalvarSabor
            // 
            this.btnSalvarSabor.Location = new System.Drawing.Point(11, 578);
            this.btnSalvarSabor.Name = "btnSalvarSabor";
            this.btnSalvarSabor.Size = new System.Drawing.Size(118, 42);
            this.btnSalvarSabor.TabIndex = 19;
            this.btnSalvarSabor.Text = "Incluir";
            this.btnSalvarSabor.UseVisualStyleBackColor = true;
            this.btnSalvarSabor.Click += new System.EventHandler(this.btnSalvarSabor_Click);
            // 
            // dgSabor
            // 
            this.dgSabor.AllowUserToAddRows = false;
            this.dgSabor.AllowUserToDeleteRows = false;
            this.dgSabor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSabor.Location = new System.Drawing.Point(11, 153);
            this.dgSabor.Name = "dgSabor";
            this.dgSabor.ReadOnly = true;
            this.dgSabor.RowHeadersWidth = 62;
            this.dgSabor.RowTemplate.Height = 28;
            this.dgSabor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgSabor.Size = new System.Drawing.Size(1086, 409);
            this.dgSabor.TabIndex = 18;
            // 
            // FrmConsultaSabores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 635);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.btnAtualizarSabor);
            this.Controls.Add(this.txbPesquisa);
            this.Controls.Add(this.btnCancelarSabor);
            this.Controls.Add(this.btnEditarSabor);
            this.Controls.Add(this.btnSalvarSabor);
            this.Controls.Add(this.dgSabor);
            this.Controls.Add(this.panel2);
            this.MaximizeBox = false;
            this.Name = "FrmConsultaSabores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmConsultaSabores";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSabor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblSabores;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button btnAtualizarSabor;
        private System.Windows.Forms.TextBox txbPesquisa;
        private System.Windows.Forms.Button btnCancelarSabor;
        private System.Windows.Forms.Button btnEditarSabor;
        private System.Windows.Forms.Button btnSalvarSabor;
        private System.Windows.Forms.DataGridView dgSabor;
    }
}