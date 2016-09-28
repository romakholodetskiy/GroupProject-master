using System;

namespace _03_Calc
{
	class Program
	{
		/*public void doid()
        {
            char plus = '+';
            char minus = '-';
            char mult = '*';
            char dec = '/';
        }*/
		static void Main()
		{
			int a = 0, b = 0;
			char doit = '+';
			Console.WriteLine("Enter first number of 1 to 10");
			a = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("First number is: {0}. Okey now enter second number of 1 to 10", a);
			b = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("We have first number: {0} and second number {1} \nNow chose operation you whant to do... chose: '+', '-', '*', '/'", a, b);
			doit = Convert.ToChar(Console.ReadLine());
			switch (doit)
			{
				case '+':
					{
						Console.WriteLine("{0} + {1} = {2}", a, b, a + b);
						break;
					}
				case '-':
					{
						Console.WriteLine("{0} - {1} = {2}", a, b, a - b);
						break;
					}
				case '*':
					{
						Console.WriteLine("{0} * {1} = {2}", a, b, a * b);
						break;
					}
				case '/':
					{
						Console.WriteLine("{0} / {1} = {2}", a, b, a / b);
						break;
					}
				default:
					Console.WriteLine("Somthing wrong?");
					break;
			}
			Console.ReadLine();
		}
	}
}
