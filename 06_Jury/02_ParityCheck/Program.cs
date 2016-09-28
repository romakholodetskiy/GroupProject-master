using System;

namespace _02_ParityCheck
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("\n Введите число: ");
			var anyNumber = Console.ReadLine();
			int verify;
			if (int.TryParse(anyNumber, out verify))
			{
				var result = int.Parse(anyNumber) % 2 == 0 ? "ЧИСЛО ЧЁТНОЕ" : "ЧИСЛО НЕЧЁТНОЕ";
				Console.WriteLine($"\n {result}");
			}
			else
			{
				Console.WriteLine("\n ВЫ НЕ ВВЕЛИ ЧИСЛО ИЛИ ВВЕЛИ БУКВЫ!");
			}
			Console.ReadKey();
		}
	}
}
