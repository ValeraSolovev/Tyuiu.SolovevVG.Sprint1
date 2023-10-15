using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.SolovevVG.Sprint1.Task3.V10.Lib;

namespace Tyuiu.SolovevVG.Sprint1.Task3.V10
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
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #8                                                              *");
            Console.WriteLine("* Выполнил: Соловьев В.Г. | СМАРТБ-23-1                                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая преобразует введенное с клавиатуры          *");
            Console.WriteLine("* дробное число в денежный формат и печатает результат на экране.         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите дробное число:");
            double all = Convert.ToDouble(Console.ReadLine());
            string q = all.ToString();
            int x = Convert.ToInt32(q.Substring(0, q.IndexOf(','))); ;

            double b = (ds.NumberToMoney(all) - x) * 100;

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine($"{ds.NumberToMoney(all)} руб. = {x} рублей и {Math.Round(b, 3)} копеек");

            Console.ReadLine();
        }
    }
}
