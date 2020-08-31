namespace GestaoFinanceira.Views
{
    partial class FrmCreditCard
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtIssuer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.mtxtExpirationDate = new System.Windows.Forms.MaskedTextBox();
            this.mtxtNumber = new System.Windows.Forms.MaskedTextBox();
            this.txtHolder = new System.Windows.Forms.TextBox();
            this.mtxtClosingDate = new System.Windows.Forms.MaskedTextBox();
            this.txtLimit = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.mtxtLateFee = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mtxtDueDate = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.mtxtInterestDay = new System.Windows.Forms.MaskedTextBox();
            this.mtxtInterest = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "Titular";
            // 
            // txtIssuer
            // 
            this.txtIssuer.Location = new System.Drawing.Point(85, 98);
            this.txtIssuer.Name = "txtIssuer";
            this.txtIssuer.Size = new System.Drawing.Size(155, 22);
            this.txtIssuer.TabIndex = 1;
            this.txtIssuer.TextChanged += new System.EventHandler(this.txtIssuer_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "Credora";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 14);
            this.label4.TabIndex = 1;
            this.label4.Text = "Número";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(37, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 28);
            this.label5.TabIndex = 1;
            this.label5.Text = "Data Validade";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mtxtExpirationDate
            // 
            this.mtxtExpirationDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mtxtExpirationDate.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtExpirationDate.Location = new System.Drawing.Point(55, 296);
            this.mtxtExpirationDate.Mask = "00/0000";
            this.mtxtExpirationDate.Name = "mtxtExpirationDate";
            this.mtxtExpirationDate.Size = new System.Drawing.Size(59, 20);
            this.mtxtExpirationDate.TabIndex = 7;
            this.mtxtExpirationDate.ValidatingType = typeof(System.DateTime);
            this.mtxtExpirationDate.TextChanged += new System.EventHandler(this.txtIssuer_TextChanged);
            this.mtxtExpirationDate.Validated += new System.EventHandler(this.mtxtExpirationDate_Validated);
            // 
            // mtxtNumber
            // 
            this.mtxtNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mtxtNumber.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtNumber.Location = new System.Drawing.Point(85, 182);
            this.mtxtNumber.Mask = "0000 0000 0000 0000";
            this.mtxtNumber.Name = "mtxtNumber";
            this.mtxtNumber.Size = new System.Drawing.Size(136, 17);
            this.mtxtNumber.TabIndex = 5;
            this.mtxtNumber.ValidatingType = typeof(System.DateTime);
            // 
            // txtHolder
            // 
            this.txtHolder.Location = new System.Drawing.Point(85, 126);
            this.txtHolder.Name = "txtHolder";
            this.txtHolder.Size = new System.Drawing.Size(155, 22);
            this.txtHolder.TabIndex = 2;
            this.txtHolder.TextChanged += new System.EventHandler(this.txtIssuer_TextChanged);
            // 
            // mtxtClosingDate
            // 
            this.mtxtClosingDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mtxtClosingDate.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtClosingDate.Location = new System.Drawing.Point(193, 228);
            this.mtxtClosingDate.Mask = "00";
            this.mtxtClosingDate.Name = "mtxtClosingDate";
            this.mtxtClosingDate.Size = new System.Drawing.Size(29, 20);
            this.mtxtClosingDate.TabIndex = 6;
            this.mtxtClosingDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtxtClosingDate.ValidatingType = typeof(int);
            this.mtxtClosingDate.TextChanged += new System.EventHandler(this.txtIssuer_TextChanged);
            this.mtxtClosingDate.Validated += new System.EventHandler(this.mtxtClosingDate_Validated);
            // 
            // txtLimit
            // 
            this.txtLimit.Location = new System.Drawing.Point(85, 154);
            this.txtLimit.Name = "txtLimit";
            this.txtLimit.Size = new System.Drawing.Size(155, 22);
            this.txtLimit.TabIndex = 3;
            this.txtLimit.TextChanged += new System.EventHandler(this.txtIssuer_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(40, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 14);
            this.label7.TabIndex = 1;
            this.label7.Text = "Limite";
            // 
            // mtxtLateFee
            // 
            this.mtxtLateFee.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mtxtLateFee.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtLateFee.Location = new System.Drawing.Point(136, 300);
            this.mtxtLateFee.Mask = "0.00 %";
            this.mtxtLateFee.Name = "mtxtLateFee";
            this.mtxtLateFee.Size = new System.Drawing.Size(42, 16);
            this.mtxtLateFee.TabIndex = 8;
            this.mtxtLateFee.ValidatingType = typeof(System.DateTime);
            this.mtxtLateFee.TextChanged += new System.EventHandler(this.txtIssuer_TextChanged);
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(156, 258);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 28);
            this.label8.TabIndex = 1;
            this.label8.Text = "Taxa de juros:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(156, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Dia de Fechamento";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mtxtDueDate
            // 
            this.mtxtDueDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mtxtDueDate.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtDueDate.Location = new System.Drawing.Point(72, 228);
            this.mtxtDueDate.Mask = "00";
            this.mtxtDueDate.Name = "mtxtDueDate";
            this.mtxtDueDate.Size = new System.Drawing.Size(29, 20);
            this.mtxtDueDate.TabIndex = 6;
            this.mtxtDueDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtxtDueDate.ValidatingType = typeof(int);
            this.mtxtDueDate.TextChanged += new System.EventHandler(this.txtIssuer_TextChanged);
            this.mtxtDueDate.Validated += new System.EventHandler(this.mtxtDueDate_Validated);
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(35, 210);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 18);
            this.label9.TabIndex = 1;
            this.label9.Text = "Dia de Vencimento";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mtxtInterestDay
            // 
            this.mtxtInterestDay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mtxtInterestDay.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtInterestDay.Location = new System.Drawing.Point(184, 300);
            this.mtxtInterestDay.Mask = "0.000 %";
            this.mtxtInterestDay.Name = "mtxtInterestDay";
            this.mtxtInterestDay.Size = new System.Drawing.Size(42, 16);
            this.mtxtInterestDay.TabIndex = 9;
            this.mtxtInterestDay.ValidatingType = typeof(System.DateTime);
            this.mtxtInterestDay.TextChanged += new System.EventHandler(this.txtIssuer_TextChanged);
            // 
            // mtxtInterest
            // 
            this.mtxtInterest.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mtxtInterest.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtInterest.Location = new System.Drawing.Point(231, 300);
            this.mtxtInterest.Mask = "00.00 %";
            this.mtxtInterest.Name = "mtxtInterest";
            this.mtxtInterest.Size = new System.Drawing.Size(42, 16);
            this.mtxtInterest.TabIndex = 10;
            this.mtxtInterest.ValidatingType = typeof(System.DateTime);
            this.mtxtInterest.TextChanged += new System.EventHandler(this.txtIssuer_TextChanged);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(132, 282);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "Multa";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(175, 282);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 15);
            this.label10.TabIndex = 1;
            this.label10.Text = "Dia";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(228, 282);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 15);
            this.label11.TabIndex = 1;
            this.label11.Text = "Mês";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GestaoFinanceira.Properties.Resources.icons8_credit_card_70px_1;
            this.pictureBox1.Location = new System.Drawing.Point(115, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Enabled = false;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Image = global::GestaoFinanceira.Properties.Resources.icons8_checkmark_26px;
            this.btnSave.Location = new System.Drawing.Point(214, 343);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(44, 23);
            this.btnSave.TabIndex = 11;
            this.toolTip1.SetToolTip(this.btnSave, "Salvar Cartão");
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Image = global::GestaoFinanceira.Properties.Resources.icons8_multiply_26px;
            this.btnCancel.Location = new System.Drawing.Point(33, 343);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(44, 23);
            this.btnCancel.TabIndex = 12;
            this.toolTip1.SetToolTip(this.btnCancel, "Sair");
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::GestaoFinanceira.Properties.Resources.icons8_info_26px;
            this.pictureBox2.Location = new System.Drawing.Point(235, 266);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(13, 13);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox2, "Informações");
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // FrmCreditCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(285, 378);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.mtxtNumber);
            this.Controls.Add(this.mtxtInterest);
            this.Controls.Add(this.mtxtInterestDay);
            this.Controls.Add(this.mtxtLateFee);
            this.Controls.Add(this.mtxtDueDate);
            this.Controls.Add(this.mtxtClosingDate);
            this.Controls.Add(this.mtxtExpirationDate);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLimit);
            this.Controls.Add(this.txtHolder);
            this.Controls.Add(this.txtIssuer);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft PhagsPa", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmCreditCard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cartão de Crédito";
            this.TextChanged += new System.EventHandler(this.txtIssuer_TextChanged);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIssuer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox mtxtExpirationDate;
        private System.Windows.Forms.MaskedTextBox mtxtNumber;
        private System.Windows.Forms.TextBox txtHolder;
        private System.Windows.Forms.MaskedTextBox mtxtClosingDate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtLimit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox mtxtLateFee;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mtxtDueDate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox mtxtInterestDay;
        private System.Windows.Forms.MaskedTextBox mtxtInterest;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}