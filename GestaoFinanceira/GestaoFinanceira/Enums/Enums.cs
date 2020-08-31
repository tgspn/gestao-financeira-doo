using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoFinanceira.Enums
{
    public enum EntryType {Expense, Revenue, Transfer , AjustBalance, ExpenseCreditCard}
    public enum PaymentMethodType { BankAccount, CreditCard }
    public enum ChartType {Account, CreditCard, Categories}
    public enum DtvTypes {Account, CreditCard, Entries, Categories, SubCategories, Transfer }
}
