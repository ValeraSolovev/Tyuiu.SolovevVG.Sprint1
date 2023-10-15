using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.SolovevVG.Sprint1.Task7.V26.Lib;

namespace Tyuiu.SolovevVG.Sprint1.Task7.V26
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Соловьев В.Г. | СМАРТБ-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Создания итогового решения по спринту                             *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #26                                                             *");
            Console.WriteLine("* Выполнил: Соловьев В.Г. | СМАРТБ-23-1                                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу,которая вычисляет математическое выражение по        *");
            Console.WriteLine("* исходным значениям данных, вводимых пользователем. Ответ                *");
            Console.WriteLine("* округлите до 3 знаков после запятой.                                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");


            Console.WriteLine("Введите первое вещественное число");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите второе вещественное число");
            double y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine($"Значение выражения равно: {ds.Calculate(x, y)}");

            Console.ReadKey();
        }
    }
}
