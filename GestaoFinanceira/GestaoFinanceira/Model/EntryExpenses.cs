using GestaoFinanceira.Enums;
using System;

namespace GestaoFinanceira.Model
{
    public class EntryExpenses
    {
        public EntryExpenses()
        {

        }
        public EntryExpenses(string description, double value, DateTime date, bool status, bool repeat, Category categorie, SubCategories subCategorie, PaymentMethod paymentMethod, DateTime repeatUntil, EntryType entryType)
        {
            Description = description;
            Value = value;
            Date = date;
            PaymentDate = date;
            Status = status;
            Category = categorie;
            Repeat = repeat;
            SubCategory = subCategorie;
            PaymentMethod = paymentMethod;
            RepeatUntil = repeatUntil;
            EntryType = entryType;
        }
        public int Id { get; set; }
        public string Description { get; set; }
        public double Value { get; set; }
        public DateTime Date { get; set; }
        public DateTime PaymentDate { get; set; }
        public bool Status { get; set; }
        public virtual Category Category { get; set; } = new Category();
        public virtual SubCategories SubCategory { get; set; } = new SubCategories();
        public virtual PaymentMethod PaymentMethod { get; set; }
        public string CaptionCategories
        {
            get
            {
                if (SubCategory != null && !string.IsNullOrEmpty(SubCategory.Description))
                    return Category.Description + ">" + SubCategory.Description;
                else
                    return Category != null ? Category.Description : "";
            }
        }
        private string _captionRepeat;
        public bool Repeat { set; get; }
        public DateTime RepeatUntil { get; set; }
        public EntryType EntryType { get; set; }

        public string CaptionRepeat
        {
            get => this.Repeat ? _captionRepeat : "à vista"; 
            set => _captionRepeat = value;
        }

        public void CopyTo(EntryExpenses destino)
        {
            if (destino is null)
                throw new Exception("O destino não pode ser nulo");

            destino.Description = Description;
            destino.Value = Value;
            destino.Date = Date;
            destino.PaymentDate = PaymentDate;
            destino.Status = Status;
            destino.Category = Category;
            destino.SubCategory = SubCategory;
            destino.PaymentMethod = PaymentMethod;
            destino.CaptionRepeat = _captionRepeat;
            destino.Repeat = Repeat;
            destino.RepeatUntil = RepeatUntil;
            destino.EntryType = EntryType;

        }

        public override string ToString()
        {
            return this.Description;
        }

        public EntryExpenses Clone()
        {
            EntryExpenses clone = new EntryExpenses();
            CopyTo(clone);
            return clone;
        }

    }
}
