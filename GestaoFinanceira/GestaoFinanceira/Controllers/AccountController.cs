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
    class AccountController
    {

        private AccountDAO dao;
        private IConnection<Account> connection;
        public AccountController(IConnection<Account> connection)
        {
            this.connection = connection;
            this.dao = new AccountDAO(connection);
        }
        public List<Account> List()
        {
            return dao.Get().ToList();
        }
        public Account Find(int account)
        {
            throw new NotImplementedException();
        }

        public void Save(Account account)
        {
            if (account.Id == 0)
                dao.Insert(account);
            else
                dao.Update(account);
        }
        public void Remove(Account account)
        {
            dao.Delete(account.Id);
        }
    }
}
