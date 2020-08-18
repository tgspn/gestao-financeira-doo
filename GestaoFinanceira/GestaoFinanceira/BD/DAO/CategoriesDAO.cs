using GestaoFinanceira.BD.Conections;
using GestaoFinanceira.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoFinanceira.BD.DAO
{
    public class CategoriesDAO : DAOBase<Category>
    {
        public CategoriesDAO(IConnection<Category> connection):base(connection)
        {

        }

        public override bool Delete(int id)
        {
            return connection.Delete(id);
        }

        public override IEnumerable<Category> Get()
        {
            return connection.Select();
        }

        public override Category Insert(Category categories)
        {
            var id=connection.Insert(categories);
            categories.Id = id;
            return categories;
        }

        public override Category Update(Category categories)
        {
            connection.Update(categories);
            return categories;
        }

        protected override string GetTableName()
        {
            return "categories";
        }
    }
}
