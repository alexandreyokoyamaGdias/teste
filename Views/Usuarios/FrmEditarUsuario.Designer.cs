namespace SGPPC.Views.Usuarios
{
    partial class FrmEditarUsuario
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
            this.txbEmailEdit = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txbSenhaEdit = new System.Windows.Forms.TextBox();
            this.lblFuncao = new System.Windows.Forms.Label();
            this.cbFuncaoEdit = new System.Windows.Forms.ComboBox();
            this.lblDataHoraAdmissao = new System.Windows.Forms.Label();
            this.maskDataHoraAdmissaoEdit = new System.Windows.Forms.MaskedTextBox();
            this.maskCPFEdit = new System.Windows.Forms.MaskedTextBox();
            this.panelProduto = new System.Windows.Forms.Panel();
            this.lblProduto = new System.Windows.Forms.Label();
            this.txbNomeEdit = new System.Windows.Forms.TextBox();
            this.lblCNPJ = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.panelProduto.SuspendLayout();
            this.SuspendLayout();
            // 
            // txbEmailEdit
            // 
            this.txbEmailEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbEmailEdit.Location = new System.Drawing.Point(215, 64);
            this.txbEmailEdit.Margin = new System.Windows.Forms.Padding(2);
            this.txbEmailEdit.Name = "txbEmailEdit";
            this.txbEmailEdit.Size = new System.Drawing.Size(193, 23);
            this.txbEmailEdit.TabIndex = 51;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(96, 317);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(79, 27);
            this.btnLimpar.TabIndex = 50;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(11, 131);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(42, 13);
            this.lblSenha.TabIndex = 49;
            this.lblSenha.Text = "*Senha";
            // 
            // txbSenhaEdit
            // 
            this.txbSenhaEdit.Location = new System.Drawing.Point(11, 147);
            this.txbSenhaEdit.Name = "txbSenhaEdit";
            this.txbSenhaEdit.PasswordChar = '*';
            this.txbSenhaEdit.Size = new System.Drawing.Size(193, 20);
            this.txbSenhaEdit.TabIndex = 48;
            // 
            // lblFuncao
            // 
            this.lblFuncao.AutoSize = true;
            this.lblFuncao.Location = new System.Drawing.Point(212, 92);
            this.lblFuncao.Name = "lblFuncao";
            this.lblFuncao.Size = new System.Drawing.Size(47, 13);
            this.lblFuncao.TabIndex = 47;
            this.lblFuncao.Text = "*Função";
            // 
            // cbFuncaoEdit
            // 
            this.cbFuncaoEdit.FormattingEnabled = true;
            this.cbFuncaoEdit.Items.AddRange(new object[] {
            "Administrador",
            "Padrão"});
            this.cbFuncaoEdit.Location = new System.Drawing.Point(215, 108);
            this.cbFuncaoEdit.Name = "cbFuncaoEdit";
            this.cbFuncaoEdit.Size = new System.Drawing.Size(193, 21);
            this.cbFuncaoEdit.TabIndex = 46;
            // 
            // lblDataHoraAdmissao
            // 
            this.lblDataHoraAdmissao.AutoSize = true;
            this.lblDataHoraAdmissao.Location = new System.Drawing.Point(212, 132);
            this.lblDataHoraAdmissao.Name = "lblDataHoraAdmissao";
            this.lblDataHoraAdmissao.Size = new System.Drawing.Size(110, 13);
            this.lblDataHoraAdmissao.TabIndex = 45;
            this.lblDataHoraAdmissao.Text = "*Data/Hora Admissão";
            // 
            // maskDataHoraAdmissaoEdit
            // 
            this.maskDataHoraAdmissaoEdit.Location = new System.Drawing.Point(215, 148);
            this.maskDataHoraAdmissaoEdit.Mask = "00/00/0000 90:00";
            this.maskDataHoraAdmissaoEdit.Name = "maskDataHoraAdmissaoEdit";
            this.maskDataHoraAdmissaoEdit.Size = new System.Drawing.Size(193, 20);
            this.maskDataHoraAdmissaoEdit.TabIndex = 44;
            this.maskDataHoraAdmissaoEdit.ValidatingType = typeof(System.DateTime);
            // 
            // maskCPFEdit
            // 
            this.maskCPFEdit.Location = new System.Drawing.Point(11, 108);
            this.maskCPFEdit.Mask = "000.000.000-00";
            this.maskCPFEdit.Name = "maskCPFEdit";
            this.maskCPFEdit.Size = new System.Drawing.Size(193, 20);
            this.maskCPFEdit.TabIndex = 43;
            // 
            // panelProduto
            // 
            this.panelProduto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelProduto.BackColor = System.Drawing.Color.Orange;
            this.panelProduto.Controls.Add(this.lblProduto);
            this.panelProduto.Location = new System.Drawing.Point(-1, 2);
            this.panelProduto.Margin = new System.Windows.Forms.Padding(2);
            this.panelProduto.Name = "panelProduto";
            this.panelProduto.Size = new System.Drawing.Size(422, 31);
            this.panelProduto.TabIndex = 42;
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
            // txbNomeEdit
            // 
            this.txbNomeEdit.Location = new System.Drawing.Point(11, 64);
            this.txbNomeEdit.Multiline = true;
            this.txbNomeEdit.Name = "txbNomeEdit";
            this.txbNomeEdit.Size = new System.Drawing.Size(193, 23);
            this.txbNomeEdit.TabIndex = 41;
            // 
            // lblCNPJ
            // 
            this.lblCNPJ.AutoSize = true;
            this.lblCNPJ.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCNPJ.Location = new System.Drawing.Point(11, 90);
            this.lblCNPJ.Name = "lblCNPJ";
            this.lblCNPJ.Size = new System.Drawing.Size(33, 15);
            this.lblCNPJ.TabIndex = 40;
            this.lblCNPJ.Text = "*CPF";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(212, 47);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(44, 15);
            this.lblEmail.TabIndex = 39;
            this.lblEmail.Text = "*Email";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(11, 47);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(44, 15);
            this.lblNome.TabIndex = 38;
            this.lblNome.Text = "*Nome";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(184, 317);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(77, 27);
            this.btnCancelar.TabIndex = 37;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(7, 317);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(79, 27);
            this.btnCadastrar.TabIndex = 36;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            // 
            // FrmEditarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 347);
            this.Controls.Add(this.txbEmailEdit);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.txbSenhaEdit);
            this.Controls.Add(this.lblFuncao);
            this.Controls.Add(this.cbFuncaoEdit);
            this.Controls.Add(this.lblDataHoraAdmissao);
            this.Controls.Add(this.maskDataHoraAdmissaoEdit);
            this.Controls.Add(this.maskCPFEdit);
            this.Controls.Add(this.panelProduto);
            this.Controls.Add(this.txbNomeEdit);
            this.Controls.Add(this.lblCNPJ);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnCadastrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmEditarUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmEditarUsuario";
            this.panelProduto.ResumeLayout(false);
            this.panelProduto.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbEmailEdit;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txbSenhaEdit;
        private System.Windows.Forms.Label lblFuncao;
        private System.Windows.Forms.ComboBox cbFuncaoEdit;
        private System.Windows.Forms.Label lblDataHoraAdmissao;
        private System.Windows.Forms.MaskedTextBox maskDataHoraAdmissaoEdit;
        private System.Windows.Forms.MaskedTextBox maskCPFEdit;
        private System.Windows.Forms.Panel panelProduto;
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.TextBox txbNomeEdit;
        private System.Windows.Forms.Label lblCNPJ;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnCadastrar;
    }
}