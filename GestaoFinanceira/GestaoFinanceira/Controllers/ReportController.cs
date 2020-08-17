using GestaoFinanceira.BD.Conections;
using GestaoFinanceira.Enums;
using GestaoFinanceira.Model;
using System;
using System.Windows.Forms;

namespace GestaoFinanceira.Controllers
{
    public class ReportController
    {
        PaymentMethodController ctrPayment = new PaymentMethodController(new MemorySQLConnection<Account>(), new MemorySQLConnection<CreditCard>());
        AccountController ctrAcc = new AccountController(new MemorySQLConnection<Account>());
        CreditCardController ctrCredit = new CreditCardController(new MemorySQLConnection<CreditCard>());
        EntryExpensesController ctrEntry = new EntryExpensesController(new MemorySQLConnection<EntryExpenses>());
        public string Export()
        {
            throw new NotImplementedException();
        }

        public void Import(string csvContent)
        {
            throw new NotImplementedException();
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

            foreach (var payment in ctrPayment.List())
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

            foreach (var entry in ctrEntry.List())
            {
                if (CheckMonth(date, entry.Date)){
                    if (entry.EntryType == EntryType.Expense)
                    {
                        report.TotalExpenses = entry.Value + report.TotalExpenses;
                        report.EntryExpenses.Add(entry);
                    }

                    if (entry.EntryType == EntryType.Revenue)
                    {
                        report.TotalRevenue = entry.Value + report.TotalRevenue;
                        report.EntryRevenue.Add(entry);
                    }
                    
                    if (!report.Categories.Contains(entry.Category))
                        report.Categories.Add(entry.Category);

                    if (!report.SubCategories.Contains(entry.SubCategory) && entry.SubCategory.Description != null)
                        report.SubCategories.Add(entry.SubCategory);
                    
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
            
            foreach (var method in ctrPayment.List())
            {
                if (method is Account)
                    report.Accounts.Add((Account)method);
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
            foreach (var entry in ctrEntry.List())
            {
                if (DateTime.Compare(entry.Date, dateInit) > 0 && entry.EntryType == EntryType.Expense)
                {
                    report.EntryExpenses.Add(entry);
                    report.Categories.Add(entry.Category);
                    if (!(entry.SubCategory is null) && entry.Description != null)
                        report.SubCategories.Add(entry.SubCategory);
                }
                if (DateTime.Compare(entry.Date, dateInit) > 0 && entry.EntryType == EntryType.Revenue)
                {
                    report.EntryRevenue.Add(entry);
                    report.Categories.Add(entry.Category);
                    if (!(entry.SubCategory is null) && entry.Description != null)
                        report.SubCategories.Add(entry.SubCategory);
                }
            }
        }

        private void LoadEntriesAndCategoriesToDate(Report report, DateTime dateEnd)
        {
            foreach (var entry in ctrEntry.List())
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
            }
        }

        public Report GenerateByAccount(DateTime date, Account acc)
        {
            Report report = new Report();
            report.Accounts.Add(acc);
            report.TotalIncome = 0.00;
            report.TotalExpenses = 0.00;
            report.TotalRevenue = 0.00;

            foreach (var entry in ctrEntry.List())
            {
                if (CheckMonth(date, entry.Date) && entry.PaymentMethod is Account)
                {
                    if (((Account)entry.PaymentMethod).Id == acc.Id)
                    {
                        if (entry.EntryType == EntryType.Expense)
                        {
                            report.TotalExpenses = entry.Value + report.TotalExpenses;
                            report.EntryExpenses.Add(entry);
                        }

                        if (!report.Categories.Contains(entry.Category))
                            report.Categories.Add(entry.Category);

                        if (!report.SubCategories.Contains(entry.SubCategory))
                            report.SubCategories.Add(entry.SubCategory);
                    }
                }
            }
            report.TotalIncome = acc.Balance - report.TotalExpenses;
            return report;
        }

        public Report GenerateByCreditCard(DateTime date, CreditCard card)
        {
            Report report = new Report();
            report.CreditCards.Add(card);
            report.TotalIncome = 0.00;
            report.TotalExpenses = 0.00;
            report.TotalRevenue = 0.00;

            foreach (var entry in ctrEntry.List())
            {
                if (CheckMonth(date, entry.Date) && entry.PaymentMethod is CreditCard)
                {
                    if (((CreditCard)entry.PaymentMethod).Id == card.Id)
                    {
                        if (entry.EntryType == EntryType.Expense)
                        {
                            report.TotalExpenses = entry.Value + report.TotalExpenses;
                            report.EntryExpenses.Add(entry);
                        }

                        if (!report.Categories.Contains(entry.Category))
                            report.Categories.Add(entry.Category);

                        if (!report.SubCategories.Contains(entry.SubCategory))
                            report.SubCategories.Add(entry.SubCategory);
                    }
                }
            }
            report.TotalIncome = card.Amount - report.TotalExpenses;
            return report;
        }

        public Report GenerateByCategories(DateTime date)
        {
            throw new NotImplementedException();
        }
        public Report GenerateBySubCategories()
        {
            throw new NotImplementedException();
        }

        private void ToModel(string csvContent)
        {
            throw new NotImplementedException();
        }

        public bool CheckMonth(DateTime RefDate, DateTime EntryDate)
        {
            if (RefDate.Month == EntryDate.Date.Month && RefDate.Year == EntryDate.Date.Year)
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
                percent =  1 - percent;
                return "+ " + percent.ToString("P");
            }
        }
    }
}
