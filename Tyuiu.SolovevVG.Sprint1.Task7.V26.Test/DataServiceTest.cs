using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SolovevVG.Sprint1.Task7.V26.Lib;

namespace Tyuiu.SolovevVG.Sprint1.Task7.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double res = ds.Calculate(1.0, 2.0);
            Assert.AreEqual(1.233, res);
        }
    }
}
