using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_exerc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ВВедите номер задания=>");
            int i=Console.Read();
            switch (i)
            {
                case 1:
                {
                    Console.WriteLine("Введите количество галонов=>");
                    double k = Console.Read();
                    double f = k/7.481;
                    Console.WriteLine("Количество кубических футов=>"+f);
                    break;
                }
                case 2:
                {
                    Console.WriteLine("1990 135 1991 7290 1992 11300 1993 16200");
                    break;
                }
                case 6:
                {
                    Console.WriteLine("Введите количество долларов=>");
                    double dol=Console.Read();
                    Console.WriteLine("Фунтов стерлингов=>"+dol*1.487);
                    Console.WriteLine("Франков=>"+dol*0.172);
                    Console.WriteLine("Немецких марок=>"+dol*0.584);
                    Console.WriteLine("Японских ен=>"+dol*0.0095);
                    break;
                }
                case 7:
                {
                    Console.WriteLine("ВВедите температуру в градусах цельсия=>");
                    double cel=Console.Read();
                    cel = cel*9/5 + 32;
                    Console.WriteLine("Температура по Фаренгейту=>"+cel);
                    break;
                }
            }
        }
    }
}
