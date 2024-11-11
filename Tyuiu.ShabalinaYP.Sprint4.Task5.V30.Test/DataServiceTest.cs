using Tyuiu.ShabalinaYP.Sprint4.Task5.V30.Lib;
namespace Tyuiu.ShabalinaYP.Sprint4.Task5.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int[,] matrix = { { -2, -1, 0, 1, 2, 3, 4 },
                              { -2, -1, 0, 1, 2, 3, 4 },
                              { -2, -1, 0, 1, 2, 3, 4 },
                              { -2, -1, 0, 1, 2, 3, 4 },
                              { -2, -1, 0, 1, 2, 3, 4 } };
            int wait = 50;
            int res = ds.Calculate(matrix);
            Assert.AreEqual(wait, res);
        }
    }
}