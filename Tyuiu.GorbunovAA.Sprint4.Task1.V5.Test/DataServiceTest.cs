using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GorbunovAA.Sprint4.Task1.V5.Lib;

namespace Tyuiu.GorbunovAA.Sprint4.Task1.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int[] array = new int[] { 9, 6, 6, 9, 7, 8, 5, 9, 6, 6, 8, 6, 8, 6, 7 };
            var res = ds.Calculate(array);
            var wait = 60;
            Assert.AreEqual(wait, res);
        }
    }
}
