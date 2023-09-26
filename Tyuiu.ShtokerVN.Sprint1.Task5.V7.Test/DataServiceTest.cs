using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ShtokerVN.Sprint1.Task5.V7.Lib;

namespace Tyuiu.ShtokerVN.Sprint1.Task5.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            double f = 15;
            DataService ds = new DataService();
            int h = ds.AngleToHoursMinutes(f);

            int result =Convert.ToInt32(h);

            double wait = 0;
            Assert.AreEqual(wait, result);
        }
    }
}
