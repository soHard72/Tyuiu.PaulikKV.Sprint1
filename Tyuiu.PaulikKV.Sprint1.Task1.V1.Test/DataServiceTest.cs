using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.PaulikKV.Sprint1.Task1.V1.Lib;

namespace Tyuiu.PaulikKV.Sprint1.Task1.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double a = 3;
            double x = 12;
            double y = 2;
            var res = ds.Calculate(a, x, y);
            Assert.AreEqual(20, res);
        }
    }
}
