namespace SGPPC.Views.Sabores
{
    partial class FrmAlterarSabores
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
            this.lblSabor = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.txbAlterarDescricao = new System.Windows.Forms.TextBox();
            this.btnCancelarSabor = new System.Windows.Forms.Button();
            this.btnLimparSabor = new System.Windows.Forms.Button();
            this.btnAlterarSabor = new System.Windows.Forms.Button();
            this.txbId = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Orange;
            this.panel2.Controls.Add(this.lblSabor);
            this.panel2.Location = new System.Drawing.Point(1, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(631, 48);
            this.panel2.TabIndex = 17;
            // 
            // lblSabor
            // 
            this.lblSabor.AutoSize = true;
            this.lblSabor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSabor.ForeColor = System.Drawing.Color.White;
            this.lblSabor.Location = new System.Drawing.Point(5, 8);
            this.lblSabor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSabor.Name = "lblSabor";
            this.lblSabor.Size = new System.Drawing.Size(80, 32);
            this.lblSabor.TabIndex = 1;
            this.lblSabor.Text = "Sabor";
            this.lblSabor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(8, 63);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(86, 20);
            this.lblDescricao.TabIndex = 30;
            this.lblDescricao.Text = "*Descrição";
            // 
            // txbAlterarDescricao
            // 
            this.txbAlterarDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbAlterarDescricao.Location = new System.Drawing.Point(12, 86);
            this.txbAlterarDescricao.Name = "txbAlterarDescricao";
            this.txbAlterarDescricao.Size = new System.Drawing.Size(604, 30);
            this.txbAlterarDescricao.TabIndex = 29;
            // 
            // btnCancelarSabor
            // 
            this.btnCancelarSabor.Location = new System.Drawing.Point(280, 480);
            this.btnCancelarSabor.Name = "btnCancelarSabor";
            this.btnCancelarSabor.Size = new System.Drawing.Size(118, 42);
            this.btnCancelarSabor.TabIndex = 41;
            this.btnCancelarSabor.Text = "Cancelar";
            this.btnCancelarSabor.UseVisualStyleBackColor = true;
            this.btnCancelarSabor.Click += new System.EventHandler(this.btnCancelarSabor_Click);
            // 
            // btnLimparSabor
            // 
            this.btnLimparSabor.Location = new System.Drawing.Point(147, 480);
            this.btnLimparSabor.Name = "btnLimparSabor";
            this.btnLimparSabor.Size = new System.Drawing.Size(118, 42);
            this.btnLimparSabor.TabIndex = 40;
            this.btnLimparSabor.Text = "Limpar";
            this.btnLimparSabor.UseVisualStyleBackColor = true;
            this.btnLimparSabor.Click += new System.EventHandler(this.btnLimparSabor_Click);
            // 
            // btnAlterarSabor
            // 
            this.btnAlterarSabor.Location = new System.Drawing.Point(15, 480);
            this.btnAlterarSabor.Name = "btnAlterarSabor";
            this.btnAlterarSabor.Size = new System.Drawing.Size(118, 42);
            this.btnAlterarSabor.TabIndex = 39;
            this.btnAlterarSabor.Text = "Alterar";
            this.btnAlterarSabor.UseVisualStyleBackColor = true;
            this.btnAlterarSabor.Click += new System.EventHandler(this.btnAlterarSabor_Click);
            // 
            // txbId
            // 
            this.txbId.Location = new System.Drawing.Point(559, 496);
            this.txbId.Name = "txbId";
            this.txbId.ReadOnly = true;
            this.txbId.Size = new System.Drawing.Size(57, 26);
            this.txbId.TabIndex = 42;
            this.txbId.Visible = false;
            // 
            // FrmAlterarSabores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(632, 534);
            this.Controls.Add(this.txbId);
            this.Controls.Add(this.btnCancelarSabor);
            this.Controls.Add(this.btnLimparSabor);
            this.Controls.Add(this.btnAlterarSabor);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.txbAlterarDescricao);
            this.Controls.Add(this.panel2);
            this.MaximizeBox = false;
            this.Name = "FrmAlterarSabores";
            this.Text = "FrmAlterarSabores";
            this.Load += new System.EventHandler(this.FrmAlterarSabores_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblSabor;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.TextBox txbAlterarDescricao;
        private System.Windows.Forms.Button btnCancelarSabor;
        private System.Windows.Forms.Button btnLimparSabor;
        private System.Windows.Forms.Button btnAlterarSabor;
        private System.Windows.Forms.TextBox txbId;
    }
}