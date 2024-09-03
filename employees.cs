using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;


namespace employees_section
{
    internal class employees
    {
        public int emp_id;
        public string emp_name;
        DateTime ta_date;

        public void employeedetails()
        {
            Console.WriteLine("Enter employee name:");
            emp_name = Console.ReadLine();
            Console.WriteLine("Enter employee ID:");
            emp_id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter date of ta:");
            ta_date = Convert.ToDateTime(Console.ReadLine());
        }
    }
}
