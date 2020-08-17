using GestaoFinanceira.BD.Conections;
using GestaoFinanceira.Enums;
using GestaoFinanceira.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoFinanceira.Controllers
{
    public class ReportController
    {
        AccountController ctrAcc = new AccountController(new MemorySQLConnection<Account>());
        CreditCardController ctrCredit = new CreditCardController(new MemorySQLConnection<CreditCard>());
        CategoriesController ctrCategories = new CategoriesController(new MemorySQLConnection<Categories>());
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

            foreach (var acc in ctrAcc.List())
                report.TotalIncome = acc.Balance + report.TotalIncome;

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
                    
                    if (!report.Categories.Contains(entry.Categorie))
                        report.Categories.Add(entry.Categorie);

                    if (!report.SubCategories.Contains(entry.SubCategorie))
                        report.SubCategories.Add(entry.SubCategorie);
                    
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
            throw new NotImplementedException();
        }

        public Report GenerateByAccount(DateTime date, Account acc)
        {
            throw new NotImplementedException();
        }

        public Report GenerateByCreditCard(DateTime date, CreditCard card)
        {
            Report report = new Report();
            report.TotalIncome = 0.00;
            report.TotalExpenses = 0.00;
            report.TotalRevenue = 0.00;

            foreach (var entry in ctrEntry.List())
            {
                if (CheckMonth(date, entry.Date) && entry.PaymentMethod is CreditCard)
                {
                    if (((CreditCard)entry.PaymentMethod).Issuer == card.Issuer)
                    {
                        if (entry.EntryType == EntryType.Expense)
                        {
                            report.TotalExpenses = entry.Value + report.TotalExpenses;
                            report.EntryExpenses.Add(entry);
                        }

                        if (!report.Categories.Contains(entry.Categorie))
                            report.Categories.Add(entry.Categorie);

                        if (!report.SubCategories.Contains(entry.SubCategorie))
                            report.SubCategories.Add(entry.SubCategorie);
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
