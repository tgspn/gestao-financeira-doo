using GestaoFinanceira.BD.Conections;
using GestaoFinanceira.BD.DAO;
using GestaoFinanceira.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
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

            return Context.CreditCards.Select(x => (PaymentMethod)x).Concat(Context.Accounts.Select(x => (PaymentMethod)x));
        }

        public PaymentMethod Find(int paymentId)
        {
            return this.List().FirstOrDefault(x => x.Id == paymentId);
        }
        [Obsolete("Analisar a usabilidade de buscar por nome ao invez do id")]
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
                Context.Accounts.Add(paymentMethod as Account);
            else
                Context.CreditCards.Add(paymentMethod as CreditCard);

            Context.SaveChanges();
        }
        public void Remove(PaymentMethod paymentMethod)
        {
            if (paymentMethod is Account)
                Context.Accounts.Remove(paymentMethod as Account);
            else
                Context.CreditCards.Remove(paymentMethod as CreditCard);

            Context.SaveChanges();
        }
    }
}
