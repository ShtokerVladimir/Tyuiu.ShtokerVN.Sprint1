using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ShtokerVN.Sprint1.Task6.V8.Lib;

namespace Tyuiu.ShtokerVN.Sprint1.Task6.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            string strTest = "Сева*любит*женские*глаза";
            DataService ds = new DataService();
            string res = ds.MoveLetterToEnd(strTest);
            string wait = "ева юбит енские лаза слжг";
            Assert.AreEqual(wait, res);

        }
    }
}
