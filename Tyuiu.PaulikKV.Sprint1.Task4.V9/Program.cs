using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.PaulikKV.Sprint1.Task4.V9.Lib;

namespace Tyuiu.PaulikKV.Sprint1.V9
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ :                                                       *");
            Console.WriteLine("***************************************************************************");
            int x, y;
            Console.WriteLine("Введите значение Х :");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение Y :");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Результат :                                                             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(" lnxy/x-√(1+y^2) = " + ds.Calculate(x,y));
            Console.ReadKey();
        }
    }
}
