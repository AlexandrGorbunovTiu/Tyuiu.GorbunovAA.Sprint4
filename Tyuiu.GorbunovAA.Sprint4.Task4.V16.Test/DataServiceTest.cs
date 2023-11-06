﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GorbunovAA.Sprint4.Task4.V16.Lib;

namespace Tyuiu.GorbunovAA.Sprint4.Task4.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int[,] res = new int[,] { { 6, 5, 6, 7, 3 }, { 5, 4, 6, 7, 3 } , { 5, 5, 5, 6, 5 } , { 6, 5, 4, 4, 3 } , { 4, 5, 4, 5, 5 } };
            int[,] wait = new int[,] { { 1, 5, 1, 7, 3 }, { 5, 1, 1, 7, 3 }, { 5, 5, 5, 1, 5 } , { 1, 5, 1, 1, 3 } , { 1, 5, 1, 5, 5 } };
            Assert.AreEqual(ds.Calculate(res), ds.Calculate(res));
        }
    }
}
