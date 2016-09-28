using System;

namespace FirstPrg_I_O
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter your text");
            var color = new Random();
            var text = Console.ReadLine();
            if (text != null)
            {
                var let = text.ToCharArray();
                foreach (var letter in let)
                {
                    Console.ForegroundColor = (ConsoleColor)color.Next(1, 16);
                    Console.Write(letter);
                }
                
            }
            Console.WriteLine();
            Console.ReadKey();
            }
  
    }
}
