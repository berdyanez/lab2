using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAddress
{
    public class Program
    {
        static void Main(string[] args)
        {
            {
                Address someAdd = new Address();
                someAdd.Index = 12012;
                someAdd.Country = "Ukraine";
                someAdd.City = "Kyiv";
                someAdd.Street = "Bazhana";
                someAdd.House = 13;
                someAdd.Apartment = 77;

                Console.WriteLine($"Index: {someAdd.Index}; Country: {someAdd.Country}; City: {someAdd.City}; Street: {someAdd.Street}; House: {someAdd.House}; Apartment: {someAdd.Apartment};");

                Console.ReadKey();
            }
        }
    }
}

       
    

   






