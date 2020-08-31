using GestaoFinanceira.BD.Conections;
using GestaoFinanceira.BD.DAO;
using GestaoFinanceira.Enums;
using GestaoFinanceira.Model;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestaoFinanceira.Controllers
{
    class CategoriesController : ControllerBase
    {
        public CategoriesController()
        {
        }
        public CategoriesController(ApplicationDbContext db) : base(db)
        {
        }

        public IEnumerable<Category> List()
        {
            return Context.Categories.ToList();
        }
        public Category Find(int categoriesId)
        {
            return Context.Categories.Find(categoriesId);
        }

        public Category FindByDescription(string description)
        {
            return Context.Categories.FirstOrDefault(x => x.Description == description);
        }

        public void Save(Category categories)
        {
            Category cat = categories.Id != 0 ? Context.Categories.FirstOrDefault(a => a.Id == categories.Id): null;
            if (cat == null)
                Context.Categories.Add(categories);
            Context.SaveChanges();
        }
        public void Remove(Category categories)
        {
            Context.Categories.Remove(categories);
            Context.SaveChanges();
        }

        public void LoadTreeView(TreeView tree)
        {
            tree.Nodes.Clear();
            tree.Nodes.Add("Tipo despesa             ").Tag=EntryType.Expense;
            tree.Nodes.Add("Tipo receita            ").Tag=EntryType.Revenue;
            tree.Nodes[0].NodeFont = new Font("Microsoft PhagsPa", 9, FontStyle.Bold);
            tree.Nodes[1].NodeFont = new Font("Microsoft PhagsPa", 9, FontStyle.Bold);

            int type = 0;
            int i = 0;
            int j = 0;
            foreach (var cat in Context.Categories.ToList().Where(c => 
                c.type != Enums.EntryType.AjustBalance &&
                c.type != Enums.EntryType.Transfer &&
                c.type != Enums.EntryType.ExpenseCreditCard
                ).OrderBy(a => a.type).ThenBy(a => a.Description))
            {
                if (cat.type == Enums.EntryType.Expense)
                {
                    type = 0;
                }
                else
                {
                    i = type == 1 ? i : 0;
                    type = 1;
                }

                j = 0;
                tree.Nodes[type].Nodes.Add(cat.Description);
                tree.Nodes[type].Nodes[i].Tag = cat;
                foreach (var subCat in cat.SubCategories)
                {
                    tree.Nodes[type].Nodes[i].Nodes.Add(subCat.Description);
                    tree.Nodes[type].Nodes[i].Nodes[j].Tag = subCat;
                    j++;
                }
                i++;
            }
        }

    }
}