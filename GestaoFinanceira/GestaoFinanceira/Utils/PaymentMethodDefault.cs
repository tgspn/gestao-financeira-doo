using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoFinanceira.Model
{
    [Obsolete("Utilize as instancias do banco de dados", true)]
    public static class PaymentMethodDefault
    {
        public static List<PaymentMethod> GetPaymentMethod()
        {
            List<PaymentMethod> list = new List<PaymentMethod>();

            Account account = new Account();
            account.AccountBank = "654321";
            account.Agency = 1234;
            account.Balance = 5200.00;
            account.Bank = "Banco do Brasil";
            account.Holder = "João Bernardino";
            account.Limit = 5000;
            list.Add(account);

            account = new Account();
            account.AccountBank = Convert.ToString(123465);
            account.Agency = 4321;
            account.Balance = 600.00;
            account.Bank = "Banco Itau";
            account.Holder = "Maria Pereira";
            account.Limit = 2500;
            list.Add(account);

            account = new Account();
            account.AccountBank = Convert.ToString(135497);
            account.Agency = 47123;
            account.Balance = 1200.00;
            account.Bank = "Banco Itau";
            account.Holder = "João Bernardino";
            account.Limit = 2500;
            list.Add(account);

            CreditCard credit = new CreditCard();
            credit.Issuer = "Master Card";
            credit.LateFee = 12.50;
            credit.Number = "3215648971";
            credit.Amount = 2500;
            credit.ClosingDate = "10";
            credit.ExpirationDate = "06/2021";
            credit.Holder = "João Bernardino";
            list.Add(credit);

            credit = new CreditCard();
            credit.Issuer = "Master Card";
            credit.LateFee = 12.50;
            credit.Number = "3215648971";
            credit.Amount = 2500;
            credit.ClosingDate = "10";
            credit.ExpirationDate = "06/2022";
            credit.Holder = "Maria Pereira";
            list.Add(credit);

            return list;
        }
    }
}
