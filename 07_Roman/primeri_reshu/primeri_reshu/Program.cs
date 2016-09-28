using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primeri_reshu
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0) throw new ArgumentException("Value cannot be an empty collection.", nameof(args));
            if (args.Length != 3) throw new ArgumentException("Value cannot be an empty collection.", nameof(args));
            double pershe = double.Parse(args[0]);
            double druge = double.Parse(args[2]);
            string diya = args[1];
            //Console.Write("Введите первое число=>");
            //string per=Console.ReadLine();
            //Console.Write("ВВедите второе число=>");
            //string dr = Console.ReadLine();
            //double pershe = double.Parse(per);
            //double druge=double.Parse(dr);
            double res=0;
            //Console.Write("Введите операцию=>");
            //string diya = Console.ReadLine();
            if (diya == "+") res = pershe + druge;
            if (diya == "-") res = pershe - druge;
            if (diya == "*") res = pershe*druge;
            if (diya == "/") res = pershe/druge;
            Console.WriteLine("Результат=>"+res);
            Console.ReadKey();
        }
    }
}
