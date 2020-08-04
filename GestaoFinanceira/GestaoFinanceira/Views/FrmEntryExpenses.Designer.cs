﻿namespace GestaoFinanceira.Views
{
    partial class FrmEntryExpenses
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
            this.ckbRepetir = new System.Windows.Forms.CheckBox();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.cbConta = new System.Windows.Forms.ComboBox();
            this.dtDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.pnBanner = new System.Windows.Forms.Panel();
            this.lbUnit = new System.Windows.Forms.Label();
            this.nupValue = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.cbSubCategoria = new System.Windows.Forms.ComboBox();
            this.btnAddCategorias = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pnBanner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupValue)).BeginInit();
            this.SuspendLayout();
            // 
            // ckbRepetir
            // 
            this.ckbRepetir.AutoSize = true;
            this.ckbRepetir.Location = new System.Drawing.Point(22, 289);
            this.ckbRepetir.Name = "ckbRepetir";
            this.ckbRepetir.Size = new System.Drawing.Size(60, 17);
            this.ckbRepetir.TabIndex = 16;
            this.ckbRepetir.Text = "Repetir";
            this.ckbRepetir.UseVisualStyleBackColor = true;
            // 
            // cbCategoria
            // 
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(22, 220);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(182, 21);
            this.cbCategoria.TabIndex = 15;
            this.cbCategoria.SelectionChangeCommitted += new System.EventHandler(this.txtDescription_TextChanged);
            // 
            // cbConta
            // 
            this.cbConta.FormattingEnabled = true;
            this.cbConta.Location = new System.Drawing.Point(22, 178);
            this.cbConta.Name = "cbConta";
            this.cbConta.Size = new System.Drawing.Size(211, 21);
            this.cbConta.TabIndex = 13;
            this.cbConta.SelectionChangeCommitted += new System.EventHandler(this.txtDescription_TextChanged);
            // 
            // dtDate
            // 
            this.dtDate.Location = new System.Drawing.Point(22, 136);
            this.dtDate.Name = "dtDate";
            this.dtDate.Size = new System.Drawing.Size(211, 20);
            this.dtDate.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Categoria";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Conta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Data";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Descrição";
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(22, 91);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(211, 23);
            this.txtDescription.TabIndex = 11;
            this.txtDescription.TextChanged += new System.EventHandler(this.txtDescription_TextChanged);
            // 
            // pnBanner
            // 
            this.pnBanner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnBanner.Controls.Add(this.lbUnit);
            this.pnBanner.Controls.Add(this.nupValue);
            this.pnBanner.Location = new System.Drawing.Point(12, 12);
            this.pnBanner.Name = "pnBanner";
            this.pnBanner.Size = new System.Drawing.Size(232, 58);
            this.pnBanner.TabIndex = 12;
            // 
            // lbUnit
            // 
            this.lbUnit.AutoSize = true;
            this.lbUnit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbUnit.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUnit.Location = new System.Drawing.Point(6, 16);
            this.lbUnit.Name = "lbUnit";
            this.lbUnit.Size = new System.Drawing.Size(37, 26);
            this.lbUnit.TabIndex = 1;
            this.lbUnit.Text = "R$";
            // 
            // nupValue
            // 
            this.nupValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.nupValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nupValue.CausesValidation = false;
            this.nupValue.DecimalPlaces = 2;
            this.nupValue.Font = new System.Drawing.Font("Comic Sans MS", 14.25F);
            this.nupValue.Location = new System.Drawing.Point(0, 17);
            this.nupValue.Name = "nupValue";
            this.nupValue.Size = new System.Drawing.Size(252, 30);
            this.nupValue.TabIndex = 20;
            this.nupValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nupValue.ValueChanged += new System.EventHandler(this.txtDescription_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "Sub Categoria";
            // 
            // cbSubCategoria
            // 
            this.cbSubCategoria.FormattingEnabled = true;
            this.cbSubCategoria.Location = new System.Drawing.Point(22, 262);
            this.cbSubCategoria.Name = "cbSubCategoria";
            this.cbSubCategoria.Size = new System.Drawing.Size(182, 21);
            this.cbSubCategoria.TabIndex = 15;
            this.cbSubCategoria.SelectionChangeCommitted += new System.EventHandler(this.txtDescription_TextChanged);
            // 
            // btnAddCategorias
            // 
            this.btnAddCategorias.AutoSize = true;
            this.btnAddCategorias.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddCategorias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddCategorias.FlatAppearance.BorderSize = 0;
            this.btnAddCategorias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCategorias.Image = global::GestaoFinanceira.Properties.Resources.icons8_plus_math_15px;
            this.btnAddCategorias.Location = new System.Drawing.Point(210, 220);
            this.btnAddCategorias.Name = "btnAddCategorias";
            this.btnAddCategorias.Size = new System.Drawing.Size(21, 21);
            this.btnAddCategorias.TabIndex = 17;
            this.btnAddCategorias.UseVisualStyleBackColor = true;
            this.btnAddCategorias.Click += new System.EventHandler(this.btnAddCategorias_Click);
            // 
            // btnSave
            // 
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Image = global::GestaoFinanceira.Properties.Resources.icons8_checkmark_30px_2;
            this.btnSave.Location = new System.Drawing.Point(160, 320);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(44, 31);
            this.btnSave.TabIndex = 18;
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Image = global::GestaoFinanceira.Properties.Resources.icons8_delete_30px;
            this.btnCancel.Location = new System.Drawing.Point(38, 324);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(44, 23);
            this.btnCancel.TabIndex = 19;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FrmEntryExpenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(254, 359);
            this.ControlBox = false;
            this.Controls.Add(this.btnAddCategorias);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.ckbRepetir);
            this.Controls.Add(this.cbSubCategoria);
            this.Controls.Add(this.cbCategoria);
            this.Controls.Add(this.cbConta);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.pnBanner);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmEntryExpenses";
            this.Text = "Despesas";
            this.pnBanner.ResumeLayout(false);
            this.pnBanner.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddCategorias;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.CheckBox ckbRepetir;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.ComboBox cbConta;
        private System.Windows.Forms.DateTimePicker dtDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Panel pnBanner;
        private System.Windows.Forms.Label lbUnit;
        private System.Windows.Forms.NumericUpDown nupValue;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbSubCategoria;
    }
}