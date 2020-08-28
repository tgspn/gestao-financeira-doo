using GestaoFinanceira.BD.Conections;
using GestaoFinanceira.Enums;
using GestaoFinanceira.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GestaoFinanceira.Controllers
{
    class EntryExpensesController:ControllerBase
    {

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
            EntryExpenses ent = entry.Id != 0 ? Context.Expenses.FirstOrDefault(e => e.Id == entry.Id) : null;
            if (ent == null)
                Context.Expenses.Add(entry);
            Context.SaveChanges();
        }

        internal bool AdjustBalance(double value, int id)
        {
            Account account = Context.Accounts.First(acc => acc.Id == id);
            EntryExpenses entry = new EntryExpenses()
                {
                    Description = "Ajuste de Saldo",
                    Value = value > account.Balance ? value - account.Balance : account.Balance - value,
                    Date = DateTime.Now,
                    EntryType = value > account.Balance ? Enums.EntryType.Revenue : Enums.EntryType.Expense,
                    Category = Context.Categories.FirstOrDefault(c => c.Id == 8),
                    PaymentMethod = account
                };

            if (-1 * account.Limit < value)
            {
                account.Balance = value;
                this.Save(entry);
                return true;
            }
            return false;
        }

        public void Remove(EntryExpenses entry)
        {
            Context.Expenses.Remove(entry);
            Context.SaveChanges();
        }

        internal bool PerformTransaction(EntryExpenses entry)
        {
            if (entry.EntryType == EntryType.Revenue)
            {
                if (entry.PaymentMethod is Account)
                {
                    ReceivePayment(entry);
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

        private void ReceivePayment(EntryExpenses entry)
        {
            Account acc = Context.Accounts.FirstOrDefault(a => a.Id == entry.PaymentMethod.Id);
            acc.Balance += entry.Value;
            Context.SaveChanges();
        }

        internal bool UpdateEntry(double oldvalue, int idPayment, EntryExpenses entryNew)
        {
            if (entryNew.EntryType == EntryType.Expense)
            {
                    if (MakePayment(entryNew))
                    {
                        PaymentReturn(oldvalue, idPayment, entryNew.EntryType);
                        return true;
                    }
                    else
                        return false;
            }
            else
            {
                ReceivePayment(entryNew);
                PaymentReturn(oldvalue, idPayment, entryNew.EntryType);
                return true;
            }
            
        }

        internal bool PerformTransfer(double value, int bankOrigin, int BankDestination, DateTime date)
        {
            Account inAcc = Context.Accounts.FirstOrDefault(c => c.Id == BankDestination);
            Account outAcc = Context.Accounts.FirstOrDefault(c => c.Id == bankOrigin);
            if (outAcc.Limit * -1 > (outAcc.Balance - value))
                return false;
            outAcc.Balance += -value;
            inAcc.Balance += value;

            EntryExpenses inEntry = new EntryExpenses()
            {
                Description = $"Recebido de {GenerateCaptionHolder(outAcc.Holder)} - {outAcc.Bank}",
                Value = value,
                Date = date,
                PaymentMethod = inAcc,
                Category = Context.Categories.FirstOrDefault(c => c.Id == 9),
                EntryType = EntryType.Transfer
            };

            EntryExpenses outEntry = new EntryExpenses()
            {
                Description = $"Enviado para {GenerateCaptionHolder(inAcc.Holder)} - {inAcc.Bank}",
                Value = value,
                Date = date,
                Category = Context.Categories.FirstOrDefault(c => c.Id == 9),
                PaymentMethod = outAcc,
                EntryType = EntryType.Transfer
            };
            Save(inEntry);
            Save(outEntry);
            return true;
        }

        private bool MakePayment(EntryExpenses entry)
        {
            Account acc;
            CreditCard card;
            if (entry.PaymentMethod is Account)
            {
                acc = Context.Accounts.First( a => a.Id == entry.PaymentMethod.Id);
                if ((acc.Balance - entry.Value) > (-1) * (acc.Limit))
                {
                    acc.Balance += - entry.Value;
                    Context.SaveChanges();
                    return true;
                }
                else
                    return false;
            }else
            {
                card = entry.PaymentMethod as CreditCard;
                if (card.Amount > (-1) * card.Limit)
                {
                    card.Amount += -entry.Value;
                    Context.SaveChanges();
                    return true;
                }
                else
                    return false;

            }
        }

        private void PaymentReturn(double value, int idPayment, EntryType type)
        {
            PaymentMethod payment = Context.PaymentMethod.First(p => p.Id == idPayment);
            Account acc;
            CreditCard card;
            if (payment is Account)
            {
                acc = payment as Account;
                acc.Balance = type == EntryType.Expense ? acc.Balance + value : acc.Balance - value;              
            }
            else
            {
                card = payment as CreditCard;
                card.Amount += value;
           
            }
            Context.SaveChanges();
        }

        public string GenerateCaptionHolder(string name)
        {
            string abbreviation = "";
            var names = name.Split(' ');
            for (int i = names.Length; i > 0; i--)
            {
                abbreviation = names[i - 1].Remove(1, names[i - 1].Length - 1) + "." + abbreviation;
            }

            return abbreviation;
        }
    }
}
