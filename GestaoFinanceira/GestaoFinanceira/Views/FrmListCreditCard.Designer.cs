namespace GestaoFinanceira.Views
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
            this.dtvRevenue = new System.Windows.Forms.DataGridView();
            this.cId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descrição = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPaymentMethod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCategories = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cRepeatEvery = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cRepeatUntil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.pnCreditCard = new System.Windows.Forms.Panel();
            this.lbCreditCard = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtvRevenue)).BeginInit();
            this.pnCreditCard.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtvRevenue
            // 
            this.dtvRevenue.AllowUserToAddRows = false;
            this.dtvRevenue.AllowUserToDeleteRows = false;
            this.dtvRevenue.BackgroundColor = System.Drawing.Color.White;
            this.dtvRevenue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtvRevenue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvRevenue.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cId,
            this.Descrição,
            this.cValue,
            this.cPaymentMethod,
            this.cCategories,
            this.cDate,
            this.cStatus,
            this.cRepeatEvery,
            this.cRepeatUntil});
            this.dtvRevenue.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dtvRevenue.Location = new System.Drawing.Point(49, 12);
            this.dtvRevenue.Name = "dtvRevenue";
            this.dtvRevenue.Size = new System.Drawing.Size(881, 149);
            this.dtvRevenue.TabIndex = 3;
            // 
            // cId
            // 
            this.cId.HeaderText = "id";
            this.cId.Name = "cId";
            this.cId.Visible = false;
            // 
            // Descrição
            // 
            this.Descrição.HeaderText = "Descrição";
            this.Descrição.Name = "Descrição";
            this.Descrição.Width = 150;
            // 
            // cValue
            // 
            this.cValue.HeaderText = "Valor";
            this.cValue.Name = "cValue";
            this.cValue.Width = 70;
            // 
            // cPaymentMethod
            // 
            this.cPaymentMethod.HeaderText = "Conta";
            this.cPaymentMethod.Name = "cPaymentMethod";
            // 
            // cCategories
            // 
            this.cCategories.HeaderText = "Categoria";
            this.cCategories.Name = "cCategories";
            // 
            // cDate
            // 
            this.cDate.HeaderText = "Data";
            this.cDate.Name = "cDate";
            // 
            // cStatus
            // 
            this.cStatus.HeaderText = "Status";
            this.cStatus.Name = "cStatus";
            this.cStatus.Width = 70;
            // 
            // cRepeatEvery
            // 
            this.cRepeatEvery.HeaderText = "Repetir";
            this.cRepeatEvery.Name = "cRepeatEvery";
            // 
            // cRepeatUntil
            // 
            this.cRepeatUntil.HeaderText = "Data repetição";
            this.cRepeatUntil.Name = "cRepeatUntil";
            this.cRepeatUntil.Width = 150;
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
            // FrmListCreditCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(934, 210);
            this.ControlBox = false;
            this.Controls.Add(this.dtvRevenue);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.pnCreditCard);
            this.Font = new System.Drawing.Font("Microsoft PhagsPa", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmListCreditCard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.dtvRevenue)).EndInit();
            this.pnCreditCard.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtvRevenue;
        private System.Windows.Forms.DataGridViewTextBoxColumn cId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descrição;
        private System.Windows.Forms.DataGridViewTextBoxColumn cValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPaymentMethod;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCategories;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn cStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn cRepeatEvery;
        private System.Windows.Forms.DataGridViewTextBoxColumn cRepeatUntil;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel pnCreditCard;
        private System.Windows.Forms.Label lbCreditCard;
    }
}