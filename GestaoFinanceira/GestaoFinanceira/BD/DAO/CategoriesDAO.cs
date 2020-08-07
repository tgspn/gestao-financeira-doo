using GestaoFinanceira.BD.Conections;
using GestaoFinanceira.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoFinanceira.BD.DAO
{
    public class CategoriesDAO : DAOBase<Categories>
    {
        public CategoriesDAO(IConnection<Categories> connection):base(connection)
        {

        }

        public override bool Delete(int id)
        {
            return connection.Delete(id);
        }

        public override IEnumerable<Categories> Get()
        {
            return connection.Select();
        }

        public override Categories Insert(Categories categories)
        {
            var id=connection.Insert(categories);
            categories.Id = id;
            return categories;
        }

        public override Categories Update(Categories categories)
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
