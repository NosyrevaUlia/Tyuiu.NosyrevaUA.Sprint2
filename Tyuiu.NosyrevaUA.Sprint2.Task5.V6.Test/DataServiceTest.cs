using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.NosyrevaUA.Sprint2.Task5.V6.Lib;

namespace Tyuiu.NosyrevaUA.Sprint2.Task5.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindCardNameAndValue()
        {
            DataService ds = new DataService();

            Assert.AreEqual("Дама пик", ds.FindCardNameAndValue(12, 1));
            Assert.AreEqual("Шестерка бубен", ds.FindCardNameAndValue(6, 3));
            Assert.AreEqual("Девятка треф", ds.FindCardNameAndValue(9, 2));
            Assert.AreEqual("Туз треф", ds.FindCardNameAndValue(14, 2));
            Assert.AreEqual("Семерка червей",ds.FindCardNameAndValue(7, 4));
            Assert.AreEqual("Король бубен", ds.FindCardNameAndValue(13, 3));
            Assert.AreEqual("Десятка пик", ds.FindCardNameAndValue(10, 1));

            Assert.ThrowsException<ArgumentException>(() =>
            {
                ds.FindCardNameAndValue(0, 6);
            });
            Assert.ThrowsException<ArgumentException>(() =>
            {
                ds.FindCardNameAndValue(3, 65);
            });
        }
    }
}
