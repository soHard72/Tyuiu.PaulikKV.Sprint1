using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.PaulikKV.Sprint1.Task6.V3.Lib;

namespace Tyuiu.PaulikKV.Sprint1.Task6.V3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ :                                                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Введите строку");
            string str = Console.ReadLine();
            string[] words = str.Split(new char[] { ' ', ',', '.', '!', '?', ':', ';' }, StringSplitOptions.RemoveEmptyEntries);
            string result = string.Empty;

            foreach (string word in words)
            {
                char LastLetter = word[word.Length - 1];
                result += LastLetter;
            }
            string res = result;
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Результат :                                                             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Строка из последних букв данной строки : " + res);
            Console.ReadKey();

        }
    }
}
