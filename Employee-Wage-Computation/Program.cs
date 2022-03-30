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
            //UC4
             const int FullTime = 1,PartTime=2;
            int empRatePerHr = 20;
            int empHrs = 0;
            int empWage = 0;
            Random random = new Random();
            int empInput = random.Next(0, 3);

            switch(empInput)
            {
                case FullTime:
                    Console.WriteLine(" fulltime employee is present");
                    empHrs = 8;
                    break;
                case PartTime:
                    Console.WriteLine(" parttime employee is present");
                    empHrs = 4;
                    break;
                default:
                    Console.WriteLine("employee is absent");
                    empHrs = 0;
                    break;
            }
             empWage = empRatePerHr * empHrs;
            Console.WriteLine("Daily employee wage:" + empWage);
            Console.ReadLine();
        }
    }
}
