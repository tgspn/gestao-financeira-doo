using Microsoft.VisualStudio.TestTools.UnitTesting;
using GestaoFinanceira;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoFinanceira.Tests
{
    [TestClass()]
    public class Form1Tests
    {
        [TestMethod()]
        public void Form1Test()
        {
            //var result = função.soma(1,1);
            Assert.Equals(2);
        }
    }
}