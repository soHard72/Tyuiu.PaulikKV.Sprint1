using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.PaulikKV.Sprint1.Task5.V6.Lib;

namespace Tyuiu.PaulikKV.Sprint1.Task5.V6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ :                                                       *");
            Console.WriteLine("***************************************************************************");
            int k;
            Console.WriteLine("Введите значение k");
            k = Convert.ToInt32(Console.ReadLine());
            int n = k - ((k - 1) / 7) * 7;
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(" Результат :                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(k + " день - это " + n + " день недели");
            Console.ReadKey();
        }
    }
}
