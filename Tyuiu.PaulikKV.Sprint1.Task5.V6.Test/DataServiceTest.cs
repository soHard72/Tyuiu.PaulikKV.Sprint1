using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.PaulikKV.Sprint1.Task5.V6.Lib;

namespace Tyuiu.PaulikKV.Sprint1.Task5.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            int k = 9;
            DataService ds = new DataService();
            var res = ds.Calculate(k);
            int wait = 2;
            Assert.AreEqual(wait,res);
        }
    }
}
