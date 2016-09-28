using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_FirstConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("\n Welcome! It's your first console application! ");
            Console.Write("\n Введите имя: ");
            var name = Console.ReadLine();
            var newArr = name.ToCharArray();
            var randomcolor = new Random();
            if (!string.IsNullOrEmpty(name))
            {
                Console.Write(" Имя: ");
                foreach (var letter in newArr)
                {
                    Console.ForegroundColor = (ConsoleColor)randomcolor.Next(1, 16);
                    Console.Write(letter);
                }
                Console.ForegroundColor = ConsoleColor.Gray;
                //Возраст
                Console.Write("\n Введите ваш возраст: ");
                var age = Console.ReadLine();
                Console.WriteLine($" Возраст: {age}");
                //Пол
                Console.Write(" Введите пол (f либо m): ");
                var sex = Console.ReadLine();
                Console.Write($" Пол: {sex}");
                //color selection 
                Console.BackgroundColor = sex == "f" ? ConsoleColor.DarkRed : ConsoleColor.DarkBlue;
                Console.Clear();
                Console.WriteLine("\n Введены данные:\n");
                Console.WriteLine($"   Имя: {name}\n   Возраст: {age}\n   Пол: {sex}");
                Console.Write("\n Press any key to exit...");

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n Вы ничего не ввели!\n Press any key to exit...");
            }
            Console.ReadKey();

        }
    }
}
