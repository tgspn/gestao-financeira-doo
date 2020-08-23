using GestaoFinanceira.BD.Conections;
using GestaoFinanceira.BD.DAO;
using GestaoFinanceira.Enums;
using GestaoFinanceira.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoFinanceira.Controllers
{
    class EntryExpensesController:ControllerBase
    {
        AccountController ctrAcc = new AccountController();
        CreditCardController ctrCard = new CreditCardController();

        public EntryExpensesController()
        {

        }
        public EntryExpensesController(ApplicationDbContext db) : base(db)
        {
        }

        public IEnumerable<EntryExpenses> List()
        {
            return Context.Expenses.Include("Category").Include("SubCategory").ToList();
        }
        public EntryExpenses Find(int entryId)
        {
            return Context.Expenses.Find(entryId);
        }

        public void Save(EntryExpenses entry)
        {
            Context.Expenses.Add(entry);
            Context.SaveChanges();
        }
        public void Remove(EntryExpenses entry)
        {
            Context.Expenses.Remove(entry);
            Context.SaveChanges();
        }

        internal bool PerformTransaction(EntryExpenses entry)
        {
            Account acc = new Account();
            CreditCard card = new CreditCard();

            if (entry.EntryType == EntryType.Revenue)
            {
                if (entry.PaymentMethod is Account)
                {
                    acc = Context.Accounts.First(a => a.Id == entry.PaymentMethod.Id);
                    acc.Balance += entry.Value;
                    Context.SaveChanges();
                    return true;
                }
                else
                    return false;
            }
            else if (entry.EntryType == EntryType.Expense)
            {
              return MakePayment(entry) ? true : false;
            }
            return false;
        }

        private bool MakePayment(EntryExpenses entry)
        {
            Account acc;
            CreditCard card;
            if (entry.PaymentMethod is Account)
            {
                acc = Context.Accounts.First(a => a.Id == entry.PaymentMethod.Id);
                if (acc.Balance > (-1) * acc.Limit)
                {
                    acc.Balance += - entry.Value;
                    Context.SaveChanges();
                    return true;
                }
                else
                    return false;
            }else
            {
                card = Context.CreditCards.First(a => a.Id == entry.PaymentMethod.Id);
                if (card.Amount > (-1) * card.Limit)
                {
                    card.Amount += -entry.Value;
                    ctrCard.Save(card);
                    return true;
                }
                else
                    return false;

            }
            return false;
        }
    }
}
