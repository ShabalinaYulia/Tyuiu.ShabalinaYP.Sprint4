using Tyuiu.ShabalinaYP.Sprint4.Task3.V30.Lib;
namespace Tyuiu.ShabalinaYP.Sprint4.Task3.V30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int[,] mas2 = new int[5, 5] { {2, 4, 3, 5, 1 },
                                          { 6, 6, 1, 2, 6 },
                                          { 3, 3, 2, 1, 5 },
                                          { 6, 4, 1, 3, 3 },
                                          { 5, 1, 1, 6, 4 } };
            Console.WriteLine("Спринт #4 | Выполнил: Шабалина Ю. П. | ПКТб-24-1");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Двумерные массивы. (статический ввод)                             *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #30                                                             *");
            Console.WriteLine("* Выполнил: Шабалина Юлия Павловна | ПКТб-24-1                            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
            Console.WriteLine("* статическими значениями в диапазоне от 1 до 6. Найдите максимальный     *");
            Console.WriteLine("* элемент в третьей строке массива.                                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.Write("Массив: ");
            for (int i = 0; i < mas2.GetLength(0); i++)
            {
                for (int j = 0; j < mas2.GetLength(1); j++)
                {
                    Console.Write($"{mas2[i, j]} \t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            int res = ds.Calculate(mas2);
            Console.WriteLine("Максимальный элемент в третьей строке массива = " + res);
            Console.ReadKey();
        }
    }
}
