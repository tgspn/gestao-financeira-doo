using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoFinanceira.Model
{
    public class Report
    {
        public double TotalIncome { get; set; } = 0.00;
        public double TotalExpenses { get; set; } = 0.00;
        public double TotalRevenue { get; set; } = 0.00;
        private double Projection { get; set; } = 0.00;
        public DateTime Date { get; set; }
        private int saving { get; set; }
        public List<Account> Accounts { get; set; } = new List<Account>();
        public List<CreditCard> CreditCards { get; set; } = new List<CreditCard>();
        public List<EntryExpenses> EntryRevenue { get; set; } = new List<EntryExpenses>();
        public List<EntryExpenses> EntryExpenses { get; set; } = new List<EntryExpenses>();
        public List<Categories> Categories { get; set; } = new List<Categories>();
        public List<SubCategories> SubCategories { get; set; } = new List<SubCategories>();



        public double GetProjection()
        {
            return this.TotalIncome + this.TotalRevenue - this.TotalExpenses;
        }
    }
}
