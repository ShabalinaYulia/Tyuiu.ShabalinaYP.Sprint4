using Tyuiu.ShabalinaYP.Sprint4.Task6.V7.Lib;
namespace Tyuiu.ShabalinaYP.Sprint4.Task6.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            var subjects = new string[] { "����������", "������", "�����", "��������", "���������", "�������", "���������" };
            int wait = 3;
            int res = ds.Calculate(subjects);
            Assert.AreEqual(wait, res);
        }
    }
}