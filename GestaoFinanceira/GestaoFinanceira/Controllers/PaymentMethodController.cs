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

        public void Save(PaymentMethod paymentMethod)
        {
            PaymentMethod payment = paymentMethod.Id != 0 ? Context.PaymentMethod.First(c => c.Id == paymentMethod.Id) : null;
            if (payment == null)
            {
                if (paymentMethod is Account)
                    Context.Accounts.Add(paymentMethod as Account);
                else
                    Context.CreditCards.Add(paymentMethod as CreditCard);
            }
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
