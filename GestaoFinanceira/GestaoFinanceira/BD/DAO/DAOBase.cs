using GestaoFinanceira.BD.Conections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoFinanceira.BD.DAO
{
    public abstract class DAOBase<TModel>
    {
        protected readonly IConnection<TModel> connection;

        public DAOBase(IConnection<TModel> connection)
        {
            this.connection = connection;
            Initialize();        
        }

        private void Initialize()
        {
            connection.SetTableName(GetTableName());
        }

        public abstract IEnumerable<TModel> Get();
        public abstract TModel Update(TModel categories);
        public abstract TModel Insert(TModel categories);
        public abstract bool Delete(int id);
        protected abstract string GetTableName();

    }
}
