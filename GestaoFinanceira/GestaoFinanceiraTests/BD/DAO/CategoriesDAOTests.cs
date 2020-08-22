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

            MemorySQLConnection<Category> connection = new MemorySQLConnection<Category>();
            var categoria = new CategoriesDAO(connection);
            var result = categoria.Delete(11);

            Assert.IsTrue(result);
            Assert.AreEqual(1, categoria.Get().Count());
            Assert.AreNotEqual(11, categoria.Get().First().Id);           
        }

        

        [TestMethod()]
        public void GetTest()
        {

            MemorySQLConnection<Category> connection = new MemorySQLConnection<Category>();
            var categoria = new CategoriesDAO(connection);
            var result = categoria.Get();

            
            Assert.AreEqual(2, categoria.Get().Count());
            Assert.AreEqual(10, categoria.Get().First().Id);
        }

        [TestMethod()]
        public void InsertTest()
        {

            MemorySQLConnection<Category> connection = new MemorySQLConnection<Category>();
            var categoria = new CategoriesDAO(connection);
            var cat = new Category()
            {
                Id = 2,
                Description = "categoria com id 2"
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

            MemorySQLConnection<Category> connection = new MemorySQLConnection<Category>();
            var categoria = new CategoriesDAO(connection);
            var cat = new Category()
            {
                Id = 10,
                Description = "categoria com id 2"
            };
            var result = categoria.Update(cat);


            Assert.AreEqual(2, categoria.Get().Count());
            Assert.AreEqual("categoria com id 2",categoria.Get().First(x => x.Id == 10).Description);
        }

        private void AddSample()
        {
            MemorySQLConnection<Category> connection = new MemorySQLConnection<Category>();
            var categoria = new CategoriesDAO(connection);
            categoria.Insert(new Category()
            {
                Id = 10
            });
            categoria.Insert(new Category()
            {
                Id = 11
            });
        }
    }
}