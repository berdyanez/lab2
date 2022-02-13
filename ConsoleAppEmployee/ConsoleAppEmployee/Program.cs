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
            employee.Name = "Vova";
            employee.Surname = "Volkov";
            employee.Status = "Junior Developer";
            employee.Salary = 700;
            employee.Tax = 140;

            Console.WriteLine($"Name: {employee.Name}; Surname: {employee.Surname}; Status: {employee.Status}; Salary: {employee.Salary}; Taxes: {employee.Tax};");
        }


    }
}
