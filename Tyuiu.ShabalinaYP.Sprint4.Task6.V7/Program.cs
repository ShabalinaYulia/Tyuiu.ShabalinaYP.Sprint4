using Tyuiu.ShabalinaYP.Sprint4.Task6.V7.Lib;
namespace Tyuiu.ShabalinaYP.Sprint4.Task6.V7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("Спринт #4 | Выполнил: Шабалина Ю. П. | ПКТб-24-1");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Класс Array                                                       *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #7                                                              *");
            Console.WriteLine("* Выполнил: Шабалина Юлия Павловна | ПКТб-24-1                            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан строковый массив данных используя класс Array.                       *");
            Console.WriteLine("* Подсчитайте количество элементов, длина которых больше 8.               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            var subjects = new string[] { "Математика", "Физика", "Химия", "Биология", "География", "История", "Экономика" };
            Console.WriteLine("Исходный массив:");
            for (int i = 0; i <= subjects.Length-1; i++)
            {
                Console.WriteLine(subjects[i]);
            }
         
            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Количество элементов, длина которых больше 8:");
            int res = ds.Calculate(subjects);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
