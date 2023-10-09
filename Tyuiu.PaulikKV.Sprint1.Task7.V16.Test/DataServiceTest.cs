using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.PaulikKV.Sprint1.Task7.V16.Lib;

namespace Tyuiu.PaulikKV.Sprint1.Task7.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2;
            double wait = -0.105;
            var res = ds.Calculate(x);
            Assert.AreEqual(wait, res);
        }
    }
}
