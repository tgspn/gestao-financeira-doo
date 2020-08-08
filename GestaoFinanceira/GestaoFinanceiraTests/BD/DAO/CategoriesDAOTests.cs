using Microsoft.VisualStudio.TestTools.UnitTesting;
using GestaoFinanceira.BD.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestaoFinanceira.BD.Conections;
using GestaoFinanceira.Model;

namespace GestaoFinanceira.BD.DAO.Tests
{
    [TestClass()]
    public class CategoriesDAOTests
    {
        [TestInitialize]
        public void Initialize()
        {
            AddSample();
        }
        [TestCleanup]
        public void CleanUp()
        {
            MemorySQLConnector.Instance.Close();
        }
        [TestMethod()]
        public void DeleteTest()
        {

            MemorySQLConnection<Categories> connection = new MemorySQLConnection<Categories>();
            var categoria = new CategoriesDAO(connection);
            var result = categoria.Delete(11);

            Assert.IsTrue(result);
            Assert.AreEqual(1, categoria.Get().Count());
            Assert.AreNotEqual(11, categoria.Get().First().Id);           
        }

        

        [TestMethod()]
        public void GetTest()
        {

            MemorySQLConnection<Categories> connection = new MemorySQLConnection<Categories>();
            var categoria = new CategoriesDAO(connection);
            var result = categoria.Get();

            
            Assert.AreEqual(2, categoria.Get().Count());
            Assert.AreEqual(10, categoria.Get().First().Id);
        }

        [TestMethod()]
        public void InsertTest()
        {

            MemorySQLConnection<Categories> connection = new MemorySQLConnection<Categories>();
            var categoria = new CategoriesDAO(connection);
            var cat = new Categories()
            {
                Id = 2,
                Descricao = "categoria com id 2"
            };
            var result = categoria.Insert(cat);


            Assert.AreEqual(3, categoria.Get().Count());
            Assert.IsTrue(categoria.Get().Any(x => x.Id == 2));
            Assert.AreEqual(cat, categoria.Get().First(x => x.Id == 2));
            Assert.AreEqual(cat, result);
        }

        [TestMethod()]
        public void UpdateTest()
        {

            MemorySQLConnection<Categories> connection = new MemorySQLConnection<Categories>();
            var categoria = new CategoriesDAO(connection);
            var cat = new Categories()
            {
                Id = 10,
                Descricao = "categoria com id 2"
            };
            var result = categoria.Update(cat);


            Assert.AreEqual(2, categoria.Get().Count());
            Assert.AreEqual("categoria com id 2",categoria.Get().First(x => x.Id == 10).Descricao);
        }

        private void AddSample()
        {
            MemorySQLConnection<Categories> connection = new MemorySQLConnection<Categories>();
            var categoria = new CategoriesDAO(connection);
            categoria.Insert(new Categories()
            {
                Id = 10
            });
            categoria.Insert(new Categories()
            {
                Id = 11
            });
        }
    }
}