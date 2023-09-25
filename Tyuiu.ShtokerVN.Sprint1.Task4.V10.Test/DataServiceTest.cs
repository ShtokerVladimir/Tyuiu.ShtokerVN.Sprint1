using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ShtokerVN.Sprint1.Task4.V10.Lib;

namespace Tyuiu.ShtokerVN.Sprint1.Task4.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double a = 2;
            double wait = 0.706;
            var res = ds.Calculate(a);
            Assert.AreEqual(wait, res);
        }
    }
}
