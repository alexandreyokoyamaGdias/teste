namespace SGPPC.Views.Cadastros
{
    partial class FrmCadastroFuncionario
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
            this.lblNomeFuncionario = new System.Windows.Forms.Label();
            this.lblCadastroTelefone = new System.Windows.Forms.Label();
            this.lblCadastroCPF = new System.Windows.Forms.Label();
            this.lblCadastroEndereco = new System.Windows.Forms.Label();
            this.lblCadastroCargo = new System.Windows.Forms.Label();
            this.txbCadastroNome = new System.Windows.Forms.TextBox();
            this.txbCadastroTelefone = new System.Windows.Forms.TextBox();
            this.txbCadastrarCPF = new System.Windows.Forms.TextBox();
            this.txbCadastroEndereco = new System.Windows.Forms.TextBox();
            this.cbbCadastrarCargo = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCadastroFuncionarioNovo = new System.Windows.Forms.Button();
            this.btnCadastroFuncionarioSalvar = new System.Windows.Forms.Button();
            this.btnCadastroFuncionarioEditar = new System.Windows.Forms.Button();
            this.btnCadastroFuncionarioExcluir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNomeFuncionario
            // 
            this.lblNomeFuncionario.AutoSize = true;
            this.lblNomeFuncionario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeFuncionario.Location = new System.Drawing.Point(18, 29);
            this.lblNomeFuncionario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomeFuncionario.Name = "lblNomeFuncionario";
            this.lblNomeFuncionario.Size = new System.Drawing.Size(83, 32);
            this.lblNomeFuncionario.TabIndex = 0;
            this.lblNomeFuncionario.Text = "Nome";
            // 
            // lblCadastroTelefone
            // 
            this.lblCadastroTelefone.AutoSize = true;
            this.lblCadastroTelefone.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastroTelefone.Location = new System.Drawing.Point(12, 100);
            this.lblCadastroTelefone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCadastroTelefone.Name = "lblCadastroTelefone";
            this.lblCadastroTelefone.Size = new System.Drawing.Size(111, 32);
            this.lblCadastroTelefone.TabIndex = 1;
            this.lblCadastroTelefone.Text = "Telefone";
            // 
            // lblCadastroCPF
            // 
            this.lblCadastroCPF.AutoSize = true;
            this.lblCadastroCPF.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastroCPF.Location = new System.Drawing.Point(798, 40);
            this.lblCadastroCPF.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCadastroCPF.Name = "lblCadastroCPF";
            this.lblCadastroCPF.Size = new System.Drawing.Size(56, 32);
            this.lblCadastroCPF.TabIndex = 2;
            this.lblCadastroCPF.Text = "CPF";
            // 
            // lblCadastroEndereco
            // 
            this.lblCadastroEndereco.AutoSize = true;
            this.lblCadastroEndereco.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastroEndereco.Location = new System.Drawing.Point(12, 169);
            this.lblCadastroEndereco.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCadastroEndereco.Name = "lblCadastroEndereco";
            this.lblCadastroEndereco.Size = new System.Drawing.Size(120, 32);
            this.lblCadastroEndereco.TabIndex = 3;
            this.lblCadastroEndereco.Text = "Endereço";
            // 
            // lblCadastroCargo
            // 
            this.lblCadastroCargo.AutoSize = true;
            this.lblCadastroCargo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastroCargo.Location = new System.Drawing.Point(772, 109);
            this.lblCadastroCargo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCadastroCargo.Name = "lblCadastroCargo";
            this.lblCadastroCargo.Size = new System.Drawing.Size(82, 32);
            this.lblCadastroCargo.TabIndex = 4;
            this.lblCadastroCargo.Text = "Cargo";
            // 
            // txbCadastroNome
            // 
            this.txbCadastroNome.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbCadastroNome.Location = new System.Drawing.Point(112, 29);
            this.txbCadastroNome.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbCadastroNome.Multiline = true;
            this.txbCadastroNome.Name = "txbCadastroNome";
            this.txbCadastroNome.Size = new System.Drawing.Size(589, 41);
            this.txbCadastroNome.TabIndex = 5;
            // 
            // txbCadastroTelefone
            // 
            this.txbCadastroTelefone.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbCadastroTelefone.Location = new System.Drawing.Point(135, 100);
            this.txbCadastroTelefone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbCadastroTelefone.Multiline = true;
            this.txbCadastroTelefone.Name = "txbCadastroTelefone";
            this.txbCadastroTelefone.Size = new System.Drawing.Size(252, 39);
            this.txbCadastroTelefone.TabIndex = 6;
            // 
            // txbCadastrarCPF
            // 
            this.txbCadastrarCPF.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbCadastrarCPF.Location = new System.Drawing.Point(864, 34);
            this.txbCadastrarCPF.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbCadastrarCPF.Multiline = true;
            this.txbCadastrarCPF.Name = "txbCadastrarCPF";
            this.txbCadastrarCPF.Size = new System.Drawing.Size(322, 39);
            this.txbCadastrarCPF.TabIndex = 7;
            // 
            // txbCadastroEndereco
            // 
            this.txbCadastroEndereco.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbCadastroEndereco.Location = new System.Drawing.Point(142, 169);
            this.txbCadastroEndereco.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbCadastroEndereco.Multiline = true;
            this.txbCadastroEndereco.Name = "txbCadastroEndereco";
            this.txbCadastroEndereco.Size = new System.Drawing.Size(589, 41);
            this.txbCadastroEndereco.TabIndex = 8;
            // 
            // cbbCadastrarCargo
            // 
            this.cbbCadastrarCargo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbCadastrarCargo.FormattingEnabled = true;
            this.cbbCadastrarCargo.Location = new System.Drawing.Point(864, 109);
            this.cbbCadastrarCargo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbbCadastrarCargo.Name = "cbbCadastrarCargo";
            this.cbbCadastrarCargo.Size = new System.Drawing.Size(322, 28);
            this.cbbCadastrarCargo.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 288);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(1686, 669);
            this.dataGridView1.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(1382, 18);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(321, 260);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // btnCadastroFuncionarioNovo
            // 
            this.btnCadastroFuncionarioNovo.Location = new System.Drawing.Point(22, 982);
            this.btnCadastroFuncionarioNovo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCadastroFuncionarioNovo.Name = "btnCadastroFuncionarioNovo";
            this.btnCadastroFuncionarioNovo.Size = new System.Drawing.Size(178, 62);
            this.btnCadastroFuncionarioNovo.TabIndex = 12;
            this.btnCadastroFuncionarioNovo.Text = "Novo";
            this.btnCadastroFuncionarioNovo.UseVisualStyleBackColor = true;
            // 
            // btnCadastroFuncionarioSalvar
            // 
            this.btnCadastroFuncionarioSalvar.Location = new System.Drawing.Point(210, 982);
            this.btnCadastroFuncionarioSalvar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCadastroFuncionarioSalvar.Name = "btnCadastroFuncionarioSalvar";
            this.btnCadastroFuncionarioSalvar.Size = new System.Drawing.Size(178, 62);
            this.btnCadastroFuncionarioSalvar.TabIndex = 13;
            this.btnCadastroFuncionarioSalvar.Text = "Salvar";
            this.btnCadastroFuncionarioSalvar.UseVisualStyleBackColor = true;
            // 
            // btnCadastroFuncionarioEditar
            // 
            this.btnCadastroFuncionarioEditar.Location = new System.Drawing.Point(398, 983);
            this.btnCadastroFuncionarioEditar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCadastroFuncionarioEditar.Name = "btnCadastroFuncionarioEditar";
            this.btnCadastroFuncionarioEditar.Size = new System.Drawing.Size(178, 62);
            this.btnCadastroFuncionarioEditar.TabIndex = 14;
            this.btnCadastroFuncionarioEditar.Text = "Editar";
            this.btnCadastroFuncionarioEditar.UseVisualStyleBackColor = true;
            // 
            // btnCadastroFuncionarioExcluir
            // 
            this.btnCadastroFuncionarioExcluir.Location = new System.Drawing.Point(585, 985);
            this.btnCadastroFuncionarioExcluir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCadastroFuncionarioExcluir.Name = "btnCadastroFuncionarioExcluir";
            this.btnCadastroFuncionarioExcluir.Size = new System.Drawing.Size(178, 60);
            this.btnCadastroFuncionarioExcluir.TabIndex = 15;
            this.btnCadastroFuncionarioExcluir.Text = "Excluir";
            this.btnCadastroFuncionarioExcluir.UseVisualStyleBackColor = true;
            // 
            // FrmCadastroFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1720, 1063);
            this.Controls.Add(this.btnCadastroFuncionarioExcluir);
            this.Controls.Add(this.btnCadastroFuncionarioEditar);
            this.Controls.Add(this.btnCadastroFuncionarioSalvar);
            this.Controls.Add(this.btnCadastroFuncionarioNovo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cbbCadastrarCargo);
            this.Controls.Add(this.txbCadastroEndereco);
            this.Controls.Add(this.txbCadastrarCPF);
            this.Controls.Add(this.txbCadastroTelefone);
            this.Controls.Add(this.txbCadastroNome);
            this.Controls.Add(this.lblCadastroCargo);
            this.Controls.Add(this.lblCadastroEndereco);
            this.Controls.Add(this.lblCadastroCPF);
            this.Controls.Add(this.lblCadastroTelefone);
            this.Controls.Add(this.lblNomeFuncionario);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FrmCadastroFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCadastroFuncionario";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomeFuncionario;
        private System.Windows.Forms.Label lblCadastroTelefone;
        private System.Windows.Forms.Label lblCadastroCPF;
        private System.Windows.Forms.Label lblCadastroEndereco;
        private System.Windows.Forms.Label lblCadastroCargo;
        private System.Windows.Forms.TextBox txbCadastroNome;
        private System.Windows.Forms.TextBox txbCadastroTelefone;
        private System.Windows.Forms.TextBox txbCadastrarCPF;
        private System.Windows.Forms.TextBox txbCadastroEndereco;
        private System.Windows.Forms.ComboBox cbbCadastrarCargo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCadastroFuncionarioNovo;
        private System.Windows.Forms.Button btnCadastroFuncionarioSalvar;
        private System.Windows.Forms.Button btnCadastroFuncionarioEditar;
        private System.Windows.Forms.Button btnCadastroFuncionarioExcluir;
    }
}