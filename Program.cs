using employees_section;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using accounts_section;
using System.Threading.Tasks;

namespace Call_ExpenceCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            employees employee = new employees();
            employee.employeedetails();


            Console.WriteLine("Enter the number of kilometers travelled:");
            int km = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Did the employee utilize food? (true/false):");
            Boolean food = Boolean.Parse(Console.ReadLine());
            accounts account = new accounts(km,food);

            Console.ReadLine();  
        }
    }
}
