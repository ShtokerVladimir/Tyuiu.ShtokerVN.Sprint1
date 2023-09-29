using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ShtokerVN.Sprint1.Task7.V17.Lib;

namespace Tyuiu.ShtokerVN.Sprint1.Task7.V17
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();


            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* Спринт #1                                                                  *");
            Console.WriteLine("* Тема: Базовые навыки работы C#                                             *");
            Console.WriteLine("* Задание #7                                                                 *");
            Console.WriteLine("* Вариант #17                                                                *");
            Console.WriteLine("* Выполнил: Штокер Владимир Николаевич | ИИПБ-23-1                           *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                   *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные,    *");
            Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.                *");
            Console.WriteLine("*                                                                            *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                           *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("    1 + sin √x ^ 2 + 1");
            Console.WriteLine("z = ------------------");
            Console.WriteLine("     cos (12 * y - 4)");

            double x, y;

            Console.WriteLine("Введите значение X:");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение Y:");
            y = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                 *");
            Console.WriteLine("******************************************************************************");

            Console.WriteLine(ds.Calculate(x, y));
            Console.ReadLine();
        }
    }
}
