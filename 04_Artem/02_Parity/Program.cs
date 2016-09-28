using System;

namespace _02_Parity
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter your number");
            var n = Console.ReadLine();
            int check;
            if (int.TryParse(n, out check))
            {
                string result;
                if (n != null && int.Parse(n)%2 == 0)
                    result = "Number is Even";
                else result = "Number is Odd";
                Console.WriteLine($"{result}");
            }
            else
            {
                Console.WriteLine("You didn't enter the number or entered a letter!");
                Console.ReadKey();
            }
        }
        
    }
}
