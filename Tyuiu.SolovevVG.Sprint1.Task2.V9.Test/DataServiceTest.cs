using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SolovevVG.Sprint1.Task2.V9.Lib;

namespace Tyuiu.SolovevVG.Sprint1.Task2.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExression()
        {
            DataService ds = new DataService();
            int x = 2;
            var res = ds.CalculateVolumeCircle(x);
            Assert.AreEqual(33.493, res);
        }
    }
}
