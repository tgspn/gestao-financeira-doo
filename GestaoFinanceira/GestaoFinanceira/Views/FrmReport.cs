using GestaoFinanceira.Controllers;
using GestaoFinanceira.Enums;
using GestaoFinanceira.Model;
using System;
using System.ComponentModel;
using System.Globalization;
using System.IO;
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

            }
            else
            {
                if (this.Payment is Account)
                {
                    lbSaving.Visible = false;
                    lbBill.Visible = false;
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
            lbTotalRevenue.Text = report.TotalRevenue.ToString("C");
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
                    dtvBankAccount.DataSource = new BindingList<Account>(report.Accounts);
                    break;
                case "Cartão de Crédido":
                    HabilitDataGridView(DtvTypes.CreditCard);
                    dtvCreditCard.DataSource = new BindingList<CreditCard>(report.CreditCards);
                    break;
                case "Receitas":
                    HabilitDataGridView(DtvTypes.Entries);
                    dtvEntries.DataSource = new BindingList<EntryExpenses>(report.EntryRevenue);
                    break;
                case "Despesas":
                    HabilitDataGridView(DtvTypes.Entries);
                    dtvEntries.DataSource = new BindingList<EntryExpenses>(report.EntryExpenses);
                    break;
                case "Categorias":
                    HabilitDataGridView(DtvTypes.Categories);
                    ctrReport.LoadDtvCategories(dtvCategorias, DtvTypes.Categories, report);
                    break;
                case "SubCategorias":
                    HabilitDataGridView(DtvTypes.Categories);
                    ctrReport.LoadDtvCategories(dtvCategorias, DtvTypes.SubCategories, report);
                    break;
            }
        }

        private void HabilitDataGridView(DtvTypes type)
        {
            dtvBankAccount.Visible = false;
            dtvCreditCard.Visible = false;
            dtvCategorias.Visible = false;
            dtvEntries.Visible = false;

            if (type == DtvTypes.Account)
                    dtvBankAccount.Visible = true;
            else if (type == DtvTypes.CreditCard)
                    dtvCreditCard.Visible = true;
            else if(type == DtvTypes.Entries)
                    dtvEntries.Visible = true;
            else if(type == DtvTypes.Categories)
                    dtvCategorias.Visible = true;
            else 
                    dtvEntries.Visible = true;
        }

        private void dtpDateIni_ValueChanged(object sender, EventArgs e)
        {

            if (editDate)
            {
                lbHolder.Visible = false;
                lbName.Visible = false;
                lbSaving.Visible = false;
                lbBill.Visible = false;

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
            using (SaveFileDialog save = new SaveFileDialog())
            {
                save.FileName = $"relatorio_{date:MMMM_yyyy}";
                save.DefaultExt = ".gfc";
                save.AddExtension = true;
                save.Filter = "Arquivo do Gestão Financeira|*.gfc|Arquivos do excel|*.xlsx|Arquivos do excel 97-2003|*.xls|Todos os arquivos|*.*";
                save.Title = "Exportar";
                if (save.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        ctrReport.Export(save.FileName, report);
                        MessageBox.Show("Exportado com sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Algo deu errado, não foi possível exportar", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }


        }


        private void btnImport_Click(object sender, EventArgs e)
        {

        }


        private void btnImport_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog open=new OpenFileDialog())
            {
                open.Filter = "Arquivo do Gestão Financeira|*.gfc|Todos os arquivos|*.*";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        var report= ctrReport.Import(open.FileName);
                        ctrDash.report = report;
                        LoadFilds(report.Date, report);
                    }catch
                    {
                        MessageBox.Show("Não foi possivel abrir o arquivo","Erro",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
