using Microsoft.VisualStudio.TestTools.UnitTesting;
using GestaoFinanceira.BD.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoFinanceira.BD.DAO.Tests
{
    [TestClass()]
    public class CategoriesDAOTests
    {
        [TestMethod()]
        public void DeleteTest()
        {
            var categoria = new CategoriesDAO();
            Assert.ThrowsException<NotImplementedException>(() =>
            {
                categoria.Delete();
            });
        }

        [TestMethod()]
        public void GetTest()
        {
            var categoria = new CategoriesDAO();
            Assert.ThrowsException<NotImplementedException>(() =>
            {
                categoria.Get();
            });
        }

        [TestMethod()]
        public void InsertTest()
        {
            var categoria = new CategoriesDAO();
            Assert.ThrowsException<NotImplementedException>(() =>
            {
                categoria.Insert();
            });
        }

        [TestMethod()]
        public void UpdateTest()
        {
            var categoria = new CategoriesDAO();
            Assert.ThrowsException<NotImplementedException>(() =>
            {
                categoria.Update();
            });
        }
    }
}