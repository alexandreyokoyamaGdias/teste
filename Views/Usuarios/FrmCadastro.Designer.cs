namespace SGPPC.Views.Usuarios
{
    partial class FrmCadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastro));
            this.ptbCadastro = new System.Windows.Forms.PictureBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblComfirmarSenha = new System.Windows.Forms.Label();
            this.txbSenha = new System.Windows.Forms.TextBox();
            this.txbComfirmarSenha = new System.Windows.Forms.TextBox();
            this.txbLogin = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCadastro)).BeginInit();
            this.SuspendLayout();
            // 
            // ptbCadastro
            // 
            this.ptbCadastro.Image = ((System.Drawing.Image)(resources.GetObject("ptbCadastro.Image")));
            this.ptbCadastro.Location = new System.Drawing.Point(143, 12);
            this.ptbCadastro.Name = "ptbCadastro";
            this.ptbCadastro.Size = new System.Drawing.Size(117, 113);
            this.ptbCadastro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbCadastro.TabIndex = 1;
            this.ptbCadastro.TabStop = false;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(93, 409);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(106, 39);
            this.btnCadastrar.TabIndex = 2;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(205, 409);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(106, 39);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.Location = new System.Drawing.Point(90, 168);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(36, 15);
            this.lblLogin.TabIndex = 4;
            this.lblLogin.Text = "Login";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.Location = new System.Drawing.Point(90, 222);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(40, 15);
            this.lblSenha.TabIndex = 5;
            this.lblSenha.Text = "Senha";
            // 
            // lblComfirmarSenha
            // 
            this.lblComfirmarSenha.AutoSize = true;
            this.lblComfirmarSenha.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComfirmarSenha.Location = new System.Drawing.Point(90, 273);
            this.lblComfirmarSenha.Name = "lblComfirmarSenha";
            this.lblComfirmarSenha.Size = new System.Drawing.Size(101, 15);
            this.lblComfirmarSenha.TabIndex = 6;
            this.lblComfirmarSenha.Text = "Comfirmar Senha";
            // 
            // txbSenha
            // 
            this.txbSenha.Location = new System.Drawing.Point(93, 240);
            this.txbSenha.Multiline = true;
            this.txbSenha.Name = "txbSenha";
            this.txbSenha.PasswordChar = '*';
            this.txbSenha.Size = new System.Drawing.Size(213, 26);
            this.txbSenha.TabIndex = 7;
            // 
            // txbComfirmarSenha
            // 
            this.txbComfirmarSenha.Location = new System.Drawing.Point(93, 291);
            this.txbComfirmarSenha.Multiline = true;
            this.txbComfirmarSenha.Name = "txbComfirmarSenha";
            this.txbComfirmarSenha.PasswordChar = '*';
            this.txbComfirmarSenha.Size = new System.Drawing.Size(213, 26);
            this.txbComfirmarSenha.TabIndex = 8;
            // 
            // txbLogin
            // 
            this.txbLogin.Location = new System.Drawing.Point(93, 186);
            this.txbLogin.Multiline = true;
            this.txbLogin.Name = "txbLogin";
            this.txbLogin.Size = new System.Drawing.Size(213, 26);
            this.txbLogin.TabIndex = 9;
            // 
            // FrmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(412, 460);
            this.Controls.Add(this.txbLogin);
            this.Controls.Add(this.txbComfirmarSenha);
            this.Controls.Add(this.txbSenha);
            this.Controls.Add(this.lblComfirmarSenha);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.ptbCadastro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCadastro";
            ((System.ComponentModel.ISupportInitialize)(this.ptbCadastro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptbCadastro;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblComfirmarSenha;
        private System.Windows.Forms.TextBox txbSenha;
        private System.Windows.Forms.TextBox txbComfirmarSenha;
        private System.Windows.Forms.TextBox txbLogin;
    }
}