﻿using Tyuiu.Kazhahmetov.Sprint4.Task0.V5.Lib;
namespace Tyuiu.Kazhahmetov.Sprint4.Task0.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] array = { 8, 9, 4, 1, 2, 3, 4, 5, 6, 7 };
            int res = ds.GetSumEvenArrEl(array);
            int wait = 24;
            Assert.AreEqual(wait, res);
        }
    }
}
