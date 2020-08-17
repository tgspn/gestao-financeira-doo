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
            return db.PaymentMethod.OfType<CreditCard>();
        }
        public CreditCard Find(int creditCardId)
        {
            return db.CreditCards.Find(creditCardId);
        }

        public void Save(CreditCard creditCard)
        {
            db.CreditCards.Add(creditCard);
            db.SaveChanges();
        }
        public void Remove(CreditCard creditCard)
        {
            db.CreditCards.Remove(creditCard);
            db.SaveChanges();
        }
    }
}
