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
            return db.PaymentMethod.OfType<Account>();
        }
        public Account Find(int account)
        {
            return db.Accounts.Find(account);
        }

        public void Save(Account account)
        {
            db.Accounts.Add(account);
            db.SaveChanges();
        }
        public void Remove(Account account)
        {
            db.Accounts.Remove(account);
            db.SaveChanges();
        }


    }
}
