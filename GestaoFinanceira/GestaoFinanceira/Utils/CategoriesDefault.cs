using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoFinanceira.Model
{
    public static class  CategoriesDefault
    {
        public static List<Category> GetCategories()
        {
            List<Category> categories = new List<Category>();
            List<SubCategories> list = new List<SubCategories>();

            Category cat = new Category();
            SubCategories subCat = new SubCategories();

            cat.Description = "Salario";
            cat.type = Enums.EntryType.Revenue;
            subCat = new SubCategories();
            subCat.Description = "Mensal";
            list.Add(subCat);
            subCat = new SubCategories();
            subCat.Description = "Retorno Investido";
            list.Add(subCat);
            cat.SubCategories = list;
            categories.Add(cat);

            list = new List<SubCategories>();
            cat = new Category();
            cat.Description = "Alimentação";
            cat.type = Enums.EntryType.Expense;
            subCat = new SubCategories();
            subCat.Description = "Refeição";
            list.Add(subCat);
            subCat = new SubCategories();
            subCat.Description = "Petisco";
            list.Add(subCat);
            subCat = new SubCategories();
            subCat.Description = "Lanche";
            list.Add(subCat);
            cat.SubCategories = list;
            categories.Add(cat);

            list = new List<SubCategories>();
            cat = new Category();
            cat.Description = "Educação";
            cat.type = Enums.EntryType.Expense;
            subCat = new SubCategories();
            subCat.Description = "Livros";
            list.Add(subCat);
            subCat = new SubCategories();
            subCat.Description = "Curso";
            list.Add(subCat);
            cat.SubCategories = list;
            categories.Add(cat);

            cat = new Category();
            cat.Description = "Lazer";
            cat.type = Enums.EntryType.Expense;
            categories.Add(cat);

            list = new List<SubCategories>();
            cat = new Category();
            cat.Description = "Saúde";
            cat.type = Enums.EntryType.Expense;
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
            cat = new Category();
            cat.Description = "Transporte";
            cat.type = Enums.EntryType.Expense;
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

            list = new List<SubCategories>();
            cat = new Category();
            cat.Description = "Fatura";
            cat.type = Enums.EntryType.ExpenseCreditCard;
            subCat = new SubCategories();
            subCat.Description = "Cartão de Crédito";
            list.Add(subCat);
            cat.SubCategories = list;
            categories.Add(cat);

            cat = new Category();
            cat.Description = "Outros";
            cat.type = Enums.EntryType.Expense;
            categories.Add(cat);

            cat = new Category();
            cat.Description = "Reajuste";
            cat.type = Enums.EntryType.AjustBalance;
            categories.Add(cat);

            cat = new Category();
            cat.Description = "Transferência";
            cat.type = Enums.EntryType.Transfer;
            categories.Add(cat);

            return categories;
        }

    }
}
