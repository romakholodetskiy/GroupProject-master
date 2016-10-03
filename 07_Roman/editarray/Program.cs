using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace editarray
{
    class Program
    {
        static void Main(string[] args)
        {
            int l = 10;
            int h = 5;
            int[][] array = new int[h][];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new int[l];
                for (int j = 0; j < array[i].Length; j++)
                {
                    array[i][j] = new Random().Next(0, 9);
                    Thread.Sleep(100);
                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    Console.Write(array[i][j]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
