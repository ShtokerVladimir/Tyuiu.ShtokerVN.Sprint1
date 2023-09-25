using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ShtokerVN.Sprint1.Task4.V10.Lib;

namespace Tyuiu.ShtokerVN.Sprint1.Task4.V10
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* Спринт #1                                                                  *");
            Console.WriteLine("* Тема: Базовые навыки работы C#                                             *");
            Console.WriteLine("* Задание #4                                                                 *");
            Console.WriteLine("* Вариант #10                                                                *");
            Console.WriteLine("* Выполнил: Штокер Владимир Николаевич | ИИПБ-23-1                           *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                   *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные,    *");
            Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.                *");
            Console.WriteLine("*                                                                            *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                           *");
            Console.WriteLine("******************************************************************************");

            int a;

            Console.WriteLine(" Введите значение A:");
            a = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                 *");
            Console.WriteLine("******************************************************************************");

            Console.WriteLine("1 + cos(a) / sin^2(a) = " + ds.Calculate(a));
            Console.ReadLine();
        }
    }
}
