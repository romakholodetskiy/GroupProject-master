using System;
using System.Collections.Generic;

namespace _003_Array
{
	class Program
	{
		static void Main()
		{
			var list = new List<string>() { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
			//var list = "12345678901234567890";
			for (int i = 0, j = 0; i < list.Count; i++, j--)
			{
				if (i == 4)
				{
					list.Remove(list[i]);
				}
				Console.ForegroundColor = (ConsoleColor)(i % 15);
				Console.Write(list[i]);
			}

			foreach (var item in list)
			{
				if (item == "5")
				{
					//list.Remove(item);
				}
				Console.WriteLine(item);
			}

			var user = new User();
			user.ChangeWorkEvent += x => { Console.WriteLine("1: " + x); };
			user.ChangeWorkEvent += x => { Console.WriteLine("2: " + x); };
			Console.ForegroundColor = ConsoleColor.White;
			user.OnChangeWorkEvent("Intel");

		}
	}

	internal class User
	{
		public string Name { get; set; }
		public string SName { get; set; }
		public int Age { get; set; }
		public event Action<object> ChangeWorkEvent;

		public virtual void OnChangeWorkEvent(object obj)
		{
			ChangeWorkEvent?.Invoke(obj);
		}
	}
}
