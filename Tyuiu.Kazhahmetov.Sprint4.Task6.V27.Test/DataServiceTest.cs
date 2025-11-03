using Tyuiu.Kazhahmetov.Sprint4.Task6.V27.Lib;
namespace Tyuiu.Kazhahmetov.Sprint4.Task6.V27.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string[] Array = new string[] { "Квадрат", "Прямоугольник", "Круг", "Треугольник", "Пятиугольник", "Шестиугольник", "Восьмиугольник" };
            int res = ds.Calculate(Array);
            int wait = 1;
            Assert.AreEqual(wait, res);
        }
    }
}
