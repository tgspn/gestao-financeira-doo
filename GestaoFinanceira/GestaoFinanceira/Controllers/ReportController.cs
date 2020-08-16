using GestaoFinanceira.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoFinanceira.Controllers
{
    public class ReportController<TModel>
    {
        public string Export()
        {
            throw new NotImplementedException();
        }

        public void Import(string csvContent)
        {
            throw new NotImplementedException();
        }

        public  List<TModel> GenerateByDay()
        {
            throw new NotImplementedException();
        }

        public List<TModel> GenerateByMonth()
        {
            throw new NotImplementedException();
        }

        public List<TModel> GenerateByYear()
        {
            throw new NotImplementedException();
        }

        public List<TModel> GenerateByPeriod(DateTime dateIni, DateTime dateEnd)
        {
            throw new NotImplementedException();
        }

        public List<TModel> GenerateByCategories()
        {
            throw new NotImplementedException();
        }
        public List<TModel> GenerateBySubCategories()
        {
            throw new NotImplementedException();
        }

        private void ToModel(string csvContent)
        {
            throw new NotImplementedException();
        }
    }
}
