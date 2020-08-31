using GestaoFinanceira.BD.Conections;
using GestaoFinanceira.Enums;
using GestaoFinanceira.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;

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
                    EntryType = value > account.Balance ? EntryType.Revenue : EntryType.Expense,
                    Category = Context.Categories.Find(9),
                    PaymentMethod = account,
                    Status = true
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
            else if (entry.EntryType == EntryType.Expense || entry.EntryType == EntryType.ExpenseCreditCard)
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
                Category = Context.Categories.Find(10),
                EntryType = EntryType.Transfer,
                Status = true
            };

            EntryExpenses outEntry = new EntryExpenses()
            {
                Description = $"Enviado para {GenerateCaptionHolder(inAcc.Holder)} - {inAcc.Bank}",
                Value = value,
                Date = date,
                Category = Context.Categories.Find(10),
                PaymentMethod = outAcc,
                EntryType = EntryType.Transfer,
                Status = true
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
                //Se data de fechamento menor que data de pagamento da conta data de pagamento vai para o mês que vem.
                int day = Convert.ToInt32(card.DueDate);
                int month = Convert.ToInt32(card.ClosingDate) < entry.Date.Day ? entry.Date.AddMonths(1).Month : entry.Date.Month;
                int year = Convert.ToInt32(card.ClosingDate) < entry.Date.Day ? entry.Date.AddMonths(2).Year : entry.Date.AddMonths(1).Year;
                entry.PaymentDate = DateTime.Parse($"{day}-{month}-{year}");
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

        internal void PayCreditCard(int idAcc, int idCredit, double valueToPay, double valueParcel, DateTime DatePaid ,DateTime dateToPay)
        {
            CreditCard card = Context.CreditCards.Find(idCredit);
            EntryExpenses entry = new EntryExpenses
            {
                Description = $"{GenerateCaptionHolder(card.Holder)} fatura - {card.Issuer}",
                Value = valueToPay,
                EntryType = EntryType.ExpenseCreditCard,
                Date = DatePaid,
                Category = Context.Categories.Find(6),
                SubCategory = Context.SubCategories.Find(14),
                PaymentMethod = Context.PaymentMethod.Find(idAcc),
                Status = true
            };

            PerformTransaction(entry);
            Save(entry);

            if (valueParcel > 0)
            {
                entry = new EntryExpenses
                {
                    Description = $"{GenerateCaptionHolder(card.Holder)} fatura parcial - {card.Issuer}",
                    Value = valueParcel,
                    EntryType = EntryType.ExpenseCreditCard,
                    Date = dateToPay.AddMonths(1),
                    Category = Context.Categories.Find(6),
                    SubCategory = Context.SubCategories.Find(14),
                    PaymentMethod = card
                };
                Save(entry);
            }
        }

        internal void SplitAccount(int value, EntryExpenses model)
        {
            PerformTransaction(model);
            for (int i = 1; i < value; i++)
            {
                model.Date = model.Date.AddMonths(1);
                model.CaptionRepeat = $"({i+1}/{value})";
                PerformTransaction(model);
                Save(model.Clone());
            }
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
