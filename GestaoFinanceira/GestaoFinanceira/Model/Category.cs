using GestaoFinanceira.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoFinanceira.Model
{    [Table("Category")]
    public class Category
    {
        public int Id {get; set;}
        public string Description { get; set; }
        public EntryType type { set; get; }
        public virtual List<SubCategories> SubCategories { get; set; } = new List<SubCategories>();
        public override string ToString()
        {
            return this.Description;
        }
    }
}
