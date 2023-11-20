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
            this.pedidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entradaProdutoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaToolStripMenuItemFornecedor = new System.Windows.Forms.ToolStripMenuItem();
            this.produtoToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.saboresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formasDePagamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controleDeCaixaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entradaDeProdutoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoDeOperaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuRelatorios = new System.Windows.Forms.ToolStripMenuItem();
            this.RelatórioVenda = new System.Windows.Forms.ToolStripMenuItem();
            this.RelatórioEstoque = new System.Windows.Forms.ToolStripMenuItem();
            this.usuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarToolStripMenuItemCadastrar = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItemUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.perfilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.toolStripMenuStatus = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabelData = new System.Windows.Forms.ToolStripLabel();
            this.StatusData = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabelHora = new System.Windows.Forms.ToolStripLabel();
            this.StatusHora = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.StripLabelUsuario = new System.Windows.Forms.ToolStripLabel();
            this.StatusUsuarioLogado = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabelIdUser = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.StripLabelId = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBoxFuncao = new System.Windows.Forms.ToolStripLabel();
            this.timerStatus = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.pnlCabecalhoSistema.SuspendLayout();
            this.toolStripMenuStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pedidoToolStripMenuItem,
            this.entradaProdutoToolStripMenuItem,
            this.produtoToolStripMenuItem1,
            this.MenuRelatorios,
            this.usuarioToolStripMenuItem,
            this.MenuSair});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(1161, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pedidoToolStripMenuItem
            // 
            this.pedidoToolStripMenuItem.Name = "pedidoToolStripMenuItem";
            this.pedidoToolStripMenuItem.Size = new System.Drawing.Size(56, 22);
            this.pedidoToolStripMenuItem.Text = "Pedido";
            this.pedidoToolStripMenuItem.Click += new System.EventHandler(this.pedidoToolStripMenuItem_Click);
            // 
            // entradaProdutoToolStripMenuItem
            // 
            this.entradaProdutoToolStripMenuItem.Name = "entradaProdutoToolStripMenuItem";
            this.entradaProdutoToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.entradaProdutoToolStripMenuItem.Text = "Entrada Produto";
            this.entradaProdutoToolStripMenuItem.Click += new System.EventHandler(this.entradaProdutoToolStripMenuItem_Click);
            // 
            // produtoToolStripMenuItem1
            // 
            this.produtoToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultaToolStripMenuItemFornecedor,
            this.produtoToolStripMenu,
            this.saboresToolStripMenuItem,
            this.formasDePagamentoToolStripMenuItem,
            this.controleDeCaixaToolStripMenuItem,
            this.entradaDeProdutoToolStripMenuItem,
            this.tipoDeOperaçãoToolStripMenuItem});
            this.produtoToolStripMenuItem1.Name = "produtoToolStripMenuItem1";
            this.produtoToolStripMenuItem1.Size = new System.Drawing.Size(66, 22);
            this.produtoToolStripMenuItem1.Text = "Consulta";
            // 
            // consultaToolStripMenuItemFornecedor
            // 
            this.consultaToolStripMenuItemFornecedor.Name = "consultaToolStripMenuItemFornecedor";
            this.consultaToolStripMenuItemFornecedor.Size = new System.Drawing.Size(193, 22);
            this.consultaToolStripMenuItemFornecedor.Text = "Fornecedor";
            this.consultaToolStripMenuItemFornecedor.Click += new System.EventHandler(this.consultaToolStripMenuItem_Click);
            // 
            // produtoToolStripMenu
            // 
            this.produtoToolStripMenu.Name = "produtoToolStripMenu";
            this.produtoToolStripMenu.Size = new System.Drawing.Size(193, 22);
            this.produtoToolStripMenu.Text = "Produto";
            this.produtoToolStripMenu.Click += new System.EventHandler(this.produtoToolStripMenuItem2_Click);
            // 
            // saboresToolStripMenuItem
            // 
            this.saboresToolStripMenuItem.Name = "saboresToolStripMenuItem";
            this.saboresToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.saboresToolStripMenuItem.Text = "Sabor";
            this.saboresToolStripMenuItem.Click += new System.EventHandler(this.saboresToolStripMenuItem_Click);
            // 
            // formasDePagamentoToolStripMenuItem
            // 
            this.formasDePagamentoToolStripMenuItem.Name = "formasDePagamentoToolStripMenuItem";
            this.formasDePagamentoToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.formasDePagamentoToolStripMenuItem.Text = "Formas de Pagamento";
            this.formasDePagamentoToolStripMenuItem.Click += new System.EventHandler(this.formasDePagamentoToolStripMenuItem_Click);
            // 
            // controleDeCaixaToolStripMenuItem
            // 
            this.controleDeCaixaToolStripMenuItem.Name = "controleDeCaixaToolStripMenuItem";
            this.controleDeCaixaToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.controleDeCaixaToolStripMenuItem.Text = "Controle de Caixa";
            this.controleDeCaixaToolStripMenuItem.Click += new System.EventHandler(this.controleDeCaixaToolStripMenuItem_Click);
            // 
            // entradaDeProdutoToolStripMenuItem
            // 
            this.entradaDeProdutoToolStripMenuItem.Name = "entradaDeProdutoToolStripMenuItem";
            this.entradaDeProdutoToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.entradaDeProdutoToolStripMenuItem.Text = "Entrada de Produto";
            this.entradaDeProdutoToolStripMenuItem.Click += new System.EventHandler(this.entradaDeProdutoToolStripMenuItem_Click);
            // 
            // tipoDeOperaçãoToolStripMenuItem
            // 
            this.tipoDeOperaçãoToolStripMenuItem.Name = "tipoDeOperaçãoToolStripMenuItem";
            this.tipoDeOperaçãoToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.tipoDeOperaçãoToolStripMenuItem.Text = "Tipo de Operação";
            this.tipoDeOperaçãoToolStripMenuItem.Click += new System.EventHandler(this.tipoDeOperaçãoToolStripMenuItem_Click);
            // 
            // MenuRelatorios
            // 
            this.MenuRelatorios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RelatórioVenda,
            this.RelatórioEstoque});
            this.MenuRelatorios.Name = "MenuRelatorios";
            this.MenuRelatorios.Size = new System.Drawing.Size(66, 22);
            this.MenuRelatorios.Text = "Relatório";
            // 
            // RelatórioVenda
            // 
            this.RelatórioVenda.Name = "RelatórioVenda";
            this.RelatórioVenda.Size = new System.Drawing.Size(116, 22);
            this.RelatórioVenda.Text = "Venda";
            this.RelatórioVenda.Click += new System.EventHandler(this.RelatórioVenda_Click);
            // 
            // RelatórioEstoque
            // 
            this.RelatórioEstoque.Name = "RelatórioEstoque";
            this.RelatórioEstoque.Size = new System.Drawing.Size(116, 22);
            this.RelatórioEstoque.Text = "Estoque";
            this.RelatórioEstoque.Click += new System.EventHandler(this.RelatórioEstoque_Click);
            // 
            // usuarioToolStripMenuItem
            // 
            this.usuarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarToolStripMenuItemCadastrar,
            this.consultarToolStripMenuItemUsuario,
            this.perfilToolStripMenuItem});
            this.usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            this.usuarioToolStripMenuItem.Size = new System.Drawing.Size(59, 22);
            this.usuarioToolStripMenuItem.Text = "Usuário";
            // 
            // cadastrarToolStripMenuItemCadastrar
            // 
            this.cadastrarToolStripMenuItemCadastrar.Name = "cadastrarToolStripMenuItemCadastrar";
            this.cadastrarToolStripMenuItemCadastrar.Size = new System.Drawing.Size(125, 22);
            this.cadastrarToolStripMenuItemCadastrar.Text = "Cadastrar";
            this.cadastrarToolStripMenuItemCadastrar.Click += new System.EventHandler(this.cadastrarToolStripMenuItem_Click);
            // 
            // consultarToolStripMenuItemUsuario
            // 
            this.consultarToolStripMenuItemUsuario.Name = "consultarToolStripMenuItemUsuario";
            this.consultarToolStripMenuItemUsuario.Size = new System.Drawing.Size(125, 22);
            this.consultarToolStripMenuItemUsuario.Text = "Consultar";
            this.consultarToolStripMenuItemUsuario.Click += new System.EventHandler(this.consultarToolStripMenuItem_Click);
            // 
            // perfilToolStripMenuItem
            // 
            this.perfilToolStripMenuItem.Name = "perfilToolStripMenuItem";
            this.perfilToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.perfilToolStripMenuItem.Text = "Perfil";
            this.perfilToolStripMenuItem.Click += new System.EventHandler(this.perfilToolStripMenuItem_Click);
            // 
            // MenuSair
            // 
            this.MenuSair.Name = "MenuSair";
            this.MenuSair.Size = new System.Drawing.Size(38, 22);
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
            this.pnlCabecalhoSistema.Location = new System.Drawing.Point(0, 24);
            this.pnlCabecalhoSistema.Margin = new System.Windows.Forms.Padding(2);
            this.pnlCabecalhoSistema.Name = "pnlCabecalhoSistema";
            this.pnlCabecalhoSistema.Size = new System.Drawing.Size(1161, 40);
            this.pnlCabecalhoSistema.TabIndex = 1;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblData.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.lblData.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblData.Location = new System.Drawing.Point(883, 0);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(159, 37);
            this.lblData.TabIndex = 6;
            this.lblData.Text = "00/00/0000";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblHora.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.lblHora.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblHora.Location = new System.Drawing.Point(1042, 0);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(119, 37);
            this.lblHora.TabIndex = 5;
            this.lblHora.Text = "00:00:00";
            // 
            // button5
            // 
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Image = global::SGPPC.Properties.Resources.iconRecibo;
            this.button5.Location = new System.Drawing.Point(160, 2);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(40, 35);
            this.button5.TabIndex = 4;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Image = global::SGPPC.Properties.Resources.iconSair;
            this.button4.Location = new System.Drawing.Point(211, 2);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(40, 35);
            this.button4.TabIndex = 3;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = global::SGPPC.Properties.Resources.iconCarCompras;
            this.button3.Location = new System.Drawing.Point(59, 2);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(40, 35);
            this.button3.TabIndex = 2;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::SGPPC.Properties.Resources.iconDocumento;
            this.button2.Location = new System.Drawing.Point(109, 2);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(40, 35);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::SGPPC.Properties.Resources.iconUser;
            this.button1.Location = new System.Drawing.Point(8, 2);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 35);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.label1.Location = new System.Drawing.Point(12, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1137, 139);
            this.label1.TabIndex = 2;
            this.label1.Text = "Salgadaria e Pastelaria Ponto Certo";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // toolStripMenuStatus
            // 
            this.toolStripMenuStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStripMenuStatus.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStripMenuStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.toolStripLabelData,
            this.StatusData,
            this.toolStripSeparator2,
            this.toolStripLabelHora,
            this.StatusHora,
            this.toolStripSeparator3,
            this.StripLabelUsuario,
            this.StatusUsuarioLogado,
            this.toolStripSeparator4,
            this.toolStripLabelIdUser,
            this.toolStripSeparator5,
            this.StripLabelId,
            this.toolStripSeparator6,
            this.toolStripLabel1,
            this.toolStripTextBoxFuncao});
            this.toolStripMenuStatus.Location = new System.Drawing.Point(0, 438);
            this.toolStripMenuStatus.Name = "toolStripMenuStatus";
            this.toolStripMenuStatus.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStripMenuStatus.Size = new System.Drawing.Size(1161, 25);
            this.toolStripMenuStatus.TabIndex = 4;
            this.toolStripMenuStatus.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabelData
            // 
            this.toolStripLabelData.Name = "toolStripLabelData";
            this.toolStripLabelData.Size = new System.Drawing.Size(34, 22);
            this.toolStripLabelData.Text = "Data:";
            // 
            // StatusData
            // 
            this.StatusData.Name = "StatusData";
            this.StatusData.Size = new System.Drawing.Size(65, 22);
            this.StatusData.Text = "00/00/0000";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabelHora
            // 
            this.toolStripLabelHora.Name = "toolStripLabelHora";
            this.toolStripLabelHora.Size = new System.Drawing.Size(36, 22);
            this.toolStripLabelHora.Text = "Hora:";
            // 
            // StatusHora
            // 
            this.StatusHora.Name = "StatusHora";
            this.StatusHora.Size = new System.Drawing.Size(49, 22);
            this.StatusHora.Text = "00:00:00";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // StripLabelUsuario
            // 
            this.StripLabelUsuario.Name = "StripLabelUsuario";
            this.StripLabelUsuario.Size = new System.Drawing.Size(93, 22);
            this.StripLabelUsuario.Text = "Usuário Logado:";
            // 
            // StatusUsuarioLogado
            // 
            this.StatusUsuarioLogado.Name = "StatusUsuarioLogado";
            this.StatusUsuarioLogado.Size = new System.Drawing.Size(82, 22);
            this.StatusUsuarioLogado.Text = "nome_usuario";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabelIdUser
            // 
            this.toolStripLabelIdUser.Name = "toolStripLabelIdUser";
            this.toolStripLabelIdUser.Size = new System.Drawing.Size(80, 22);
            this.toolStripLabelIdUser.Text = "Id do Usuário:";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // StripLabelId
            // 
            this.StripLabelId.Name = "StripLabelId";
            this.StripLabelId.Size = new System.Drawing.Size(62, 22);
            this.StripLabelId.Text = "Id_Usuario";
            this.StripLabelId.Click += new System.EventHandler(this.StripLabelId_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(50, 22);
            this.toolStripLabel1.Text = "Usuário:";
            // 
            // toolStripTextBoxFuncao
            // 
            this.toolStripTextBoxFuncao.Name = "toolStripTextBoxFuncao";
            this.toolStripTextBoxFuncao.Size = new System.Drawing.Size(88, 22);
            this.toolStripTextBoxFuncao.Text = "funcao_usuario";
            // 
            // timerStatus
            // 
            this.timerStatus.Tick += new System.EventHandler(this.timerStatus_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::SGPPC.Properties.Resources.iconCompras;
            this.pictureBox1.Location = new System.Drawing.Point(12, 261);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1137, 155);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1161, 463);
            this.Controls.Add(this.toolStripMenuStatus);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlCabecalhoSistema);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlCabecalhoSistema.ResumeLayout(false);
            this.pnlCabecalhoSistema.PerformLayout();
            this.toolStripMenuStatus.ResumeLayout(false);
            this.toolStripMenuStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel pnlCabecalhoSistema;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.ToolStripMenuItem MenuSair;
        public System.Windows.Forms.ToolStripMenuItem RelatórioVenda;
        public System.Windows.Forms.ToolStripMenuItem RelatórioEstoque;
        public System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItemCadastrar;
        public System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItemUsuario;
        public System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItemFornecedor;
        public System.Windows.Forms.ToolStripMenuItem produtoToolStripMenu;
        public System.Windows.Forms.ToolStripMenuItem saboresToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem formasDePagamentoToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem pedidoToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem controleDeCaixaToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem entradaDeProdutoToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStripMenuStatus;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabelData;
        private System.Windows.Forms.ToolStripLabel StatusData;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabelHora;
        private System.Windows.Forms.ToolStripLabel StatusHora;
        private System.Windows.Forms.Timer timerStatus;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel StripLabelUsuario;
        private System.Windows.Forms.ToolStripLabel StatusUsuarioLogado;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripLabel StripLabelId;
        private System.Windows.Forms.ToolStripLabel toolStripLabelIdUser;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem tipoDeOperaçãoToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem MenuRelatorios;
        public System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem produtoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem entradaProdutoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripTextBoxFuncao;
        private System.Windows.Forms.ToolStripMenuItem perfilToolStripMenuItem;
    }
}

