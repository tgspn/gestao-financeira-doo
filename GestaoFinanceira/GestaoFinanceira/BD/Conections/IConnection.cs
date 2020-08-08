using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoFinanceira.BD.Conections
{
    public interface IConnection<T>
    {
        int Insert(T obj);
        void Update(T obj);
        void Update(T obj, string where);
        bool Delete(int id);
        IEnumerable<T> Select();
        IEnumerable<T> Select(string columns);
        IEnumerable<T> Select(string columns, string where);
        IEnumerable<T> Select(string columns, string where, string extra);
        void SetTableName(string tableName);
    }
}
