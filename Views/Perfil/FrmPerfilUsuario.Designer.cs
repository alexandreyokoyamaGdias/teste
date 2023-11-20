namespace SGPPC.Views.Perfil
{
    partial class FrmPerfilUsuario
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
            this.panelPerfilUsuario = new System.Windows.Forms.Panel();
            this.lblPerfilUsuario = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.lblFuncao = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxCPF = new System.Windows.Forms.TextBox();
            this.textBoxFuncao = new System.Windows.Forms.TextBox();
            this.maskedTextBoxData = new System.Windows.Forms.MaskedTextBox();
            this.lblDataAdmissao = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.panelPerfilUsuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPerfilUsuario
            // 
            this.panelPerfilUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelPerfilUsuario.BackColor = System.Drawing.Color.Orange;
            this.panelPerfilUsuario.Controls.Add(this.lblPerfilUsuario);
            this.panelPerfilUsuario.Location = new System.Drawing.Point(1, 1);
            this.panelPerfilUsuario.Name = "panelPerfilUsuario";
            this.panelPerfilUsuario.Size = new System.Drawing.Size(552, 51);
            this.panelPerfilUsuario.TabIndex = 9;
            // 
            // lblPerfilUsuario
            // 
            this.lblPerfilUsuario.AutoSize = true;
            this.lblPerfilUsuario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerfilUsuario.ForeColor = System.Drawing.Color.White;
            this.lblPerfilUsuario.Location = new System.Drawing.Point(4, 8);
            this.lblPerfilUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPerfilUsuario.Name = "lblPerfilUsuario";
            this.lblPerfilUsuario.Size = new System.Drawing.Size(287, 32);
            this.lblPerfilUsuario.TabIndex = 1;
            this.lblPerfilUsuario.Text = "Informações do usuário";
            this.lblPerfilUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(12, 67);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(51, 20);
            this.lblNome.TabIndex = 10;
            this.lblNome.Text = "Nome";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(287, 67);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(53, 20);
            this.lblEmail.TabIndex = 11;
            this.lblEmail.Text = "E-mail";
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(12, 135);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(40, 20);
            this.lblCPF.TabIndex = 12;
            this.lblCPF.Text = "CPF";
            // 
            // lblFuncao
            // 
            this.lblFuncao.AutoSize = true;
            this.lblFuncao.Location = new System.Drawing.Point(287, 135);
            this.lblFuncao.Name = "lblFuncao";
            this.lblFuncao.Size = new System.Drawing.Size(63, 20);
            this.lblFuncao.TabIndex = 13;
            this.lblFuncao.Text = "Função";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(16, 90);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.ReadOnly = true;
            this.textBoxNome.Size = new System.Drawing.Size(257, 26);
            this.textBoxNome.TabIndex = 14;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(291, 90);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.ReadOnly = true;
            this.textBoxEmail.Size = new System.Drawing.Size(251, 26);
            this.textBoxEmail.TabIndex = 15;
            // 
            // textBoxCPF
            // 
            this.textBoxCPF.Location = new System.Drawing.Point(16, 158);
            this.textBoxCPF.Name = "textBoxCPF";
            this.textBoxCPF.ReadOnly = true;
            this.textBoxCPF.Size = new System.Drawing.Size(257, 26);
            this.textBoxCPF.TabIndex = 16;
            // 
            // textBoxFuncao
            // 
            this.textBoxFuncao.Location = new System.Drawing.Point(291, 158);
            this.textBoxFuncao.Name = "textBoxFuncao";
            this.textBoxFuncao.ReadOnly = true;
            this.textBoxFuncao.Size = new System.Drawing.Size(251, 26);
            this.textBoxFuncao.TabIndex = 17;
            // 
            // maskedTextBoxData
            // 
            this.maskedTextBoxData.Location = new System.Drawing.Point(16, 227);
            this.maskedTextBoxData.Mask = "00/00/0000";
            this.maskedTextBoxData.Name = "maskedTextBoxData";
            this.maskedTextBoxData.ReadOnly = true;
            this.maskedTextBoxData.Size = new System.Drawing.Size(257, 26);
            this.maskedTextBoxData.TabIndex = 18;
            this.maskedTextBoxData.ValidatingType = typeof(System.DateTime);
            // 
            // lblDataAdmissao
            // 
            this.lblDataAdmissao.AutoSize = true;
            this.lblDataAdmissao.Location = new System.Drawing.Point(12, 204);
            this.lblDataAdmissao.Name = "lblDataAdmissao";
            this.lblDataAdmissao.Size = new System.Drawing.Size(118, 20);
            this.lblDataAdmissao.TabIndex = 19;
            this.lblDataAdmissao.Text = "Data Admissão";
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(12, 401);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(121, 42);
            this.btnVoltar.TabIndex = 20;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // FrmPerfilUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 455);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.lblDataAdmissao);
            this.Controls.Add(this.maskedTextBoxData);
            this.Controls.Add(this.textBoxFuncao);
            this.Controls.Add(this.textBoxCPF);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.lblFuncao);
            this.Controls.Add(this.lblCPF);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.panelPerfilUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmPerfilUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPerfilUsuario";
            this.Load += new System.EventHandler(this.FrmPerfilUsuario_Load);
            this.panelPerfilUsuario.ResumeLayout(false);
            this.panelPerfilUsuario.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelPerfilUsuario;
        private System.Windows.Forms.Label lblPerfilUsuario;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Label lblFuncao;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxCPF;
        private System.Windows.Forms.TextBox textBoxFuncao;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxData;
        private System.Windows.Forms.Label lblDataAdmissao;
        private System.Windows.Forms.Button btnVoltar;
    }
}