using Tyuiu.YakovlevVAa.Sprint1.Task3.V3.Lib;
namespace Tyuiu.YakovlevVAa.Sprint1.Task3.V3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил: Яковлев В. А. | ИИПб-24-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #3                                                              *");
            Console.WriteLine("* Выполнил: Яковлев Виктор Александрович | ИИПб-24-2                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу вычисления объема параллелепипеда.                   *");
            Console.WriteLine("*  Ответ округлите до 3 знаков после запятой.                             *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            double length, width, height;
            Console.WriteLine("Введите ДЛИНУ:");
            length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите ШИРИНУ:");
            width = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите ВЫСОТУ:");
            height = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"{Math.Round(ds.ParallelepipedVolume(length, width, height), 3)}");
        }
    }
}
