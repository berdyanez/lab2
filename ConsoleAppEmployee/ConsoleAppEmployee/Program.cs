using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppEmployee
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            Console.WriteLine("Write your name");
            employee.Name = Console.ReadLine();
            Console.WriteLine("Write your surname");
            employee.Surname =Console.ReadLine();
            employee.Status = "C# Developer";
            Console.WriteLine("Write your salary");
            employee.Salary = Convert.ToInt32(Console.ReadLine());
            employee.Tax = employee.Salary * (0.2);

            Console.WriteLine($"Name: {employee.Name}; Surname: {employee.Surname}; Status: {employee.Status}; Salary: {employee.Salary}; Taxes: {employee.Tax};");
        }


    }
}
