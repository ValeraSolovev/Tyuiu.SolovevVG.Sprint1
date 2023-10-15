using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SolovevVG.Sprint1.Task1.V4.Lib;

namespace Tyuiu.SolovevVG.Sprint1.Task1.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2.0;
            double y = 5.0;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(17.5, res);
        }
    }
}
