using System;
using System.Collections.Specialized;
using System.Configuration;

namespace ConsoleTemplate
{
	class Program
	{
		static void Main(string[] args)
		{
			Init();

			foreach (var arg in args)
			{
				Console.Write($"{arg} ");
			}

			Console.ReadKey();
		}

		private static void Init()
		{
			NameValueCollection settings = ConfigurationManager.AppSettings;
			var LogLevel = ConfigSetting<string>(settings, "LogLevel");
			var LogDir = ConfigSetting<string>(settings, "LogDir");
		}

		public static T ConfigSetting<T>(NameValueCollection settings, string settingName)
		{
			const string method = "ConfigSetting";
			try
			{
				Logger.Enter(method);
				var value = settings[settingName];
				Logger.Leave(method, settingName + ": " + value);
				switch (Type.GetTypeCode(typeof(T)))
				{
					case TypeCode.Boolean:
						{
							bool result;
							bool.TryParse(value, out result);
							return (T)Convert.ChangeType(result, typeof(T));
						}
					case TypeCode.Int32:
						{
							int result;
							int.TryParse(value, out result);
							return (T)Convert.ChangeType(result, typeof(T));
						}
					default:
						return (T)Convert.ChangeType(value, typeof(T));
				}
			}
			catch (Exception e)
			{
				Logger.Exception(method, e);
				throw;
			}
		}

	}

	internal class Logger
	{
		public static void Enter(string configsetting)
		{
		}

		public static void Leave(string configsetting, string s)
		{
		}

		public static void Exception(string configsetting, Exception exception)
		{
		}
	}
}
