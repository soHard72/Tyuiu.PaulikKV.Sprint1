using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.PaulikKV.Sprint1.Task2.V21.Lib;

namespace Tyuiu.PaulikKV.Sprint1.Task2.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 8;
            int y = 7;
            var res = ds.CalculateRectangleSquare(x, y);
            Assert.AreEqual(56, res);

        }
    }
}
