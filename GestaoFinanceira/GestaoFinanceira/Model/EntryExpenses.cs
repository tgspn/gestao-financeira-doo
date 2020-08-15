using GestaoFinanceira.Enums;
using System;
using System.Collections.Generic;
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
        public PaymentMethod PaymentMethod { get; set; }
        public bool Repeat { set; get; }
        public DateTime RepeatUntil { get; set; }
        public EntryType EntryType{ get; set; }
    }
}
