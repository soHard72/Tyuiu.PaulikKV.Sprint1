﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.PaulikKV.Sprint1.Task1.V1.Lib;
namespace Tyuiu.PaulikKV.Sprint1.Task1.V1
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил: Паулик Кирилл Владимирович. | АСОиУб-23-3";
            Console.WriteLine("************************************************************************");
            Console.WriteLine(" Спринт #1 ");
            Console.WriteLine(" Тема: Базовые навыки работы в С# ");
            Console.WriteLine(" Задание #1 ");
            Console.WriteLine(" Вариант #1 ");
            Console.WriteLine(" Выполнил: Паулик Кирилл Владимирович | АСОиУб-23-3 ");
            Console.WriteLine("************************************************************************");
            Console.WriteLine("* УСЛОВИЕ: ");
            Console.WriteLine(" Написать  программу, которая вычисляет выражение (x / 3 / y) + (6 * a) ");
            Console.WriteLine("  и печатает результат на экране ");
            Console.WriteLine(" ");
            Console.WriteLine("************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ: ");
            Console.WriteLine("************************************************************************");
            double a, x, y;
            Console.WriteLine("Введите значение A:");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение X:");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение Y:");
            y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ: *");
            Console.WriteLine("************************************************************************");
            Console.WriteLine(ds.Calculate(a, x, y));
            Console.ReadLine();

        }
    }
}
