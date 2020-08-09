using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace GestaoFinanceira.BD.Conections
{
    public class MemorySQLConnector
    {
        Dictionary<string, dynamic> data;
        private MemorySQLConnector()
        {
            data = new Dictionary<string, dynamic>();
        }
        public void CreateTable<TModel>(string tableName)
        {
            data[tableName] = new Dictionary<int, TModel>();
        }
        public Dictionary<int, TModel> GetTable<TModel>(string tableName)
        {
            if (!data.ContainsKey(tableName))
                CreateTable<TModel>(tableName);

            return data[tableName];
        }

        public void Close()
        {
            data = new Dictionary<string, dynamic>();
        }

        public static MemorySQLConnector Instance { get; } = new MemorySQLConnector();
    }
    public class MemorySQLConnection<TModel> : IConnection<TModel>
    {
        private string tableName;

        private Dictionary<int, TModel> data { get => MemorySQLConnector.Instance.GetTable<TModel>(tableName); }


        public bool Delete(int id)
        {
            if (data.ContainsKey(id))
            {
                data.Remove(id);
                return true;
            }
            return false;

        }


        //Reflexão
        private int GetIdValue(TModel obj)
        {
            var type = typeof(TModel);
            var propId = type.GetProperty("Id");
            if (propId == null)
                throw new ArgumentOutOfRangeException("Não foi encontrado a propriedade Id no objeto, por favor, defina uma propriedade Id com o tipo Int");
            return (int)propId.GetValue(obj);
        }

        public int Insert(TModel obj)
        {
            var id = GetIdValue(obj);
            if (id == 0)
                id = data.Keys.Count() == 0 ? 1 : data.Keys.Max() + 1;

            if (data.ContainsKey(id))
                throw new Exception($"Já existe uma chave com esse valor {id}");
            data[id] = obj;
            return id;
        }

        public IEnumerable<TModel> Select()
        {
            return data.Values.ToList();
        }

        public IEnumerable<TModel> Select(string columns)
        {
            return Select();
        }

        public IEnumerable<TModel> Select(string columns, string where)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TModel> Select(string columns, string where, string extra)
        {
            throw new NotImplementedException();
        }

        public void SetTableName(string tableName) => this.tableName = tableName;

        public void Update(TModel obj)
        {
            var id = GetIdValue(obj);
            if (data.ContainsKey(id))
                data[id] = obj;
            else
                throw new Exception("O id não existe na base");

        }

        public void Update(TModel obj, string where)
        {
            throw new NotImplementedException();
        }
    }
}