using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoFinanceira.Model
{
    public class Account : PaymentMethod
    {
        public int AccountBank { get; set; }
        public int Agency { get; set; }
        public string Bank { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double Limit { get; set; }

        public override string ToString()
        {
            return Bank;
        }

    }
}
