using System.Runtime.ExceptionServices;
using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.ShabalinaYP.Sprint4.Task3.V30.Lib
{
    public class DataService : ISprint4Task3V30
    {
        public int Calculate(int[,] array)
        {
            int max = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[2, j] >= max)
                    {
                        max = array[2, j];
                    }
                }
            }

            return max;
        }
    }
}
