using System;

namespace _03_christmasTree
{
	class Program
	{
		static void Main()
		{
			Console.BackgroundColor = ConsoleColor.White;
			Console.ForegroundColor = ConsoleColor.Green;
			Console.Clear();
			while (true)
			{
				Console.Write("Ввести число");
				int n; // Число вводимое 
				if (!Int32.TryParse(Console.ReadLine(), out n) || n <= 0)
					break; //условие если меньше 0 то вібьет и если буква то тоже смаое 
				Console.WriteLine("o"); // конец
				for (int i = 0; i < n; i++) //єто вісота если которая равна n
				{
					for (int j = 0; j < i + 1; j++)
					{
						for (int k = 0; k < n - j; k++) Console.Write('+'); // отступ пустого места 
						for (int k = 0; k < 2 * j + 1; k++) Console.Write('*'); // сама елка 
						Console.WriteLine("1"); //показывает высоту
					}
				}
				Console.ReadKey();
			}
		}
	}
}
