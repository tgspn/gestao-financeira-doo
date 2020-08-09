﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoFinanceira.Model
{
    public static class PaymentMethodDefault
    {
        public static List<PaymentMethod> GetPaymentMethod()
        {
            List<PaymentMethod> list = new List<PaymentMethod>();

            Account account = new Account();
            account.AccountBank = 654321;
            account.Agency = 1234;
            account.Balance = 5200.00;
            account.Bank = "Banco do Brasil";
            account.Holder = "João Bernardino";
            account.Limit = 5000;
            list.Add(account);

            CreditCard credit = new CreditCard();
            credit.Issuer = "MasterCard";
            credit.LateFee = 12.50;
            credit.Number = "3215648971";
            credit.Amount = 2500;
            credit.ClosingDate = "10";
            credit.ExpirationDate = "06/2021";
            credit.Holder = "João Bernardino";
            list.Add(credit);

            return list;
        }
    }
}
