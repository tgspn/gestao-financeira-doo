using GestaoFinanceira.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoFinanceira.BD.Conections
{
    class BDInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<ApplicationDbContext>
    {
        protected override void Seed(ApplicationDbContext context)
        {
            var categories = CategoriesDefault.GetCategories();
            categories.ForEach(c => context.Categories.Add(c));
            context.SaveChanges();


        }
    }
}
