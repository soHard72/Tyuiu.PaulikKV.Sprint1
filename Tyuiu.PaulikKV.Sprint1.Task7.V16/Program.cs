using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.PaulikKV.Sprint1.Task7.V16.Lib;

namespace Tyuiu.PaulikKV.Sprint1.Task7.V16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ :                                                       *");
            Console.WriteLine("***************************************************************************");
            double x;
            Console.WriteLine("Введите значение Х:");
            x = Convert.ToInt32(Console.ReadLine());
            double z = Math.Round(Math.Sin(Math.Sqrt(x * x)) + (Math.Cos(x * x) / (3 * (x * x * x))) - Math.Sin(Math.Sqrt(x * x - 1)),3);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Результат :                                                              ");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Математическое выражение sin√x^2 + cosx^2/3x^3 - sin√x^2 - 1 = " + z);
            Console.ReadKey();
        }
    }
}
