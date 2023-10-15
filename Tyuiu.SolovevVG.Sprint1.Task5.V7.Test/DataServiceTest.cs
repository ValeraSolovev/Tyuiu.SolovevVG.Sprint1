using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SolovevVG.Sprint1.Task5.V7.Lib;

namespace Tyuiu.SolovevVG.Sprint1.Task5.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            double f = 60;
            DataService ds = new DataService();
            double res = ds.AngleToHoursMinutes(f);

            int result = Convert.ToInt32(res);

            int wait = 2;
            Assert.AreEqual(wait, result);
        }
    }
}
