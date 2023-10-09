using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.PaulikKV.Sprint1.Task4.V9.Lib;

namespace Tyuiu.PaulikKV.Sprint1.Task4.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 2;
            double wait = -1.543;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
