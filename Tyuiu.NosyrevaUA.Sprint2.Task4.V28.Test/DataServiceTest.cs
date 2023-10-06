using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.NosyrevaUA.Sprint2.Task4.V28.Lib;

namespace Tyuiu.NosyrevaUA.Sprint2.Task4.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 5;
            double y = 10;
            double res = ds.Calculate(x, y);
            Assert.AreEqual(res, 7,101);
        }

        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 5;
            double y = 2;
            double res = ds.Calculate(x, y);
            Assert.AreEqual(res, 4.708);
        }
    }
}
