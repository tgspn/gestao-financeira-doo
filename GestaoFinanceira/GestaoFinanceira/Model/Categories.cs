using GestaoFinanceira.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoFinanceira.Model
{
    public class Categories
    {
        public int Id {get; set;}
        public string Description { get; set; }
        public EntryType type { set; get; }
        public List<SubCategories> SubCategories { get; set; } = new List<SubCategories>();
        public override string ToString()
        {
            return this.Description;
        }
    }
}
