using GestaoFinanceira.BD.Conections;
using GestaoFinanceira.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoFinanceira.BD.DAO
{
    public class EntryExpensesDAO : DAOBase<EntryExpenses>
    {
        public EntryExpensesDAO(IConnection<EntryExpenses> connection):base(connection)
        {

        }

        public override bool Delete(int id)
        {
            return connection.Delete(id);
        }

        public override IEnumerable<EntryExpenses> Get()
        {
            return connection.Select();
        }

        public override EntryExpenses Insert(EntryExpenses expenses)
        {
            var id=connection.Insert(expenses);
            expenses.Id = id;
            return expenses;
        }

        public override EntryExpenses Update(EntryExpenses expenses)
        {
            connection.Update(expenses);
            return expenses;
        }

        protected override string GetTableName()
        {
            return "expenses";
        }
    }
}
