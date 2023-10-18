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
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblCNPJ = new System.Windows.Forms.Label();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.panelProduto = new System.Windows.Forms.Panel();
            this.lblProduto = new System.Windows.Forms.Label();
            this.maskCPF = new System.Windows.Forms.MaskedTextBox();
            this.maskDataHoraAdmissao = new System.Windows.Forms.MaskedTextBox();
            this.lblDataHoraAdmissao = new System.Windows.Forms.Label();
            this.cbFuncao = new System.Windows.Forms.ComboBox();
            this.lblFuncao = new System.Windows.Forms.Label();
            this.txbSenha = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.panelProduto.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(8, 315);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(79, 27);
            this.btnCadastrar.TabIndex = 2;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(185, 315);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(77, 27);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(12, 45);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(44, 15);
            this.lblNome.TabIndex = 4;
            this.lblNome.Text = "*Nome";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(213, 45);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(44, 15);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "*Email";
            // 
            // lblCNPJ
            // 
            this.lblCNPJ.AutoSize = true;
            this.lblCNPJ.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCNPJ.Location = new System.Drawing.Point(12, 88);
            this.lblCNPJ.Name = "lblCNPJ";
            this.lblCNPJ.Size = new System.Drawing.Size(33, 15);
            this.lblCNPJ.TabIndex = 6;
            this.lblCNPJ.Text = "*CPF";
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(12, 62);
            this.txbNome.Multiline = true;
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(193, 23);
            this.txbNome.TabIndex = 7;
            // 
            // panelProduto
            // 
            this.panelProduto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelProduto.BackColor = System.Drawing.Color.Orange;
            this.panelProduto.Controls.Add(this.lblProduto);
            this.panelProduto.Location = new System.Drawing.Point(0, 0);
            this.panelProduto.Margin = new System.Windows.Forms.Padding(2);
            this.panelProduto.Name = "panelProduto";
            this.panelProduto.Size = new System.Drawing.Size(422, 31);
            this.panelProduto.TabIndex = 11;
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduto.ForeColor = System.Drawing.Color.White;
            this.lblProduto.Location = new System.Drawing.Point(3, 5);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(163, 21);
            this.lblProduto.TabIndex = 1;
            this.lblProduto.Text = "Cadastro de Usuário";
            this.lblProduto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // maskCPF
            // 
            this.maskCPF.Location = new System.Drawing.Point(12, 106);
            this.maskCPF.Mask = "000.000.000-00";
            this.maskCPF.Name = "maskCPF";
            this.maskCPF.Size = new System.Drawing.Size(193, 20);
            this.maskCPF.TabIndex = 12;
            // 
            // maskDataHoraAdmissao
            // 
            this.maskDataHoraAdmissao.Location = new System.Drawing.Point(216, 146);
            this.maskDataHoraAdmissao.Mask = "00/00/0000 90:00";
            this.maskDataHoraAdmissao.Name = "maskDataHoraAdmissao";
            this.maskDataHoraAdmissao.Size = new System.Drawing.Size(193, 20);
            this.maskDataHoraAdmissao.TabIndex = 13;
            this.maskDataHoraAdmissao.ValidatingType = typeof(System.DateTime);
            // 
            // lblDataHoraAdmissao
            // 
            this.lblDataHoraAdmissao.AutoSize = true;
            this.lblDataHoraAdmissao.Location = new System.Drawing.Point(213, 130);
            this.lblDataHoraAdmissao.Name = "lblDataHoraAdmissao";
            this.lblDataHoraAdmissao.Size = new System.Drawing.Size(110, 13);
            this.lblDataHoraAdmissao.TabIndex = 14;
            this.lblDataHoraAdmissao.Text = "*Data/Hora Admissão";
            // 
            // cbFuncao
            // 
            this.cbFuncao.FormattingEnabled = true;
            this.cbFuncao.Items.AddRange(new object[] {
            "Administrador",
            "Padrão"});
            this.cbFuncao.Location = new System.Drawing.Point(216, 106);
            this.cbFuncao.Name = "cbFuncao";
            this.cbFuncao.Size = new System.Drawing.Size(193, 21);
            this.cbFuncao.TabIndex = 15;
            // 
            // lblFuncao
            // 
            this.lblFuncao.AutoSize = true;
            this.lblFuncao.Location = new System.Drawing.Point(213, 90);
            this.lblFuncao.Name = "lblFuncao";
            this.lblFuncao.Size = new System.Drawing.Size(47, 13);
            this.lblFuncao.TabIndex = 16;
            this.lblFuncao.Text = "*Função";
            // 
            // txbSenha
            // 
            this.txbSenha.Location = new System.Drawing.Point(12, 145);
            this.txbSenha.Name = "txbSenha";
            this.txbSenha.PasswordChar = '*';
            this.txbSenha.Size = new System.Drawing.Size(193, 20);
            this.txbSenha.TabIndex = 18;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(12, 129);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(42, 13);
            this.lblSenha.TabIndex = 19;
            this.lblSenha.Text = "*Senha";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(97, 315);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(79, 27);
            this.btnLimpar.TabIndex = 20;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // txbEmail
            // 
            this.txbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbEmail.Location = new System.Drawing.Point(216, 62);
            this.txbEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(193, 23);
            this.txbEmail.TabIndex = 35;
            // 
            // FrmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(421, 347);
            this.Controls.Add(this.txbEmail);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.txbSenha);
            this.Controls.Add(this.lblFuncao);
            this.Controls.Add(this.cbFuncao);
            this.Controls.Add(this.lblDataHoraAdmissao);
            this.Controls.Add(this.maskDataHoraAdmissao);
            this.Controls.Add(this.maskCPF);
            this.Controls.Add(this.panelProduto);
            this.Controls.Add(this.txbNome);
            this.Controls.Add(this.lblCNPJ);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnCadastrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCadastro";
            this.Load += new System.EventHandler(this.FrmCadastro_Load);
            this.panelProduto.ResumeLayout(false);
            this.panelProduto.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblCNPJ;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.Panel panelProduto;
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.MaskedTextBox maskCPF;
        private System.Windows.Forms.MaskedTextBox maskDataHoraAdmissao;
        private System.Windows.Forms.Label lblDataHoraAdmissao;
        private System.Windows.Forms.ComboBox cbFuncao;
        private System.Windows.Forms.Label lblFuncao;
        private System.Windows.Forms.TextBox txbSenha;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.TextBox txbEmail;
    }
}