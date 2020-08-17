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
        public Report searchedReport { get; set; } = new Report();
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
            editDate = true;
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

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }
        private void cbModels_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadComboBox(report);
        }

        private void LoadComboBox(Report report)
        {
            
            cbEntities.Items.Clear();
            switch (cbModels.Text)
            {
                case "Conta Bancária":
                    foreach (var acc in report.Accounts)
                        cbEntities.Items.Add(ctrDash.GenerateCaptionHolder(acc.Holder) + " - " + acc.Bank);
                    break;
                case "Cartão de Crédido":
                    foreach (var card in report.CreditCards)
                        cbEntities.Items.Add(ctrDash.GenerateCaptionHolder(card.Holder) + " - " + card.Issuer);
                    break;
                case "Receitas":
                    foreach (var revenue in report.EntryRevenue)
                        cbEntities.Items.Add(revenue.Date.ToString("dd/MMM") + " - " + revenue.Description) ;
                    break;
                case "Despesas":
                    foreach (var expense in report.EntryExpenses)
                        cbEntities.Items.Add(expense.Date.ToString("dd/MMM") + " - " + expense.Description);
                    break;
                case "Categorias":
                    foreach (var category in report.Categories)
                        cbEntities.Items.Add(category.Description);
                    break;
                case "SubCategorias":
                        foreach (var subCategory in report.SubCategories)
                            cbEntities.Items.Add(subCategory.Description is null == false ? subCategory.Description : "");
                    break;
            }
        }

        private void dtpDateIni_ValueChanged(object sender, EventArgs e)
        {
            if (editDate)
            {
                searchedReport = ctrReport.GenerateByPeriod(dtpDateIni.Value, dtpDateEnd.Value);
                LoadComboBox(searchedReport);

                dgvReport.DataSource = new BindingList<EntryExpenses>(searchedReport.EntryExpenses);
                ctrDash.CategorieChartForReport(ctCategories, searchedReport, Enums.EntryType.Expense);

                lbDate.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(dtpDateIni.Value.ToString("MMM yyyy")) + " à " + CultureInfo.CurrentCulture.TextInfo.ToTitleCase(dtpDateEnd.Value.ToString("MMM yyyy"));
                lbTotalIncome.Text = searchedReport.TotalIncome.ToString("C");
                lbTotalRevenue.Text = searchedReport.TotalRevenue.ToString("C");
                LbTotalExpense.Text = searchedReport.TotalExpenses.ToString("C");
            }
        }
    }
}
