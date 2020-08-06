using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoFinanceira.DAO
{
    public abstract class DAOBase<TModel>
    {
        public abstract List<TModel> Get();
        public abstract TModel Update();
        public abstract TModel Insert();
        public abstract TModel Delete();

    }
}
