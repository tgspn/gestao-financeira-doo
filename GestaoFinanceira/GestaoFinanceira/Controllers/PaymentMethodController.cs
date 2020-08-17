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
    class PaymentMethodController : ControllerBase
    {
        //private CreditCardDAO daoCredit;
        //private IConnection<CreditCard> connectionCredit;
        //private AccountDAO daoAccount;
        //private IConnection<Account> connectionAccount;
        //public PaymentMethodController(IConnection<Account> connectionAccount, IConnection<CreditCard> connectionCredit)
        //{
        //    this.connectionCredit = connectionCredit;
        //    this.daoCredit = new CreditCardDAO(connectionCredit);
        //    this.connectionAccount = connectionAccount;
        //    this.daoAccount = new AccountDAO(connectionAccount);
        //}
        public PaymentMethodController()
        {

        }

        public PaymentMethodController(ApplicationDbContext db) : base(db)
        {
        }

        public IEnumerable<PaymentMethod> List()
        {

            return db.CreditCards.Select(x => (PaymentMethod)x).Concat(db.Accounts.Select(x => (PaymentMethod)x));
        }

        public PaymentMethod Find(int paymentId)
        {
            return this.List().FirstOrDefault(x => x.Id == paymentId);
        }

        public PaymentMethod FindByName(string paymentName)
        {
            return this.List().FirstOrDefault(payment =>
            {
                return (payment is Account && ((Account)payment).Bank == paymentName) ||
                (payment is CreditCard && ((CreditCard)payment).Issuer == paymentName);
            });
        }

        public void Save(PaymentMethod paymentMethod)
        {

            if (paymentMethod is Account)
                db.Accounts.Add(paymentMethod as Account);
            else
                db.CreditCards.Add(paymentMethod as CreditCard);

            db.SaveChanges();
        }
        public void Remove(PaymentMethod paymentMethod)
        {
            if (paymentMethod is Account)
                db.Accounts.Remove(paymentMethod as Account);
            else
                db.CreditCards.Remove(paymentMethod as CreditCard);

            db.SaveChanges();
        }
    }
}
