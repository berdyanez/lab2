using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppEmployee
{
    class Employee
    {
        private string name;
        private string surname;
        private string status;
        private int salary;
        private double tax;


        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }

        }
        public string Surname 
        {
            get 
            {
                return surname;
            }
            set 
            {
                surname = value;
            }
           
        }
        public string Status 
        {
            get 
            {
                return status;
            }
            set
            {
                status = value;
            }
        }
        public int Salary 
        {
            get 
            {
                return salary;
            }
            set 
            {
                salary = value;
            }
        }
        public double Tax 
        {
            get 
            {
                return tax;
            }
            set 
            {
                tax = value;
            }
        }
    }   
}
