using GestaoFinanceira.Enums;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoFinanceira.Model
{
    public class EntryExpenses
    {
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

        public EntryExpenses(string description, double value, DateTime date, bool status, Categories categorie, SubCategories subCategorie, PaymentMethod paymentMethod, bool repeat, DateTime repeatUntil, EntryType entryType)
        {
            Description = description;
            Value = value;
            Date = date;
            Status = status;
            Categorie = categorie;
            SubCategorie = subCategorie;
            PaymentMethod = paymentMethod;
            Repeat = repeat;
            RepeatUntil = repeatUntil;
            EntryType = entryType;
            this.SetDescriptionCategories();
            this.SetRepeat();
        }

        public void SetDescriptionCategories()
        {
            this.CaptionCategories = SubCategorie.Description != "" && SubCategorie.Description != null ? Categorie.Description +">" + SubCategorie.Description : Categorie.Description;
        }

        public void SetRepeat()
        {
            this.CaptionRepeat = Repeat ? "Sim" : "Não";
        }
    }
}
