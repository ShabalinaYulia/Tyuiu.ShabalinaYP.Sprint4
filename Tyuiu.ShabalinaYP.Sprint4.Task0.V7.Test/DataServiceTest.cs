using Tyuiu.ShabalinaYP.Sprint4.Task0.V7.Lib;
namespace Tyuiu.ShabalinaYP.Sprint4.Task0.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultOddArrEl()
        {
            DataService ds = new DataService();

            int[] array = new int[] { 9, 8, 7, 9, 5, 4, 3, 2, 3, 7 };
            int wait = 178605;
            int res = ds.GetMultOddArrEl(array);
            Assert.AreEqual(wait, res);
        }
    }
}