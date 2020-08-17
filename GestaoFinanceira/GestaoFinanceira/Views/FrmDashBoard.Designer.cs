namespace GestaoFinanceira
{
    partial class FrmDashBoard
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

        //teste commite
        //Isto ira dar conflito
        //teste commite2
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDashBoard));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbBalance = new System.Windows.Forms.Label();
            this.lbRevenue = new System.Windows.Forms.Label();
            this.lbExpense = new System.Windows.Forms.Label();
            this.lb_Month = new System.Windows.Forms.Label();
            this.ctBank = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ctCreditCard = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ctCategories = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label4 = new System.Windows.Forms.Label();
            this.lbEconomy = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.despesaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.receitaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.importarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opçõesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cartãoDeCréditoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cartãoDeCréditoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.despesasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.receitasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.versãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnOpenBank = new System.Windows.Forms.Button();
            this.btnOpenCreditCard = new System.Windows.Forms.Button();
            this.btnOpenRevenue = new System.Windows.Forms.Button();
            this.btnOpenEntries = new System.Windows.Forms.Button();
            this.btnOpenCalendar = new System.Windows.Forms.Button();
            this.btnOpenExpense = new System.Windows.Forms.Button();
            this.FlpAccounts = new System.Windows.Forms.FlowLayoutPanel();
            this.FlpCreditCard = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.ctBank)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctCreditCard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctCategories)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(141, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Saldo em Contas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Receitas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(249, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Despesas";
            // 
            // lbBalance
            // 
            this.lbBalance.AutoSize = true;
            this.lbBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBalance.Location = new System.Drawing.Point(131, 91);
            this.lbBalance.Name = "lbBalance";
            this.lbBalance.Size = new System.Drawing.Size(103, 24);
            this.lbBalance.TabIndex = 0;
            this.lbBalance.Text = "R$ 5700,00";
            // 
            // lbRevenue
            // 
            this.lbRevenue.AutoSize = true;
            this.lbRevenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRevenue.Location = new System.Drawing.Point(76, 149);
            this.lbRevenue.Name = "lbRevenue";
            this.lbRevenue.Size = new System.Drawing.Size(92, 20);
            this.lbRevenue.TabIndex = 0;
            this.lbRevenue.Text = "R$ 7000,00";
            // 
            // lbExpense
            // 
            this.lbExpense.AutoSize = true;
            this.lbExpense.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbExpense.Location = new System.Drawing.Point(248, 149);
            this.lbExpense.Name = "lbExpense";
            this.lbExpense.Size = new System.Drawing.Size(92, 20);
            this.lbExpense.TabIndex = 0;
            this.lbExpense.Text = "R$ 1300,00";
            // 
            // lb_Month
            // 
            this.lb_Month.AutoSize = true;
            this.lb_Month.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Month.Location = new System.Drawing.Point(157, 39);
            this.lb_Month.Name = "lb_Month";
            this.lb_Month.Size = new System.Drawing.Size(56, 24);
            this.lb_Month.TabIndex = 3;
            this.lb_Month.Text = "Julho";
            // 
            // ctBank
            // 
            this.ctBank.AccessibleDescription = "Contas Bancárias";
            chartArea1.Name = "ChartArea1";
            this.ctBank.ChartAreas.Add(chartArea1);
            this.ctBank.Cursor = System.Windows.Forms.Cursors.Hand;
            legend1.Name = "Legend1";
            this.ctBank.Legends.Add(legend1);
            this.ctBank.Location = new System.Drawing.Point(370, 172);
            this.ctBank.Name = "ctBank";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Bank";
            this.ctBank.Series.Add(series1);
            this.ctBank.Size = new System.Drawing.Size(330, 125);
            this.ctBank.TabIndex = 6;
            this.ctBank.Text = "chart1";
            this.ctBank.Click += new System.EventHandler(this.contaToolStripMenuItem_Click);
            // 
            // ctCreditCard
            // 
            this.ctCreditCard.AccessibleDescription = "Cartão de Crédito";
            this.ctCreditCard.BorderSkin.BorderWidth = 0;
            chartArea2.AxisX2.Title = "Cartões";
            chartArea2.AxisY.Title = "Reais";
            chartArea2.AxisY2.Title = "Cartões";
            chartArea2.Name = "ChartArea1";
            this.ctCreditCard.ChartAreas.Add(chartArea2);
            this.ctCreditCard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ctCreditCard.IsSoftShadows = false;
            legend2.Name = "Legend1";
            this.ctCreditCard.Legends.Add(legend2);
            this.ctCreditCard.Location = new System.Drawing.Point(370, 313);
            this.ctCreditCard.Name = "ctCreditCard";
            this.ctCreditCard.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            this.ctCreditCard.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.Blue};
            this.ctCreditCard.RightToLeft = System.Windows.Forms.RightToLeft.No;
            series2.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Top;
            series2.BackImageTransparentColor = System.Drawing.Color.White;
            series2.BackImageWrapMode = System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode.TileFlipX;
            series2.BorderWidth = 0;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series2.IsVisibleInLegend = false;
            series2.Label = "0";
            series2.LabelBackColor = System.Drawing.Color.Transparent;
            series2.Legend = "Legend1";
            series2.LegendText = "Cartões";
            series2.MarkerBorderWidth = 0;
            series2.MarkerSize = 1;
            series2.Name = "CreditCard";
            this.ctCreditCard.Series.Add(series2);
            this.ctCreditCard.Size = new System.Drawing.Size(330, 125);
            this.ctCreditCard.TabIndex = 6;
            this.ctCreditCard.TabStop = false;
            this.ctCreditCard.Text = "chart1";
            this.ctCreditCard.Click += new System.EventHandler(this.ctCreditCard_Click);
            // 
            // ctCategories
            // 
            this.ctCategories.AccessibleDescription = "Categorias";
            chartArea3.Name = "ChartArea1";
            this.ctCategories.ChartAreas.Add(chartArea3);
            this.ctCategories.Cursor = System.Windows.Forms.Cursors.Hand;
            legend3.Name = "Legend1";
            this.ctCategories.Legends.Add(legend3);
            this.ctCategories.Location = new System.Drawing.Point(370, 24);
            this.ctCategories.Name = "ctCategories";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series3.Legend = "Legend1";
            series3.Name = "Categories";
            this.ctCategories.Series.Add(series3);
            this.ctCategories.Size = new System.Drawing.Size(330, 125);
            this.ctCategories.TabIndex = 6;
            this.ctCategories.Text = "Categorias";
            this.ctCategories.Click += new System.EventHandler(this.btnOpenExpense_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(126, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Economia:";
            // 
            // lbEconomy
            // 
            this.lbEconomy.AutoSize = true;
            this.lbEconomy.Location = new System.Drawing.Point(189, 115);
            this.lbEconomy.Name = "lbEconomy";
            this.lbEconomy.Size = new System.Drawing.Size(45, 13);
            this.lbEconomy.TabIndex = 0;
            this.lbEconomy.Text = "37.25 %";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opçõesToolStripMenuItem,
            this.opçõesToolStripMenuItem1,
            this.editarToolStripMenuItem,
            this.sobreToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(712, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // opçõesToolStripMenuItem
            // 
            this.opçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoToolStripMenuItem,
            this.toolStripMenuItem1,
            this.importarToolStripMenuItem,
            this.exportarToolStripMenuItem,
            this.toolStripMenuItem2,
            this.sairToolStripMenuItem});
            this.opçõesToolStripMenuItem.Name = "opçõesToolStripMenuItem";
            this.opçõesToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.opçõesToolStripMenuItem.Text = "Arquivo";
            // 
            // novoToolStripMenuItem
            // 
            this.novoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.despesaToolStripMenuItem,
            this.receitaToolStripMenuItem});
            this.novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            this.novoToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.novoToolStripMenuItem.Text = "Novo";
            // 
            // despesaToolStripMenuItem
            // 
            this.despesaToolStripMenuItem.Name = "despesaToolStripMenuItem";
            this.despesaToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.despesaToolStripMenuItem.Text = "Despesa";
            this.despesaToolStripMenuItem.Click += new System.EventHandler(this.despesaToolStripMenuItem_Click);
            // 
            // receitaToolStripMenuItem
            // 
            this.receitaToolStripMenuItem.Name = "receitaToolStripMenuItem";
            this.receitaToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.receitaToolStripMenuItem.Text = "Receita";
            this.receitaToolStripMenuItem.Click += new System.EventHandler(this.receitaToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(132, 6);
            // 
            // importarToolStripMenuItem
            // 
            this.importarToolStripMenuItem.Name = "importarToolStripMenuItem";
            this.importarToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.importarToolStripMenuItem.Text = "Importar";
            this.importarToolStripMenuItem.Click += new System.EventHandler(this.gerarRelatórioToolStripMenuItem_Click);
            // 
            // exportarToolStripMenuItem
            // 
            this.exportarToolStripMenuItem.Name = "exportarToolStripMenuItem";
            this.exportarToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.exportarToolStripMenuItem.Text = "Exportar";
            this.exportarToolStripMenuItem.Click += new System.EventHandler(this.exportarToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(132, 6);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.sairToolStripMenuItem.Text = "&Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click_1);
            // 
            // opçõesToolStripMenuItem1
            // 
            this.opçõesToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem,
            this.cartãoDeCréditoToolStripMenuItem,
            this.categoriaToolStripMenuItem});
            this.opçõesToolStripMenuItem1.Name = "opçõesToolStripMenuItem1";
            this.opçõesToolStripMenuItem1.Size = new System.Drawing.Size(66, 20);
            this.opçõesToolStripMenuItem1.Text = "Cadastro";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.cadastrosToolStripMenuItem.Text = "Conta Bancária";
            this.cadastrosToolStripMenuItem.Click += new System.EventHandler(this.btnOpenBank_Click);
            // 
            // cartãoDeCréditoToolStripMenuItem
            // 
            this.cartãoDeCréditoToolStripMenuItem.Name = "cartãoDeCréditoToolStripMenuItem";
            this.cartãoDeCréditoToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.cartãoDeCréditoToolStripMenuItem.Text = "Cartão de Crédito";
            this.cartãoDeCréditoToolStripMenuItem.Click += new System.EventHandler(this.btnOpenCreditCard_Click);
            // 
            // categoriaToolStripMenuItem
            // 
            this.categoriaToolStripMenuItem.Name = "categoriaToolStripMenuItem";
            this.categoriaToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.categoriaToolStripMenuItem.Text = "Categoria";
            this.categoriaToolStripMenuItem.Click += new System.EventHandler(this.categoriaToolStripMenuItem_Click);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contaToolStripMenuItem,
            this.cartãoDeCréditoToolStripMenuItem1,
            this.despesasToolStripMenuItem,
            this.receitasToolStripMenuItem,
            this.categoriasToolStripMenuItem});
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.editarToolStripMenuItem.Text = "Editar";
            // 
            // contaToolStripMenuItem
            // 
            this.contaToolStripMenuItem.Name = "contaToolStripMenuItem";
            this.contaToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.contaToolStripMenuItem.Text = "Conta";
            this.contaToolStripMenuItem.Click += new System.EventHandler(this.contaToolStripMenuItem_Click);
            // 
            // cartãoDeCréditoToolStripMenuItem1
            // 
            this.cartãoDeCréditoToolStripMenuItem1.Name = "cartãoDeCréditoToolStripMenuItem1";
            this.cartãoDeCréditoToolStripMenuItem1.Size = new System.Drawing.Size(167, 22);
            this.cartãoDeCréditoToolStripMenuItem1.Text = "Cartão de Crédito";
            this.cartãoDeCréditoToolStripMenuItem1.Click += new System.EventHandler(this.cartãoDeCréditoToolStripMenuItem1_Click);
            // 
            // despesasToolStripMenuItem
            // 
            this.despesasToolStripMenuItem.Name = "despesasToolStripMenuItem";
            this.despesasToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.despesasToolStripMenuItem.Text = "Despesas";
            this.despesasToolStripMenuItem.Click += new System.EventHandler(this.despesasToolStripMenuItem_Click);
            // 
            // receitasToolStripMenuItem
            // 
            this.receitasToolStripMenuItem.Name = "receitasToolStripMenuItem";
            this.receitasToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.receitasToolStripMenuItem.Text = "Receitas";
            this.receitasToolStripMenuItem.Click += new System.EventHandler(this.receitasToolStripMenuItem_Click);
            // 
            // categoriasToolStripMenuItem
            // 
            this.categoriasToolStripMenuItem.Name = "categoriasToolStripMenuItem";
            this.categoriasToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.categoriasToolStripMenuItem.Text = "Categorias";
            this.categoriasToolStripMenuItem.Click += new System.EventHandler(this.ctCategories_Click);
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.versãoToolStripMenuItem});
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.sobreToolStripMenuItem.Text = "Ajuda";
            // 
            // versãoToolStripMenuItem
            // 
            this.versãoToolStripMenuItem.Name = "versãoToolStripMenuItem";
            this.versãoToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.versãoToolStripMenuItem.Text = "Sobre";
            this.versãoToolStripMenuItem.Click += new System.EventHandler(this.versãoToolStripMenuItem_Click);
            // 
            // btnOpenBank
            // 
            this.btnOpenBank.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpenBank.FlatAppearance.BorderSize = 0;
            this.btnOpenBank.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenBank.Image = ((System.Drawing.Image)(resources.GetObject("btnOpenBank.Image")));
            this.btnOpenBank.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpenBank.Location = new System.Drawing.Point(12, 388);
            this.btnOpenBank.Name = "btnOpenBank";
            this.btnOpenBank.Size = new System.Drawing.Size(49, 50);
            this.btnOpenBank.TabIndex = 5;
            this.btnOpenBank.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOpenBank.UseVisualStyleBackColor = true;
            this.btnOpenBank.Click += new System.EventHandler(this.btnOpenBank_Click);
            // 
            // btnOpenCreditCard
            // 
            this.btnOpenCreditCard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpenCreditCard.FlatAppearance.BorderSize = 0;
            this.btnOpenCreditCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenCreditCard.Image = ((System.Drawing.Image)(resources.GetObject("btnOpenCreditCard.Image")));
            this.btnOpenCreditCard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpenCreditCard.Location = new System.Drawing.Point(315, 388);
            this.btnOpenCreditCard.Name = "btnOpenCreditCard";
            this.btnOpenCreditCard.Size = new System.Drawing.Size(49, 50);
            this.btnOpenCreditCard.TabIndex = 5;
            this.btnOpenCreditCard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOpenCreditCard.UseVisualStyleBackColor = true;
            this.btnOpenCreditCard.Click += new System.EventHandler(this.btnOpenCreditCard_Click);
            // 
            // btnOpenRevenue
            // 
            this.btnOpenRevenue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpenRevenue.FlatAppearance.BorderSize = 0;
            this.btnOpenRevenue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenRevenue.Image = ((System.Drawing.Image)(resources.GetObject("btnOpenRevenue.Image")));
            this.btnOpenRevenue.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpenRevenue.Location = new System.Drawing.Point(31, 130);
            this.btnOpenRevenue.Name = "btnOpenRevenue";
            this.btnOpenRevenue.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnOpenRevenue.Size = new System.Drawing.Size(40, 39);
            this.btnOpenRevenue.TabIndex = 5;
            this.btnOpenRevenue.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOpenRevenue.UseVisualStyleBackColor = true;
            this.btnOpenRevenue.Click += new System.EventHandler(this.btnOpenRevenue_Click);
            // 
            // btnOpenEntries
            // 
            this.btnOpenEntries.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpenEntries.FlatAppearance.BorderSize = 0;
            this.btnOpenEntries.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenEntries.Image = ((System.Drawing.Image)(resources.GetObject("btnOpenEntries.Image")));
            this.btnOpenEntries.Location = new System.Drawing.Point(171, 388);
            this.btnOpenEntries.Name = "btnOpenEntries";
            this.btnOpenEntries.Size = new System.Drawing.Size(42, 42);
            this.btnOpenEntries.TabIndex = 5;
            this.btnOpenEntries.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnOpenEntries.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOpenEntries.UseVisualStyleBackColor = true;
            this.btnOpenEntries.Click += new System.EventHandler(this.btnOpenEntries_Click);
            // 
            // btnOpenCalendar
            // 
            this.btnOpenCalendar.FlatAppearance.BorderSize = 0;
            this.btnOpenCalendar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenCalendar.Image = ((System.Drawing.Image)(resources.GetObject("btnOpenCalendar.Image")));
            this.btnOpenCalendar.Location = new System.Drawing.Point(125, 38);
            this.btnOpenCalendar.Name = "btnOpenCalendar";
            this.btnOpenCalendar.Size = new System.Drawing.Size(26, 25);
            this.btnOpenCalendar.TabIndex = 4;
            this.btnOpenCalendar.UseVisualStyleBackColor = true;
            this.btnOpenCalendar.Click += new System.EventHandler(this.btnOpenCalendar_Click);
            // 
            // btnOpenExpense
            // 
            this.btnOpenExpense.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpenExpense.FlatAppearance.BorderSize = 0;
            this.btnOpenExpense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenExpense.Image = ((System.Drawing.Image)(resources.GetObject("btnOpenExpense.Image")));
            this.btnOpenExpense.Location = new System.Drawing.Point(210, 130);
            this.btnOpenExpense.Name = "btnOpenExpense";
            this.btnOpenExpense.Size = new System.Drawing.Size(40, 39);
            this.btnOpenExpense.TabIndex = 4;
            this.btnOpenExpense.UseVisualStyleBackColor = true;
            this.btnOpenExpense.Click += new System.EventHandler(this.btnOpenExpense_Click);
            // 
            // FlpAccounts
            // 
            this.FlpAccounts.Location = new System.Drawing.Point(31, 194);
            this.FlpAccounts.Name = "FlpAccounts";
            this.FlpAccounts.Size = new System.Drawing.Size(333, 94);
            this.FlpAccounts.TabIndex = 9;
            // 
            // FlpCreditCard
            // 
            this.FlpCreditCard.Location = new System.Drawing.Point(31, 294);
            this.FlpCreditCard.Name = "FlpCreditCard";
            this.FlpCreditCard.Size = new System.Drawing.Size(333, 94);
            this.FlpCreditCard.TabIndex = 10;
            // 
            // FrmDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(712, 445);
            this.Controls.Add(this.FlpCreditCard);
            this.Controls.Add(this.FlpAccounts);
            this.Controls.Add(this.lb_Month);
            this.Controls.Add(this.lbExpense);
            this.Controls.Add(this.btnOpenBank);
            this.Controls.Add(this.lbEconomy);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ctCreditCard);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnOpenCreditCard);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ctCategories);
            this.Controls.Add(this.lbBalance);
            this.Controls.Add(this.ctBank);
            this.Controls.Add(this.btnOpenRevenue);
            this.Controls.Add(this.lbRevenue);
            this.Controls.Add(this.btnOpenEntries);
            this.Controls.Add(this.btnOpenCalendar);
            this.Controls.Add(this.btnOpenExpense);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmDashBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestão Financeira";
            this.Load += new System.EventHandler(this.FrmDashBoard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ctBank)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctCreditCard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctCategories)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbBalance;
        private System.Windows.Forms.Label lbRevenue;
        private System.Windows.Forms.Label lbExpense;
        private System.Windows.Forms.Label lb_Month;
        private System.Windows.Forms.Button btnOpenExpense;
        private System.Windows.Forms.Button btnOpenBank;
        private System.Windows.Forms.Button btnOpenCreditCard;
        private System.Windows.Forms.Button btnOpenRevenue;
        private System.Windows.Forms.DataVisualization.Charting.Chart ctBank;
        private System.Windows.Forms.Button btnOpenEntries;
        private System.Windows.Forms.Button btnOpenCalendar;
        private System.Windows.Forms.DataVisualization.Charting.Chart ctCreditCard;
        private System.Windows.Forms.DataVisualization.Charting.Chart ctCategories;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbEconomy;

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem opçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opçõesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem despesaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem receitaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportarToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cartãoDeCréditoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem versãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cartãoDeCréditoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem despesasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem receitasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriasToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel FlpAccounts;
        private System.Windows.Forms.FlowLayoutPanel FlpCreditCard;
    }
}

