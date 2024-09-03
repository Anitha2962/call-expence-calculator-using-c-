using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace accounts_section
{
    internal class accounts
    {
        private int km;
        private Boolean food;
        private int totaltravelled;
        private int foodexp;

        public accounts (int km, Boolean food)
        {
            this.km = km;
            this.food = food;
            travelexpence();
        }

        public void travelexpence()
        {
            totaltravelled = km * 3;  
            Console.WriteLine("Your travel expense is:" + totaltravelled);
            fooddetails();
        }

        public void fooddetails()
        {
            if (food)
            {
                foodexp += 100;
                Console.WriteLine("Your food expense is:" + foodexp);
            }
            else
            {
                Console.WriteLine("No food expense recorded");
            }
        }
    }
}
