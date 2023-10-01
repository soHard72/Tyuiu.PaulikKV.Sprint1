using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.PaulikKV.Sprint1.Task3.V10.Lib;

namespace Tyuiu.PaulikKV.Sprint1.Task3.V10
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("***********************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                            *");
            Console.WriteLine("***********************************************************************************************");

            Console.WriteLine("Введите дробное значение X:");
            double x = Convert.ToDouble(Console.ReadLine());
            int y = (int)Math.Truncate(x);
            string b = x.ToString();
            string c = b.Substring(b.IndexOf(',') + 1);
            int d = Convert.ToInt32(c);


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Результат :                                                             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(ds.NumberToMoney(x) + "руб. - это " + ds.NumberToMoney(y) + " руб. " + ds.NumberToMoney(d)*10 + " коп.");
            Console.ReadLine();
        }
    }
}
