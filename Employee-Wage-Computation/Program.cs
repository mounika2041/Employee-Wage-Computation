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
            //UC1
            int ispresent = 1;
            Random random = new Random();
            int empInput = random.Next(0, 2);

            //selection statement
            if (ispresent == empInput)
                Console.WriteLine("Employee is present");
            else
                Console.WriteLine("Employee is Absent");
            Console.ReadLine();
            Console.ReadLine();
        }
    }
}
