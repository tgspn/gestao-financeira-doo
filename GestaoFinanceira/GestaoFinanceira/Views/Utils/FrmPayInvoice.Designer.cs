namespace GestaoFinanceira.Views
{
    partial class frmPayInvoice
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtpBaseTime = new System.Windows.Forms.DateTimePicker();
            this.lbInstallment = new System.Windows.Forms.Label();
            this.lbInfoPay = new System.Windows.Forms.Label();
            this.lbLatefee = new System.Windows.Forms.Label();
            this.ckParcel = new System.Windows.Forms.CheckBox();
            this.ckTotal = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnBanner = new System.Windows.Forms.Panel();
            this.lbUnit = new System.Windows.Forms.Label();
            this.lbAmount = new System.Windows.Forms.Label();
            this.nupValue = new System.Windows.Forms.NumericUpDown();
            this.cbBankSender = new System.Windows.Forms.ComboBox();
            this.lbInterest = new System.Windows.Forms.Label();
            this.lbLatefeeValue = new System.Windows.Forms.Label();
            this.lbInterestPerDayValue = new System.Windows.Forms.Label();
            this.lbTotalToPay = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnInfo = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnBanner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupValue)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 298);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(343, 47);
            this.panel2.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.lbTotalToPay);
            this.panel1.Controls.Add(this.btnInfo);
            this.panel1.Controls.Add(this.lbInterestPerDayValue);
            this.panel1.Controls.Add(this.lbLatefeeValue);
            this.panel1.Controls.Add(this.dtpBaseTime);
            this.panel1.Controls.Add(this.lbInstallment);
            this.panel1.Controls.Add(this.lbInfoPay);
            this.panel1.Controls.Add(this.lbInterest);
            this.panel1.Controls.Add(this.lbLatefee);
            this.panel1.Controls.Add(this.ckParcel);
            this.panel1.Controls.Add(this.ckTotal);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pnBanner);
            this.panel1.Controls.Add(this.cbBankSender);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(343, 303);
            this.panel1.TabIndex = 11;
            // 
            // dtpBaseTime
            // 
            this.dtpBaseTime.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBaseTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBaseTime.Location = new System.Drawing.Point(82, 136);
            this.dtpBaseTime.Name = "dtpBaseTime";
            this.dtpBaseTime.Size = new System.Drawing.Size(178, 24);
            this.dtpBaseTime.TabIndex = 14;
            this.dtpBaseTime.ValueChanged += new System.EventHandler(this.dtpBaseTime_ValueChanged);
            // 
            // lbInstallment
            // 
            this.lbInstallment.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInstallment.Location = new System.Drawing.Point(78, 273);
            this.lbInstallment.Name = "lbInstallment";
            this.lbInstallment.Size = new System.Drawing.Size(186, 21);
            this.lbInstallment.TabIndex = 13;
            this.lbInstallment.Text = "R$ 0,00";
            this.lbInstallment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbInstallment.Visible = false;
            // 
            // lbInfoPay
            // 
            this.lbInfoPay.Location = new System.Drawing.Point(52, 257);
            this.lbInfoPay.Name = "lbInfoPay";
            this.lbInfoPay.Size = new System.Drawing.Size(262, 16);
            this.lbInfoPay.TabIndex = 13;
            this.lbInfoPay.Text = "Valor com acrescimo de 15% para o mês seguinte";
            this.lbInfoPay.Visible = false;
            // 
            // lbLatefee
            // 
            this.lbLatefee.AutoSize = true;
            this.lbLatefee.Location = new System.Drawing.Point(79, 164);
            this.lbLatefee.Name = "lbLatefee";
            this.lbLatefee.Size = new System.Drawing.Size(109, 14);
            this.lbLatefee.TabIndex = 13;
            this.lbLatefee.Text = "Multa por atraso: 2%";
            // 
            // ckParcel
            // 
            this.ckParcel.AutoSize = true;
            this.ckParcel.Location = new System.Drawing.Point(170, 67);
            this.ckParcel.Name = "ckParcel";
            this.ckParcel.Size = new System.Drawing.Size(90, 18);
            this.ckParcel.TabIndex = 12;
            this.ckParcel.Text = "Pagar Parcial";
            this.ckParcel.UseVisualStyleBackColor = true;
            this.ckParcel.CheckedChanged += new System.EventHandler(this.ckParcel_CheckedChanged);
            // 
            // ckTotal
            // 
            this.ckTotal.AutoSize = true;
            this.ckTotal.Checked = true;
            this.ckTotal.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckTotal.Location = new System.Drawing.Point(82, 67);
            this.ckTotal.Name = "ckTotal";
            this.ckTotal.Size = new System.Drawing.Size(82, 18);
            this.ckTotal.TabIndex = 12;
            this.ckTotal.Text = "Pagar Total";
            this.ckTotal.UseVisualStyleBackColor = true;
            this.ckTotal.CheckedChanged += new System.EventHandler(this.ckTotal_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 14);
            this.label1.TabIndex = 11;
            this.label1.Text = "Debitar";
            // 
            // pnBanner
            // 
            this.pnBanner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(225)))));
            this.pnBanner.Controls.Add(this.lbUnit);
            this.pnBanner.Controls.Add(this.lbAmount);
            this.pnBanner.Controls.Add(this.nupValue);
            this.pnBanner.Location = new System.Drawing.Point(55, 24);
            this.pnBanner.Name = "pnBanner";
            this.pnBanner.Size = new System.Drawing.Size(232, 37);
            this.pnBanner.TabIndex = 10;
            // 
            // lbUnit
            // 
            this.lbUnit.AutoSize = true;
            this.lbUnit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(225)))));
            this.lbUnit.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUnit.Location = new System.Drawing.Point(3, 6);
            this.lbUnit.Name = "lbUnit";
            this.lbUnit.Size = new System.Drawing.Size(37, 26);
            this.lbUnit.TabIndex = 1;
            this.lbUnit.Text = "R$";
            // 
            // lbAmount
            // 
            this.lbAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(225)))));
            this.lbAmount.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAmount.Location = new System.Drawing.Point(33, 4);
            this.lbAmount.Name = "lbAmount";
            this.lbAmount.Size = new System.Drawing.Size(183, 28);
            this.lbAmount.TabIndex = 13;
            this.lbAmount.Text = "0,00";
            this.lbAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nupValue
            // 
            this.nupValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(225)))));
            this.nupValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nupValue.CausesValidation = false;
            this.nupValue.DecimalPlaces = 2;
            this.nupValue.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupValue.Location = new System.Drawing.Point(0, 6);
            this.nupValue.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nupValue.Name = "nupValue";
            this.nupValue.Size = new System.Drawing.Size(263, 28);
            this.nupValue.TabIndex = 0;
            this.nupValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nupValue.Visible = false;
            this.nupValue.ValueChanged += new System.EventHandler(this.nupValue_ValueChanged);
            // 
            // cbBankSender
            // 
            this.cbBankSender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBankSender.FormattingEnabled = true;
            this.cbBankSender.Location = new System.Drawing.Point(82, 109);
            this.cbBankSender.Name = "cbBankSender";
            this.cbBankSender.Size = new System.Drawing.Size(178, 22);
            this.cbBankSender.TabIndex = 9;
            this.cbBankSender.SelectedIndexChanged += new System.EventHandler(this.cbBankSender_SelectedIndexChanged);
            // 
            // lbInterest
            // 
            this.lbInterest.AutoSize = true;
            this.lbInterest.Location = new System.Drawing.Point(79, 178);
            this.lbInterest.Name = "lbInterest";
            this.lbInterest.Size = new System.Drawing.Size(99, 14);
            this.lbInterest.TabIndex = 13;
            this.lbInterest.Text = "Juros: 0,75% ao dia";
            // 
            // lbLatefeeValue
            // 
            this.lbLatefeeValue.Location = new System.Drawing.Point(85, 203);
            this.lbLatefeeValue.Name = "lbLatefeeValue";
            this.lbLatefeeValue.Size = new System.Drawing.Size(125, 14);
            this.lbLatefeeValue.TabIndex = 15;
            this.lbLatefeeValue.Text = "Multa: RS 3,50";
            this.lbLatefeeValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbInterestPerDayValue
            // 
            this.lbInterestPerDayValue.Location = new System.Drawing.Point(84, 217);
            this.lbInterestPerDayValue.Name = "lbInterestPerDayValue";
            this.lbInterestPerDayValue.Size = new System.Drawing.Size(126, 14);
            this.lbInterestPerDayValue.TabIndex = 15;
            this.lbInterestPerDayValue.Text = "Juros: RS 2,00";
            this.lbInterestPerDayValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbTotalToPay
            // 
            this.lbTotalToPay.Location = new System.Drawing.Point(84, 231);
            this.lbTotalToPay.Name = "lbTotalToPay";
            this.lbTotalToPay.Size = new System.Drawing.Size(126, 14);
            this.lbTotalToPay.TabIndex = 15;
            this.lbTotalToPay.Text = "Total: RS 5,50";
            this.lbTotalToPay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnInfo
            // 
            this.btnInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInfo.FlatAppearance.BorderSize = 0;
            this.btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfo.Image = global::GestaoFinanceira.Properties.Resources.icons8_info_15px_1;
            this.btnInfo.Location = new System.Drawing.Point(263, 136);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(21, 24);
            this.btnInfo.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btnInfo, "Conta Atrasada (Clique para abrir)");
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Visible = false;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Enabled = false;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Image = global::GestaoFinanceira.Properties.Resources.icons8_checkmark_26px;
            this.btnSave.Location = new System.Drawing.Point(257, 10);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 27);
            this.btnSave.TabIndex = 5;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Image = global::GestaoFinanceira.Properties.Resources.icons8_multiply_26px;
            this.btnCancel.Location = new System.Drawing.Point(28, 10);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(42, 27);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmPayInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(343, 345);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Microsoft PhagsPa", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmPayInvoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Pagar Fatura";
            this.Load += new System.EventHandler(this.frmPayInvoice_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnBanner.ResumeLayout(false);
            this.pnBanner.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupValue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbInstallment;
        private System.Windows.Forms.Label lbInfoPay;
        private System.Windows.Forms.Label lbLatefee;
        private System.Windows.Forms.CheckBox ckParcel;
        private System.Windows.Forms.CheckBox ckTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnBanner;
        private System.Windows.Forms.Label lbUnit;
        private System.Windows.Forms.NumericUpDown nupValue;
        private System.Windows.Forms.ComboBox cbBankSender;
        private System.Windows.Forms.DateTimePicker dtpBaseTime;
        private System.Windows.Forms.Label lbAmount;
        private System.Windows.Forms.Label lbTotalToPay;
        private System.Windows.Forms.Label lbInterestPerDayValue;
        private System.Windows.Forms.Label lbLatefeeValue;
        private System.Windows.Forms.Label lbInterest;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}