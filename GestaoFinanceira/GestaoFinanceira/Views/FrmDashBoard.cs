using GestaoFinanceira.Controllers;
using GestaoFinanceira.Enums;
using GestaoFinanceira.Model;
using GestaoFinanceira.Views;
using System;
using System.Globalization;
using System.Windows.Forms;

namespace GestaoFinanceira
{   
    public partial class FrmDashBoard : Form
    {
        DashBoardController ctr = new DashBoardController();
        DateTime date = DateTime.Now;

        public FrmDashBoard()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOpenCalendar_Click(object sender, EventArgs e)
        {
            FrmMothCalendar form = new FrmMothCalendar();

            if (form.ShowDialog() == DialogResult.OK)
            {
                this.lb_Month.Text = form.Month;
                this.date = form.Date;
                this.LoadFilds();
            }
        }

        private void btnOpenBank_Click(object sender, EventArgs e)
        {
            FrmBankAccount form = new FrmBankAccount();
            if (form.ShowDialog() == DialogResult.OK)
            {
                form.Show();
                this.LoadFilds();
            }
        }

        private void btnOpenCreditCard_Click(object sender, EventArgs e)
        {
            FrmCreditCard form = new FrmCreditCard();
            if (form.ShowDialog() == DialogResult.OK)
            {
                this.LoadFilds();
            }
        }

        private void btnOpenEntries_Click(object sender, EventArgs e)
        {
            FrmEntries form = new FrmEntries();
            if(form.ShowDialog(this)==DialogResult.OK)
            {
                FrmEntryExpenses frm = new FrmEntryExpenses(form.EntryType);
                if (frm.ShowDialog(this) == DialogResult.OK)
                {
                    this.LoadFilds(); 
                }
            }
        }

        private void btnOpenExpense_Click(object sender, EventArgs e)
        {
            FrmListEntryRevenue form = new FrmListEntryRevenue(EntryType.Expense);
            if (form.ShowDialog() == DialogResult.OK)
            {
                this.LoadFilds();
            }
        }

        private void btnOpenRevenue_Click(object sender, EventArgs e)
        {
            FrmListEntryRevenue form = new FrmListEntryRevenue(EntryType.Revenue);
            if (form.ShowDialog() == DialogResult.OK)
            {
                this.LoadFilds();
            }
        }

        private void ctCategories_Click(object sender, EventArgs e)
        {
            FrmListCategories form = new FrmListCategories ();
            if (form.ShowDialog() == DialogResult.OK)
            {
                this.LoadFilds();
            }
        }

        private void gerarRelatórioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new FrmReport();
            form.Show();
        }

        private void despesaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEntryExpenses form = new FrmEntryExpenses(EntryType.Expense);
            if (form.ShowDialog() == DialogResult.OK)
            {
                this.LoadFilds();
            }
        }

        private void receitaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEntryExpenses form = new FrmEntryExpenses(EntryType.Revenue);
            if (form.ShowDialog() == DialogResult.OK)
            {
                this.LoadFilds();
            }
        }

        private void exportarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new FrmReport();
            form.Show();
        }

        private void sairToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }


        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCategories form = new FrmCategories();
            if (form.ShowDialog() == DialogResult.OK)
            {
                this.LoadFilds();
            }
        }

        private void versãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new FrmAbout();
            form.Show();
        }

        private void ctCreditCard_Click(object sender, EventArgs e)
        {
            FrmListCreditCard form = new FrmListCreditCard();
            if (form.ShowDialog() == DialogResult.OK)
            {
                this.LoadFilds();
            }
        }

        private void cartãoDeCréditoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmListCreditCard form = new FrmListCreditCard();
            if (form.ShowDialog() == DialogResult.OK)
            {
                this.LoadFilds();
            }
        }

        private void despesasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListEntryRevenue form = new FrmListEntryRevenue(EntryType.Expense);
            form.Show();
        }

        private void receitasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListEntryRevenue form = new FrmListEntryRevenue(EntryType.Revenue);
            if (form.ShowDialog() == DialogResult.OK)
            {
                this.LoadFilds();
            }
        }

        private void contaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListBankAccount form = new FrmListBankAccount();
            if (form.ShowDialog() == DialogResult.OK)
            {
                this.LoadFilds();
            }
        }

        private void FrmDashBoard_Load(object sender, EventArgs e)
        {
            ctr.LoadDemoProgram();
            this.LoadFilds();

        }

        private void LoadFilds()
        {
            FlpAccounts.Controls.Clear();
            FlpCreditCard.Controls.Clear();

            foreach (var button in ctr.GenerateCardsForFlp(PaymentMethodType.BankAccount))
                FlpAccounts.Controls.Add(button);
            foreach (var button in ctr.GenerateCardsForFlp(PaymentMethodType.CreditCard))
                FlpCreditCard.Controls.Add(button);

            ctr.LoadReport(date);
            Report report = ctr.report;

            lb_Month.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(date.ToString("MMMM"));
            lbBalance.Text = report.TotalIncome.ToString("C");
            lbExpense.Text = report.TotalExpenses.ToString("C");
            lbRevenue.Text = report.TotalRevenue.ToString("C");
            lbEconomy.Text = ctr.GetEconomy(date);

            ctr.GenerateChart(this.ctBank, ChartType.Account, date);
            ctr.GenerateChart(this.ctCategories, ChartType.Categories, date);
            ctr.GenerateChart(this.ctCreditCard, ChartType.CreditCard, date);
        }
    }
}
