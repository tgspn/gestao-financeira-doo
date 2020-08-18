using GestaoFinanceira.Enums;
using System;

namespace GestaoFinanceira.Model
{
    public class EntryExpenses
    {
        public EntryExpenses()
        {

        }
        public EntryExpenses(string description, double value, DateTime date, bool status, Category categorie, SubCategories subCategorie, PaymentMethod paymentMethod, bool repeat, DateTime repeatUntil, EntryType entryType)
        {
            Description = description;
            Value = value;
            Date = date;
            Status = status;
            Category = categorie;
            SubCategory = subCategorie;
            PaymentMethod = paymentMethod;
            Repeat = repeat;
            RepeatUntil = repeatUntil;
            EntryType = entryType;
        }
        public int Id { get; set; }
        public string Description { get; set; }
        public double Value { get; set; }
        public DateTime Date { get; set; }
        public bool Status { get; set; }
        public virtual Category Category { get; set; } = new Category();
        public virtual SubCategories SubCategory { get; set; } = new SubCategories();
        public virtual PaymentMethod PaymentMethod { get; set; }
        public string CaptionCategories
        {
            get
            {
                if (!string.IsNullOrEmpty(SubCategory.Description))
                    return Category.Description + ">" + SubCategory.Description;
                else
                    return Category.Description;
            }
        }
        public string CaptionRepeat { get => Repeat ? "Sim" : "Não"; }
        public bool Repeat { set; get; }
        public DateTime RepeatUntil { get; set; }
        public EntryType EntryType { get; set; }


    }
}
