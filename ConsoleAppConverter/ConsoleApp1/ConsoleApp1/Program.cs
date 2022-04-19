using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {
            {
                Converter someCnv = new Converter();
                someCnv.UahToUsd = 0.034;
                someCnv.UahToEur = 0.031;
                someCnv.UsdToUah = 32.3;
                someCnv.UsdToEur = 0.93;
                someCnv.EurToUah = 35.3;
                someCnv.EurToUsd = 1.08;
                string command;
                double num1 = 0;
                Console.WriteLine("Console Converter in C#\r");
                Console.WriteLine("------------------------\n");
                Console.WriteLine("Type a number, and then press Enter");
                num1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Choose an option from the following list:");
                Console.WriteLine("\ta - UAH TO USD");
                Console.WriteLine("\ts - UAH TO EUR");
                Console.WriteLine("\tm - USD TO UAH");
                Console.WriteLine("\td - USD TO EUR");
                Console.WriteLine("\tc - EUR TO UAH");
                Console.WriteLine("\te - EUR TO USD");
                Console.Write("Your option? ");
                switch (Console.ReadLine())
                {
                    case "a":
                        Console.WriteLine($"Your result:" + (num1 * someCnv.UahToUsd));
                        break;
                    case "s":
                        Console.WriteLine($"Your result:" + (num1 * someCnv.UahToEur));
                        break;
                    case "m":
                        Console.WriteLine($"Your result:" + (num1 * someCnv.UsdToUah));
                        break;
                    case "d":
                        Console.WriteLine($"Your result:" + (num1 * someCnv.UsdToEur));
                        break;
                    case "c":
                        Console.WriteLine($"Your result:" + (num1 * someCnv.EurToUah));
                        break;
                    case "e":
                        Console.WriteLine($"Your result:" + (num1 * someCnv.EurToUsd));
                        break;
                }
                Console.Write("Write exit and press enter to close the converter console app...");
                command = Console.ReadLine();
                while (command != null && !command.Equals("exit")) ;
            }

        }
    }
}
