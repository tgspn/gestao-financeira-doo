using GestaoFinanceira.BD.Conections;
using GestaoFinanceira.BD.DAO;
using GestaoFinanceira.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoFinanceira.Controllers
{
    class AccountController : ControllerBase
    {        

        public AccountController()
        {
            
        }
        public AccountController(ApplicationDbContext db):base(db)
        {
            
        }

        public IEnumerable<Account> List()
        {
            return Context.PaymentMethod.OfType<Account>();
        }
        public Account Find(int account)
        {
            return Context.Accounts.Find(account);
        }

        public void Save(Account account)
        {
            Account acc = account.Id != 0 ? Context.Accounts.FirstOrDefault(a => a.Id == account.Id) : null;
            if (acc == null)
                Context.Accounts.Add(account);
            Context.SaveChanges();
        }
        public void Remove(Account account)
        {
            Context.Entry(account).State = EntityState.Deleted;
            Context.SaveChanges();
        }


    }
}
