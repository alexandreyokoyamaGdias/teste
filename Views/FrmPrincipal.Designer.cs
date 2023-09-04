namespace SGPPC
{
    partial class FrmPrincipal
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuCadastros = new System.Windows.Forms.ToolStripMenuItem();
            this.fornecedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CadastroPedidos = new System.Windows.Forms.ToolStripMenuItem();
            this.CadastroFormasDePagamento = new System.Windows.Forms.ToolStripMenuItem();
            this.CadastroPerfil = new System.Windows.Forms.ToolStripMenuItem();
            this.CadastroDeUsuário = new System.Windows.Forms.ToolStripMenuItem();
            this.cargosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuRelatórios = new System.Windows.Forms.ToolStripMenuItem();
            this.RelatórioFluxoDeCaixa = new System.Windows.Forms.ToolStripMenuItem();
            this.RelatórioVenda = new System.Windows.Forms.ToolStripMenuItem();
            this.RelatórioEstoque = new System.Windows.Forms.ToolStripMenuItem();
            this.usuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSair = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlCabecalhoSistema = new System.Windows.Forms.Panel();
            this.lblData = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.pnlCabecalhoSistema.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuCadastros,
            this.MenuRelatórios,
            this.usuárioToolStripMenuItem,
            this.MenuSair});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1742, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuCadastros
            // 
            this.MenuCadastros.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fornecedorToolStripMenuItem,
            this.produtoToolStripMenuItem,
            this.CadastroPedidos,
            this.CadastroFormasDePagamento,
            this.CadastroPerfil,
            this.CadastroDeUsuário,
            this.cargosToolStripMenuItem});
            this.MenuCadastros.Name = "MenuCadastros";
            this.MenuCadastros.Size = new System.Drawing.Size(107, 29);
            this.MenuCadastros.Text = "Cadastros";
            // 
            // fornecedorToolStripMenuItem
            // 
            this.fornecedorToolStripMenuItem.Name = "fornecedorToolStripMenuItem";
            this.fornecedorToolStripMenuItem.Size = new System.Drawing.Size(293, 34);
            this.fornecedorToolStripMenuItem.Text = "Fornecedor";
            this.fornecedorToolStripMenuItem.Click += new System.EventHandler(this.fornecedorToolStripMenuItem_Click);
            // 
            // produtoToolStripMenuItem
            // 
            this.produtoToolStripMenuItem.Name = "produtoToolStripMenuItem";
            this.produtoToolStripMenuItem.Size = new System.Drawing.Size(293, 34);
            this.produtoToolStripMenuItem.Text = "Produto";
            this.produtoToolStripMenuItem.Click += new System.EventHandler(this.produtoToolStripMenuItem_Click);
            // 
            // CadastroPedidos
            // 
            this.CadastroPedidos.Name = "CadastroPedidos";
            this.CadastroPedidos.Size = new System.Drawing.Size(293, 34);
            this.CadastroPedidos.Text = "Pedido";
            this.CadastroPedidos.Click += new System.EventHandler(this.CadastroPedidos_Click);
            // 
            // CadastroFormasDePagamento
            // 
            this.CadastroFormasDePagamento.Name = "CadastroFormasDePagamento";
            this.CadastroFormasDePagamento.Size = new System.Drawing.Size(293, 34);
            this.CadastroFormasDePagamento.Text = "Formas de Pagamento";
            // 
            // CadastroPerfil
            // 
            this.CadastroPerfil.Name = "CadastroPerfil";
            this.CadastroPerfil.Size = new System.Drawing.Size(293, 34);
            this.CadastroPerfil.Text = "Perfil";
            // 
            // CadastroDeUsuário
            // 
            this.CadastroDeUsuário.Name = "CadastroDeUsuário";
            this.CadastroDeUsuário.Size = new System.Drawing.Size(293, 34);
            this.CadastroDeUsuário.Text = "Usuário";
            // 
            // cargosToolStripMenuItem
            // 
            this.cargosToolStripMenuItem.Name = "cargosToolStripMenuItem";
            this.cargosToolStripMenuItem.Size = new System.Drawing.Size(293, 34);
            this.cargosToolStripMenuItem.Text = "Cargos";
            // 
            // MenuRelatórios
            // 
            this.MenuRelatórios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RelatórioFluxoDeCaixa,
            this.RelatórioVenda,
            this.RelatórioEstoque});
            this.MenuRelatórios.Name = "MenuRelatórios";
            this.MenuRelatórios.Size = new System.Drawing.Size(98, 29);
            this.MenuRelatórios.Text = "Relatório";
            // 
            // RelatórioFluxoDeCaixa
            // 
            this.RelatórioFluxoDeCaixa.Name = "RelatórioFluxoDeCaixa";
            this.RelatórioFluxoDeCaixa.Size = new System.Drawing.Size(227, 34);
            this.RelatórioFluxoDeCaixa.Text = "Fluxo de Caixa";
            // 
            // RelatórioVenda
            // 
            this.RelatórioVenda.Name = "RelatórioVenda";
            this.RelatórioVenda.Size = new System.Drawing.Size(227, 34);
            this.RelatórioVenda.Text = "Venda";
            // 
            // RelatórioEstoque
            // 
            this.RelatórioEstoque.Name = "RelatórioEstoque";
            this.RelatórioEstoque.Size = new System.Drawing.Size(227, 34);
            this.RelatórioEstoque.Text = "Estoque";
            // 
            // usuárioToolStripMenuItem
            // 
            this.usuárioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarToolStripMenuItem,
            this.consultarToolStripMenuItem,
            this.alterarToolStripMenuItem2,
            this.excluirToolStripMenuItem2});
            this.usuárioToolStripMenuItem.Name = "usuárioToolStripMenuItem";
            this.usuárioToolStripMenuItem.Size = new System.Drawing.Size(88, 29);
            this.usuárioToolStripMenuItem.Text = "Usuário";
            // 
            // cadastrarToolStripMenuItem
            // 
            this.cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            this.cadastrarToolStripMenuItem.Size = new System.Drawing.Size(189, 34);
            this.cadastrarToolStripMenuItem.Text = "Cadastrar";
            // 
            // consultarToolStripMenuItem
            // 
            this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            this.consultarToolStripMenuItem.Size = new System.Drawing.Size(189, 34);
            this.consultarToolStripMenuItem.Text = "Consultar";
            // 
            // alterarToolStripMenuItem2
            // 
            this.alterarToolStripMenuItem2.Name = "alterarToolStripMenuItem2";
            this.alterarToolStripMenuItem2.Size = new System.Drawing.Size(189, 34);
            this.alterarToolStripMenuItem2.Text = "Alterar";
            // 
            // excluirToolStripMenuItem2
            // 
            this.excluirToolStripMenuItem2.Name = "excluirToolStripMenuItem2";
            this.excluirToolStripMenuItem2.Size = new System.Drawing.Size(189, 34);
            this.excluirToolStripMenuItem2.Text = "Excluir";
            // 
            // MenuSair
            // 
            this.MenuSair.Name = "MenuSair";
            this.MenuSair.Size = new System.Drawing.Size(57, 29);
            this.MenuSair.Text = "Sair";
            this.MenuSair.Click += new System.EventHandler(this.MenuSair_Click);
            // 
            // pnlCabecalhoSistema
            // 
            this.pnlCabecalhoSistema.BackColor = System.Drawing.Color.Orange;
            this.pnlCabecalhoSistema.Controls.Add(this.lblData);
            this.pnlCabecalhoSistema.Controls.Add(this.lblHora);
            this.pnlCabecalhoSistema.Controls.Add(this.button5);
            this.pnlCabecalhoSistema.Controls.Add(this.button4);
            this.pnlCabecalhoSistema.Controls.Add(this.button3);
            this.pnlCabecalhoSistema.Controls.Add(this.button2);
            this.pnlCabecalhoSistema.Controls.Add(this.button1);
            this.pnlCabecalhoSistema.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCabecalhoSistema.Location = new System.Drawing.Point(0, 33);
            this.pnlCabecalhoSistema.Name = "pnlCabecalhoSistema";
            this.pnlCabecalhoSistema.Size = new System.Drawing.Size(1742, 62);
            this.pnlCabecalhoSistema.TabIndex = 1;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblData.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.lblData.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblData.Location = new System.Drawing.Point(1338, 0);
            this.lblData.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(231, 54);
            this.lblData.TabIndex = 6;
            this.lblData.Text = "00/00/0000";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblHora.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.lblHora.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblHora.Location = new System.Drawing.Point(1569, 0);
            this.lblHora.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(173, 54);
            this.lblHora.TabIndex = 5;
            this.lblHora.Text = "00:00:00";
            // 
            // button5
            // 
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Image = global::SGPPC.Properties.Resources.iconRecibo;
            this.button5.Location = new System.Drawing.Point(240, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(60, 54);
            this.button5.TabIndex = 4;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Image = global::SGPPC.Properties.Resources.iconSair;
            this.button4.Location = new System.Drawing.Point(316, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(60, 54);
            this.button4.TabIndex = 3;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = global::SGPPC.Properties.Resources.iconCarCompras;
            this.button3.Location = new System.Drawing.Point(88, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(60, 54);
            this.button3.TabIndex = 2;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::SGPPC.Properties.Resources.iconDocumento;
            this.button2.Location = new System.Drawing.Point(164, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(60, 54);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::SGPPC.Properties.Resources.iconUser;
            this.button1.Location = new System.Drawing.Point(12, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 54);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe UI Emoji", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 183);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1706, 214);
            this.label1.TabIndex = 2;
            this.label1.Text = "Salgadaria e Pastelaria Ponto Certo";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::SGPPC.Properties.Resources.iconCompras;
            this.pictureBox1.Location = new System.Drawing.Point(18, 402);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1706, 238);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1742, 712);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlCabecalhoSistema);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlCabecalhoSistema.ResumeLayout(false);
            this.pnlCabecalhoSistema.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuCadastros;
        private System.Windows.Forms.ToolStripMenuItem CadastroPedidos;
        private System.Windows.Forms.ToolStripMenuItem MenuRelatórios;
        private System.Windows.Forms.ToolStripMenuItem MenuSair;
        private System.Windows.Forms.ToolStripMenuItem CadastroFormasDePagamento;
        private System.Windows.Forms.ToolStripMenuItem CadastroDeUsuário;
        private System.Windows.Forms.ToolStripMenuItem RelatórioFluxoDeCaixa;
        private System.Windows.Forms.ToolStripMenuItem RelatórioVenda;
        private System.Windows.Forms.ToolStripMenuItem RelatórioEstoque;
        private System.Windows.Forms.ToolStripMenuItem CadastroPerfil;
        private System.Windows.Forms.Panel pnlCabecalhoSistema;
        private System.Windows.Forms.ToolStripMenuItem cargosToolStripMenuItem;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem usuárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alterarToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem excluirToolStripMenuItem2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ToolStripMenuItem fornecedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtoToolStripMenuItem;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

