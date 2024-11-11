using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.ShabalinaYP.Sprint4.Task6.V7.Lib
{
    public class DataService : ISprint4Task6V7
    {
        public int Calculate(string[] array)
        {
            int count = array.Count(s => s.Length > 8);
            return count;
        }
    }
}
