using GestaoFinanceira.BD.Conections;
using GestaoFinanceira.Controllers;
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
            CategoriesController ctrCategories = new CategoriesController(new MemorySQLConnection<Categories>());
            PaymentMethodController ctrPaymentMethod = new PaymentMethodController(new MemorySQLConnection<Account>(), new MemorySQLConnection<CreditCard>());
            List<EntryExpenses> entries = new List<EntryExpenses>();
            EntryExpenses entry = new EntryExpenses();

            entry.Value = 15.00;
            entry.Description = "Recarga Celular";
            entry.EntryType = Enums.EntryType.Expense;
            entry.Categorie = ctrCategories.FindByDescription("Outros");
            entry.PaymentMethod = ctrPaymentMethod.FindByName("Banco do Brasil");
            entry.RepeatUntil = DateTime.Today;
            entry.Date = DateTime.Today;
            entries.Add(entry);

            entry = new EntryExpenses();
            entry.Value = 25.00;
            entry.Description = "Dogão";
            entry.EntryType = Enums.EntryType.Expense;
            entry.PaymentMethod = ctrPaymentMethod.FindByName("Master Card");
            entry.Categorie = ctrCategories.FindByDescription("Outros");
            entry.RepeatUntil = DateTime.Today;
            entry.Date = DateTime.Today;
            entries.Add(entry);

            entry = new EntryExpenses();
            entry.Value = 3500.00;
            entry.Description = "Salario";
            entry.EntryType = Enums.EntryType.Revenue;
            entry.PaymentMethod = ctrPaymentMethod.FindByName("Banco do Brasil");
            entry.Categorie = ctrCategories.FindByDescription("Salario");
            entry.RepeatUntil = DateTime.Today;
            entry.Date = DateTime.Today;
            entries.Add(entry);

            return entries;
        }
    }
}
