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
        public double Projection { get; set; } = 0.00;
        public DateTime Date { get; set; }
        private int saving { get; set; }
    }
}
