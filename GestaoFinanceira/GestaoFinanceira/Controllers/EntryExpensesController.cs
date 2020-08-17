using GestaoFinanceira.BD.Conections;
using GestaoFinanceira.BD.DAO;
using GestaoFinanceira.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoFinanceira.Controllers
{
    class EntryExpensesController:ControllerBase
    {

        public EntryExpensesController()
        {

        }
        public EntryExpensesController(ApplicationDbContext db) : base(db)
        {
        }

        public IEnumerable<EntryExpenses> List()
        {
            return Context.Expenses;
        }
        public EntryExpenses Find(int entryId)
        {
            return Context.Expenses.Find(entryId);
        }

        public void Save(EntryExpenses entry)
        {
            Context.Expenses.Add(entry);
            Context.SaveChanges();
        }
        public void Remove(EntryExpenses entry)
        {
            Context.Expenses.Remove(entry);
            Context.SaveChanges();
        }
    }
}
