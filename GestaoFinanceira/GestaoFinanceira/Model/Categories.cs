using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoFinanceira.Model
{
    class Categories
    {
        private int Id {get; set;}
        private string Descricao { get; set; }
        private List<SubCategories> SubCategories { get; set; }


    }
}
