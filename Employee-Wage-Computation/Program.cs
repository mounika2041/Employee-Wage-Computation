using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Wage_Computation
{
    class Program
    {
        private static readonly int empInput;

        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to employee wage computation");
            //UC5
            //consants
            int empWage = 0, empHrs = 0, totalEmpWage = 0;
            const int FULL_TIME = 1;
            const int PART_TIME = 2;
            const int NUM_OF_WORKING_DAYS = 20;
            const int EMP_PER_HR = 20;
            Random random = new Random();
            for (int day=1;day<=NUM_OF_WORKING_DAYS;day++)
            {
                int empInput = random.Next(0, 3);
                switch(empInput)
                {
                    case FULL_TIME:
                        //Console.WriteLine("full time employee is present");
                        empHrs = 8;
                        break;
                    case PART_TIME:
                        //Console.WriteLine("part time employee is present");
                        empHrs = 4;
                        break;
                    default:
                        //Console.WriteLine("employee is absent");
                        empHrs = 0;
                        break;
                }
                empWage = EMP_PER_HR * empHrs;
                Console.WriteLine("Daily wage for day{0} is:{1}", day, empWage);
                totalEmpWage += empWage;
            }
            Console.WriteLine("Total for {0}days is:{1}", NUM_OF_WORKING_DAYS, totalEmpWage);
            Console.ReadLine();
        }
    }
}
