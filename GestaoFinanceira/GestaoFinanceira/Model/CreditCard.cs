using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoFinanceira.Model
{
    public class CreditCard : PaymentMethod
    {
        public string Number { get; set; }
        public double LateFee { get; set; }
        public double Amount { get; set; }
        public string Issuer { get; set; }
        public string ExpirationDate { get; set; }
        public string ClosingDate { get; set; }

        public override string ToString()
        {
            return Issuer;
        }

    }
}
