﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ShtokerVN.Sprint1.Task0.V10.Lib;

namespace Tyuiu.ShtokerVN.Sprint1.Task0.V10
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* Спринт #1                                                                  *");
            Console.WriteLine("* Тема: Базовые навыки работы C#                                             *");
            Console.WriteLine("* Задание #0                                                                 *");
            Console.WriteLine("* Вариант #10                                                                *");
            Console.WriteLine("* Выполнил: Штокер Владимир Николаевич | ИИПБ-23-1                           *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                   *");
            Console.WriteLine("* Написать программу, которая вычисляет выражение (3 / 6 - 4) * 3            *");
            Console.WriteLine("* и печатает результат на экране.                                            *");
            Console.WriteLine("*                                                                            *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                           *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* (3 / 6 - 4) * 3                                                            *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                 *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine(ds.Calculate());
            Console.ReadLine();
        }
    }
}
