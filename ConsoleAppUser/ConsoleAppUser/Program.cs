using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppUser
{
    public class Program
    {
        static void Main(string[] args)
        {
            {
                User someUse = new User();
                someUse.Login = "login@mail.com";
                someUse.Name = "Ivan";
                someUse.Surname = "Ivanov";
                someUse.Age = 22;
                DateTime date1= new DateTime(2022,4,12,19,4,34);

                Console.WriteLine($"Login: {someUse.Login}; Name: {someUse.Name}; Surname: {someUse.Surname}; Age: {someUse.Age}; Date: {date1}");
            }
        }
    }
}
