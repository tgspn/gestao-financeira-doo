﻿namespace GestaoFinanceira.Views
{
    partial class FrmListCreditCard
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
            this.dtvCreditCard = new System.Windows.Forms.DataGridView();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.pnCreditCard = new System.Windows.Forms.Panel();
            this.lbCreditCard = new System.Windows.Forms.Label();
            this.cId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIssuer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cHolder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLateFee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cExpirationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cClosingDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtvCreditCard)).BeginInit();
            this.pnCreditCard.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtvCreditCard
            // 
            this.dtvCreditCard.AllowUserToAddRows = false;
            this.dtvCreditCard.AllowUserToDeleteRows = false;
            this.dtvCreditCard.BackgroundColor = System.Drawing.Color.White;
            this.dtvCreditCard.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtvCreditCard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvCreditCard.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cId,
            this.cIssuer,
            this.cHolder,
            this.cAmount,
            this.cNumber,
            this.cLateFee,
            this.cExpirationDate,
            this.cClosingDate});
            this.dtvCreditCard.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dtvCreditCard.Location = new System.Drawing.Point(49, 12);
            this.dtvCreditCard.Name = "dtvCreditCard";
            this.dtvCreditCard.Size = new System.Drawing.Size(881, 149);
            this.dtvCreditCard.TabIndex = 3;
            this.dtvCreditCard.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtvRevenue_CellContentClick);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Image = global::GestaoFinanceira.Properties.Resources.icons8_multiply_26px;
            this.btnCancel.Location = new System.Drawing.Point(49, 167);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(37, 33);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Transparent;
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Image = global::GestaoFinanceira.Properties.Resources.icons8_edit_26px_2;
            this.btnEdit.Location = new System.Drawing.Point(842, 167);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(37, 33);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Image = global::GestaoFinanceira.Properties.Resources.icons8_trash_26px_1;
            this.btnDelete.Location = new System.Drawing.Point(799, 167);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(37, 33);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Image = global::GestaoFinanceira.Properties.Resources.icons8_plus_30px_1;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnAdd.Location = new System.Drawing.Point(885, 167);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(37, 33);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // pnCreditCard
            // 
            this.pnCreditCard.Controls.Add(this.lbCreditCard);
            this.pnCreditCard.Location = new System.Drawing.Point(-2, -5);
            this.pnCreditCard.Name = "pnCreditCard";
            this.pnCreditCard.Size = new System.Drawing.Size(45, 217);
            this.pnCreditCard.TabIndex = 8;
            // 
            // lbCreditCard
            // 
            this.lbCreditCard.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCreditCard.Location = new System.Drawing.Point(3, 17);
            this.lbCreditCard.Name = "lbCreditCard";
            this.lbCreditCard.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbCreditCard.Size = new System.Drawing.Size(36, 189);
            this.lbCreditCard.TabIndex = 3;
            this.lbCreditCard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbCreditCard.Paint += new System.Windows.Forms.PaintEventHandler(this.lbCreditCard_Paint);
            // 
            // cId
            // 
            this.cId.HeaderText = "id";
            this.cId.Name = "cId";
            this.cId.Visible = false;
            // 
            // cIssuer
            // 
            this.cIssuer.HeaderText = "Credor";
            this.cIssuer.Name = "cIssuer";
            this.cIssuer.Width = 70;
            // 
            // cHolder
            // 
            this.cHolder.HeaderText = "Titular";
            this.cHolder.Name = "cHolder";
            this.cHolder.Width = 170;
            // 
            // cAmount
            // 
            this.cAmount.HeaderText = "Saldo";
            this.cAmount.Name = "cAmount";
            // 
            // cNumber
            // 
            this.cNumber.HeaderText = "Numero";
            this.cNumber.Name = "cNumber";
            // 
            // cLateFee
            // 
            this.cLateFee.HeaderText = "% ao mês";
            this.cLateFee.Name = "cLateFee";
            // 
            // cExpirationDate
            // 
            this.cExpirationDate.HeaderText = "Vencimento do Cartão";
            this.cExpirationDate.Name = "cExpirationDate";
            this.cExpirationDate.Width = 150;
            // 
            // cClosingDate
            // 
            this.cClosingDate.HeaderText = "Fechamento da Fatura";
            this.cClosingDate.Name = "cClosingDate";
            this.cClosingDate.Width = 150;
            // 
            // FrmListCreditCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(934, 210);
            this.ControlBox = false;
            this.Controls.Add(this.dtvCreditCard);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.pnCreditCard);
            this.Font = new System.Drawing.Font("Microsoft PhagsPa", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmListCreditCard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.dtvCreditCard)).EndInit();
            this.pnCreditCard.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtvCreditCard;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel pnCreditCard;
        private System.Windows.Forms.Label lbCreditCard;
        private System.Windows.Forms.DataGridViewTextBoxColumn cId;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIssuer;
        private System.Windows.Forms.DataGridViewTextBoxColumn cHolder;
        private System.Windows.Forms.DataGridViewTextBoxColumn cAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLateFee;
        private System.Windows.Forms.DataGridViewTextBoxColumn cExpirationDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn cClosingDate;
    }
}