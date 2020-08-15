using GestaoFinanceira.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoFinanceira.Utils
{
    public static class EntryesRevenueDefault
    {
        public static List<EntryExpenses> GetEntryExpenses() {
            List<EntryExpenses> entries = new List<EntryExpenses>();
            EntryExpenses entry = new EntryExpenses();

            entry.Value = 15.00;
            entry.Description = "Recarga Celular";
            entry.EntryType = Enums.EntryType.Expense;
            entry.Status = true;
            entry.RepeatUntil = DateTime.Today;
            entry.Date = DateTime.Today;
            entries.Add(entry);

            entry = new EntryExpenses();
            entry.Value = 3500.00;
            entry.Description = "Salario";
            entry.EntryType = Enums.EntryType.Revenue;
            entry.Status = true;
            entry.RepeatUntil = DateTime.Today;
            entry.Date = DateTime.Today;
            entries.Add(entry);

            return entries;
        }
    }
}
