using Tyuiu.ShabalinaYP.Sprint4.Task2.V24.Lib;
namespace Tyuiu.ShabalinaYP.Sprint4.Task2.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int[] array = new int[12] { 4, 5, 6, 7, 8, 9, 4, 5, 6, 7, 8, 9 };
            int wait = 42;
            int res = ds.Calculate(array);
            Assert.AreEqual(wait, res);
        }
    }
}