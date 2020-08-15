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
    class PaymentMethodController
    {
        private CreditCardDAO daoCredit;
        private IConnection<CreditCard> connectionCredit;
        private AccountDAO daoAccount;
        private IConnection<Account> connectionAccount;
        public PaymentMethodController(IConnection<Account> connectionAccount, IConnection<CreditCard> connectionCredit)
        {
            this.connectionCredit = connectionCredit;
            this.daoCredit = new CreditCardDAO(connectionCredit);
            this.connectionAccount = connectionAccount;
            this.daoAccount = new AccountDAO(connectionAccount);
        }
        public List<PaymentMethod> List()
        {
            List<PaymentMethod> list = new List<PaymentMethod>();
            foreach (var credit in daoCredit.Get().ToList())
                list.Add(credit);
            foreach (var account in daoAccount.Get().ToList())   
                list.Add(account);
            list.OrderBy(payment => payment.Id);

            return list;
        }

        public PaymentMethod Find(int paymentId)
        {
            foreach (var payment in this.List())
            {
                if (payment.Id == paymentId)
                    return payment;
            }
            return null;
        }

        public PaymentMethod FindByName(String paymentName)
        {
            foreach (var payment in this.List()) {
                if (payment is Account)
                {
                    if (((Account)payment).Bank == paymentName)
                        return payment;
                }
                else
                {
                    if (((CreditCard)payment).Issuer == paymentName)
                        return payment;
                }
            }
            return null;
        }

        public void Save(PaymentMethod paymentMethod)
        {

            if (paymentMethod.Id == 0)
                if (paymentMethod is Account)
                    daoAccount.Insert(paymentMethod as Account);
                else
                    daoCredit.Insert(paymentMethod as CreditCard);
            else
                if (paymentMethod is Account)
                    daoAccount.Update(paymentMethod as Account);
                else
                    daoCredit.Update(paymentMethod as CreditCard);
        }
        public void Remove(PaymentMethod paymentMethod)
        {
            if (paymentMethod is Account)
                daoAccount.Delete(paymentMethod.Id);
            else
                daoCredit.Delete(paymentMethod.Id);
        }
    }
}
