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
    class CreditCardController:ControllerBase
    {
        public CreditCardController()
        {
        }

        public CreditCardController(ApplicationDbContext db) : base(db)
        {
        }

        public IEnumerable<CreditCard> List()
        {
            return Context.PaymentMethod.OfType<CreditCard>();
        }
        public CreditCard Find(int creditCardId)
        {
            return Context.CreditCards.Find(creditCardId);
        }

        public void Save(CreditCard creditCard)
        {
            CreditCard card = creditCard.Id != 0 ? Context.CreditCards.FirstOrDefault(c => c.Id == creditCard.Id) : null;
            if (card == null)
                Context.CreditCards.Add(creditCard);
            Context.SaveChanges();
        }
        public void Remove(CreditCard creditCard)
        {
            Context.CreditCards.Remove(creditCard);
            Context.SaveChanges();
        }
    }
}
