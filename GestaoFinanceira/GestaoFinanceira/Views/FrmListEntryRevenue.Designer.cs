namespace GestaoFinanceira.Views
{
    partial class FrmListEntryRevenue
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.pnEtries = new System.Windows.Forms.Panel();
            this.lbEntries = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtvRevenue)).BeginInit();
            this.pnEtries.SuspendLayout();
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
            this.dtvRevenue.Location = new System.Drawing.Point(46, 12);
            this.dtvRevenue.Name = "dtvRevenue";
            this.dtvRevenue.Size = new System.Drawing.Size(881, 198);
            this.dtvRevenue.TabIndex = 0;
            this.dtvRevenue.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtvRevenue_CellContentClick);
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
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Image = global::GestaoFinanceira.Properties.Resources.icons8_plus_30px_1;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnAdd.Location = new System.Drawing.Point(890, 256);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(37, 33);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Image = global::GestaoFinanceira.Properties.Resources.icons8_multiply_26px;
            this.btnCancel.Location = new System.Drawing.Point(46, 256);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(37, 33);
            this.btnCancel.TabIndex = 1;
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
            this.btnEdit.Location = new System.Drawing.Point(847, 256);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(37, 33);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Image = global::GestaoFinanceira.Properties.Resources.icons8_trash_26px_1;
            this.btnDelete.Location = new System.Drawing.Point(804, 256);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(37, 33);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // pnEtries
            // 
            this.pnEtries.Controls.Add(this.lbEntries);
            this.pnEtries.Location = new System.Drawing.Point(-5, -5);
            this.pnEtries.Name = "pnEtries";
            this.pnEtries.Size = new System.Drawing.Size(45, 308);
            this.pnEtries.TabIndex = 2;
            // 
            // lbEntries
            // 
            this.lbEntries.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEntries.Location = new System.Drawing.Point(3, 104);
            this.lbEntries.Name = "lbEntries";
            this.lbEntries.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbEntries.Size = new System.Drawing.Size(36, 138);
            this.lbEntries.TabIndex = 3;
            this.lbEntries.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbEntries.Paint += new System.Windows.Forms.PaintEventHandler(this.lbEntries_Paint);
            // 
            // FrmListEntryRevenue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(941, 301);
            this.ControlBox = false;
            this.Controls.Add(this.dtvRevenue);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.pnEtries);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Font = new System.Drawing.Font("Microsoft PhagsPa", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmListEntryRevenue";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.dtvRevenue)).EndInit();
            this.pnEtries.ResumeLayout(false);
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
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Panel pnEtries;
        private System.Windows.Forms.Label lbEntries;
    }
}