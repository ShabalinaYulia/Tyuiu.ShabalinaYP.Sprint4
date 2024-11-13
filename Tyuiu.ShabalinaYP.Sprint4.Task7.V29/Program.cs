using Tyuiu.ShabalinaYP.Sprint4.Task7.V29.Lib;
namespace Tyuiu.ShabalinaYP.Sprint4.Task7.V29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = 4;
            int columns = 3;
            int[,] matrix = new int[rows, columns];
            string str = "983157642891";
            DataService ds = new DataService();
            Console.WriteLine("Спринт #4 | Выполнил: Шабалина Ю. П. | ПКТб-24-1");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #29                                                             *");
            Console.WriteLine("* Выполнил: Шабалина Юлия Павловна | ПКТб-24-1                            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дана строка из одноразрядных цифр 983157642891.                         *");
            Console.WriteLine("* Преобразуйте ее в матрицу 4 на 3 и подсчитайте сумму четных чисел.      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            int index = 0;
            Console.WriteLine("\nМассив:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{str[index]} \t");
                    index++;
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            int res = ds.Calculate(rows, columns, str);
            Console.WriteLine("Сумма четных чисел = " + res);
            Console.ReadKey();
        }
    }
}
