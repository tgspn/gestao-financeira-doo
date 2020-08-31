using GestaoFinanceira.Controllers;
using GestaoFinanceira.Enums;
using GestaoFinanceira.Model;
using GestaoFinanceira.Views;
using System;
using System.Globalization;
using System.Runtime.Remoting.Messaging;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestaoFinanceira
{
    public partial class FrmDashBoard : Form
    {
        //DashBoardController ctr = new DashBoardController();
        DateTime date = DateTime.Now;
        private Report report { get; set; }

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
                this.btnOpenCalendar.Text = form.Month;
                this.date = form.Date;
                this.LoadFilds();
            }
        }

        private void btnOpenBank_Click(object sender, EventArgs e)
        {
            FrmBankAccount form = new FrmBankAccount();
            form.FormClosed += Form_FormClosed;
            form.Show();

        }

        private void btnOpenCreditCard_Click(object sender, EventArgs e)
        {
            FrmCreditCard form = new FrmCreditCard();
            form.FormClosed += Form_FormClosed;
            form.Show();
        }

        private void btnOpenEntries_Click(object sender, EventArgs e)
        {
            FrmEntries form = new FrmEntries();
            if (form.ShowDialog(this) == DialogResult.OK)
            {
                FrmEntryExpenses frm = new FrmEntryExpenses(form.EntryType);
                frm.FormClosed += Form_FormClosed;
                frm.Show();
            }
        }

        private void btnOpenExpense_Click(object sender, EventArgs e)
        {
            FrmListEntryRevenue form = new FrmListEntryRevenue(EntryType.Expense, date);
            form.FormClosed += Form_FormClosed;
            form.Show();
        }

        private void btnOpenRevenue_Click(object sender, EventArgs e)
        {
            FrmListEntryRevenue form = new FrmListEntryRevenue(EntryType.Revenue, date);
            form.FormClosed += Form_FormClosed;
            form.Show();
        }

        private void ctCategories_Click(object sender, EventArgs e)
        {
            FrmListCategories form = new FrmListCategories();
            form.FormClosed += Form_FormClosed;
            form.Show();
        }

        private void exportarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReport form = new FrmReport(this.report, date);
            form.Show();
        }

        private void gerarRelatórioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReport form = new FrmReport(this.report, date);
            form.Show();
        }

        private void GerarRelatórioByButton_Click(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            FrmReport form = new FrmReport(this.report, date);
            form.Payment = (PaymentMethod)btn.Tag;
            form.FormClosed += Form_FormClosed;
            form.Show();
        }


        private void despesaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEntryExpenses form = new FrmEntryExpenses(EntryType.Expense);
            form.FormClosed += Form_FormClosed;
            form.Show();
        }

        private void receitaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEntryExpenses form = new FrmEntryExpenses(EntryType.Revenue);
            form.FormClosed += Form_FormClosed;
            form.Show();
        }

        private void sairToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }


        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCategories form = new FrmCategories();
            form.FormClosed += Form_FormClosed;
            form.Show();
        }

        private void versãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new FrmAbout();
            form.Show();
        }

        private void ctCreditCard_Click(object sender, EventArgs e)
        {
            FrmListCreditCard form = new FrmListCreditCard();
            form.FormClosed += Form_FormClosed;
            form.Show();
        }

        private void cartãoDeCréditoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmListCreditCard form = new FrmListCreditCard();
            form.FormClosed += Form_FormClosed;
            form.Show();
        }

        private void despesasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListEntryRevenue form = new FrmListEntryRevenue(EntryType.Expense, date);
            form.Show();
        }

        private void receitasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListEntryRevenue form = new FrmListEntryRevenue(EntryType.Revenue, date);
            form.FormClosed += Form_FormClosed;
            form.Show();
        }

        private void contaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListBankAccount form = new FrmListBankAccount();
            form.FormClosed += Form_FormClosed;
            form.Show();

        }

        private void Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form form = sender as Form;
            form.FormClosed -= Form_FormClosed;
            this.LoadFlowPanels();
            this.LoadFilds();
        }

        private void FrmDashBoard_Load(object sender, EventArgs e)
        {

        }

        private void LoadFlowPanels()
        {
            FlpAccounts.Controls.Clear();
            FlpCreditCard.Controls.Clear();
            using (DashBoardController ctr = new DashBoardController())
            {
                foreach (var button in ctr.GenerateCardsForFlp(PaymentMethodType.BankAccount))
                {
                    button.Click += new System.EventHandler(this.GerarRelatórioByButton_Click);
                    FlpAccounts.Controls.Add(button);
                }
                foreach (var button in ctr.GenerateCardsForFlp(PaymentMethodType.CreditCard))
                {
                    button.Click += new System.EventHandler(this.GerarRelatórioByButton_Click);
                    FlpCreditCard.Controls.Add(button);
                }
            }
        }

        private void LoadFilds()
        {
            using (DashBoardController ctr = new DashBoardController())
            {
                ctr.LoadReport(date);
                report = ctr.report;

                btnOpenCalendar.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(date.ToString("MMMM"));
                lbBalance.Text = report.TotalIncome.ToString("C");
                lbExpense.Text = report.TotalExpenses.ToString("C");
                lbRevenue.Text = report.TotalRevenue.ToString("C");
                lbEconomy.Text = ctr.GetEconomy(date);

                ctr.GenerateChart(this.ctBank, ChartType.Account, date);
                ctr.GenerateChart(this.ctCategories, ChartType.Categories, date);
                ctr.GenerateChart(this.ctCreditCard, ChartType.CreditCard, date);
            }

        }

        private async void FrmDashBoard_Shown(object sender, EventArgs e)
        {
            await Task.Run(() => { });
            this.LoadFlowPanels();
            await Task.Run(() => { });
            this.LoadFilds();
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            date = date.AddMonths(1);
            LoadFilds();
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            date = date.AddMonths(-1);
            LoadFilds();
        }
    }
}
