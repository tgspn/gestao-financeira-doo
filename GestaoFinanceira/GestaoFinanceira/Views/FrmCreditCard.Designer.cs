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
            this.label1 = new System.Windows.Forms.Label();
            this.txtIssuer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.mtxtExpirationDate = new System.Windows.Forms.MaskedTextBox();
            this.mtxtNumber = new System.Windows.Forms.MaskedTextBox();
            this.txtHolder = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.mtxtClosingDate = new System.Windows.Forms.MaskedTextBox();
            this.txtLimit = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.mtxtLateFee = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cbPaymentMethod = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.label4.Location = new System.Drawing.Point(31, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 14);
            this.label4.TabIndex = 1;
            this.label4.Text = "Número";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(123, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 28);
            this.label5.TabIndex = 1;
            this.label5.Text = "Data Validade";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mtxtExpirationDate
            // 
            this.mtxtExpirationDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mtxtExpirationDate.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtExpirationDate.Location = new System.Drawing.Point(126, 274);
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
            this.mtxtNumber.Location = new System.Drawing.Point(90, 211);
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
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(26, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 28);
            this.label6.TabIndex = 1;
            this.label6.Text = "Dia de Fechamento";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mtxtClosingDate
            // 
            this.mtxtClosingDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mtxtClosingDate.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtClosingDate.Location = new System.Drawing.Point(26, 271);
            this.mtxtClosingDate.Mask = "00";
            this.mtxtClosingDate.Name = "mtxtClosingDate";
            this.mtxtClosingDate.Size = new System.Drawing.Size(91, 20);
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
            this.mtxtLateFee.Location = new System.Drawing.Point(201, 274);
            this.mtxtLateFee.Mask = "00.00 %";
            this.mtxtLateFee.Name = "mtxtLateFee";
            this.mtxtLateFee.Size = new System.Drawing.Size(42, 16);
            this.mtxtLateFee.TabIndex = 8;
            this.mtxtLateFee.ValidatingType = typeof(System.DateTime);
            this.mtxtLateFee.TextChanged += new System.EventHandler(this.txtIssuer_TextChanged);
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(201, 235);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 37);
            this.label8.TabIndex = 1;
            this.label8.Text = "Taxa ao mês";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.btnSave.Location = new System.Drawing.Point(204, 328);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(44, 23);
            this.btnSave.TabIndex = 9;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Image = global::GestaoFinanceira.Properties.Resources.icons8_multiply_26px;
            this.btnCancel.Location = new System.Drawing.Point(27, 328);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(44, 23);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cbPaymentMethod
            // 
            this.cbPaymentMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPaymentMethod.FormattingEnabled = true;
            this.cbPaymentMethod.Location = new System.Drawing.Point(85, 183);
            this.cbPaymentMethod.Name = "cbPaymentMethod";
            this.cbPaymentMethod.Size = new System.Drawing.Size(155, 22);
            this.cbPaymentMethod.TabIndex = 4;
            this.cbPaymentMethod.TextChanged += new System.EventHandler(this.txtIssuer_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft PhagsPa", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(15, 186);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 14);
            this.label9.TabIndex = 11;
            this.label9.Text = "Pagamento";
            // 
            // FrmCreditCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(285, 369);
            this.ControlBox = false;
            this.Controls.Add(this.cbPaymentMethod);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.mtxtNumber);
            this.Controls.Add(this.mtxtLateFee);
            this.Controls.Add(this.mtxtClosingDate);
            this.Controls.Add(this.mtxtExpirationDate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
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
            this.Load += new System.EventHandler(this.FrmCreditCard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox mtxtClosingDate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtLimit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox mtxtLateFee;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cbPaymentMethod;
        private System.Windows.Forms.Label label9;
    }
}