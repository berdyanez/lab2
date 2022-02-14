using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppConverter
{
    class Converter
    {
        static void Main(string[] args) 
        {
            double UahToUsd = 0.035;
            double UahToEur = 0.031;
            double UahToRub = 2.70;
            double UAH;

            Console.WriteLine("Vvedite summu v UAH");
            
            UAH = double.Parse(Console.ReadLine());

            Console.WriteLine(UAH + " UAH to USD = " + UAH * UahToUsd);

            Console.WriteLine(UAH + " UAH to EUR = " + UAH * UahToEur);

            Console.WriteLine(UAH + " UAH to RUB = " + UAH * UahToRub);
            // Извините,не до конца понял как сделать обратный,не успел(

        }
    }
}
