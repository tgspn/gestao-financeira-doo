using GestaoFinanceira.BD.Conections;
using GestaoFinanceira.Enums;
using GestaoFinanceira.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace GestaoFinanceira.Controllers
{
    class ReportController : ControllerBase
    {

        EntryExpensesController ctrEntry = new EntryExpensesController();
        public ReportController()
        {

        }
        public ReportController(ApplicationDbContext db) : base(db)
        {
        }

        public void Export(string fileName, Report report)
        {
            if (Path.GetExtension(fileName) == ".gfc")
                ReportExportImportManager.GenerateGFC(fileName, report);
            else
                ReportExportImportManager.GenerateExcel(fileName, report);
        }

        public Report Import(string filename)
        {
            if (Path.GetExtension(filename) == ".gfc")
                return Newtonsoft.Json.JsonConvert.DeserializeObject<Report>(File.ReadAllText(filename));

            throw new Exception("Arquivo invalido");
        }

        public Report GenerateByDay()
        {
            throw new NotImplementedException();
        }

        public Report GenerateByMonth(DateTime date)
        {
            Report report = new Report();
            report.TotalIncome = 0.00;
            report.TotalExpenses = 0.00;
            report.TotalRevenue = 0.00;
            report.Date=date;

            foreach (var payment in Context.PaymentMethod)
            {
                if (payment is Account)
                {
                    report.TotalIncome = ((Account)payment).Balance + report.TotalIncome;
                    report.Accounts.Add(payment as Account);
                }
                else
                {
                    report.CreditCards.Add((CreditCard)payment);
                }
            }

            foreach (var entry in Context.Expenses.Include("Category").Include("SubCategory").ToList())
            {
                if (CheckMonth(date, entry.Date))
                {
                    RulesForFeactures(report, entry);
                }
            }
            return report;
        }

        public Report GenerateByYear()
        {
            throw new NotImplementedException();
        }

        public Report GenerateByPeriod(DateTime dateIni, DateTime dateEnd)
        {
            Report report = new Report();
            report.TotalIncome = 0.00;
            report.TotalExpenses = 0.00;
            report.TotalRevenue = 0.00;
            double balance = 0.00;

            foreach (var method in Context.PaymentMethod.ToList())
            {
                if (method is Account)
                {
                    report.Accounts.Add((Account)method);
                    report.TotalIncome += ((Account)method).Balance;
                }
                else
                    report.CreditCards.Add((CreditCard)method);
            }

            LoadEntriesAndCategoriesOnDate(report, dateIni);
            LoadEntriesAndCategoriesToDate(report, dateEnd);

            foreach (var acc in report.Accounts)
                balance += acc.Balance;
            foreach (var expense in report.EntryExpenses)
                report.TotalExpenses += expense.Value;
            foreach (var revenue in report.EntryRevenue)
                report.TotalRevenue += revenue.Value;

            report.TotalIncome = balance - report.TotalExpenses;
            return report;
        }

        private void LoadEntriesAndCategoriesOnDate(Report report, DateTime dateInit)
        {
            foreach (var entry in Context.Expenses.Include("Category").Include("SubCategory").ToList())
            {
                if (DateTime.Compare(entry.Date, dateInit) > 0 && entry.EntryType == EntryType.Expense)
                {
                    report.EntryExpenses.Add(entry);
                    if (!(report.Categories.Contains(entry.Category)))
                        report.Categories.Add(entry.Category) ;
                    if (!(entry.SubCategory is null) && string.IsNullOrEmpty(entry.Description))
                        if(!(report.SubCategories.Contains(entry.SubCategory)))
                            report.SubCategories.Add(entry.SubCategory);
                }
                if (DateTime.Compare(entry.Date, dateInit) > 0 && entry.EntryType == EntryType.Revenue)
                {
                    report.EntryRevenue.Add(entry);
                    if (!(report.Categories.Contains(entry.Category)))
                        report.Categories.Add(entry.Category);
                    if (!(report.SubCategories.Contains(entry.SubCategory)))
                        if (!(entry.SubCategory is null) && entry.Description != null)
                            report.SubCategories.Add(entry.SubCategory);
                }

                if (DateTime.Compare(entry.Date, dateInit) > 0 || entry.EntryType == EntryType.Transfer)
                    report.EntryTransfer.Add(entry);

                if (DateTime.Compare(entry.Date, dateInit) > 0 && entry.EntryType == EntryType.AjustBalance)
                    report.EntryAjustBalance.Add(entry);

            }
        }

        private void LoadEntriesAndCategoriesToDate(Report report, DateTime dateEnd)
        {
            foreach (var entry in Context.Expenses)
            {
                if (DateTime.Compare(entry.Date, dateEnd) > 0 && entry.EntryType == EntryType.Expense)
                {
                    report.EntryExpenses.Remove(entry);
                    report.Categories.Remove(entry.Category);
                    if (!(entry.SubCategory is null))
                        report.SubCategories.Remove(entry.SubCategory);
                }
                if (DateTime.Compare(entry.Date, dateEnd) > 0 && entry.EntryType == EntryType.Revenue)
                {
                    report.EntryRevenue.Remove(entry);
                    report.Categories.Remove(entry.Category);
                    if (!(entry.SubCategory is null))
                        report.SubCategories.Remove(entry.SubCategory);
                }

                if (DateTime.Compare(entry.Date, dateEnd) > 0 && entry.EntryType == EntryType.Transfer)
                    report.EntryTransfer.Remove(entry);

                if (DateTime.Compare(entry.Date, dateEnd) > 0 && entry.EntryType == EntryType.AjustBalance)
                    report.EntryAjustBalance.Remove(entry);
            }
        }

        public Report GenerateByAccount(DateTime date, Account acc)
        {
            Report report = new Report();
            report.Accounts.Add(acc);
            report.TotalIncome = acc.Balance;
            report.TotalExpenses = 0.00;
            report.TotalRevenue = 0.00;
            report.Date = date;

            foreach (var entry in Context.Expenses.Include("Category").Include("SubCategory").ToList())
            {
                if (CheckMonth(date, entry.Date) && entry.PaymentMethod is Account)
                {
                    if (((Account)entry.PaymentMethod).Id == acc.Id)
                    {
                        RulesForFeactures(report, entry);
                    }
                }
            }
            return report;
        }

        public Report GenerateByCreditCard(DateTime date, CreditCard card)
        {
            Report report = new Report();
            report.CreditCards.Add(card);
            report.TotalIncome = card.Amount;
            report.TotalExpenses = 0.00;
            report.TotalRevenue = 0.00;
            report.Date = date;

            foreach (var entry in Context.Expenses.Include("Category").Include("SubCategory").Where(e => e.PaymentMethod.Id == card.Id).ToList())
            {
                if (CheckMonth(date, entry.Date) && entry.PaymentMethod is CreditCard)
                {
                    if (CheckMonthCreditCard(card.ClosingDate, entry.Date, date))
                    {
                        RulesForFeactures(report, entry);
                        report.TotalExpenses += entry.Status is false ? entry.Value : -entry.Value;
                    }
                }
            }
            return report;
        }

        private void RulesForFeactures(Report report, EntryExpenses entry)
        {
            if (entry.EntryType == EntryType.Expense || entry.EntryType == EntryType.ExpenseCreditCard)
            {
                report.EntryExpenses.Add(entry);
                report.TotalExpenses += entry.Status ? entry.Value : 0.00;
            }

            if (entry.EntryType == EntryType.Revenue)
            {
                report.TotalRevenue = entry.Value + report.TotalRevenue;
                report.EntryRevenue.Add(entry);
            }

            if (entry.EntryType == EntryType.Transfer)
                report.EntryTransfer.Add(entry);

            if (entry.EntryType == EntryType.AjustBalance)
                report.EntryAjustBalance.Add(entry);

            if (!report.Categories.Any(x => x.Id == entry.Category.Id) && !string.IsNullOrEmpty(entry.Category.Description))
                report.Categories.Add(entry.Category);

            if (!report.SubCategories.Any(x => entry.SubCategory.Id == x.Id) && !string.IsNullOrEmpty(entry.SubCategory.Description))
                report.SubCategories.Add(entry.SubCategory);
        }

        public bool CheckMonth(DateTime RefDate, DateTime EntryDate)
        {
            if (RefDate.Month == EntryDate.Date.Month && RefDate.Year == EntryDate.Date.Year)
                return true;
            return false;
        }

        public bool CheckMonthCreditCard(string RefDate, DateTime EntryDate, DateTime date)
        {
            //if (EntryDate.Date.Day >= Convert.ToInt32(RefDate))
            if ((date.Month >= EntryDate.Month && EntryDate.Day >= Convert.ToInt32(RefDate)) ||
                (EntryDate.Month <= date.AddMonths(1).Month && EntryDate.Day <= Convert.ToInt32(RefDate)))
                    return true;
            return false;
        }

        public string CalcEconomy(DateTime date)
        {
            double percent;
            Report reportNow = this.GenerateByMonth(date);
            Report reportOld = this.GenerateByMonth(date.AddMonths(-1));

            if (reportOld.TotalExpenses == 0)
                return "- %";

            percent = reportNow.TotalExpenses / reportOld.TotalExpenses;

            if (percent > 1)
            {
                percent = percent - 1;
                return "- " + percent.ToString("P");
            }
            else
            {
                percent = 1 - percent;
                return "+ " + percent.ToString("P");
            }
        }

        public void LoadDtvCategories(DataGridView dtv,DtvTypes type, Report report)
        {
            int i, j, qtdEntry;
            double valueExpense = 0.00;
            bool addRow = false;
            string description;
            i = 0;
            List<EntryExpenses> entries = new List<EntryExpenses>();
            List<Category> cats = new List<Category>();
            List<SubCategories> subCats = new List<SubCategories>();

            dtv.Rows.Clear();

            dtv.Columns[0].Name = type == DtvTypes.Categories ? "Categoria" : "SubCategoria";

            foreach (var entry in report.EntryExpenses)
                entries.Add(entry);

            foreach (var entry in report.EntryRevenue)
                entries.Add(entry);


            entries = entries.OrderBy(e => e.Date).ToList();

            foreach (var cat in report.Categories)
            {
                j = 1;
                valueExpense = 0.00;
                qtdEntry = 0;
                addRow = false;
                description = "";

                foreach (var entry in entries)
                {
                    if (entry.Category.Id == cat.Id)
                    {
                        valueExpense += entry.Value;
                        qtdEntry++;
                        addRow = true;
                        description = type == DtvTypes.Categories ? cat.Description : entry.SubCategory.Description;
                    }

                    if (entries.Count == j && addRow)
                    {
                        dtv.Rows.Add();
                        dtv.Rows[i].Cells[0].Value = description;
                        dtv.Rows[i].Cells[1].Value = valueExpense;
                        dtv.Rows[i].Cells[2].Value = entry.EntryType == EntryType.Expense ? "Despesa" : "Receita";
                        dtv.Rows[i].Cells[3].Value = qtdEntry;
                        i++;
                    }
                    j++;
                }
            }
        }
    }
}
