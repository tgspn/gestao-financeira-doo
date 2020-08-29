using GestaoFinanceira.Controllers;
using GestaoFinanceira.Enums;
using GestaoFinanceira.Model;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace GestaoFinanceira.Views
{
    public partial class FrmReport : Form
    {
        DashBoardController ctrDash = new DashBoardController();
        ReportController ctrReport = new ReportController();
        public Report report { get; set; } = new Report();
        public PaymentMethod Payment { get; set; }
        public DateTime date { get; set; }
        bool editDate = false;

        public FrmReport()
        {
            InitializeComponent();
        }
        public FrmReport(Report report, DateTime date)
        {
            InitializeComponent();
            this.report = report;
            this.date = date;
        }

        private void FrmReport_Load(object sender, EventArgs e)
        {
            lbHolder.Text = "Titular: ";
            if (this.Payment is null)
            {
                ctrDash.LoadReport(date);
                report = ctrDash.report;
                lbHolder.Visible = false;
                lbName.Visible = false;

            }
            else
            {
                if (this.Payment is Account)
                {
                    lbDate.Text = ((Account)Payment).Bank;
                    lbName.Text += Payment.Holder;
                    lbName.Visible = true;
                    lbHolder.Visible = true;
                    report = ctrReport.GenerateByAccount(date, ((Account)this.Payment));
                }
                else
                {
                    lbDate.Text = ((CreditCard)Payment).Issuer;
                    lbName.Text += Payment.Holder;
                    lbName.Visible = true;
                    lbHolder.Visible = true;
                    lbCaptionRevenue.Text = "Limite";
                    report = ctrReport.GenerateByCreditCard(date, ((CreditCard)this.Payment));
                }

                ctrDash.report = report;
            }

            LoadFilds(date, report);
            editDate = true;
        }

        private void LoadFilds(DateTime date, Report report)
        {
            dtvEntries.DataSource = new BindingList<EntryExpenses>(report.EntryExpenses);
            ctrDash.GenerateChart(ctCategories, Enums.ChartType.Categories, date);

            lbDate.Text += " - " +  CultureInfo.CurrentCulture.TextInfo.ToTitleCase(date.ToString("MMMM yyyy"));
            lbTotalIncome.Text = report.TotalIncome.ToString("C");
            lbTotalRevenue.Text = report.Accounts.Count() > 0 ? report.TotalRevenue.ToString("C") : report.CreditCards.Sum(c => c.Limit).ToString("C");
            LbTotalExpense.Text = report.TotalExpenses.ToString("C");

            dtpDateIni.Value = new DateTime(date.Year, date.Month, 1);
            dtpDateEnd.Value = new DateTime(date.Year, date.Month, DateTime.DaysInMonth(date.Year, date.Month));
        }

        private void cbModels_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbModels.Text)
            {
                case "Conta Bancária":
                    HabilitDataGridView(DtvTypes.Account);
                    dtvBankAccount.DataSource = new BindingList<Account>(report.Accounts.OrderBy(a=> a.Id).ToList());
                    break;
                case "Cartão de Crédido":
                    lbCaptionRevenue.Text = "Limite";
                    lbTotalRevenue.Text = report.CreditCards.Sum(c => c.Limit).ToString("C");
                    HabilitDataGridView(DtvTypes.CreditCard);
                    dtvCreditCard.DataSource = new BindingList<CreditCard>(report.CreditCards.OrderBy(a => a.Id).ToList());
                    break;
                case "Receitas":
                    HabilitDataGridView(DtvTypes.Entries);
                    dtvEntries.DataSource = new BindingList<EntryExpenses>(report.EntryRevenue.OrderBy(a => a.Id).ToList());
                    break;
                case "Despesas":
                    HabilitDataGridView(DtvTypes.Entries);
                    dtvEntries.DataSource = new BindingList<EntryExpenses>(report.EntryExpenses.OrderBy(a => a.Id).ToList());
                    break;
                case "Categorias":
                    HabilitDataGridView(DtvTypes.Categories);
                    ctrReport.LoadDtvCategories(dtvCategorias, DtvTypes.Categories, report);
                    break;
                case "SubCategorias":
                    HabilitDataGridView(DtvTypes.Categories);
                    ctrReport.LoadDtvCategories(dtvCategorias, DtvTypes.SubCategories, report);
                    break;
                case "Transferências":
                    HabilitDataGridView(DtvTypes.Transfer);
                    dtvEntries2.DataSource = new BindingList<EntryExpenses>(report.EntryTransfer.OrderBy(a => a.Id).ToList());
                    break;
            }
        }

        private void HabilitDataGridView(DtvTypes type)
        {
            dtvBankAccount.Visible = false;
            dtvCreditCard.Visible = false;
            dtvCategorias.Visible = false;
            dtvEntries.Visible = false;
            dtvEntries2.Visible = false;

            if (type == DtvTypes.Account)
                    dtvBankAccount.Visible = true;
            else if (type == DtvTypes.CreditCard)
                    dtvCreditCard.Visible = true;
            else if(type == DtvTypes.Entries)
                    dtvEntries.Visible = true;
            else if(type == DtvTypes.Categories)
                    dtvCategorias.Visible = true;
            else if (type == DtvTypes.Transfer)
                    dtvEntries2.Visible = true;
            else 
                    dtvEntries.Visible = true;
        }

        private void dtpDateIni_ValueChanged(object sender, EventArgs e)
        {

            if (editDate)
            {
                lbHolder.Visible = false;
                lbName.Visible = false;
                lbCaptionRevenue.Text = "Receita";

                report = ctrReport.GenerateByPeriod(dtpDateIni.Value, dtpDateEnd.Value);
                HabilitDataGridView(DtvTypes.Entries);
                dtvEntries.DataSource = new BindingList<EntryExpenses>(report.EntryExpenses);
                ctrDash.CategorieChartForReport(ctCategories, report, Enums.EntryType.Expense);

                lbDate.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(dtpDateIni.Value.ToString("MMM yyyy")) + " à " + CultureInfo.CurrentCulture.TextInfo.ToTitleCase(dtpDateEnd.Value.ToString("MMM yyyy"));
                lbTotalIncome.Text = report.TotalIncome.ToString("C");
                lbTotalRevenue.Text = report.TotalRevenue.ToString("C");
                LbTotalExpense.Text = report.TotalExpenses.ToString("C");
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbCategories_Paint(object sender, PaintEventArgs e)
        {
            Font myFont = new Font("Microsoft PhagsPa", 16, FontStyle.Bold);
            Brush myBrush = new SolidBrush(Color.Black);
            e.Graphics.TranslateTransform(6, 200);
            e.Graphics.RotateTransform(-90);
            e.Graphics.DrawString("Relatório", myFont, myBrush, 0, 0);
        }
    }
}
