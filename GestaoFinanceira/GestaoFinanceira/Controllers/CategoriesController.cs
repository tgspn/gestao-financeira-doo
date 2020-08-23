using GestaoFinanceira.BD.Conections;
using GestaoFinanceira.BD.DAO;
using GestaoFinanceira.Model;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            Context.Categories.Add(categories);
            Context.SaveChanges();
        }
        public void Remove(Category categories)
        {
            Context.Categories.Remove(categories);
            Context.SaveChanges();
        }


    }
}