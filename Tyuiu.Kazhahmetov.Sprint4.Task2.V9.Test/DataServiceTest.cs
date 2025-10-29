using Tyuiu.Kazhahmetov.Sprint4.Task2.V9.Lib;
namespace Tyuiu.Kazhahmetov.Sprint4.Task1.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] array = { 4, 8, 8, 9, 6, 5, 3, 2, 9, 7, 7, 7, 1, 1 };
            int res = ds.Calculate(array);
            int wait = 3072;
            Assert.AreEqual(wait, res);
        }
    }
}