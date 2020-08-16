using GestaoFinanceira.BD.Conections;
using GestaoFinanceira.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoFinanceira.BD.DAO
{
    public class CreditCardDAO : DAOBase<CreditCard>
    {

        public CreditCardDAO(IConnection<CreditCard> connection) : base(connection)
        {

        }

        public override bool Delete(int id)
        {
            return connection.Delete(id);
        }

        public override IEnumerable<CreditCard> Get()
        {
            return connection.Select();
        }

        public override CreditCard Insert(CreditCard creditCard)
        {
            var id = connection.Insert(creditCard);
            creditCard.Id = id;
            return creditCard;
        }

        public override CreditCard Update(CreditCard creditCard)
        {
            connection.Update(creditCard);
            return creditCard;
        }

        protected override string GetTableName()
        {
            return "credit-card";
        }
    }
}
