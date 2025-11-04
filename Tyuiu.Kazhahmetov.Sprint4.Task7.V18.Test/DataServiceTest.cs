using Tyuiu.Kazhahmetov.Sprint4.Task7.V18.Lib;
namespace Tyuiu.Kazhahmetov.Sprint4.Task7.V18.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string value = "145258749635789";
            int rows = 5;
            int cols = 3;
            int res = ds.Calculate(rows, cols, value);
            int wait = 12_288;
            Assert.AreEqual(wait, res);
        }
    }
}
