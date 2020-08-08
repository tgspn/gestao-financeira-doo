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
    class CreditCardController
    {
        private CreditCardDAO dao;
        private IConnection<CreditCard> connection;
        public CreditCardController(IConnection<CreditCard> connection)
        {
            this.connection = connection;
            this.dao = new CreditCardDAO(connection);
        }
        public List<CreditCard> List()
        {
            return dao.Get().ToList();
        }
        public CreditCard Find(int creditCardId)
        {
            throw new NotImplementedException();
        }

        public void Save(CreditCard creditCard)
        {
            if (creditCard.Id == 0)
                dao.Insert(creditCard);
            else
                dao.Update(creditCard);
        }
        public void Remove(CreditCard creditCard)
        {
            dao.Delete(creditCard.Id);
        }
    }
}
