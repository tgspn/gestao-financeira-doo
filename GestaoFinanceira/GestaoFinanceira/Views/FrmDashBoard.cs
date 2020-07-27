using GestaoFinanceira.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestaoFinanceira
{
    public partial class FrmDashBoard : Form
    {
        public FrmDashBoard()
        {
            InitializeComponent();

            this.ctBank.Series["Bank"].Points.Add(0);
            this.ctBank.Series["Bank"].Points[0].LegendText = "Banco A";
            this.ctBank.Series["Bank"].Points[0].SetValueXY(15, 15);
            this.ctBank.Series["Bank"].Points[0].Label = "15%";
            this.ctBank.Series["Bank"].Points.Add(1);
            this.ctBank.Series["Bank"].Points[1].LegendText = "Banco B";
            this.ctBank.Series["Bank"].Points[1].SetValueXY(15, 15);
            this.ctBank.Series["Bank"].Points[1].Label = "15%";
            this.ctBank.Series["Bank"].Points.Add(3);
            this.ctBank.Series["Bank"].Points[2].LegendText = "Banco C";
            this.ctBank.Series["Bank"].Points[2].SetValueXY(70, 70);
            this.ctBank.Series["Bank"].Points[2].Label = "70%";

            this.ctCreditCard.Series["CreditCard"].Points.Add(0);
            this.ctCreditCard.Series["CreditCard"].Points[0].YValues[0] = 350;
            this.ctCreditCard.Series["CreditCard"].Points[0].Label = "Cartão 1";
            this.ctCreditCard.Series["CreditCard"].Points.Add(1);
            this.ctCreditCard.Series["CreditCard"].Points[1].Label = "Cartão 2";
            this.ctCreditCard.Series["CreditCard"].Points[1].YValues[0] = 450;
            this.ctCreditCard.Series["CreditCard"].Points.Add(2);
            this.ctCreditCard.Series["CreditCard"].Points[2].Label = "Cartão 3";
            this.ctCreditCard.Series["CreditCard"].Points[2].YValues[0] = 500;

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOpenCalendar_Click(object sender, EventArgs e)
        {
            Form form = new FrmMothCalendar();
            form.Show();
        }

        private void btnOpenBank_Click(object sender, EventArgs e)
        {
            Form form = new FrmBankAccount();
            form.Show();
        }

        private void btnOpenCreditCard_Click(object sender, EventArgs e)
        {
            Form form = new FrmCreditCard();
            form.Show();
        }

        private void btnOpenEntries_Click(object sender, EventArgs e)
        {
            Form form = new FrmEntries();
            form.Show();
        }

        private void btnOpenExpense_Click(object sender, EventArgs e)
        {
            Form form = new FrmExpense();
            form.Show();
        }

        private void btnOpenRevenue_Click(object sender, EventArgs e)
        {
            Form form = new FrmRevenue();
            form.Show();
        }
    }
}
