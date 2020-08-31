using GestaoFinanceira.BD.Conections;
using GestaoFinanceira.Controllers;
using GestaoFinanceira.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Windows.Forms;

namespace GestaoFinanceira.Views
{
    public partial class frmPayInvoice : Form
    {
        AccountController ctrAccount = new AccountController();
        EntryExpensesController ctrEntry = new EntryExpensesController();
        decimal ValueToPay;

        Report report;
        public frmPayInvoice(Report report, ApplicationDbContext context)
        {
            InitializeComponent();
            this.report = report;
            ctrEntry = context == null ? new EntryExpensesController() : new EntryExpensesController(context);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadFilds()
        {
            Dictionary<string, string> dict = new Dictionary<string, string>()
            { { "Selecione uma Conta", null} };

            foreach (var bank in ctrAccount.List().ToList())
                dict.Add(ctrEntry.GenerateCaptionHolder(bank.Holder) + " - " + bank.Bank, bank.Id.ToString());

            cbBankSender.DataSource = new BindingSource(dict, null);
            cbBankSender.DisplayMember = "Key";
            cbBankSender.ValueMember = "Value";
            btnSave.Enabled = this.ValidFields(cbBankSender);
        }

        private void frmPayInvoice_Load(object sender, EventArgs e)
        {
            LoadLateFeeCalc();
            nupValue.Value = ValueToPay;
            lbAmount.Text = ValueToPay.ToString("F");
            lbLatefee.Text = $"Multa por atrazo: {report.CreditCards[0].LateFee} %";
            lbInterest.Text = $"Juros: {report.CreditCards[0].InterestPerDay} % por dia";
            LoadFilds();
        }

        private void LoadLateFeeCalc()
        {
            List<EntryExpenses> entries = report.EntryExpenses.Where(entry => entry.Status == false).ToList();
            double value = entries.Sum(a => a.Value);
            var DaysOfDalays = this.dtpBaseTime.Value.Day - Convert.ToInt32(report.CreditCards[0].DueDate);
            var MonthOfDalays = entries.Count > 0 ? this.dtpBaseTime.Value.Month - Convert.ToInt32(report.EntryExpenses[0].PaymentDate.Month) : -1;
            //Se a data selecionada for maior que o vencimento da fatura cobra juros
            if (MonthOfDalays > -1 && DaysOfDalays > 0)
            {
                var LateFee = value * (report.CreditCards[0].LateFee / 100);
                var InterestPerDay = (DaysOfDalays * (report.CreditCards[0].InterestPerDay / 100)) * value;
                value += LateFee + InterestPerDay;
                LoadLateFee(LateFee, InterestPerDay);
                ValueToPay =  Convert.ToDecimal(value);
                btnInfo.Visible = true;
            }
            else
            {
                LoadLateFee(0, 0);
                btnInfo.Visible = false;
                ValueToPay = Convert.ToDecimal(value);
            }
        }

        private void LoadLateFee(double lateFee, double interestPerDay)
        {
            lbLatefeeValue.Text = $"Multa: {lateFee.ToString("C")}";
            lbInterestPerDayValue.Text = $"Juros por dia: {interestPerDay.ToString("C")}";
            lbTotalToPay.Text = $"Total: {(lateFee + interestPerDay).ToString("C")}";
        }

        private void ckParcel_CheckedChanged(object sender, EventArgs e)
        {
            if (ckParcel.Checked)
            {
                nupValue.Visible = true;
                lbAmount.Visible = false;
                ckTotal.Checked = false;
                AdjusteLabels();

            }
        }

        private void ckTotal_CheckedChanged(object sender, EventArgs e)
        {
            if (ckTotal.Checked)
            {
                lbAmount.Visible = true;
                nupValue.Visible = false;
                ckParcel.Checked = false;
                lbInfoPay.Visible = false;
                lbInstallment.Visible = false;
            }
        }

        private void nupValue_ValueChanged(object sender, EventArgs e)
        {
            AdjusteLabels();
        }

        private void AdjusteLabels()
        {
            if (nupValue.Value < ValueToPay)
            {
                lbInfoPay.Visible = true;
                lbInfoPay.Text = $"Valor com acréscimo de { report.CreditCards[0].InterestPerMonth} % para o mês seguinte";
                lbInstallment.Visible = true;
                double ValueParcel = (Convert.ToDouble(ValueToPay - nupValue.Value)) * (1 + (report.CreditCards[0].LateFee / 100));
                lbInstallment.Text = ValueParcel.ToString("C");
            }
            else
                nupValue.Value = ValueToPay;
        }

        private void cbBankSender_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnSave.Enabled = this.ValidFields(cbBankSender);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var valueToPay = nupValue.Visible ? Convert.ToDouble(nupValue.Value) : Convert.ToDouble(lbAmount.Text);
            var valueParcel = Convert.ToDouble(lbInstallment.Text.Replace("R$ ", ""));
            int day = Convert.ToInt32(report.CreditCards[0].DueDate);
            int month = Convert.ToInt32(report.CreditCards[0].ClosingDate) < dtpBaseTime.Value.Day ? dtpBaseTime.Value.AddMonths(1).Month : dtpBaseTime.Value.Month;
            int year = Convert.ToInt32(report.CreditCards[0].ClosingDate) < dtpBaseTime.Value.Day ? dtpBaseTime.Value.AddMonths(1).Year : dtpBaseTime.Value.AddMonths(1).Year;
            var date = DateTime.Parse($"{day}-{month}-{year}");
            ctrEntry.PayCreditCard(Convert.ToInt32(cbBankSender.SelectedValue), report.CreditCards[0].Id, valueToPay, valueParcel, dtpBaseTime.Value, date);
            
            foreach(var entry in report.EntryExpenses.Where(entry=> entry.Status == false).ToList())
            {
                entry.Status = true;
                ctrEntry.Save(entry);
                EntryExpenses oldExpense = entry.Clone();
                oldExpense.Value *= (-1);
                ctrEntry.PerformTransaction(oldExpense);
            }
            
            MessageBox.Show("Pagamento realizado com sucesso!", "Informativo", MessageBoxButtons.OK);
            this.Close();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            var msg = $"Conta com {this.dtpBaseTime.Value.Day - Convert.ToInt32(report.CreditCards[0].DueDate)} dias de atraso, confira o dia a ser pago.";
            MessageBox.Show(msg, "Conta com atraso", MessageBoxButtons.OK);
        }

        private void dtpBaseTime_ValueChanged(object sender, EventArgs e)
        {
            LoadLateFeeCalc();
            lbAmount.Text = ValueToPay.ToString("F");
        }

        public ApplicationDbContext GetContext() {
            return ctrEntry.Context;
        }
    }
}
