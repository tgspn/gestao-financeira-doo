namespace GestaoFinanceira.Views
{
    partial class FrmTransfer
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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.dtpBaseTime = new System.Windows.Forms.DateTimePicker();
            this.cbBankSender = new System.Windows.Forms.ComboBox();
            this.cbDestination = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnBanner = new System.Windows.Forms.Panel();
            this.lbUnit = new System.Windows.Forms.Label();
            this.nupValue = new System.Windows.Forms.NumericUpDown();
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
            this.panel2.Location = new System.Drawing.Point(0, 241);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(261, 44);
            this.panel2.TabIndex = 6;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Enabled = false;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Image = global::GestaoFinanceira.Properties.Resources.icons8_checkmark_26px;
            this.btnSave.Location = new System.Drawing.Point(174, 9);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 25);
            this.btnSave.TabIndex = 5;
            this.toolTip1.SetToolTip(this.btnSave, "Salvar");
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Image = global::GestaoFinanceira.Properties.Resources.icons8_multiply_26px;
            this.btnCancel.Location = new System.Drawing.Point(28, 9);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(42, 25);
            this.btnCancel.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btnCancel, "Cancelar");
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // dtpBaseTime
            // 
            this.dtpBaseTime.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBaseTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBaseTime.Location = new System.Drawing.Point(51, 188);
            this.dtpBaseTime.Name = "dtpBaseTime";
            this.dtpBaseTime.Size = new System.Drawing.Size(161, 24);
            this.dtpBaseTime.TabIndex = 7;
            // 
            // cbBankSender
            // 
            this.cbBankSender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBankSender.FormattingEnabled = true;
            this.cbBankSender.Location = new System.Drawing.Point(51, 102);
            this.cbBankSender.Name = "cbBankSender";
            this.cbBankSender.Size = new System.Drawing.Size(161, 22);
            this.cbBankSender.TabIndex = 9;
            this.cbBankSender.SelectedIndexChanged += new System.EventHandler(this.cbBankSender_SelectedIndexChanged);
            // 
            // cbDestination
            // 
            this.cbDestination.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDestination.FormattingEnabled = true;
            this.cbDestination.Location = new System.Drawing.Point(51, 148);
            this.cbDestination.Name = "cbDestination";
            this.cbDestination.Size = new System.Drawing.Size(161, 22);
            this.cbDestination.TabIndex = 9;
            this.cbDestination.SelectedIndexChanged += new System.EventHandler(this.cbBankSender_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pnBanner);
            this.panel1.Controls.Add(this.dtpBaseTime);
            this.panel1.Controls.Add(this.cbBankSender);
            this.panel1.Controls.Add(this.cbDestination);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(261, 244);
            this.panel1.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 14);
            this.label2.TabIndex = 11;
            this.label2.Text = "Destino";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 14);
            this.label1.TabIndex = 11;
            this.label1.Text = "Origem";
            // 
            // pnBanner
            // 
            this.pnBanner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(225)))));
            this.pnBanner.Controls.Add(this.lbUnit);
            this.pnBanner.Controls.Add(this.nupValue);
            this.pnBanner.Location = new System.Drawing.Point(15, 11);
            this.pnBanner.Name = "pnBanner";
            this.pnBanner.Size = new System.Drawing.Size(232, 62);
            this.pnBanner.TabIndex = 10;
            // 
            // lbUnit
            // 
            this.lbUnit.AutoSize = true;
            this.lbUnit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(225)))));
            this.lbUnit.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUnit.Location = new System.Drawing.Point(6, 17);
            this.lbUnit.Name = "lbUnit";
            this.lbUnit.Size = new System.Drawing.Size(37, 26);
            this.lbUnit.TabIndex = 1;
            this.lbUnit.Text = "R$";
            // 
            // nupValue
            // 
            this.nupValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(225)))));
            this.nupValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nupValue.CausesValidation = false;
            this.nupValue.DecimalPlaces = 2;
            this.nupValue.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupValue.Location = new System.Drawing.Point(-5, 18);
            this.nupValue.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nupValue.Name = "nupValue";
            this.nupValue.Size = new System.Drawing.Size(263, 28);
            this.nupValue.TabIndex = 0;
            this.nupValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nupValue.ValueChanged += new System.EventHandler(this.cbBankSender_SelectedIndexChanged);
            // 
            // frmTransfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(261, 285);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Microsoft PhagsPa", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmTransfer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Transferência";
            this.Load += new System.EventHandler(this.frmTransfer_Load);
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
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DateTimePicker dtpBaseTime;
        private System.Windows.Forms.ComboBox cbBankSender;
        private System.Windows.Forms.ComboBox cbDestination;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnBanner;
        private System.Windows.Forms.Label lbUnit;
        private System.Windows.Forms.NumericUpDown nupValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}