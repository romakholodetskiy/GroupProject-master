using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elka
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0) throw new ArgumentException("Value cannot be an empty collection.", nameof(args));
            int urovni=int.Parse(args[0]);
            //while (urovni >= 15)
           // {
               // Console.Write("Введите количество уровней=>");
                //string s = Console.ReadLine();
                //urovni = Convert.ToInt32(s);
            //}
            string osn = "";
            Console.ForegroundColor=ConsoleColor.Green;
            for (int i = 1; i <= urovni; i++)//цикл уровней елки//
            {
                int per = 1;
                int dr = 1;
                osn = "";
                for (int j = 1; j <= i + 1; j++)//цикл програмирования одного данного уровня//
                {
                    for (int k = 1; k <=60-j; k++)//цикл непосредственного рисования строк уровня//
                    {
                        osn = osn + " ";
                    }
                    for (int m = 1; m <= dr; m++)
                    {
                        osn = osn + "*";
                    }
                    Console.WriteLine(osn);
                    osn = "";
                    per = per + 1;
                    dr = dr + 2;
                }
            }
            if (urovni < 4)
            {
                Console.ForegroundColor=ConsoleColor.White;
                for (int n = 1; n <= 120; n++)
                {
                    osn = osn + "*";
                }
                Console.Write(osn);
                Console.Write("ваша елка через чур маленькая чтоб иметь пенек");
            }
            if (urovni >= 4)
            {
                    Console.ForegroundColor=ConsoleColor.DarkGray;
                    for (int n = 1; n <= 57; n++)
                    {
                        osn = osn + " ";
                    }
                    for (int n = 1; n <= 5; n++)
                    {
                        osn = osn + "*";
                    }
                    Console.WriteLine(osn);
                    Console.WriteLine(osn);
                    Console.WriteLine(osn);
                    Console.WriteLine(osn);
                osn = "";
                Console.ForegroundColor=ConsoleColor.White;
                for (int n = 1; n <= 120; n++)
                {
                    osn = osn + "*";
                }
                Console.Write(osn);

            }
            Console.ReadKey();
        }
    }
}
