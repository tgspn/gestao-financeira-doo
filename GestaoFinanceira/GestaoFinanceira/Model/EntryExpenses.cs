using GestaoFinanceira.Enums;
using System;

namespace GestaoFinanceira.Model
{
    public class EntryExpenses
    {
        public EntryExpenses()
        {

        }
        public EntryExpenses(string description, double value, DateTime date, bool status, Categories categorie, SubCategories subCategorie, PaymentMethod paymentMethod, bool repeat, DateTime repeatUntil, EntryType entryType)
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
            this.SetDescriptionCategories();
            this.SetRepeat();
        }
        public int Id { get; set; }
        public string Description { get; set; }
        public double Value { get; set; }
        public DateTime Date { get; set; }
        public bool Status { get; set; }
        public Categories Categorie { get; set; } = new Categories();
        public SubCategories SubCategorie { get; set; } = new SubCategories();
        public PaymentMethod PaymentMethod { get; set; }
        public string CaptionCategories { get; set; }
        public string CaptionRepeat { get; set; }
        public bool Repeat { set; get; }
        public DateTime RepeatUntil { get; set; }
        public EntryType EntryType { get; set; }

        

        public void SetDescriptionCategories()
        {
            this.CaptionCategories = SubCategory.Description != "" && SubCategory.Description != null ? Category.Description +">" + SubCategory.Description : Category.Description;
        }

        public void SetRepeat()
        {
            this.CaptionRepeat = Repeat ? "Sim" : "Não";
        }
    }
}
