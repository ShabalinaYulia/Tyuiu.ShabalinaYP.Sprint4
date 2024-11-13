using Tyuiu.ShabalinaYP.Sprint4.Task7.V29.Lib;
namespace Tyuiu.ShabalinaYP.Sprint4.Task7.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int rows = 4;
            int columns = 3;
            int[,] matrix = new int[rows, columns];
            string str = "983157642891";
            int wait = 28;
            int res = ds.Calculate(rows, columns, str);
            Assert.AreEqual(wait, res);
        }
    }
}