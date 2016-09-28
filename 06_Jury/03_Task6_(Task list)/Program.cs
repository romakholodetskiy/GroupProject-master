using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task6
{
    class Program
    {
        static void Main(string[] args)
        {
            var gbr = 1.487M;
            var chf = 0.172M;
            var dm = 0.584M;
            var jpy = 0.00955M;
            var today = DateTime.Now;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write($"\n Конвертер валюты\n\n Курс на {today.ToShortDateString()}\n\t1 USD (Доллар США):\n" +
                          $"\t\t\t1.487 GBR (Фунт стерлингов)\n \t\t\t0.172 CHF (Швейцарский франк)\n" +
                          $"\t\t\t0.584 DM (Немецкая марка)\n\t\t\t0.00955 JPY (Японская йена)\n\n");
            Console.Write(" Конвертировать одну валюту (нажмите 1) или все валюты (нажмите 2): ");
            var choise = Console.ReadLine();

          
            switch (choise)
            {
                case "2":
                    Console.Write(" Введите сумму USD для конвертации: ");
                    var usd = Console.ReadLine();
                    var usdDemical = decimal.Parse(usd);
                    var gbrcalc = gbr * usdDemical;
                    var chfcalc = chf * usdDemical;
                    var dmcalc = dm * usdDemical;
                    var jpycalc = jpy * usdDemical;
                    Console.Clear();
                    Console.WriteLine($"\a\n   На {today.ToShortDateString()} {usd} USD:\n\n\t\t\t{gbrcalc} GBR\n\t\t\t{chfcalc} CHF\n\t\t\t{dmcalc} DM\n\t\t\t{jpycalc} JPY");
                    break;
                 case "1":
                    Console.Write("\n\t\t\tGBR (Фунт стерлингов) - нажмите 1\n\t\t\t" +
                                      "CHF (Швейцарский франк) - нажмите 2\n\t\t\t" +
                                      "DM (Немецкая марка) - нажмите 3\n\t\t\t" +
                                      "JPY (Японская йена) - нажмите 4\n\n" +
                                      " Выберите валюту для конвертации: ");
                    var choiseone = Console.ReadLine();
                    switch (choiseone)
                    {
                        case "1":
                            Console.Write(" Введите сумму USD для конвертации: ");
                            var usd1 = Console.ReadLine();
                            var usdDemical1 = decimal.Parse(usd1);
                            var gbrcalc1 = gbr * usdDemical1;
                            Console.Clear();
                            Console.WriteLine($"\a\n   На {today.ToShortDateString()} {usd1} USD = {gbrcalc1} GBR");
                            break;
                        case "2":
                            Console.Write(" Введите сумму USD для конвертации: ");
                            var usd2 = Console.ReadLine();
                            var usdDemical2 = decimal.Parse(usd2);
                            var chfcalc2 = chf * usdDemical2;
                            Console.Clear();
                            Console.WriteLine($"\a\n   На {today.ToShortDateString()} {usd2} USD = {chfcalc2} CHF");
                            break;
                        case "3":
                            Console.Write(" Введите сумму USD для конвертации: ");
                            var usd3 = Console.ReadLine();
                            var usdDemical3 = decimal.Parse(usd3);
                            var dmcalc3 = dm * usdDemical3;
                            Console.Clear();
                            Console.WriteLine($"\a\n   На {today.ToShortDateString()} {usd3} USD = {dmcalc3} DM");
                            break;
                        case "4":
                            Console.Write(" Введите сумму USD для конвертации: ");
                            var usd4 = Console.ReadLine();
                            var usdDemical4 = decimal.Parse(usd4);
                            var jpycalc4 = jpy * usdDemical4;
                            Console.Clear();
                            Console.WriteLine($"\a\n   На {today.ToShortDateString()} {usd4} USD = {jpycalc4} JPY");
                            break;
                        default:
                            Console.WriteLine("\a\n Вы сделали неправильный выбор!");
                            break;

                    }
                 break;
                 default:
                    Console.WriteLine("\a\n Вы сделали неправильный выбор!");
                    break;
            }

            Console.Write("\n Нажмите любую клавишу для выхода...");
            Console.ReadKey();

        }
    }
}
