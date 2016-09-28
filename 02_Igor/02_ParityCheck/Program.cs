using System;

namespace _02_ParityCheck
{
	class Program
	{
		static void Main(string[] args)
		{
			int a;
			Console.WriteLine("Введіть число");
			a = Convert.ToInt32(Console.ReadLine()); //вводимо дані
			if (a % 2 == 0) //перевіряємо число на парність, знаходимо залишок шляхом ділення на 2
			{
				Console.WriteLine("Число" + a + "-парне");
			}
			else
			{
				Console.WriteLine("Число" + a + "-непарне");
			}
			Console.ReadKey();
		}
	}
}
