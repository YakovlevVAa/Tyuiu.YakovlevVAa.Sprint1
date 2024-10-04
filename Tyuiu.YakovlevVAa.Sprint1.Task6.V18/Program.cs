using Tyuiu.YakovlevVAa.Sprint1.Task6.V18.Lib;
namespace Tyuiu.YakovlevVAa.Sprint1.Task6.V18
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
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #2                                                              *");
            Console.WriteLine("* Выполнил: Яковлев Виктор Александрович | ИИПб-24-2                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дано значение температуры в градусах Фаренгейта.                        *");
            Console.WriteLine("* Определить значение этой же температуры в градусах Цельсия.             *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            string value;
            Console.WriteLine("Введите текст:");
            value = Convert.ToString(Console.ReadLine());
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            if (ds.CheckNumber(value) is true)
                Console.WriteLine("Введёный текст является натуральным числом");
            if (ds.CheckNumber(value) is false)
                Console.WriteLine("Введёный текст не является натуральным числом");
        }
    }
}
