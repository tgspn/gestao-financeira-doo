using GestaoFinanceira.BD.Conections;
using GestaoFinanceira.BD.DAO;
using GestaoFinanceira.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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
            Context.Accounts.Add(account);
            Context.SaveChanges();
        }
        public void Remove(Account account)
        {
            Context.Accounts.Remove(account);
            Context.SaveChanges();
        }


    }
}
