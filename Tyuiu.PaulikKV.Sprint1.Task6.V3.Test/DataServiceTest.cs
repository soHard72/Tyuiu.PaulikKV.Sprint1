using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.PaulikKV.Sprint1.Task6.V3.Lib;

namespace Tyuiu.PaulikKV.Sprint1.Task6.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            string strTest = "Добрый вечер, как дела ?";
            DataService ds = new DataService();
            string result = ds.LastLetterWord(strTest);
            string wait = "йрка";
            Assert.AreEqual(wait,result);
        }
    }
}
