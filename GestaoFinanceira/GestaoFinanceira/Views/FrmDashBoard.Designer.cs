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
            this.ctCreditCard = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnOpenEntries = new System.Windows.Forms.Button();
            this.btnOpenCreditCard = new System.Windows.Forms.Button();
            this.btnOpenRevenue = new System.Windows.Forms.Button();
            this.btnOpenBank = new System.Windows.Forms.Button();
            this.btnOpenCalendar = new System.Windows.Forms.Button();
            this.btnOpenExpense = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ctBank)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctCreditCard)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(147, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Saldo em Contas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Receitas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(263, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Despesas";
            // 
            // lbBalance
            // 
            this.lbBalance.AutoSize = true;
            this.lbBalance.Location = new System.Drawing.Point(163, 91);
            this.lbBalance.Name = "lbBalance";
            this.lbBalance.Size = new System.Drawing.Size(45, 13);
            this.lbBalance.TabIndex = 0;
            this.lbBalance.Text = "R$ 0,00";
            // 
            // lbRevenue
            // 
            this.lbRevenue.AutoSize = true;
            this.lbRevenue.Location = new System.Drawing.Point(91, 176);
            this.lbRevenue.Name = "lbRevenue";
            this.lbRevenue.Size = new System.Drawing.Size(45, 13);
            this.lbRevenue.TabIndex = 0;
            this.lbRevenue.Text = "R$ 0,00";
            // 
            // lbExpense
            // 
            this.lbExpense.AutoSize = true;
            this.lbExpense.Location = new System.Drawing.Point(263, 176);
            this.lbExpense.Name = "lbExpense";
            this.lbExpense.Size = new System.Drawing.Size(45, 13);
            this.lbExpense.TabIndex = 0;
            this.lbExpense.Text = "R$ 0,00";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opçõesToolStripMenuItem,
            this.sobreToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(692, 24);
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
            this.lb_MesAtual.Location = new System.Drawing.Point(162, 24);
            this.lb_MesAtual.Name = "lb_MesAtual";
            this.lb_MesAtual.Size = new System.Drawing.Size(56, 24);
            this.lb_MesAtual.TabIndex = 3;
            this.lb_MesAtual.Text = "Julho";
            // 
            // ctBank
            // 
            chartArea11.Name = "ChartArea1";
            this.ctBank.ChartAreas.Add(chartArea11);
            legend11.Name = "Legend1";
            this.ctBank.Legends.Add(legend11);
            this.ctBank.Location = new System.Drawing.Point(384, 27);
            this.ctBank.Name = "ctBank";
            series11.ChartArea = "ChartArea1";
            series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series11.Legend = "Legend1";
            series11.Name = "Bank";
            this.ctBank.Series.Add(series11);
            this.ctBank.Size = new System.Drawing.Size(296, 133);
            this.ctBank.TabIndex = 6;
            this.ctBank.Text = "chart1";
            // 
            // ctCreditCard
            // 
            this.ctCreditCard.BorderSkin.BorderWidth = 0;
            chartArea12.AxisX2.Title = "Cartões";
            chartArea12.AxisY.Title = "Reais";
            chartArea12.AxisY2.Title = "Cartões";
            chartArea12.Name = "ChartArea1";
            this.ctCreditCard.ChartAreas.Add(chartArea12);
            this.ctCreditCard.IsSoftShadows = false;
            legend12.Name = "Legend1";
            this.ctCreditCard.Legends.Add(legend12);
            this.ctCreditCard.Location = new System.Drawing.Point(384, 176);
            this.ctCreditCard.Name = "ctCreditCard";
            this.ctCreditCard.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            this.ctCreditCard.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.Blue};
            this.ctCreditCard.RightToLeft = System.Windows.Forms.RightToLeft.No;
            series12.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Top;
            series12.BackImageTransparentColor = System.Drawing.Color.White;
            series12.BackImageWrapMode = System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode.TileFlipX;
            series12.BorderWidth = 0;
            series12.ChartArea = "ChartArea1";
            series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series12.IsVisibleInLegend = false;
            series12.Label = "0";
            series12.LabelBackColor = System.Drawing.Color.Transparent;
            series12.Legend = "Legend1";
            series12.LegendText = "Cartões";
            series12.MarkerBorderWidth = 0;
            series12.MarkerSize = 1;
            series12.Name = "CreditCard";
            this.ctCreditCard.Series.Add(series12);
            this.ctCreditCard.Size = new System.Drawing.Size(296, 133);
            this.ctCreditCard.TabIndex = 6;
            this.ctCreditCard.TabStop = false;
            this.ctCreditCard.Text = "chart1";
            // 
            // btnOpenEntries
            // 
            this.btnOpenEntries.FlatAppearance.BorderSize = 0;
            this.btnOpenEntries.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenEntries.Image = global::GestaoFinanceira.Properties.Resources.icons8_plus_30px_1;
            this.btnOpenEntries.Location = new System.Drawing.Point(166, 275);
            this.btnOpenEntries.Name = "btnOpenEntries";
            this.btnOpenEntries.Size = new System.Drawing.Size(42, 42);
            this.btnOpenEntries.TabIndex = 5;
            this.btnOpenEntries.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOpenEntries.UseVisualStyleBackColor = true;
            this.btnOpenEntries.Click += new System.EventHandler(this.btnOpenEntries_Click);
            // 
            // btnOpenCreditCard
            // 
            this.btnOpenCreditCard.FlatAppearance.BorderSize = 0;
            this.btnOpenCreditCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenCreditCard.Image = global::GestaoFinanceira.Properties.Resources.icons8_credit_control_40px_1;
            this.btnOpenCreditCard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpenCreditCard.Location = new System.Drawing.Point(297, 275);
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
            this.btnOpenRevenue.Location = new System.Drawing.Point(53, 151);
            this.btnOpenRevenue.Name = "btnOpenRevenue";
            this.btnOpenRevenue.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnOpenRevenue.Size = new System.Drawing.Size(40, 39);
            this.btnOpenRevenue.TabIndex = 5;
            this.btnOpenRevenue.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOpenRevenue.UseVisualStyleBackColor = true;
            this.btnOpenRevenue.Click += new System.EventHandler(this.btnOpenRevenue_Click);
            // 
            // btnOpenBank
            // 
            this.btnOpenBank.FlatAppearance.BorderSize = 0;
            this.btnOpenBank.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenBank.Image = global::GestaoFinanceira.Properties.Resources.icons8_bank_40px_3;
            this.btnOpenBank.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpenBank.Location = new System.Drawing.Point(12, 275);
            this.btnOpenBank.Name = "btnOpenBank";
            this.btnOpenBank.Size = new System.Drawing.Size(49, 50);
            this.btnOpenBank.TabIndex = 5;
            this.btnOpenBank.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOpenBank.UseVisualStyleBackColor = true;
            this.btnOpenBank.Click += new System.EventHandler(this.btnOpenBank_Click);
            // 
            // btnOpenCalendar
            // 
            this.btnOpenCalendar.FlatAppearance.BorderSize = 0;
            this.btnOpenCalendar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenCalendar.Image = global::GestaoFinanceira.Properties.Resources.icons8_down_button_20px;
            this.btnOpenCalendar.Location = new System.Drawing.Point(224, 26);
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
            this.btnOpenExpense.Location = new System.Drawing.Point(226, 151);
            this.btnOpenExpense.Name = "btnOpenExpense";
            this.btnOpenExpense.Size = new System.Drawing.Size(40, 39);
            this.btnOpenExpense.TabIndex = 4;
            this.btnOpenExpense.UseVisualStyleBackColor = true;
            this.btnOpenExpense.Click += new System.EventHandler(this.btnOpenExpense_Click);
            // 
            // FrmDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 337);
            this.Controls.Add(this.ctCreditCard);
            this.Controls.Add(this.ctBank);
            this.Controls.Add(this.btnOpenEntries);
            this.Controls.Add(this.btnOpenCreditCard);
            this.Controls.Add(this.btnOpenRevenue);
            this.Controls.Add(this.btnOpenBank);
            this.Controls.Add(this.btnOpenCalendar);
            this.Controls.Add(this.btnOpenExpense);
            this.Controls.Add(this.lb_MesAtual);
            this.Controls.Add(this.lbExpense);
            this.Controls.Add(this.lbRevenue);
            this.Controls.Add(this.lbBalance);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmDashBoard";
            this.Text = "Gestão Financeira";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ctBank)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctCreditCard)).EndInit();
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
        private System.Windows.Forms.DataVisualization.Charting.Chart ctCreditCard;
        private System.Windows.Forms.Button btnOpenEntries;
        private System.Windows.Forms.Button btnOpenCalendar;
    }
}

