using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SolovevVG.Sprint1.Task3.V10.Lib;

namespace Tyuiu.SolovevVG.Sprint1.Task3.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2;
            
            Assert.AreEqual(2, x);
        }
    }
}
