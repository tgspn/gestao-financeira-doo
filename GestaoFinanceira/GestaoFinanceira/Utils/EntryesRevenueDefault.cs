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
            Categories cat;
            
            EntryExpenses entry = new EntryExpenses(
                "Recarga Celular", 
                15.00, 
                DateTime.Today, 
                true, ctrCategories.FindByDescription("Outros"), 
                new SubCategories(),
                ctrPaymentMethod.FindByName("Banco do Brasil"),
                false,
                DateTime.Today,
                Enums.EntryType.Expense
                );
            entries.Add(entry);

            cat = ctrCategories.FindByDescription("Alimentação");
            entry = new EntryExpenses(
                "Dogão",
                25.00,
                DateTime.Today,
                true, 
                cat,
                cat.SubCategories[2],
                ctrPaymentMethod.FindByName("Master Card"),
                false,
                DateTime.Today,
                Enums.EntryType.Expense
                );
            entries.Add(entry);

            cat = ctrCategories.FindByDescription("Alimentação");
            entry = new EntryExpenses(
                "Dogão Duplo",
                35.00,
                ((DateTime)(DateTime.Today)).AddMonths(-1),
                true,
                cat,
                cat.SubCategories[2],
                ctrPaymentMethod.FindByName("Master Card"),
                false,
                ((DateTime)(DateTime.Today)).AddMonths(-1),
                Enums.EntryType.Expense
                );
            entries.Add(entry);

            cat = ctrCategories.FindByDescription("Salario");
            entry = new EntryExpenses(
                "Salario",
                3500.00,
                DateTime.Today,
                true,
                cat,
                cat.SubCategories[0],
                ctrPaymentMethod.FindByName("Banco do Brasil"),
                true,
                DateTime.Today,
               Enums.EntryType.Revenue
                );
            entries.Add(entry);

            return entries;
        }
    }
}
