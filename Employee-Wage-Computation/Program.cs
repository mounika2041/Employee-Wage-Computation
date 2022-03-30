using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Wage_Computation
{
    class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to employee wage computation");
            //UC2
            int ispresent = 1;
            int empRatePerHr = 20;
            int empHrs = 0;
            int empWage = 0;
            Random random = new Random();
            int empInput = random.Next(0, 2);

            //selection statement
            if(ispresent==empInput)
            {
                Console.WriteLine("employee is present");
                empHrs = 8;
            }
            else
            {
                Console.WriteLine("employee is Absent");
                empHrs = 0;
            }
            empWage = empRatePerHr * empHrs;
            Console.WriteLine("Daily employee wage:" + empWage);
            Console.ReadLine();
        }
    }
}
