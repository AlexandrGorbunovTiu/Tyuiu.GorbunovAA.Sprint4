using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GorbunovAA.Sprint4.Task0.V26.Lib;

namespace Tyuiu.GorbunovAA.Sprint4.Task0.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            int[] array = { 9, 3, 7, 1, 5, 5, 3, 2, 1, 7 };
            int wait = 41;
            Assert.AreEqual(wait, ds.GetSumOddArrEl(array));
        }
    }
}
