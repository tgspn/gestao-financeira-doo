using GestaoFinanceira.BD.Conections;
using GestaoFinanceira.BD.DAO;
using GestaoFinanceira.Model;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoFinanceira.Controllers
{
    class CategoriesController
    {
        private CategoriesDAO dao;
        private IConnection<Categories> connection;
        private MemorySQLConnection<CreditCard> memorySQLConnection;

        public CategoriesController(IConnection<Categories> connection)
        {
            this.connection = connection;
            this.dao = new CategoriesDAO(connection);
        }

        public CategoriesController(MemorySQLConnection<CreditCard> memorySQLConnection)
        {
            this.memorySQLConnection = memorySQLConnection;
        }

        public List<Categories> List()
        {
            return dao.Get().ToList();
        }
        public Categories Find(int categoriesId)
        {
            throw new NotImplementedException();
        }

        public void Save(Categories categories)
        {
            if (categories.Id == 0)
                dao.Insert(categories);
            else
                dao.Update(categories);
        }
        public void Remove(Categories categories)
        {
            dao.Delete(categories.Id);
        }
    }
}