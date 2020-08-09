using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoFinanceira.Model
{
    public static class  CategoriesDefault
    {
        public static List<Categories> GetCategories()
        {
            List<Categories> categories = new List<Categories>();
            List<SubCategories> list = new List<SubCategories>();

            Categories cat = new Categories();
            SubCategories subCat = new SubCategories();

            cat.Description = "Salario";
            categories.Add(cat);
            
            cat = new Categories();
            cat.Description = "Alimentação";
            subCat = new SubCategories();
            subCat.Description = "Bebida Alcolica";
            list.Add(subCat);
            subCat = new SubCategories();
            subCat.Description = "Bebida Geral";
            list.Add(subCat);
            subCat = new SubCategories();
            subCat.Description = "Lanche";
            list.Add(subCat);
            cat.SubCategories = list;
            categories.Add(cat);

            list = new List<SubCategories>();
            cat = new Categories();
            cat.Description = "Educação";
            subCat = new SubCategories();
            subCat.Description = "Livros";
            list.Add(subCat);
            subCat = new SubCategories();
            subCat.Description = "Curso";
            list.Add(subCat);
            cat.SubCategories = list;
            categories.Add(cat);



            cat = new Categories();
            cat.Description = "Lazer";
            categories.Add(cat);

            list = new List<SubCategories>();
            cat = new Categories();
            cat.Description = "Saude";
            subCat = new SubCategories();
            subCat.Description = "Academia";
            list.Add(subCat);
            subCat = new SubCategories();
            subCat.Description = "Médico";
            list.Add(subCat);
            subCat = new SubCategories();
            subCat.Description = "Remédios";
            list.Add(subCat);
            cat.SubCategories = list;
            categories.Add(cat);

            list = new List<SubCategories>();
            cat = new Categories();
            cat.Description = "Transporte";
            subCat = new SubCategories();
            subCat.Description = "Combustível";
            list.Add(subCat);
            subCat = new SubCategories();
            subCat.Description = "Manutenção";
            list.Add(subCat);
            subCat = new SubCategories();
            subCat.Description = "Documentos";
            list.Add(subCat);
            cat.SubCategories = list;
            categories.Add(cat);

            cat = new Categories();
            cat.Description = "Outros";
            categories.Add(cat);



            return categories;
        }

    }
}
