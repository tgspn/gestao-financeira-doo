namespace GestaoFinanceira.Views
{
    partial class FrmEntries
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
            this.btnRevenue = new System.Windows.Forms.Button();
            this.btnExpense = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(97, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adicionar";
            // 
            // btnRevenue
            // 
            this.btnRevenue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRevenue.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnRevenue.FlatAppearance.BorderSize = 0;
            this.btnRevenue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRevenue.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRevenue.Image = global::GestaoFinanceira.Properties.Resources.icons8_up_30px;
            this.btnRevenue.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRevenue.Location = new System.Drawing.Point(12, 46);
            this.btnRevenue.Name = "btnRevenue";
            this.btnRevenue.Size = new System.Drawing.Size(96, 34);
            this.btnRevenue.TabIndex = 1;
            this.btnRevenue.Text = "Receita";
            this.btnRevenue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRevenue.UseVisualStyleBackColor = true;
            this.btnRevenue.Click += new System.EventHandler(this.btnRevenue_Click);
            // 
            // btnExpense
            // 
            this.btnExpense.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExpense.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnExpense.FlatAppearance.BorderSize = 0;
            this.btnExpense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExpense.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExpense.Image = global::GestaoFinanceira.Properties.Resources.icons8_down_arrow_30px;
            this.btnExpense.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExpense.Location = new System.Drawing.Point(168, 46);
            this.btnExpense.Name = "btnExpense";
            this.btnExpense.Size = new System.Drawing.Size(102, 34);
            this.btnExpense.TabIndex = 1;
            this.btnExpense.Text = "Despesa";
            this.btnExpense.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExpense.UseVisualStyleBackColor = true;
            this.btnExpense.Click += new System.EventHandler(this.btnExpense_Click);
            // 
            // FrmEntries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(282, 94);
            this.ControlBox = false;
            this.Controls.Add(this.btnExpense);
            this.Controls.Add(this.btnRevenue);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmEntries";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRevenue;
        private System.Windows.Forms.Button btnExpense;
    }
}