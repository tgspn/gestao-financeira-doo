using GestaoFinanceira.Controllers;
using GestaoFinanceira.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            if (this.Payment is null)
            {
                ctrDash.LoadReport(date);
                report = ctrDash.report;
            }
            else
            {
                if (this.Payment is Account)
                    report = ctrReport.GenerateByAccount(date, ((Account)this.Payment));
                else
                    report = ctrReport.GenerateByCreditCard(date, ((CreditCard)this.Payment));

                ctrDash.report = report;
            }

            LoadFilds(date, report);

        }

        private void LoadFilds(DateTime date, Report report)
        {
            dgvReport.DataSource = new BindingList<EntryExpenses>(report.EntryExpenses);
            ctrDash.GenerateChart(ctCategories, Enums.ChartType.Categories, date);

            lbDate.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(date.ToString("MMMM yyyy"));
            lbTotalIncome.Text = report.TotalIncome.ToString("C");
            lbTotalRevenue.Text = report.TotalRevenue.ToString("C");
            LbTotalExpense.Text = report.TotalExpenses.ToString("C");

            dtpDateIni.Value = new DateTime(date.Year, date.Month, 1);
            dtpDateEnd.Value = new DateTime(date.Year, date.Month, DateTime.DaysInMonth(date.Year, date.Month));

        }
    }
}
