using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Wage_Computation
{
    class EmployeeWageCompute
    {
         public const int IS_FULL_TIME = 2;
         public const int IS_PART_TIME = 1;

        public static int computeEmpWage(string company, int empRatePerHoue, int numOfWorkingDays, int maxHoursPerMonth)
        {
            //variables
            int empHrs = 0,totalEmPHrs = 0,totalWorkingDays = 0;
            //computation
            while(totalEmPHrs<= maxHoursPerMonth && totalWorkingDays< numOfWorkingDays)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch(empCheck)
                {
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    default:
                        empHrs = 0;
                        break;

                }
                totalEmPHrs += empHrs;
                Console.WriteLine("Day#:" + totalWorkingDays + "Emp Hrs :" + empHrs);
            }
            int totalEmpWage = totalEmPHrs * empRatePerHoue;
            Console.WriteLine("Total Emp Wage for Company :" + company +"is:" + totalEmpWage);
            return totalEmpWage;
        }
       
        static void Main(string[] args)
        {
            computeEmpWage("DMart", 20, 10, 10);
            computeEmpWage("tcs", 10, 15, 20);
            Console.ReadLine();
        }
    }
}
