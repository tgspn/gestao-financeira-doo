using GestaoFinanceira.BD.Conections;
using GestaoFinanceira.Enums;
using GestaoFinanceira.Model;
using GestaoFinanceira.Utils;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace GestaoFinanceira.Controllers
{
    public class DashBoardController
    {
        AccountController ctrAcc = new AccountController(new MemorySQLConnection<Account>());
        PaymentMethodController ctrPayment = new PaymentMethodController(new MemorySQLConnection<Account>(),new MemorySQLConnection<CreditCard>());
        CreditCardController ctrCredit = new CreditCardController(new MemorySQLConnection<CreditCard>());
        CategoriesController ctrCategories = new CategoriesController(new MemorySQLConnection<Categories>());
        EntryExpensesController ctrEntry = new EntryExpensesController(new MemorySQLConnection<EntryExpenses>());
        ReportController ctrReport = new ReportController();
        public Report report { get; set; }

        public void LoadDemoProgram()
        {
            foreach (var categorie in CategoriesDefault.GetCategories())
            {
                ctrCategories.Save(categorie);
            }

            foreach (var payment in PaymentMethodDefault.GetPaymentMethod())
            {
                if (payment is Account)
                {
                    ctrAcc.Save((Account)payment);
                }
                if (payment is CreditCard)
                {
                    ctrCredit.Save((CreditCard)payment);
                }
            }

            foreach (var entry in EntryesRevenueDefault.GetEntryExpenses())
            {
                ctrEntry.Save(((EntryExpenses)entry));
            }
        }


        public List<Button> GenerateCardsForFlp(PaymentMethodType method)
        {
            List<Button> list = new List<Button>();
            Button button;

            foreach (var payment in ctrPayment.List())
            {
                button = new Button();
                button.Font = new Font("Microsoft PhagsPa", 10, FontStyle.Regular);
                button.Size = new Size(158, 40);
                button.FlatStyle = FlatStyle.Flat;
                button.FlatAppearance.BorderColor = SystemColors.BLUE;
                button.Cursor = Cursors.Hand;

                if (method == PaymentMethodType.BankAccount && payment is Account)
                {
                    button.Text = GenerateCaptionHolder(payment.Holder) + " - " + ((Account)payment).Bank;
                    list.Add(button);
                }
                else if (method == PaymentMethodType.CreditCard && payment is CreditCard)
                {
                    button.Text = GenerateCaptionHolder(payment.Holder) + " - " + ((CreditCard)payment).Issuer;
                    list.Add(button);
                }
            }
            return list;
        }

        private string GenerateCaptionHolder(string name)
        {
            string abbreviation = "";
            var names = name.Split(' ');
            for (int i = names.Length; i > 0; i--)
            {
                abbreviation = names[i - 1].Remove(1, names[i - 1].Length - 1) + "." + abbreviation;
            }

            return abbreviation;
        }

        public void GenerateChart(Chart chart, ChartType typeChart, DateTime date)
        {
            double percent = 0.00;
            int i = 0;

            switch (typeChart)
            {
                case ChartType.Account:
                    chart.Series["Bank"].Points.Clear();
                    chart.Series["Bank"].ChartType = SeriesChartType.Pie;

                    foreach (var acc in ctrAcc.List())
                    {
                        percent = (acc.Balance / report.TotalIncome);
                        chart.Series["Bank"].Points.Add(i);
                        chart.Series["Bank"].Points[i].LegendText = GenerateCaptionHolder(acc.Holder) + " - " + acc.Bank;
                        chart.Series["Bank"].Points[i].Label = percent.ToString("P");
                        chart.Series["Bank"].Points[i].SetValueXY(percent, percent);
                        i++;
                    }
                    break;

                case ChartType.CreditCard:
                    chart.Series["CreditCard"].Points.Clear();
                    foreach (var card in ctrCredit.List())
                    {
                        Report reportCard = ctrReport.GenerateByCreditCard(date, card);
                        chart.Series["CreditCard"].Points.Add(i);
                        chart.Series["CreditCard"].Points[i].YValues[i] = reportCard.TotalExpenses;
                        chart.Series["CreditCard"].Points[i].Label = GenerateCaptionHolder(card.Holder) + " - " + card.Issuer;
                    }
                    break;

                case ChartType.Categories:
                    chart.Series["Categories"].Points.Clear();
                    chart.Series["Categories"].ChartType = SeriesChartType.Pie;
                    List<EntryExpenses> listEntries = ctrEntry.List();

                    foreach (var cat in report.Categories)
                    {
                        foreach (var entry in listEntries)
                        {
                            if (cat.type == EntryType.Expense && cat.Description == entry.Categorie.Description)
                            {
                                percent = (entry.Value / report.TotalExpenses);
                                chart.Series["Categories"].Points.Add(i);
                                chart.Series["Categories"].Points[i].LegendText = cat.Description;
                                chart.Series["Categories"].Points[i].Label = percent.ToString("P");
                                chart.Series["Categories"].Points[i].SetValueXY(percent, percent);
                                i++;
                                break;
                            }
                        }
                    }
                    break;
            }
        }

        public void LoadReport(DateTime date)
        {
            this.report = ctrReport.GenerateByMonth(date);
        }

        internal string GetEconomy(DateTime date)
        {
            return ctrReport.CalcEconomy(date);
        }
    }
}
