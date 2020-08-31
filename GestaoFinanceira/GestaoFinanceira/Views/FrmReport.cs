using GestaoFinanceira.Controllers;
using GestaoFinanceira.Enums;
using GestaoFinanceira.Model;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Linq;
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
                pnPayment.Visible = false;
                lbHolder.Visible = false;
                lbName.Visible = false;

            }
            else
            {
                pnReport.Visible = false;
                pnPayment.Visible = true;
                if (this.Payment is Account)
                {
                    lbPayment.Text = $"{ctrDash.GenerateCaptionHolder(Payment.Holder)} - {((Account)Payment).Bank}";
                    lbName.Text += Payment.Holder;
                    lbName.Visible = true;
                    lbHolder.Visible = true;
                    btnPayFatura.Visible = false;
                    report = ctrReport.GenerateByAccount(date, ((Account)this.Payment));
                }
                else
                {
                    lbPayment.Text = $"{ctrDash.GenerateCaptionHolder(Payment.Holder)} - {((CreditCard)Payment).Issuer}";
                    lbName.Text += Payment.Holder;
                    lbName.Visible = true;
                    lbHolder.Visible = true;
                    lbCaptionRevenue2.Text = "Limite";
                    report = ctrReport.GenerateByCreditCard(date, ((CreditCard)this.Payment));
                }

                ctrDash.report = report;
            }

            LoadFilds(date, report);
            editDate = true;
        }

        private void LoadFilds(DateTime date, Report report)
        {
            DateTime dateToBoard = VerificDateForCreditCard(report, date);
            dtvEntries.DataSource = new BindingList<EntryExpenses>(report.EntryExpenses);
            ctrDash.GenerateChart(ctCategories, ChartType.Categories, date);

            lbDate.Text = lbDate2.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(dateToBoard.ToString("MMMM yyyy"));
            lbTotalIncome.Text = lbTotalIncome2.Text  = report.TotalIncome.ToString("C");
            lbTotalRevenue.Text = lbTotalRevenue2.Text = report.Accounts.Count() > 0 ? report.TotalRevenue.ToString("C") : report.CreditCards.Sum(c => c.Limit).ToString("C");
            LbTotalExpense.Text = LbTotalExpense2.Text = report.TotalExpenses.ToString("C");
            lbParcelCost.Text = report.CreditCards.Count > 0 ? (report.CreditCards[0].Limit - (report.TotalIncome + report.TotalExpenses)).ToString("C") : "0.00";

            dtpDateIni.Value = new DateTime(date.Year, date.Month, 1);
            dtpDateEnd.Value = new DateTime(date.Year, date.Month, DateTime.DaysInMonth(date.Year, date.Month));
        }

        private void cbModels_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbModels.Text)
            {
                case "Conta Bancária":
                    lbFilter.Text = "Relatório de Contas";
                    HabilitDataGridView(DtvTypes.Account);
                    dtvBankAccount.DataSource = new BindingList<Account>(report.Accounts.OrderBy(a=> a.Id).ToList());
                    break;
                case "Cartão de Crédido":
                    lbCaptionRevenue.Text = "Limite";
                    lbFilter.Text = "Relatório de Cartões de Crédito";
                    lbTotalRevenue.Text = report.CreditCards.Sum(c => c.Limit).ToString("C");
                    HabilitDataGridView(DtvTypes.CreditCard);
                    dtvCreditCard.DataSource = new BindingList<CreditCard>(report.CreditCards.OrderBy(a => a.Id).ToList());
                    break;
                case "Receitas":
                    HabilitDataGridView(DtvTypes.Entries);
                    lbFilter.Text = "Relatório de Receitas";
                    dtvEntries.DataSource = new BindingList<EntryExpenses>(report.EntryRevenue.OrderBy(a => a.Id).ToList());
                    break;
                case "Despesas":
                    lbFilter.Text = "Relatório de Despesas";
                    HabilitDataGridView(DtvTypes.Entries);
                    dtvEntries.DataSource = new BindingList<EntryExpenses>(report.EntryExpenses.OrderBy(a => a.Id).ToList());
                    break;
                case "Categorias":
                    lbFilter.Text = "Relatório de Categorias";
                    HabilitDataGridView(DtvTypes.Categories);
                    ctrReport.LoadDtvCategories(dtvCategorias, DtvTypes.Categories, report);
                    break;
                case "SubCategorias":
                    lbFilter.Text = "Relatório de SubCategorias";
                    HabilitDataGridView(DtvTypes.Categories);
                    ctrReport.LoadDtvCategories(dtvCategorias, DtvTypes.SubCategories, report);
                    break;
                case "Transferências":
                    lbFilter.Text = "Relatório de Transferências";
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
                lbCaptionRevenue.Text = "Receita";

                report = ctrReport.GenerateByPeriod(dtpDateIni.Value, dtpDateEnd.Value);
                HabilitDataGridView(DtvTypes.Entries);
                dtvEntries.DataSource = new BindingList<EntryExpenses>(report.EntryExpenses);
                ctrDash.CategorieChartForReport(ctCategories, report, EntryType.Expense);

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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbCategories_Paint(object sender, PaintEventArgs e)
        {
            Font myFont = new Font("Microsoft PhagsPa", 16, FontStyle.Bold);
            Brush myBrush = new SolidBrush(Color.Black);
            e.Graphics.TranslateTransform(6, 300);
            e.Graphics.RotateTransform(-90);
            e.Graphics.DrawString("Relatório", myFont, myBrush, 0, 0);
        }

        private void btnPayFatura_Click(object sender, EventArgs e)
        {
            frmPayInvoice pay = new frmPayInvoice(report, ctrReport.Context);
            pay.ShowDialog();
            ctrReport = new ReportController();
            LoadFilds(date, ctrReport.GenerateByCreditCard(date, report.CreditCards[0]));
        }

        private DateTime VerificDateForCreditCard(Report report, DateTime date)
        {
            if (report.Accounts.Count == 0 && report.CreditCards.Count > 0)
            {
                int day = Convert.ToInt32(report.CreditCards[0].ClosingDate);
                int month = date.Day > day ? date.AddMonths(1).Month : date.Month;
                int year = date.Day > day ? date.AddMonths(1).Year : date.Year;
                return new DateTime(year, month, day);
            }
            return date;
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
