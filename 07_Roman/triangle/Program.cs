using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("ВВедите длину прямоугольника=>");
            int dl = Convert.ToInt32(Console.ReadLine());
            Console.Write("ВВедите ширину прямоугольника=>");
            int sh = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            string s = "   ";
            for (int i = 1; i <= dl; i++)
            {
                s = s + "*";
            }
            Console.WriteLine(s);
            int dl2 = dl - 2;
            for (int i = 1; i <= sh-2; i++)
            {
                s = "   *";
                for (int j = 1; j <=dl2; j++)
                {
                    s = s + " ";
                }
                s = s + "*";
                Console.WriteLine(s);
            }
            s = "   ";
            for (int i = 1; i <= dl; i++)
            {
                s = s + "*";
            }
            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
