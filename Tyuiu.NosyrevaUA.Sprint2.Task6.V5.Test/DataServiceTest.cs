using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.NosyrevaUA.Sprint2.Task6.V5.Lib;

namespace Tyuiu.NosyrevaUA.Sprint2.Task6.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindCardValue()
        {
            DataService ds = new DataService();

            Assert.AreEqual("Шестерка", ds.FindCardValue(6));
            Assert.AreEqual("Восьмерка", ds.FindCardValue(8));
            Assert.AreEqual("Десятка", ds.FindCardValue(10));
            Assert.AreEqual("Дама", ds.FindCardValue(12));
            Assert.AreEqual("Туз", ds.FindCardValue(14));
            Assert.AreEqual("Девятка", ds.FindCardValue(9));
            Assert.AreEqual("Валет", ds.FindCardValue(11));
            Assert.AreEqual("Король", ds.FindCardValue(13));
            Assert.AreEqual("Семерка", ds.FindCardValue(7));
            Assert.ThrowsException<ArgumentException>(() =>
            {
                ds.FindCardValue(0);
            });
        }
    }
}
