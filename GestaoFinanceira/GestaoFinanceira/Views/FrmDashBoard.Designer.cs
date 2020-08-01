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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea10 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend10 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea11 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend11 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea12 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend12 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbBalance = new System.Windows.Forms.Label();
            this.lbRevenue = new System.Windows.Forms.Label();
            this.lbExpense = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerarRelatórioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lb_MesAtual = new System.Windows.Forms.Label();
            this.ctBank = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.ctCreditCard = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ctCategories = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnOpenBank = new System.Windows.Forms.Button();
            this.btnOpenCreditCard = new System.Windows.Forms.Button();
            this.btnOpenRevenue = new System.Windows.Forms.Button();
            this.btnOpenEntries = new System.Windows.Forms.Button();
            this.btnOpenCalendar = new System.Windows.Forms.Button();
            this.btnOpenExpense = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lbEconomia = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ctBank)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctCreditCard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctCategories)).BeginInit();
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
            this.lbBalance.Location = new System.Drawing.Point(125, 91);
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
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opçõesToolStripMenuItem,
            this.sobreToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(620, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // opçõesToolStripMenuItem
            // 
            this.opçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gerarRelatórioToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.opçõesToolStripMenuItem.Name = "opçõesToolStripMenuItem";
            this.opçõesToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.opçõesToolStripMenuItem.Text = "Opções";
            // 
            // gerarRelatórioToolStripMenuItem
            // 
            this.gerarRelatórioToolStripMenuItem.Name = "gerarRelatórioToolStripMenuItem";
            this.gerarRelatórioToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.gerarRelatórioToolStripMenuItem.Text = "Gerar Relatório";
            this.gerarRelatórioToolStripMenuItem.Click += new System.EventHandler(this.gerarRelatórioToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.sobreToolStripMenuItem.Text = "Sobre";
            // 
            // lb_MesAtual
            // 
            this.lb_MesAtual.AutoSize = true;
            this.lb_MesAtual.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_MesAtual.Location = new System.Drawing.Point(157, 39);
            this.lb_MesAtual.Name = "lb_MesAtual";
            this.lb_MesAtual.Size = new System.Drawing.Size(56, 24);
            this.lb_MesAtual.TabIndex = 3;
            this.lb_MesAtual.Text = "Julho";
            // 
            // ctBank
            // 
            chartArea10.Name = "ChartArea1";
            this.ctBank.ChartAreas.Add(chartArea10);
            legend10.Name = "Legend1";
            this.ctBank.Legends.Add(legend10);
            this.ctBank.Location = new System.Drawing.Point(370, 160);
            this.ctBank.Name = "ctBank";
            series10.ChartArea = "ChartArea1";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series10.Legend = "Legend1";
            series10.Name = "Bank";
            this.ctBank.Series.Add(series10);
            this.ctBank.Size = new System.Drawing.Size(238, 125);
            this.ctBank.TabIndex = 6;
            this.ctBank.Text = "chart1";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // ctCreditCard
            // 
            this.ctCreditCard.BorderSkin.BorderWidth = 0;
            chartArea11.AxisX2.Title = "Cartões";
            chartArea11.AxisY.Title = "Reais";
            chartArea11.AxisY2.Title = "Cartões";
            chartArea11.Name = "ChartArea1";
            this.ctCreditCard.ChartAreas.Add(chartArea11);
            this.ctCreditCard.IsSoftShadows = false;
            legend11.Name = "Legend1";
            this.ctCreditCard.Legends.Add(legend11);
            this.ctCreditCard.Location = new System.Drawing.Point(370, 308);
            this.ctCreditCard.Name = "ctCreditCard";
            this.ctCreditCard.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            this.ctCreditCard.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.Blue};
            this.ctCreditCard.RightToLeft = System.Windows.Forms.RightToLeft.No;
            series11.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Top;
            series11.BackImageTransparentColor = System.Drawing.Color.White;
            series11.BackImageWrapMode = System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode.TileFlipX;
            series11.BorderWidth = 0;
            series11.ChartArea = "ChartArea1";
            series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series11.IsVisibleInLegend = false;
            series11.Label = "0";
            series11.LabelBackColor = System.Drawing.Color.Transparent;
            series11.Legend = "Legend1";
            series11.LegendText = "Cartões";
            series11.MarkerBorderWidth = 0;
            series11.MarkerSize = 1;
            series11.Name = "CreditCard";
            this.ctCreditCard.Series.Add(series11);
            this.ctCreditCard.Size = new System.Drawing.Size(238, 125);
            this.ctCreditCard.TabIndex = 6;
            this.ctCreditCard.TabStop = false;
            this.ctCreditCard.Text = "chart1";
            // 
            // ctCategories
            // 
            chartArea12.Name = "ChartArea1";
            this.ctCategories.ChartAreas.Add(chartArea12);
            legend12.Name = "Legend1";
            this.ctCategories.Legends.Add(legend12);
            this.ctCategories.Location = new System.Drawing.Point(370, 27);
            this.ctCategories.Name = "ctCategories";
            series12.ChartArea = "ChartArea1";
            series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series12.Legend = "Legend1";
            series12.Name = "Categories";
            this.ctCategories.Series.Add(series12);
            this.ctCategories.Size = new System.Drawing.Size(238, 125);
            this.ctCategories.TabIndex = 6;
            this.ctCategories.Text = "chart1";
            this.ctCategories.Click += new System.EventHandler(this.ctCategories_Click);
            // 
            // btnOpenBank
            // 
            this.btnOpenBank.FlatAppearance.BorderSize = 0;
            this.btnOpenBank.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenBank.Image = global::GestaoFinanceira.Properties.Resources.icons8_bank_40px_3;
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
            this.btnOpenCreditCard.FlatAppearance.BorderSize = 0;
            this.btnOpenCreditCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenCreditCard.Image = global::GestaoFinanceira.Properties.Resources.icons8_credit_control_40px_1;
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
            this.btnOpenRevenue.FlatAppearance.BorderSize = 0;
            this.btnOpenRevenue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenRevenue.Image = global::GestaoFinanceira.Properties.Resources.icons8_up_30px;
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
            this.btnOpenEntries.FlatAppearance.BorderSize = 0;
            this.btnOpenEntries.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenEntries.Image = global::GestaoFinanceira.Properties.Resources.icons8_plus_30px_1;
            this.btnOpenEntries.Location = new System.Drawing.Point(161, 388);
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
            this.btnOpenCalendar.Image = global::GestaoFinanceira.Properties.Resources.icons8_down_button_20px;
            this.btnOpenCalendar.Location = new System.Drawing.Point(125, 38);
            this.btnOpenCalendar.Name = "btnOpenCalendar";
            this.btnOpenCalendar.Size = new System.Drawing.Size(26, 25);
            this.btnOpenCalendar.TabIndex = 4;
            this.btnOpenCalendar.UseVisualStyleBackColor = true;
            this.btnOpenCalendar.Click += new System.EventHandler(this.btnOpenCalendar_Click);
            // 
            // btnOpenExpense
            // 
            this.btnOpenExpense.FlatAppearance.BorderSize = 0;
            this.btnOpenExpense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenExpense.Image = global::GestaoFinanceira.Properties.Resources.icons8_down_arrow_30px;
            this.btnOpenExpense.Location = new System.Drawing.Point(210, 130);
            this.btnOpenExpense.Name = "btnOpenExpense";
            this.btnOpenExpense.Size = new System.Drawing.Size(40, 39);
            this.btnOpenExpense.TabIndex = 4;
            this.btnOpenExpense.UseVisualStyleBackColor = true;
            this.btnOpenExpense.Click += new System.EventHandler(this.btnOpenExpense_Click);
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
            // lbEconomia
            // 
            this.lbEconomia.AutoSize = true;
            this.lbEconomia.Location = new System.Drawing.Point(189, 115);
            this.lbEconomia.Name = "lbEconomia";
            this.lbEconomia.Size = new System.Drawing.Size(45, 13);
            this.lbEconomia.TabIndex = 0;
            this.lbEconomia.Text = "37.25 %";
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(46, 193);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 46);
            this.button1.TabIndex = 7;
            this.button1.Text = "Conta A";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(144, 193);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 46);
            this.button2.TabIndex = 7;
            this.button2.Text = "Conta B";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(241, 193);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(91, 46);
            this.button3.TabIndex = 7;
            this.button3.Text = "Conta C";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(46, 245);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(91, 40);
            this.button4.TabIndex = 7;
            this.button4.Text = "Conta D";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(143, 245);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(91, 40);
            this.button5.TabIndex = 7;
            this.button5.Text = "Conta E";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(241, 245);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(91, 40);
            this.button6.TabIndex = 7;
            this.button6.Text = "Conta F";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Visible = false;
            // 
            // button7
            // 
            this.button7.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Location = new System.Drawing.Point(46, 290);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(91, 46);
            this.button7.TabIndex = 7;
            this.button7.Text = "Cartão 1";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Location = new System.Drawing.Point(144, 290);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(91, 46);
            this.button8.TabIndex = 7;
            this.button8.Text = "Cartão 2";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Location = new System.Drawing.Point(241, 290);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(91, 46);
            this.button9.TabIndex = 7;
            this.button9.Text = "Cartão 3";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Location = new System.Drawing.Point(46, 342);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(91, 40);
            this.button10.TabIndex = 7;
            this.button10.Text = "Cartão 4";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Visible = false;
            // 
            // button11
            // 
            this.button11.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Location = new System.Drawing.Point(143, 342);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(91, 40);
            this.button11.TabIndex = 7;
            this.button11.Text = "Cartão 5";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Visible = false;
            // 
            // button12
            // 
            this.button12.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Location = new System.Drawing.Point(241, 342);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(91, 40);
            this.button12.TabIndex = 7;
            this.button12.Text = "Cartão 6";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Visible = false;
            // 
            // FrmDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(620, 445);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lb_MesAtual);
            this.Controls.Add(this.lbExpense);
            this.Controls.Add(this.btnOpenBank);
            this.Controls.Add(this.lbEconomia);
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
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnOpenExpense);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmDashBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestão Financeira";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ctBank)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctCreditCard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctCategories)).EndInit();
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
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem opçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerarRelatórioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.Label lb_MesAtual;
        private System.Windows.Forms.Button btnOpenExpense;
        private System.Windows.Forms.Button btnOpenBank;
        private System.Windows.Forms.Button btnOpenCreditCard;
        private System.Windows.Forms.Button btnOpenRevenue;
        private System.Windows.Forms.DataVisualization.Charting.Chart ctBank;
        private System.Windows.Forms.Button btnOpenEntries;
        private System.Windows.Forms.Button btnOpenCalendar;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.DataVisualization.Charting.Chart ctCreditCard;
        private System.Windows.Forms.DataVisualization.Charting.Chart ctCategories;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbEconomia;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
    }
}

