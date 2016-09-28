using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Rect
{
   

    class Program
    {
       static void Main(string[] args)
        {
            Console.Write("\n Введите ширину прямоугольника: ");
            var length = Console.ReadLine();
            Console.Write(" Введите высоту прямоугольника: ");
            var height = Console.ReadLine();
            int verify;
            if (!string.IsNullOrEmpty(length)&&!string.IsNullOrEmpty(height)&&int.TryParse(length, out verify)&& int.TryParse(height, out verify))
            {
                var x = int.Parse(length);
                var y = int.Parse(height);
                Console.WriteLine();
                Drawing(x);
                Console.WriteLine();
                var randomcolor = new Random();
                for (var i = 0; i < y; i++)
                {
                    Console.Write("\t*");
                    for (var j = 0; j < x-2; j++)
                    {
                        Console.ForegroundColor = (ConsoleColor)randomcolor.Next(1, 16);
                        Console.Write(" ");
                    }
                    Console.Write("*");
                    Console.WriteLine();
                }
                Drawing(x);
            }
            else
            {
                Console.Write("\n Вы ввели некоректное значение!");
            }
            
            Console.ReadKey();
            
        }

        private static void Drawing(int x)
        {
            Console.Write("\t");
            var randomcolor = new Random();
            for (var i = 0; i < x; i++)
            {
                Console.ForegroundColor = (ConsoleColor)randomcolor.Next(1, 16);
                Console.Write("*");
            }
        }


    }
}
