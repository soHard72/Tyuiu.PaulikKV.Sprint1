﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.PaulikKV.Sprint1.Task0.V20.Lib;

namespace Tyuiu.PaulikKV.Sprint1.Task0.V20
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил: Паулик Кирилл Владимирович. | АСОиУб-23-3";
            Console.WriteLine("");
            Console.WriteLine(" Спринт #1 ");
            Console.WriteLine(" Тема: Базовые навыки работы в С# ");
            Console.WriteLine(" Задание #0 ");
            Console.WriteLine(" Вариант #20 ");
            Console.WriteLine(" Выполнил: Паулик Кирилл Владимирович | АСОиУб-23-3 ");
            Console.WriteLine("");
            Console.WriteLine("* УСЛОВИЕ: ");
            Console.WriteLine(" Написать  программу, которая вычисляет выражение 10 + 9 / 3 ");
            Console.WriteLine("  и печатает результат на экране ");
            Console.WriteLine(" ");
            Console.WriteLine("");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ: *");
            Console.WriteLine("");
            Console.WriteLine("* 10 + 9 / 3 * ");
            Console.WriteLine("");
            Console.WriteLine("* РЕЗУЛЬТАТ: *");
            Console.WriteLine("");
            Console.WriteLine(ds.Calculate());
            Console.ReadKey();
        }
    }
}
