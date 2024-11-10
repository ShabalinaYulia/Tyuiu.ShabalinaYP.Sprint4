using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.ShabalinaYP.Sprint4.Task4.V11.Lib
{
    public class DataService : ISprint4Task4V11
    {
        public int Calculate(int[,] matrix)
        {
            int res = 0;
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (matrix[i, j] %2 != 0)
                    {
                        res += matrix[i, j];
                    }
                }
            }
            return res;
        }
    }
}
