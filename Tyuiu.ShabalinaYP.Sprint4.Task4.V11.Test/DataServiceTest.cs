using Tyuiu.ShabalinaYP.Sprint4.Task4.V11.Lib;

namespace Tyuiu.ShabalinaYP.Sprint4.Task4.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            int[,] matrix = { { 5, 7, 7, 8, 5 },
                              { 6, 5, 6, 8, 6 },
                              { 7, 6, 8, 8, 5 },
                              { 7, 6, 7, 8, 6 },
                              { 7, 6, 7, 7, 5 } };
            int wait = 81;
            int res = ds.Calculate(matrix);
            Assert.AreEqual(wait, res);
        }
    }
}