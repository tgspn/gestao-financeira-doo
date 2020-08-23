namespace GestaoFinanceira.Views
{
    partial class FrmReport
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dtvEntries = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ctCategories = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lbTotalIncome = new System.Windows.Forms.Label();
            this.LbTotalExpense = new System.Windows.Forms.Label();
            this.lbProjection = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.lbSaving = new System.Windows.Forms.Label();
            this.lbTotalRevenue = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpDateEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpDateIni = new System.Windows.Forms.DateTimePicker();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.cbModels = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbBill = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtvBankAccount = new System.Windows.Forms.DataGridView();
            this.cId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cBank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cHolder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cAgency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cAccount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLimit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtvCreditCard = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIssuer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLateFee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cExpirationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cClosingDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtvCategorias = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbHolder = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtvEntries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctCategories)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtvBankAccount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtvCreditCard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtvCategorias)).BeginInit();
            this.SuspendLayout();
            // 
            // dtvEntries
            // 
            this.dtvEntries.AllowUserToAddRows = false;
            this.dtvEntries.AllowUserToDeleteRows = false;
            this.dtvEntries.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtvEntries.BackgroundColor = System.Drawing.Color.White;
            this.dtvEntries.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtvEntries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvEntries.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column11,
            this.Column3,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column4,
            this.Column9,
            this.Column10,
            this.Column12,
            this.Column13});
            this.dtvEntries.Location = new System.Drawing.Point(277, 13);
            this.dtvEntries.Name = "dtvEntries";
            this.dtvEntries.ReadOnly = true;
            this.dtvEntries.RowHeadersWidth = 31;
            this.dtvEntries.Size = new System.Drawing.Size(617, 505);
            this.dtvEntries.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "id";
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Description";
            this.Column2.HeaderText = "Descrição";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "Value";
            this.Column11.HeaderText = "Valor";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            this.Column11.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column11.Width = 75;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Date";
            this.Column3.HeaderText = "Data";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column3.Width = 75;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "CaptionCategories";
            this.Column5.HeaderText = "Categoria";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column5.Width = 160;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Category";
            this.Column6.HeaderText = "Categories";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column6.Visible = false;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "SubCategory";
            this.Column7.HeaderText = "SubCategories";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column7.Visible = false;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "PaymentMethod";
            this.Column8.HeaderText = "Pagamento";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Status";
            this.Column4.HeaderText = "Status";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column4.Visible = false;
            this.Column4.Width = 50;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "CaptionRepeat";
            this.Column9.HeaderText = "Recorrente";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column9.Width = 75;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "RepeatUntil";
            this.Column10.HeaderText = "Repetir até";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Visible = false;
            // 
            // Column12
            // 
            this.Column12.DataPropertyName = "Repeat";
            this.Column12.HeaderText = "Repeat";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            this.Column12.Visible = false;
            // 
            // Column13
            // 
            this.Column13.DataPropertyName = "EntryType";
            this.Column13.HeaderText = "EntryType";
            this.Column13.Name = "Column13";
            this.Column13.ReadOnly = true;
            this.Column13.Visible = false;
            // 
            // ctCategories
            // 
            this.ctCategories.AccessibleDescription = "Categorias";
            this.ctCategories.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            chartArea2.Name = "ChartArea1";
            this.ctCategories.ChartAreas.Add(chartArea2);
            this.ctCategories.Cursor = System.Windows.Forms.Cursors.Hand;
            legend2.Name = "Legend1";
            this.ctCategories.Legends.Add(legend2);
            this.ctCategories.Location = new System.Drawing.Point(12, 384);
            this.ctCategories.Name = "ctCategories";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "Categories";
            this.ctCategories.Series.Add(series2);
            this.ctCategories.Size = new System.Drawing.Size(259, 135);
            this.ctCategories.TabIndex = 7;
            this.ctCategories.Text = "Categorias";
            // 
            // lbTotalIncome
            // 
            this.lbTotalIncome.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalIncome.Location = new System.Drawing.Point(156, 71);
            this.lbTotalIncome.Name = "lbTotalIncome";
            this.lbTotalIncome.Size = new System.Drawing.Size(102, 14);
            this.lbTotalIncome.TabIndex = 8;
            this.lbTotalIncome.Text = "R$ 5000,00";
            this.lbTotalIncome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LbTotalExpense
            // 
            this.LbTotalExpense.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTotalExpense.Location = new System.Drawing.Point(156, 125);
            this.LbTotalExpense.Name = "LbTotalExpense";
            this.LbTotalExpense.Size = new System.Drawing.Size(102, 14);
            this.LbTotalExpense.TabIndex = 8;
            this.LbTotalExpense.Text = "R$ 900,00";
            this.LbTotalExpense.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbProjection
            // 
            this.lbProjection.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProjection.Location = new System.Drawing.Point(156, 152);
            this.lbProjection.Name = "lbProjection";
            this.lbProjection.Size = new System.Drawing.Size(102, 14);
            this.lbProjection.TabIndex = 8;
            this.lbProjection.Text = "R$ 3500,00";
            this.lbProjection.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbDate
            // 
            this.lbDate.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDate.Location = new System.Drawing.Point(3, 13);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(270, 24);
            this.lbDate.TabIndex = 8;
            this.lbDate.Text = "Janeiro 2020";
            this.lbDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbSaving
            // 
            this.lbSaving.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSaving.Location = new System.Drawing.Point(156, 180);
            this.lbSaving.Name = "lbSaving";
            this.lbSaving.Size = new System.Drawing.Size(81, 14);
            this.lbSaving.TabIndex = 8;
            this.lbSaving.Text = "Aberta";
            this.lbSaving.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbTotalRevenue
            // 
            this.lbTotalRevenue.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalRevenue.Location = new System.Drawing.Point(156, 97);
            this.lbTotalRevenue.Name = "lbTotalRevenue";
            this.lbTotalRevenue.Size = new System.Drawing.Size(102, 14);
            this.lbTotalRevenue.TabIndex = 8;
            this.lbTotalRevenue.Text = "R$ 2500,00";
            this.lbTotalRevenue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbName);
            this.panel1.Controls.Add(this.lbHolder);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.dtpDateEnd);
            this.panel1.Controls.Add(this.dtpDateIni);
            this.panel1.Controls.Add(this.btnImport);
            this.panel1.Controls.Add(this.btnExport);
            this.panel1.Controls.Add(this.cbModels);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.LbTotalExpense);
            this.panel1.Controls.Add(this.lbTotalRevenue);
            this.panel1.Controls.Add(this.lbProjection);
            this.panel1.Controls.Add(this.lbSaving);
            this.panel1.Controls.Add(this.lbBill);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.lbDate);
            this.panel1.Controls.Add(this.lbTotalIncome);
            this.panel1.Location = new System.Drawing.Point(-2, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(273, 365);
            this.panel1.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 257);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 14);
            this.label8.TabIndex = 11;
            this.label8.Text = "Buscar";
            // 
            // dtpDateEnd
            // 
            this.dtpDateEnd.CustomFormat = "dd/MM/yyyy";
            this.dtpDateEnd.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateEnd.Location = new System.Drawing.Point(138, 228);
            this.dtpDateEnd.Name = "dtpDateEnd";
            this.dtpDateEnd.Size = new System.Drawing.Size(104, 23);
            this.dtpDateEnd.TabIndex = 10;
            this.dtpDateEnd.ValueChanged += new System.EventHandler(this.dtpDateIni_ValueChanged);
            // 
            // dtpDateIni
            // 
            this.dtpDateIni.CustomFormat = "dd/MM/yyyy";
            this.dtpDateIni.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateIni.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateIni.Location = new System.Drawing.Point(19, 228);
            this.dtpDateIni.Name = "dtpDateIni";
            this.dtpDateIni.Size = new System.Drawing.Size(104, 23);
            this.dtpDateIni.TabIndex = 10;
            this.dtpDateIni.ValueChanged += new System.EventHandler(this.dtpDateIni_ValueChanged);
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(7, 329);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(100, 23);
            this.btnImport.TabIndex = 10;
            this.btnImport.Text = "Importar CSV";
            this.btnImport.UseVisualStyleBackColor = true;
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(142, 329);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(100, 23);
            this.btnExport.TabIndex = 10;
            this.btnExport.Text = "Exportar CSV";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // cbModels
            // 
            this.cbModels.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbModels.FormattingEnabled = true;
            this.cbModels.Items.AddRange(new object[] {
            "Conta Bancária",
            "Cartão de Crédido",
            "Receitas",
            "Despesas",
            "Categorias",
            "SubCategorias"});
            this.cbModels.Location = new System.Drawing.Point(19, 274);
            this.cbModels.Name = "cbModels";
            this.cbModels.Size = new System.Drawing.Size(223, 22);
            this.cbModels.TabIndex = 10;
            this.cbModels.SelectedIndexChanged += new System.EventHandler(this.cbModels_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(135, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 14);
            this.label6.TabIndex = 10;
            this.label6.Text = "Data Fim";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 14);
            this.label5.TabIndex = 10;
            this.label5.Text = "Data início";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Despesas";
            // 
            // lbBill
            // 
            this.lbBill.AutoSize = true;
            this.lbBill.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBill.Location = new System.Drawing.Point(37, 180);
            this.lbBill.Name = "lbBill";
            this.lbBill.Size = new System.Drawing.Size(41, 16);
            this.lbBill.TabIndex = 10;
            this.lbBill.Text = "Fatura";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Projeção";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Receitas";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(37, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "Saldo disponível";
            // 
            // dtvBankAccount
            // 
            this.dtvBankAccount.AllowUserToAddRows = false;
            this.dtvBankAccount.AllowUserToDeleteRows = false;
            this.dtvBankAccount.BackgroundColor = System.Drawing.Color.White;
            this.dtvBankAccount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtvBankAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvBankAccount.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cId,
            this.cBank,
            this.cAmount,
            this.cHolder,
            this.cAgency,
            this.cAccount,
            this.cLimit});
            this.dtvBankAccount.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dtvBankAccount.Location = new System.Drawing.Point(277, 13);
            this.dtvBankAccount.MultiSelect = false;
            this.dtvBankAccount.Name = "dtvBankAccount";
            this.dtvBankAccount.ReadOnly = true;
            this.dtvBankAccount.RowHeadersWidth = 25;
            this.dtvBankAccount.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtvBankAccount.Size = new System.Drawing.Size(616, 506);
            this.dtvBankAccount.TabIndex = 10;
            this.dtvBankAccount.Visible = false;
            // 
            // cId
            // 
            this.cId.DataPropertyName = "Id";
            this.cId.HeaderText = "id";
            this.cId.Name = "cId";
            this.cId.ReadOnly = true;
            this.cId.Visible = false;
            this.cId.Width = 5;
            // 
            // cBank
            // 
            this.cBank.DataPropertyName = "Bank";
            this.cBank.HeaderText = "Banco";
            this.cBank.Name = "cBank";
            this.cBank.ReadOnly = true;
            // 
            // cAmount
            // 
            this.cAmount.DataPropertyName = "balance";
            this.cAmount.HeaderText = "Saldo";
            this.cAmount.Name = "cAmount";
            this.cAmount.ReadOnly = true;
            // 
            // cHolder
            // 
            this.cHolder.DataPropertyName = "holder";
            this.cHolder.HeaderText = "Titular";
            this.cHolder.Name = "cHolder";
            this.cHolder.ReadOnly = true;
            this.cHolder.Width = 120;
            // 
            // cAgency
            // 
            this.cAgency.DataPropertyName = "Agency";
            this.cAgency.HeaderText = "Agencia";
            this.cAgency.Name = "cAgency";
            this.cAgency.ReadOnly = true;
            this.cAgency.Width = 70;
            // 
            // cAccount
            // 
            this.cAccount.DataPropertyName = "AccountBank";
            this.cAccount.HeaderText = "Conta";
            this.cAccount.Name = "cAccount";
            this.cAccount.ReadOnly = true;
            // 
            // cLimit
            // 
            this.cLimit.DataPropertyName = "Limit";
            this.cLimit.HeaderText = "Limite";
            this.cLimit.Name = "cLimit";
            this.cLimit.ReadOnly = true;
            // 
            // dtvCreditCard
            // 
            this.dtvCreditCard.AllowUserToAddRows = false;
            this.dtvCreditCard.AllowUserToDeleteRows = false;
            this.dtvCreditCard.BackgroundColor = System.Drawing.Color.White;
            this.dtvCreditCard.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtvCreditCard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvCreditCard.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.cIssuer,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.cLateFee,
            this.cNumber,
            this.cExpirationDate,
            this.cClosingDate});
            this.dtvCreditCard.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dtvCreditCard.Location = new System.Drawing.Point(277, 13);
            this.dtvCreditCard.MultiSelect = false;
            this.dtvCreditCard.Name = "dtvCreditCard";
            this.dtvCreditCard.ReadOnly = true;
            this.dtvCreditCard.RowHeadersWidth = 25;
            this.dtvCreditCard.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtvCreditCard.Size = new System.Drawing.Size(617, 506);
            this.dtvCreditCard.TabIndex = 11;
            this.dtvCreditCard.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // cIssuer
            // 
            this.cIssuer.DataPropertyName = "Issuer";
            this.cIssuer.HeaderText = "Credor";
            this.cIssuer.Name = "cIssuer";
            this.cIssuer.ReadOnly = true;
            this.cIssuer.Width = 70;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "holder";
            this.dataGridViewTextBoxColumn2.HeaderText = "Titular";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 170;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "amount";
            this.dataGridViewTextBoxColumn3.HeaderText = "Saldo";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // cLateFee
            // 
            this.cLateFee.DataPropertyName = "latefee";
            this.cLateFee.HeaderText = "% ao mês";
            this.cLateFee.Name = "cLateFee";
            this.cLateFee.ReadOnly = true;
            // 
            // cNumber
            // 
            this.cNumber.DataPropertyName = "number";
            this.cNumber.HeaderText = "Numero";
            this.cNumber.Name = "cNumber";
            this.cNumber.ReadOnly = true;
            this.cNumber.Visible = false;
            // 
            // cExpirationDate
            // 
            this.cExpirationDate.DataPropertyName = "expirationdate";
            this.cExpirationDate.HeaderText = "Vencimento do Cartão";
            this.cExpirationDate.Name = "cExpirationDate";
            this.cExpirationDate.ReadOnly = true;
            this.cExpirationDate.Visible = false;
            this.cExpirationDate.Width = 150;
            // 
            // cClosingDate
            // 
            this.cClosingDate.DataPropertyName = "closingdate";
            this.cClosingDate.HeaderText = "Dia de Fechamento";
            this.cClosingDate.Name = "cClosingDate";
            this.cClosingDate.ReadOnly = true;
            this.cClosingDate.Width = 150;
            // 
            // dtvCategorias
            // 
            this.dtvCategorias.AllowUserToAddRows = false;
            this.dtvCategorias.AllowUserToDeleteRows = false;
            this.dtvCategorias.BackgroundColor = System.Drawing.Color.White;
            this.dtvCategorias.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtvCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvCategorias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn8});
            this.dtvCategorias.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dtvCategorias.Location = new System.Drawing.Point(277, 12);
            this.dtvCategorias.MultiSelect = false;
            this.dtvCategorias.Name = "dtvCategorias";
            this.dtvCategorias.ReadOnly = true;
            this.dtvCategorias.RowHeadersWidth = 47;
            this.dtvCategorias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtvCategorias.Size = new System.Drawing.Size(617, 506);
            this.dtvCategorias.TabIndex = 11;
            this.dtvCategorias.Visible = false;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Issuer";
            this.dataGridViewTextBoxColumn5.HeaderText = "Categoria";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "amount";
            this.dataGridViewTextBoxColumn7.HeaderText = "Valor";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "holder";
            this.dataGridViewTextBoxColumn6.HeaderText = "Tipo de conta";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 170;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "latefee";
            this.dataGridViewTextBoxColumn8.HeaderText = "Qtd Utilizada";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // lbHolder
            // 
            this.lbHolder.AutoSize = true;
            this.lbHolder.Location = new System.Drawing.Point(37, 45);
            this.lbHolder.Name = "lbHolder";
            this.lbHolder.Size = new System.Drawing.Size(44, 14);
            this.lbHolder.TabIndex = 12;
            this.lbHolder.Text = "Titular: ";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(156, 45);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(0, 14);
            this.lbName.TabIndex = 12;
            // 
            // FrmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(905, 531);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ctCategories);
            this.Controls.Add(this.dtvEntries);
            this.Controls.Add(this.dtvBankAccount);
            this.Controls.Add(this.dtvCreditCard);
            this.Controls.Add(this.dtvCategorias);
            this.Font = new System.Drawing.Font("Microsoft PhagsPa", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório";
            this.Load += new System.EventHandler(this.FrmReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtvEntries)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctCategories)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtvBankAccount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtvCreditCard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtvCategorias)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtvEntries;
        private System.Windows.Forms.DataVisualization.Charting.Chart ctCategories;
        private System.Windows.Forms.Label lbTotalIncome;
        private System.Windows.Forms.Label LbTotalExpense;
        private System.Windows.Forms.Label lbProjection;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Label lbSaving;
        private System.Windows.Forms.Label lbTotalRevenue;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbModels;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbBill;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.DateTimePicker dtpDateEnd;
        private System.Windows.Forms.DateTimePicker dtpDateIni;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridView dtvBankAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn cId;
        private System.Windows.Forms.DataGridViewTextBoxColumn cBank;
        private System.Windows.Forms.DataGridViewTextBoxColumn cAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn cHolder;
        private System.Windows.Forms.DataGridViewTextBoxColumn cAgency;
        private System.Windows.Forms.DataGridViewTextBoxColumn cAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLimit;
        private System.Windows.Forms.DataGridView dtvCreditCard;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIssuer;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLateFee;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn cExpirationDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn cClosingDate;
        private System.Windows.Forms.DataGridView dtvCategorias;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.Label lbHolder;
        private System.Windows.Forms.Label lbName;
    }
}