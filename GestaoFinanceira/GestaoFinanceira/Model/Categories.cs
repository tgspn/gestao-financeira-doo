using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoFinanceira.Model
{
    class Categories
    {
        public int Id {get; set;}
        public string Descricao { get; set; }
        public List<SubCategories> SubCategories { get; set; }


    }
}
