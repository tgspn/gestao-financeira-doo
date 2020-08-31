namespace GestaoFinanceira.Views
{
    partial class FrmMothCalendar
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
            this.lbYear = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnMesAtual = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.BtnLeftYear = new System.Windows.Forms.Button();
            this.btnRightYear = new System.Windows.Forms.Button();
            this.btnJan = new System.Windows.Forms.Button();
            this.btnFev = new System.Windows.Forms.Button();
            this.btnMar = new System.Windows.Forms.Button();
            this.btnMai = new System.Windows.Forms.Button();
            this.btnJun = new System.Windows.Forms.Button();
            this.btnNov = new System.Windows.Forms.Button();
            this.btnOut = new System.Windows.Forms.Button();
            this.btnSet = new System.Windows.Forms.Button();
            this.btnAgo = new System.Windows.Forms.Button();
            this.btnJul = new System.Windows.Forms.Button();
            this.btnDez = new System.Windows.Forms.Button();
            this.btnAbr = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbYear
            // 
            this.lbYear.AutoSize = true;
            this.lbYear.BackColor = System.Drawing.Color.Black;
            this.lbYear.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbYear.ForeColor = System.Drawing.Color.Snow;
            this.lbYear.Location = new System.Drawing.Point(127, 7);
            this.lbYear.Name = "lbYear";
            this.lbYear.Size = new System.Drawing.Size(45, 20);
            this.lbYear.TabIndex = 1;
            this.lbYear.Text = "2020";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GestaoFinanceira.Properties.Resources.barraAno;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 30);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnMesAtual
            // 
            this.btnMesAtual.Location = new System.Drawing.Point(166, 112);
            this.btnMesAtual.Name = "btnMesAtual";
            this.btnMesAtual.Size = new System.Drawing.Size(75, 23);
            this.btnMesAtual.TabIndex = 2;
            this.btnMesAtual.Text = "Mês Atual";
            this.btnMesAtual.UseVisualStyleBackColor = true;
            this.btnMesAtual.Click += new System.EventHandler(this.btnMesAtual_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancelar.FlatAppearance.BorderSize = 0;
            this.btn_Cancelar.Location = new System.Drawing.Point(55, 112);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancelar.TabIndex = 2;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // BtnLeftYear
            // 
            this.BtnLeftYear.BackColor = System.Drawing.Color.Black;
            this.BtnLeftYear.BackgroundImage = global::GestaoFinanceira.Properties.Resources.icons8_chevron_left_20px;
            this.BtnLeftYear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnLeftYear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLeftYear.FlatAppearance.BorderSize = 0;
            this.BtnLeftYear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLeftYear.Location = new System.Drawing.Point(36, 4);
            this.BtnLeftYear.Margin = new System.Windows.Forms.Padding(0);
            this.BtnLeftYear.Name = "BtnLeftYear";
            this.BtnLeftYear.Size = new System.Drawing.Size(29, 23);
            this.BtnLeftYear.TabIndex = 2;
            this.BtnLeftYear.UseVisualStyleBackColor = false;
            this.BtnLeftYear.Click += new System.EventHandler(this.BtnLeftYear_Click);
            // 
            // btnRightYear
            // 
            this.btnRightYear.BackColor = System.Drawing.Color.Black;
            this.btnRightYear.BackgroundImage = global::GestaoFinanceira.Properties.Resources.icons8_chevron_right_20px;
            this.btnRightYear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRightYear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRightYear.FlatAppearance.BorderSize = 0;
            this.btnRightYear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRightYear.Location = new System.Drawing.Point(236, 4);
            this.btnRightYear.Name = "btnRightYear";
            this.btnRightYear.Size = new System.Drawing.Size(29, 23);
            this.btnRightYear.TabIndex = 2;
            this.btnRightYear.UseVisualStyleBackColor = false;
            this.btnRightYear.Click += new System.EventHandler(this.btnRightYear_Click);
            // 
            // btnJan
            // 
            this.btnJan.BackColor = System.Drawing.Color.Transparent;
            this.btnJan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnJan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnJan.FlatAppearance.BorderSize = 0;
            this.btnJan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJan.Font = new System.Drawing.Font("Century", 11.25F);
            this.btnJan.Location = new System.Drawing.Point(9, 42);
            this.btnJan.Margin = new System.Windows.Forms.Padding(0);
            this.btnJan.Name = "btnJan";
            this.btnJan.Size = new System.Drawing.Size(45, 27);
            this.btnJan.TabIndex = 2;
            this.btnJan.Tag = "Janeiro";
            this.btnJan.Text = "Jan";
            this.btnJan.UseVisualStyleBackColor = false;
            this.btnJan.Click += new System.EventHandler(this.btnJan_Click);
            // 
            // btnFev
            // 
            this.btnFev.BackColor = System.Drawing.Color.Transparent;
            this.btnFev.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnFev.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFev.FlatAppearance.BorderSize = 0;
            this.btnFev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFev.Font = new System.Drawing.Font("Century", 11.25F);
            this.btnFev.Location = new System.Drawing.Point(55, 42);
            this.btnFev.Margin = new System.Windows.Forms.Padding(0);
            this.btnFev.Name = "btnFev";
            this.btnFev.Size = new System.Drawing.Size(45, 27);
            this.btnFev.TabIndex = 2;
            this.btnFev.Tag = "Fevereiro";
            this.btnFev.Text = "Fev";
            this.btnFev.UseVisualStyleBackColor = false;
            this.btnFev.Click += new System.EventHandler(this.btnJan_Click);
            // 
            // btnMar
            // 
            this.btnMar.BackColor = System.Drawing.Color.Transparent;
            this.btnMar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMar.FlatAppearance.BorderSize = 0;
            this.btnMar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMar.Font = new System.Drawing.Font("Century", 11.25F);
            this.btnMar.Location = new System.Drawing.Point(101, 42);
            this.btnMar.Margin = new System.Windows.Forms.Padding(0);
            this.btnMar.Name = "btnMar";
            this.btnMar.Size = new System.Drawing.Size(45, 27);
            this.btnMar.TabIndex = 2;
            this.btnMar.Tag = "Março";
            this.btnMar.Text = "Mar";
            this.btnMar.UseVisualStyleBackColor = false;
            this.btnMar.Click += new System.EventHandler(this.btnJan_Click);
            // 
            // btnMai
            // 
            this.btnMai.BackColor = System.Drawing.Color.Transparent;
            this.btnMai.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMai.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMai.FlatAppearance.BorderSize = 0;
            this.btnMai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMai.Font = new System.Drawing.Font("Century", 11.25F);
            this.btnMai.Location = new System.Drawing.Point(196, 42);
            this.btnMai.Margin = new System.Windows.Forms.Padding(0);
            this.btnMai.Name = "btnMai";
            this.btnMai.Size = new System.Drawing.Size(45, 27);
            this.btnMai.TabIndex = 2;
            this.btnMai.Tag = "Maio";
            this.btnMai.Text = "Mai";
            this.btnMai.UseVisualStyleBackColor = false;
            this.btnMai.Click += new System.EventHandler(this.btnJan_Click);
            // 
            // btnJun
            // 
            this.btnJun.BackColor = System.Drawing.Color.Transparent;
            this.btnJun.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnJun.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnJun.FlatAppearance.BorderSize = 0;
            this.btnJun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJun.Font = new System.Drawing.Font("Century", 11.25F);
            this.btnJun.Location = new System.Drawing.Point(245, 42);
            this.btnJun.Margin = new System.Windows.Forms.Padding(0);
            this.btnJun.Name = "btnJun";
            this.btnJun.Size = new System.Drawing.Size(45, 27);
            this.btnJun.TabIndex = 2;
            this.btnJun.Tag = "Junho";
            this.btnJun.Text = "Jun";
            this.btnJun.UseVisualStyleBackColor = false;
            this.btnJun.Click += new System.EventHandler(this.btnJan_Click);
            // 
            // btnNov
            // 
            this.btnNov.BackColor = System.Drawing.Color.Transparent;
            this.btnNov.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnNov.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNov.FlatAppearance.BorderSize = 0;
            this.btnNov.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNov.Font = new System.Drawing.Font("Century", 11.25F);
            this.btnNov.Location = new System.Drawing.Point(196, 69);
            this.btnNov.Margin = new System.Windows.Forms.Padding(0);
            this.btnNov.Name = "btnNov";
            this.btnNov.Size = new System.Drawing.Size(45, 27);
            this.btnNov.TabIndex = 2;
            this.btnNov.Tag = "Novembro";
            this.btnNov.Text = "Nov";
            this.btnNov.UseVisualStyleBackColor = false;
            this.btnNov.Click += new System.EventHandler(this.btnJan_Click);
            // 
            // btnOut
            // 
            this.btnOut.BackColor = System.Drawing.Color.Transparent;
            this.btnOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOut.FlatAppearance.BorderSize = 0;
            this.btnOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOut.Font = new System.Drawing.Font("Century", 11.25F);
            this.btnOut.Location = new System.Drawing.Point(146, 69);
            this.btnOut.Margin = new System.Windows.Forms.Padding(0);
            this.btnOut.Name = "btnOut";
            this.btnOut.Size = new System.Drawing.Size(45, 27);
            this.btnOut.TabIndex = 2;
            this.btnOut.Tag = "Outubro";
            this.btnOut.Text = "Out";
            this.btnOut.UseVisualStyleBackColor = false;
            this.btnOut.Click += new System.EventHandler(this.btnJan_Click);
            // 
            // btnSet
            // 
            this.btnSet.BackColor = System.Drawing.Color.Transparent;
            this.btnSet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSet.FlatAppearance.BorderSize = 0;
            this.btnSet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSet.Font = new System.Drawing.Font("Century", 11.25F);
            this.btnSet.Location = new System.Drawing.Point(101, 69);
            this.btnSet.Margin = new System.Windows.Forms.Padding(0);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(45, 27);
            this.btnSet.TabIndex = 2;
            this.btnSet.Tag = "Setembro";
            this.btnSet.Text = "Set";
            this.btnSet.UseVisualStyleBackColor = false;
            this.btnSet.Click += new System.EventHandler(this.btnJan_Click);
            // 
            // btnAgo
            // 
            this.btnAgo.BackColor = System.Drawing.Color.Transparent;
            this.btnAgo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAgo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgo.FlatAppearance.BorderSize = 0;
            this.btnAgo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgo.Font = new System.Drawing.Font("Century", 11.25F);
            this.btnAgo.Location = new System.Drawing.Point(55, 69);
            this.btnAgo.Margin = new System.Windows.Forms.Padding(0);
            this.btnAgo.Name = "btnAgo";
            this.btnAgo.Size = new System.Drawing.Size(45, 27);
            this.btnAgo.TabIndex = 2;
            this.btnAgo.Tag = "Agosto";
            this.btnAgo.Text = "Ago";
            this.btnAgo.UseVisualStyleBackColor = false;
            this.btnAgo.Click += new System.EventHandler(this.btnJan_Click);
            // 
            // btnJul
            // 
            this.btnJul.BackColor = System.Drawing.Color.Transparent;
            this.btnJul.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnJul.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnJul.FlatAppearance.BorderSize = 0;
            this.btnJul.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJul.Font = new System.Drawing.Font("Century", 11.25F);
            this.btnJul.Location = new System.Drawing.Point(9, 69);
            this.btnJul.Margin = new System.Windows.Forms.Padding(0);
            this.btnJul.Name = "btnJul";
            this.btnJul.Size = new System.Drawing.Size(45, 27);
            this.btnJul.TabIndex = 2;
            this.btnJul.Tag = "Julho";
            this.btnJul.Text = "Jul";
            this.btnJul.UseVisualStyleBackColor = false;
            this.btnJul.Click += new System.EventHandler(this.btnJan_Click);
            // 
            // btnDez
            // 
            this.btnDez.BackColor = System.Drawing.Color.Transparent;
            this.btnDez.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDez.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDez.FlatAppearance.BorderSize = 0;
            this.btnDez.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDez.Font = new System.Drawing.Font("Century", 11.25F);
            this.btnDez.Location = new System.Drawing.Point(245, 69);
            this.btnDez.Margin = new System.Windows.Forms.Padding(0);
            this.btnDez.Name = "btnDez";
            this.btnDez.Size = new System.Drawing.Size(45, 27);
            this.btnDez.TabIndex = 2;
            this.btnDez.Tag = "Dezembro";
            this.btnDez.Text = "Dez";
            this.btnDez.UseVisualStyleBackColor = false;
            this.btnDez.Click += new System.EventHandler(this.btnJan_Click);
            // 
            // btnAbr
            // 
            this.btnAbr.BackColor = System.Drawing.Color.Transparent;
            this.btnAbr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAbr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAbr.FlatAppearance.BorderSize = 0;
            this.btnAbr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbr.Font = new System.Drawing.Font("Century", 11.25F);
            this.btnAbr.Location = new System.Drawing.Point(146, 42);
            this.btnAbr.Margin = new System.Windows.Forms.Padding(0);
            this.btnAbr.Name = "btnAbr";
            this.btnAbr.Size = new System.Drawing.Size(45, 27);
            this.btnAbr.TabIndex = 2;
            this.btnAbr.Tag = "Abril";
            this.btnAbr.Text = "Abr";
            this.btnAbr.UseVisualStyleBackColor = false;
            this.btnAbr.Click += new System.EventHandler(this.btnJan_Click);
            // 
            // FrmMothCalendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btn_Cancelar;
            this.ClientSize = new System.Drawing.Size(299, 146);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btnRightYear);
            this.Controls.Add(this.btnAbr);
            this.Controls.Add(this.btnDez);
            this.Controls.Add(this.btnJul);
            this.Controls.Add(this.btnAgo);
            this.Controls.Add(this.btnSet);
            this.Controls.Add(this.btnOut);
            this.Controls.Add(this.btnNov);
            this.Controls.Add(this.btnJun);
            this.Controls.Add(this.btnMai);
            this.Controls.Add(this.btnFev);
            this.Controls.Add(this.btnJan);
            this.Controls.Add(this.BtnLeftYear);
            this.Controls.Add(this.btnMesAtual);
            this.Controls.Add(this.lbYear);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnMar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmMothCalendar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calendário";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbYear;
        private System.Windows.Forms.Button btnMesAtual;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button BtnLeftYear;
        private System.Windows.Forms.Button btnRightYear;
        private System.Windows.Forms.Button btnJan;
        private System.Windows.Forms.Button btnFev;
        private System.Windows.Forms.Button btnMar;
        private System.Windows.Forms.Button btnMai;
        private System.Windows.Forms.Button btnJun;
        private System.Windows.Forms.Button btnNov;
        private System.Windows.Forms.Button btnOut;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.Button btnAgo;
        private System.Windows.Forms.Button btnJul;
        private System.Windows.Forms.Button btnDez;
        private System.Windows.Forms.Button btnAbr;
    }
}