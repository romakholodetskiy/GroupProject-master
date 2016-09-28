using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication12
{
    class Program
    {
        static void Main(string[] args)
        {
            var str = "Hello world";
            int strLen = str.Length;
            for (int i = 0; i < strLen; i++) 
            {
                System.Console.ForegroundColor = (ConsoleColor)(i % 15 + 1);
                System.Console.Out.Write(str[i]);
            }
            Console.ReadKey();
        }
    }
}
