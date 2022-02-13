using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppUser
{
    class User
    {
        static void Main(string[] args) 
        {
            string login = "login@mail.com";
            string name = "Ivan";
            string surname = "Ivanov";
            int age = 22;
            DateTime dateTime = DateTime.Now;

            Console.WriteLine($"Login: {login}; Name: {name}; Surname: {surname}; Age: {age}; Date: {dateTime}");
        }
    }
}
