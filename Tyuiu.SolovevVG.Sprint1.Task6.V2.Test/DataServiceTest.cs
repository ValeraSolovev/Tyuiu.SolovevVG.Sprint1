using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SolovevVG.Sprint1.Task6.V2.Lib;

namespace Tyuiu.SolovevVG.Sprint1.Task6.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            bool res = ds.CheckHello("Hello, World!!!");

            
            Assert.AreEqual(true, res);
        }
    }
}
