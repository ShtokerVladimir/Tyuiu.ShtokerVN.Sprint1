using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ShtokerVN.Sprint1.Task7.V17.Lib;

namespace Tyuiu.ShtokerVN.Sprint1.Task7.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 4;
            double wait = 1.787;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
