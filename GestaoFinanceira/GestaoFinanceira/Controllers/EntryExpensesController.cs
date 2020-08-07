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
    public class EntryExpensesController
    {
        private EntryExpensesDAO dao;
        private IConnection<EntryExpenses> connection;
        public EntryExpensesController(IConnection<EntryExpenses> connection)
        {
            this.connection = connection;
            this.dao = new EntryExpensesDAO(connection);
        }
        public List<EntryExpenses> List()
        {
            return dao.Get().ToList();
        }
        public EntryExpenses Find(int entryId)
        {
            throw new NotImplementedException();
        }

        public void Save(EntryExpenses entry)
        {
            if (entry.Id == 0)
                dao.Insert(entry);
            else
                dao.Update(entry);
        }
        public void Remove(EntryExpenses entry)
        {
            dao.Delete(entry.Id);
        }
    }
}
