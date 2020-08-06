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
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.mtxtLateFee = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Titular";
            // 
            // txtIssuer
            // 
            this.txtIssuer.Location = new System.Drawing.Point(82, 95);
            this.txtIssuer.Name = "txtIssuer";
            this.txtIssuer.Size = new System.Drawing.Size(136, 25);
            this.txtIssuer.TabIndex = 1;
            this.txtIssuer.TextChanged += new System.EventHandler(this.txtIssuer_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Credora";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "Número";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(48, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 28);
            this.label5.TabIndex = 1;
            this.label5.Text = "Data Validade";
            // 
            // mtxtExpirationDate
            // 
            this.mtxtExpirationDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mtxtExpirationDate.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtExpirationDate.Location = new System.Drawing.Point(51, 240);
            this.mtxtExpirationDate.Mask = "00/0000";
            this.mtxtExpirationDate.Name = "mtxtExpirationDate";
            this.mtxtExpirationDate.Size = new System.Drawing.Size(59, 20);
            this.mtxtExpirationDate.TabIndex = 5;
            this.mtxtExpirationDate.ValidatingType = typeof(System.DateTime);
            this.mtxtExpirationDate.TextChanged += new System.EventHandler(this.txtIssuer_TextChanged);
            // 
            // mtxtNumber
            // 
            this.mtxtNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mtxtNumber.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtNumber.Location = new System.Drawing.Point(82, 180);
            this.mtxtNumber.Mask = "0000 0000 0000 0000";
            this.mtxtNumber.Name = "mtxtNumber";
            this.mtxtNumber.Size = new System.Drawing.Size(107, 20);
            this.mtxtNumber.TabIndex = 4;
            this.mtxtNumber.ValidatingType = typeof(System.DateTime);
            // 
            // txtHolder
            // 
            this.txtHolder.Location = new System.Drawing.Point(82, 149);
            this.txtHolder.Name = "txtHolder";
            this.txtHolder.Size = new System.Drawing.Size(136, 25);
            this.txtHolder.TabIndex = 3;
            this.txtHolder.TextChanged += new System.EventHandler(this.txtIssuer_TextChanged);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(140, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 28);
            this.label6.TabIndex = 1;
            this.label6.Text = "Data Fechamento";
            // 
            // mtxtClosingDate
            // 
            this.mtxtClosingDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mtxtClosingDate.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtClosingDate.Location = new System.Drawing.Point(143, 240);
            this.mtxtClosingDate.Mask = "00/00/0000";
            this.mtxtClosingDate.Name = "mtxtClosingDate";
            this.mtxtClosingDate.Size = new System.Drawing.Size(64, 20);
            this.mtxtClosingDate.TabIndex = 6;
            this.mtxtClosingDate.ValidatingType = typeof(System.DateTime);
            this.mtxtClosingDate.TextChanged += new System.EventHandler(this.txtIssuer_TextChanged);
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(82, 121);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(136, 25);
            this.txtAmount.TabIndex = 2;
            this.txtAmount.TextChanged += new System.EventHandler(this.txtIssuer_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 18);
            this.label7.TabIndex = 1;
            this.label7.Text = "Limite";
            // 
            // mtxtLateFee
            // 
            this.mtxtLateFee.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mtxtLateFee.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtLateFee.Location = new System.Drawing.Point(110, 277);
            this.mtxtLateFee.Mask = "00.00 %";
            this.mtxtLateFee.Name = "mtxtLateFee";
            this.mtxtLateFee.Size = new System.Drawing.Size(42, 20);
            this.mtxtLateFee.TabIndex = 7;
            this.mtxtLateFee.ValidatingType = typeof(System.DateTime);
            this.mtxtLateFee.TextChanged += new System.EventHandler(this.txtIssuer_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(158, 277);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "ao mês";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(73, 279);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 18);
            this.label8.TabIndex = 1;
            this.label8.Text = "Taxa";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GestaoFinanceira.Properties.Resources.icons8_credit_card_70px_1;
            this.pictureBox1.Location = new System.Drawing.Point(94, 12);
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
            this.btnSave.Location = new System.Drawing.Point(174, 311);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(44, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Image = global::GestaoFinanceira.Properties.Resources.icons8_multiply_26px;
            this.btnCancel.Location = new System.Drawing.Point(32, 311);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(44, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FrmCreditCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(255, 356);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.mtxtNumber);
            this.Controls.Add(this.mtxtLateFee);
            this.Controls.Add(this.mtxtClosingDate);
            this.Controls.Add(this.mtxtExpirationDate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.txtHolder);
            this.Controls.Add(this.txtIssuer);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft PhagsPa", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmCreditCard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cartão de Crédito";
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
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox mtxtLateFee;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}